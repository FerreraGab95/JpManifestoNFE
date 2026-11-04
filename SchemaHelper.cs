using System.Collections.Concurrent;
using System.Net;
using System.Xml;
using System.Xml.Schema;

namespace JpManifestoNFE
{
    public class SchemaHelper
    {
        private static readonly ConcurrentDictionary<string, Lazy<XmlSchemaSet>> Cache = new();
        private readonly DirectoryInfo schemaDirectory;
        private readonly IReadOnlyDictionary<WebServiceSchemas, string> selectedFiles;

        public SchemaHelper(string schemaDirectory) : this(schemaDirectory, new Dictionary<WebServiceSchemas, string>()) { }

        /// <summary>Select exact XSD filenames when a package contains more than one version.</summary>
        public SchemaHelper(string schemaDirectory, IReadOnlyDictionary<WebServiceSchemas, string> selectedFiles)
        {
            this.schemaDirectory = new DirectoryInfo(schemaDirectory);
            this.selectedFiles = new Dictionary<WebServiceSchemas, string>(selectedFiles);
        }

        public XmlSchemaSet GetSchemas(params WebServiceSchemas[] schemas)
        {
            ArgumentNullException.ThrowIfNull(schemas);
            schemaDirectory.Refresh();
            if (!schemaDirectory.Exists) throw new DirectoryNotFoundException(ErrorMsgs.XSD_PATH_NOT_FOUND);
            if (schemas.Length == 0) throw new ArgumentException("Informe ao menos um schema.", nameof(schemas));
            var files = new List<FileInfo>();
            foreach (var schema in schemas.Distinct())
            {
                FileInfo[] candidates;
                if (selectedFiles.TryGetValue(schema, out var filename))
                {
                    if (Path.GetFileName(filename) != filename || !filename.EndsWith(".xsd", StringComparison.OrdinalIgnoreCase))
                        throw new ArgumentException("Informe apenas o nome do arquivo XSD dentro do pacote.");
                    candidates = schemaDirectory.GetFiles(filename);
                }
                else candidates = schemaDirectory.GetFiles($"{schema}*.xsd");
                if (candidates.Length == 0) throw new FileNotFoundException(ErrorMsgs.XSD_FILE_NOT_FOUND + schema);
                if (candidates.Length != 1)
                    throw new InvalidOperationException($"Há mais de uma versão de {schema}. Selecione explicitamente o arquivo XSD no SchemaHelper.");
                files.Add(candidates[0]);
            }
            // Includes/imports may change independently of their entry-point XSD.
            var package = schemaDirectory.GetFiles("*.xsd", SearchOption.AllDirectories).OrderBy(file => file.FullName, StringComparer.Ordinal).ToArray();
            var stamp = string.Join("|", package.Select(file => $"{file.FullName}:{file.Length}:{file.LastWriteTimeUtc.Ticks}"));
            var key = schemaDirectory.FullName + "|" + string.Join("|", files.Select(file => file.Name).OrderBy(name => name, StringComparer.Ordinal)) + "|" + stamp;
            if (Cache.Count > 32) Cache.Clear();
            var compiled = Cache.GetOrAdd(key, _ => new Lazy<XmlSchemaSet>(() => Compile(files), LazyThreadSafetyMode.ExecutionAndPublication)).Value;
            // Do not expose the cache's mutable collection to callers.
            var result = new XmlSchemaSet();
            result.Add(compiled);
            return result;
        }

        private XmlSchemaSet Compile(IReadOnlyList<FileInfo> files)
        {
            var resolver = new PackageResolver(schemaDirectory.FullName);
            var result = new XmlSchemaSet { XmlResolver = resolver };
            result.ValidationEventHandler += (_, error) => throw error.Exception;
            foreach (var file in files)
            {
                using var reader = XmlReader.Create(file.FullName, new XmlReaderSettings
                { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver });
                result.Add(null, reader);
            }
            result.Compile();
            return result;
        }

        private sealed class PackageResolver(string root) : XmlUrlResolver
        {
            public override object GetEntity(Uri absoluteUri, string? role, Type? ofObjectToReturn)
            {
                var prefix = Path.TrimEndingDirectorySeparator(Path.GetFullPath(root)) + Path.DirectorySeparatorChar;
                if (!absoluteUri.IsFile || !Path.GetFullPath(absoluteUri.LocalPath).StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    throw new XmlException("O schema tenta carregar uma dependência fora do pacote local.");
                return base.GetEntity(absoluteUri, role, ofObjectToReturn);
            }
        }
    }

    public enum WebServiceSchemas
    {

        /// <summary>
        /// Schema contendo os tipos básicos mais recentes presentes nas operações do WebService.
        /// </summary>
        tiposBasico_v4,
        /// <summary>
        /// Leiaute da NF-e.
        /// </summary>
        leiauteNFe,
        ///Mensagem de envio de lote de NF-e.
        enviNFe,
        /// <summary>
        /// Mensagem de consulta processamento do lote de NF-e
        ///transmitida.
        /// </summary>
        consReciNFe,
        /// <summary>
        /// Leiaute de compartilhamento da NF-e.
        /// </summary>
        procNFe,
        /// <summary>
        /// Mensagem de solicitação de inutilização de numeração de NFe
        /// </summary>
        inutNFe,
        /// <summary>
        /// Mensagem de consulta da situação atual da NF-e.
        /// </summary>
        consSitNFe,
        /// <summary>
        /// Mensagem da consulta do status do serviço de autorização de
        ///NF-e.
        /// </summary>
        consStatServ,
        /// <summary>
        /// Leiaute do serviço de status de consulta,
        /// </summary>
        leiauteConsStatServ,
        /// <summary>
        /// Tipos da Distribuição DFe.
        /// </summary>
        tiposDistDFe,
        /// <summary>
        /// Distribuição DFe: Consulta notas emitidas para o CNPJ informado.
        /// </summary>
        distDFeInt,
        /// <summary>
        /// Leiaute dos eventos de confirmação de recebimento.
        /// </summary>
        leiauteConfRecebto,
        /// <summary>
        /// Leiaute de envio de confirmação de recebimento;
        /// </summary>
        envConfRecebto,
        /// <summary>
        /// Modelo mais antigo dos tipos básicos, utilizado na manifestação das NFes.
        /// </summary>
        tiposBasico_v1,
        /// <summary>
        /// Schema responsável pelos tipos de assinaturas dos documentos.
        /// </summary>
        xmldsig,
        /// <summary>
        /// Schema responsável pelo processamento de um evento recebido pelo destinatário de uma NFe emitida.
        /// </summary>
        procEventoNFe
    }
}
