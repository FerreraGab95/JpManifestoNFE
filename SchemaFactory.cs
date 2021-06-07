using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace JpManifestoNFE
{
    public class SchemaFactory : ISchemaFactory
    {
        /// <summary>
        /// Nome do schema que contém a declaração dos tipos básicos presentes nos outros arquivos;
        /// </summary>
        private const string SCHEMA_TIPOS_BASICOS = "tiposBasico";

        private DirectoryInfo schemaDirectory;

        public SchemaFactory(string schemaDirectory) 
        {
            this.schemaDirectory = new DirectoryInfo(schemaDirectory);
        }


        public XmlSchemaSet GetSchemas(string defaultNamespace, SchemasNFe schema)
        {
            if (!schemaDirectory.Exists)
                throw new DirectoryNotFoundException(Resource.xsdPathNotFound);

            //Utiliza o pattern para que seja retornado apenas os schemas relacionadas ao WebService escolhido;
            var schemaFiles = schemaDirectory.GetFiles($"*{schema}*");

            var schemaTipoBasico = schemaDirectory.GetFiles($"{SCHEMA_TIPOS_BASICOS}*");

            if (schemaFiles.Length == 0)
                throw new FileNotFoundException(Resource.xsdFileNotFound + schema);
            else if(schemaTipoBasico.Length != 1)
                throw new FileNotFoundException(Resource.xsdBasicTypesNotFound);


            var schemaSet = new XmlSchemaSet();

            schemaSet.Add(defaultNamespace , schemaTipoBasico[0].FullName);

            foreach (var schemaFile in schemaFiles)
            {
                schemaSet.Add(defaultNamespace, schemaFile.FullName);
            }

            return schemaSet;
        }
    }
}
