# JpManifestoNFE

## Biblioteca de consumo de serviços de manifestação e distribuição de documentos fiscais.

O objetivo desta biblioteca é consumir os serviços da Sefaz, permitindo a utilização
de objetos para o preenchimento de documentos, que serão convertidos em XML, assinados (se requerido) e 
autenticados. Um único arquivo contém todas as classes presentes nos arquivos XSD (Schemas) convertidas
em classes **.NET**.

Antes de utilizar, é necessário o download dos arquivos schemas (XSD) para a validação dos documentos
antes do envio. Você poderá encontra-los no <a href="https://www.nfe.fazenda.gov.br/portal/listaConteudo.aspx?tipoConteudo=/fwLvLUSmU8=" >Portal
da Nota Fiscal Eletrônica</a>. A versão atual da biblioteca utiliza os schemas **Pacote de Liberação Distribuição de DF-e v1.02 (Atualizado em 25/10/16)**
e qualquer schema dos **Esquemas XML NF-e/NFC-e**, desde que sejam da versão 4.0. Os arquivos devem ser armazenados em uma única pasta.

-------------
## Utilização

#### Criar uma instância de *SchemaHelper* que irá carregar todos os schemas necessários para a validação do XML de requisição, *SchemaHelper* será utilizado em todos os serviços.
```C#
SchemaHelper schemaManager = new SchemaHelper(diretorioSchema);
```
-----------------------------------------------------------------------------------------------------
### Serviço de Manifestação de NF-e:

#### Criar uma instância de *IManifestacaoNFe*
```C#
IManifestacaoNFe manifestacaoNFe = ManifestacaoNFe.GetManifestacaoNFe(certificadoCliente, schemaManager, TUf.RJ);
```
#### Criar as instâncias de ManifestoNFe, que contém os dados necessários para a manifestação, abaixo será criada uma instância de cada tipo de operação.
```C#
var cienciaDaOperacao = new ManifestoNFe(TEventoInfEventoTpEvento.CienciaOperacao, chaveNFe, documentoCliente);

var confirmacaoOperacao = new ManifestoNFe(TEventoInfEventoTpEvento.ConfirmacaoOperacao, chaveNFe, documentoCliente);

var descOperacao = new ManifestoNFe(TEventoInfEventoTpEvento.DesconhecimentoOperacao, chaveNFe, documentoCliente);

var opNaoRealizada = new ManifestoNFe(TEventoInfEventoTpEvento.OperacaoNaoRealizada, chaveNFe, documentoCliente);
//Ao manifestar o evento de Operação não realizada, é necessário inserir a justificativa do evento.
opNaoRealizada.JustificativaEvento = "Motivo da operação não ter sido realizada.";
```

#### Chamar o método *ManifestarNFes* passando como pârametros as manifestações criadas anteriormente. 
Obs: *Por regra, o serviço suporta até 20 eventos simultâneos por vez.*
```C#
TRetEnvEvento retornoEventos = await manifestacaoNFe.ManifestarNFes(cienciaDaOperacao, confirmacaoOperacao, opNaoRealizada, descOperacao);
```
Uma exceção *SefazReturnException* é lançada quando a manifestação do lote (como um todo) for mal sucedida, caso a solicitação seja bem sucedida, dentro da instância do retorno haverá também um lote, com a resposta de cada manifestação enviada, onde cada uma deve ser verificada para saber se o evento foi anexado a NF-e ou não.

--------------------

### Serviço de Distribuição DF-e
#### Criar uma nova instância de *IDistribuicaoDFe*
```C#
 IDistribuicaoDFe distribuicaoDFe = DistribuicaoDFe.GetDistribuicaoDFe(certificadoCliente, schemaManager, DocumentoCliente, CodigoUF);
```
O serviço de distribuição DF-e suporta 3 tipos de consulta.

#### Consulta por chave da nota fiscal.
```C#
retDistDFe retornoDFe = await distribuicaoDFe.ConsultaChaveNFe(chNFe);
```

#### Consulta por NSU (Número Sequencial Único).
```C#
retDistDFe retornoDFe = distribuicaoDFe.ConsultaNSU(NSU);
```

#### Consulta por último NSU, onde todos os documentos com NSU acima do informado serão retornados.
```C#
retDistDFe retornoDFe = await distribuicaoDFe.ConsultaUltimoNSU(NSU);
```
Obs: A consulta por último NSU limita até 50 documentos em um único lote, caso a consulta deva retornar mais do que o limite permitido, o lote recebido terá duas propriedades, **UltNSU** e **MaxNSU**, onde **MaxNSU** é o ultimo NSU do último evento registrado para o destinatário, e **UltNSU** é o último NSU do último documento do lote recebido. Caso queira obter todos os resultados, efetua novas consultas informando o último NSU recebido, até que o mesmo seja igual a **MaxNSU**.

**Atenção:** O serviço de Distribuição DF-e possui um limite de consumo, caso muitas consultas sejam feitas em um curto período de tempo, será lançada uma exceção de **Consumo Indevido** onde o usuário deverá aguardar até 1 hora para utilizar o serviço novamente.

#### Processando os resultados da Distriuição DF-e
O serviço de Distribuição DF-e retorna os documentos compactados em lotes, para facilitar o processamento do retorno, foi criada a classe **RetornoNFeDocs**, que processa e organiza todos os documentos de acordo com os tipos retornados.
```C#
IRetornoDFeDocs dfeDocs = RetornoDFeDocs.ProcessRetornoDFeDocs(retornoDistDFe);

//Retorna os resumos de eventos vinculados a notas fiscais.
var resumoEventosNFe = dfeDocs.GetResumosEventoNFe();

//Retorna os resumos das notas fiscais emitidas para o destinatário.
var resumoNFe = dfeDocs.GetResumosNFe();

//Retorna as notas fiscais emitidas para o destinatário, já processadas. (Após manifestar Ciência da Operação ou Confirmação da Operação).
var procNFe = dfeDocs.GetNFesProcessadas();
```
### Tipos convertidos

Foi criado um arquivo *.cs* chamado XsdClasses, contendo todos os tipos declarados nos schemas, esta conversão foi feita utilizando a ferramenta **Xml Schemas/DataTypes support utility** presente no Visual Studio. Infelizmente a conversão não é 100% perfeita, alguns campos possuem nomes genéricos como *"Item"*, que pode ser corrigido com alguns ajustes em versões futuras.
