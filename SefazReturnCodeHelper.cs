using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JpManifestoNFE
{
    public static class SefazReturnCodeHelper
    {

		/// <summary>
		/// Lança uma exceção caso o código retornado seja diferente do código de retorno esperado;
		/// </summary>
		/// <param name="sefazReturnCode"></param>
		public static void ThrowIfCodeIsError(int sefazReturnCode, int expectedCode)
        {
			if (sefazReturnCode != expectedCode)
				throw new SefazReturnException(sefazReturnCode, GetCodeMessage(sefazReturnCode));
        }


		/// <summary>
		/// Lança uma exceção caso o código retornado seja diferente dos códigos de retorno esperados;
		/// </summary>
		/// <param name="sefazReturnCode"></param>
		public static void ThrowIfCodeIsError(int sefazReturnCode, int[] expectedCodes)
		{
			if (!expectedCodes.Contains(sefazReturnCode))
				throw new SefazReturnException(sefazReturnCode, GetCodeMessage(sefazReturnCode));
		}


		/// <summary>
		/// Retorna a mensagem referente ao código de retorno informado;
		/// </summary>
		/// <param name="sefazReturnCode"></param>
		public static string GetCodeMessage(int sefazReturnCode)
        {
			// Obs: Arquivo gerado via script, pode conter pequenos erros.
			switch (sefazReturnCode)
			{
				case 100:
					return ("Autorizado o uso da NF-e.");
				case 101:
					return ("Cancelamento de NF-e homologado.");
				case 102:
					return ("Inutilização de número homologado.");
				case 103:
					return ("Lote recebido com sucesso.");
				case 104:
					return ("Lote processado.");
				case 105:
					return ("Lote em processamento.");
				case 106:
					return ("Lote não localizado.");
				case 107:
					return ("Serviço em Operação.");
				case 108:
					return ("Serviço Paralisado Momentaneamente (curto prazo).");
				case 109:
					return ("Serviço Paralisado sem Previsão.");
				case 110:
					return ("Uso Denegado.");
				case 111:
					return ("Consulta cadastro com uma ocorrência.");
				case 112:
					return ("Consulta cadastro com mais de uma ocorrência.");
				case 124:
					return ("EPEC Autorizado.");
				case 128:
					return ("Lote de Evento Processado.");
				case 135:
					return ("Evento registrado e vinculado a NF-e.");
				case 136:
					return ("Evento registrado, mas não vinculado a NF-e.");
				case 137:
					return ("Nenhum documento localizado para o Destinatário.");
				case 138:
					return ("Documento localizado para o Destinatário.");
				case 139:
					return ("Pedido de Download processado.");
				case 140:
					return ("Download disponibilizado.");
				case 142:
					return ("Ambiente de Contingência EPEC bloqueado para o Emitente.");
				case 150:
					return ("Autorizado o uso da NF-e, autorização fora de prazo.");
				case 151:
					return ("Cancelamento de NF-e homologado fora de prazo.");
				case 201:
					return ("Rejeição: Número máximo de numeração a inutilizar ultrapassou o limite.");
				case 202:
					return ("Rejeição: Falha no reconhecimento da autoria ou integridade do arquivo digital.");
				case 203:
					return ("Rejeição: Emissor não habilitado para emissão de NF-e.");
				case 204:
					return ("Duplicidade de NF-e [nRec:999999999999999].");
				case 205:
					return ("NF-e está denegada na base de dados da SEFAZ [nRec:999999999999999].");
				case 206:
					return ("Rejeição: NF-e já está inutilizada na Base de dados da SEFAZ.");
				case 207:
					return ("Rejeição: CNPJ do emitente inválido.");
				case 208:
					return ("Rejeição: CNPJ do destinatário inválido.");
				case 209:
					return ("Rejeição: IE do emitente inválida.");
				case 210:
					return ("Rejeição: IE do destinatário inválida.");
				case 211:
					return ("Rejeição: IE do substituto inválida .");
				case 212:
					return ("Rejeição: Data de emissão NF-e posterior a data de recebimento.");
				case 213:
					return ("Rejeição: CNPJ-Base do Emitente difere do CNPJ-Base do Certificado Digital.");
				case 214:
					return ("Rejeição: Tamanho da mensagem excedeu o limite estabelecido.");
				case 215:
					return ("Rejeição: Falha no schema XML.");
				case 216:
					return ("Rejeição: Chave de Acesso difere da cadastrada.");
				case 217:
					return ("Rejeição: NF-e não consta na base de dados da SEFAZ.");
				case 218:
					return ("NF-e já está cancelada na base de dados da SEFAZ [nRec:999999999999999].");
				case 219:
					return ("Rejeição: Circulação da NF-e verificada.");
				case 220:
					return ("Rejeição: Prazo de Cancelamento superior ao previsto na Legislação.");
				case 221:
					return ("Rejeição: Confirmado o recebimento da NF-e pelo destinatário.");
				case 222:
					return ("Rejeição: Protocolo de Autorização de Uso difere do cadastrado.");
				case 223:
					return ("Rejeição: CNPJ do transmissor do lote difere do CNPJ do transmissor da consulta.");
				case 224:
					return ("Rejeição: A faixa inicial é maior que a faixa final.");
				case 225:
					return ("Rejeição: Falha no Schema XML do lote de NFe.");
				case 226:
					return ("Rejeição: Código da UF do Emitente diverge da UF autorizadora.");
				case 227:
					return ("Rejeição: Erro na Chave de Acesso - Campo Id – falta a literal NFe.");
				case 228:
					return ("Rejeição: Data de Emissão muito atrasada.");
				case 229:
					return ("Rejeição: IE do emitente não informada.");
				case 230:
					return ("Rejeição: IE do emitente não cadastrada.");
				case 231:
					return ("Rejeição: IE do emitente não vinculada ao CNPJ.");
				case 232:
					return ("Rejeição: IE do destinatário não informada.");
				case 233:
					return ("Rejeição: IE do destinatário não cadastrada.");
				case 234:
					return ("Rejeição: IE do destinatário não vinculada ao CNPJ.");
				case 235:
					return ("Rejeição: Inscrição SUFRAMA inválida.");
				case 236:
					return ("Rejeição: Chave de Acesso com dígito verificador inválido.");
				case 237:
					return ("Rejeição: CPF do destinatário inválido.");
				case 238:
					return ("Rejeição: Cabeçalho - Versão do arquivo XML superior a Versão vigente.");
				case 239:
					return ("Rejeição: Cabeçalho - Versão do arquivo XML não suportada.");
				case 240:
					return ("Rejeição: Cancelamento/Inutilização - Irregularidade Fiscal do Emitente.");
				case 241:
					return ("Rejeição: Um número da faixa já foi utilizado.");
				case 242:
					return ("Rejeição: Cabeçalho - Falha no Schema XML.");
				case 243:
					return ("Rejeição: XML Mal Formado.");
				case 244:
					return ("Rejeição: CNPJ do Certificado Digital difere do CNPJ da Matriz e do CNPJ do Emitente.");
				case 245:
					return ("Rejeição: CNPJ Emitente não cadastrado.");
				case 246:
					return ("Rejeição: CNPJ Destinatário não cadastrado.");
				case 247:
					return ("Rejeição: Sigla da UF do Emitente diverge da UF autorizadora.");
				case 248:
					return ("Rejeição: UF do Recibo diverge da UF autorizadora.");
				case 249:
					return ("Rejeição: UF da Chave de Acesso diverge da UF autorizadora.");
				case 250:
					return ("Rejeição: UF diverge da UF autorizadora.");
				case 251:
					return ("Rejeição: UF/Município destinatário não pertence a SUFRAMA.");
				case 252:
					return ("Rejeição: Ambiente informado diverge do Ambiente de recebimento.");
				case 253:
					return ("Rejeição: Digito Verificador da chave de acesso composta inválida.");
				case 254:
					return ("Rejeição: NF-e complementar não possui NF referenciada.");
				case 255:
					return ("Rejeição: NF-e complementar possui mais de uma NF referenciada.");
				case 256:
					return ("Rejeição: Uma NF-e da faixa já está inutilizada na Base de dados da SEFAZ.");
				case 257:
					return ("Rejeição: Solicitante não habilitado para emissão da NF-e.");
				case 258:
					return ("Rejeição: CNPJ da consulta inválido.");
				case 259:
					return ("Rejeição: CNPJ da consulta não cadastrado como contribuinte na UF.");
				case 260:
					return ("Rejeição: IE da consulta inválida.");
				case 261:
					return ("Rejeição: IE da consulta não cadastrada como contribuinte na UF.");
				case 262:
					return ("Rejeição: UF não fornece consulta por CPF.");
				case 263:
					return ("Rejeição: CPF da consulta inválido.");
				case 264:
					return ("Rejeição: CPF da consulta não cadastrado como contribuinte na UF.");
				case 265:
					return ("Rejeição: Sigla da UF da consulta difere da UF do Web Service.");
				case 266:
					return ("Rejeição: Série utilizada não permitida no Web Service .");
				case 267:
					return ("Rejeição: NF Complementar referencia uma NF-e inexistente .");
				case 268:
					return ("Rejeição: NF Complementar referencia outra NF-e Complementar.");
				case 269:
					return ("Rejeição: CNPJ Emitente da NF Complementar difere do CNPJ da NF Referenciada .");
				case 270:
					return ("Rejeição: Código Município do Fato Gerador: dígito inválido.");
				case 271:
					return ("Rejeição: Código Município do Fato Gerador: difere da UF do emitente.");
				case 272:
					return ("Rejeição: Código Município do Emitente: dígito inválido.");
				case 273:
					return ("Rejeição: Código Município do Emitente: difere da UF do emitente.");
				case 274:
					return ("Rejeição: Código Município do Destinatário: dígito inválido.");
				case 275:
					return ("Rejeição: Código Município do Destinatário: difere da UF do Destinatário.");
				case 276:
					return ("Rejeição: Código Município do Local de Retirada: dígito inválido.");
				case 277:
					return ("Rejeição: Código Município do Local de Retirada: difere da UF do Local de Retirada.");
				case 278:
					return ("Rejeição: Código Município do Local de Entrega: dígito inválido.");
				case 279:
					return ("Rejeição: Código Município do Local de Entrega: difere da UF do Local de Entrega.");
				case 280:
					return ("Rejeição: Certificado Transmissor inválido.");
				case 281:
					return ("Rejeição: Certificado Transmissor Data Validade.");
				case 282:
					return ("Rejeição: Certificado Transmissor sem CNPJ.");
				case 283:
					return ("Rejeição: Certificado Transmissor - erro Cadeia de Certificação.");
				case 284:
					return ("Rejeição: Certificado Transmissor revogado.");
				case 285:
					return ("Rejeição: Certificado Transmissor difere ICP-Brasil.");
				case 286:
					return ("Rejeição: Certificado Transmissor erro no acesso a LCR.");
				case 287:
					return ("Rejeição: Código Município do FG - ISSQN: dígito inválido.");
				case 288:
					return ("Rejeição: Código Município do FG - Transporte: dígito inválido.");
				case 289:
					return ("Rejeição: Código da UF informada diverge da UF solicitada.");
				case 290:
					return ("Rejeição: Certificado Assinatura inválido.");
				case 291:
					return ("Rejeição: Certificado Assinatura Data Validade.");
				case 292:
					return ("Rejeição: Certificado Assinatura sem CNPJ.");
				case 293:
					return ("Rejeição: Certificado Assinatura - erro Cadeia de Certificação.");
				case 294:
					return ("Rejeição: Certificado Assinatura revogado.");
				case 295:
					return ("Rejeição: Certificado Assinatura difere ICP-Brasil.");
				case 296:
					return ("Rejeição: Certificado Assinatura erro no acesso a LCR.");
				case 297:
					return ("Rejeição: Assinatura difere do calculado.");
				case 298:
					return ("Rejeição: Assinatura difere do padrão do Sistema.");
				case 299:
					return ("Rejeição: XML da área de cabeçalho com codificação diferente de UTF-8.");
				case 301:
					return ("Uso Denegado: Irregularidade fiscal do emitente.");
				case 302:
					return ("Rejeição: Irregularidade fiscal do destinatário.");
				case 303:
					return ("Uso Denegado: Destinatário não habilitado a operar na UF.");
				case 304:
					return ("Rejeição: Pedido de Cancelamento para NF-e com evento da Suframa.");
				case 321:
					return ("Rejeição: NF-e de devolução de mercadoria não possui documento fiscal referenciado.");
				case 323:
					return ("Rejeição: CNPJ autorizado para download inválido.");
				case 324:
					return ("Rejeição: CNPJ do destinatário já autorizado para download.");
				case 325:
					return ("Rejeição: CPF autorizado para download inválido.");
				case 326:
					return ("Rejeição: CPF do destinatário já autorizado para download.");
				case 327:
					return ("Rejeição: CFOP inválido para NF-e com finalidade de devolução de mercadoria.");
				case 328:
					return ("Rejeição: CFOP de devolução de mercadoria para NF-e que não tem finalidade de devolução de mercadoria.");
				case 329:
					return ("Rejeição: Número da DI /DSI inválido.");
				case 330:
					return ("Rejeição: Informar o Valor da AFRMM na importação por via marítima.");
				case 331:
					return ("Rejeição: Informar o CNPJ do adquirente ou do encomendante nesta forma de importação.");
				case 332:
					return ("Rejeição: CNPJ do adquirente ou do encomendante da importação inválido.");
				case 333:
					return ("Rejeição: Informar a UF do adquirente ou do encomendante nesta forma de importação.");
				case 334:
					return ("Rejeição: Número do processo de drawback não informado na importação.");
				case 335:
					return ("Rejeição: Número do processo de drawback na importação inválido.");
				case 336:
					return ("Rejeição: Informado o grupo de exportação no item para CFOP que não é de exportação.");
				case 337:
					return ("Rejeição: Não informado o grupo de exportação no item.");
				case 338:
					return ("Rejeição: Número do processo de drawback não informado na exportação.");
				case 339:
					return ("Rejeição: Número do processo de drawback na exportação inválido.");
				case 340:
					return ("Rejeição: Não informado o grupo de exportação indireta no item.");
				case 341:
					return ("Rejeição: Número do registro de exportação inválido.");
				case 342:
					return ("Rejeição: Chave de Acesso informada na Exportação Indireta com DV inválido.");
				case 343:
					return ("Rejeição: Modelo da NF-e informada na Exportação Indireta diferente de 55.");
				case 344:
					return ("Rejeição: Duplicidade de NF-e informada na Exportação Indireta (Chave de Acesso informada mais de uma vez).");
				case 345:
					return ("Rejeição: Chave de Acesso informada na Exportação Indireta não consta como NF-e referenciada.");
				case 346:
					return ("Rejeição: Somatório das quantidades informadas na Exportação Indireta não corresponde a quantidade total do item.");
				case 347:
					return ("Rejeição: Descrição do Combustível diverge da descrição adotada pela ANP.");
				case 348:
					return ("Rejeição: NFC-e com grupo RECOPI.");
				case 349:
					return ("Rejeição: Número RECOPI não informado.");
				case 350:
					return ("Rejeição: Número RECOPI inválido.");
				case 351:
					return ("Rejeição: Valor do ICMS da Operação no CST=51 difere do produto BC e Alíquota.");
				case 352:
					return ("Rejeição: Valor do ICMS Diferido no CST=51 difere do produto Valor ICMS Operação e percentual diferimento.");
				case 353:
					return ("Rejeição: Valor do ICMS no CST=51 não corresponde a diferença do ICMS operação e ICMS diferido.");
				case 354:
					return ("Rejeição: Informado grupo de devolução de tributos para NF-e que não tem finalidade de devolução de mercadoria.");
				case 355:
					return ("Rejeição: Informar o local de saída do Pais no caso da exportação.");
				case 356:
					return ("Rejeição: Informar o local de saída do Pais somente no caso da exportação.");
				case 357:
					return ("Rejeição: Chave de Acesso do grupo de Exportação Indireta inexistente [nRef: xxx].");
				case 358:
					return ("Rejeição: Chave de Acesso do grupo de Exportação Indireta cancelada ou denegada [nRef: xxx].");
				case 359:
					return ("Rejeição: NF-e de venda a Órgão Público sem informar a Nota de Empenho.");
				case 360:
					return ("Rejeição: NF-e com Nota de Empenho inválida para a UF..");
				case 361:
					return ("Rejeição: NF-e com Nota de Empenho inexistente na UF..");
				case 362:
					return ("Rejeição: Venda de combustível sem informação do Transportador.");
				case 364:
					return ("Rejeição: Total do valor da dedução do ISS difere do somatório dos itens.");
				case 365:
					return ("Rejeição: Total de outras retenções difere do somatório dos itens.");
				case 366:
					return ("Rejeição: Total do desconto incondicionado ISS difere do somatório dos itens.");
				case 367:
					return ("Rejeição: Total do desconto condicionado ISS difere do somatório dos itens.");
				case 368:
					return ("Rejeição: Total de ISS retido difere do somatório dos itens.");
				case 369:
					return ("Rejeição: Não informado o grupo avulsa na emissão pelo Fisco.");
				case 370:
					return ("Rejeição: Nota Fiscal Avulsa com tipo de emissão inválido.");
				case 401:
					return ("Rejeição: CPF do remetente inválido.");
				case 402:
					return ("Rejeição: XML da área de dados com codificação diferente de UTF-8.");
				case 403:
					return ("Rejeição: O grupo de informações da NF-e avulsa é de uso exclusivo do Fisco.");
				case 404:
					return ("Rejeição: Uso de prefixo de namespace não permitido.");
				case 405:
					return ("Rejeição: Código do país do emitente: dígito inválido.");
				case 406:
					return ("Rejeição: Código do país do destinatário: dígito inválido.");
				case 407:
					return ("Rejeição: O CPF só pode ser informado no campo emitente para a NF-e avulsa.");
				case 408:
					return ("Rejeição: Evento não disponível para Autor pessoa física.");
				case 409:
					return ("Rejeição: Campo cUF inexistente no elemento nfeCabecMsg do SOAP Header.");
				case 410:
					return ("Rejeição: UF informada no campo cUF não é atendida pelo Web Service.");
				case 411:
					return ("Rejeição: Campo versaoDados inexistente no elemento nfeCabecMsg do SOAP Header.");
				case 416:
					return ("Rejeição: Falha na descompactação da área de dados.");
				case 417:
					return ("Rejeição: Total do ICMS superior ao valor limite estabelecido.");
				case 418:
					return ("Rejeição: Total do ICMS ST superior ao valor limite estabelecido.");
				case 420:
					return ("Rejeição: Cancelamento para NF-e já cancelada.");
				case 450:
					return ("Rejeição: Modelo da NF-e diferente de 55.");
				case 451:
					return ("Rejeição: Processo de emissão informado inválido.");
				case 452:
					return ("Rejeição: Tipo Autorizador do Recibo diverge do Órgão Autorizador.");
				case 453:
					return ("Rejeição: Ano de inutilização não pode ser superior ao Ano atual.");
				case 454:
					return ("Rejeição: Ano de inutilização não pode ser inferior a 2006.");
				case 455:
					return ("Rejeição: Órgão Autor do evento diferente da UF da Chave de Acesso.");
				case 461:
					return ("Rejeição: Informado percentual de Gás Natural na mistura para produto diferente de GLP.");
				case 465:
					return ("Rejeição: Número de Controle da FCI inexistente.");
				case 466:
					return ("Rejeição: Evento com Tipo de Autor incompatível.");
				case 467:
					return ("Rejeição: Dados da NF-e divergentes do EPEC.");
				case 468:
					return ("Rejeição: NF-e com Tipo Emissão = 4, sem EPEC correspondente.");
				case 471:
					return ("Rejeição: Informado NCM=00 indevidamente.");
				case 476:
					return ("Rejeição: Código da UF diverge da UF da primeira NF-e do Lote.");
				case 477:
					return ("Rejeição: Código do órgão diverge do órgão do primeiro evento do Lote.");
				case 478:
					return ("Rejeição: Local da entrega não informado para faturamento direto de veículos novos.");
				case 484:
					return ("Rejeição: Chave de Acesso com tipo de emissão diferente de 4 (posição 35 da Chave de Acesso).");
				case 485:
					return ("Rejeição: Duplicidade de numeração do EPEC (Modelo, CNPJ, Série e Número).");
				case 489:
					return ("Rejeição: CNPJ informado inválido (DV ou zeros).");
				case 490:
					return ("Rejeição: CPF informado inválido (DV ou zeros).");
				case 491:
					return ("Rejeição: O tpEvento informado inválido.");
				case 492:
					return ("Rejeição: O verEvento informado inválido.");
				case 493:
					return ("Rejeição: Evento não atende o Schema XML específico.");
				case 494:
					return ("Rejeição: Chave de Acesso inexistente.");
				case 501:
					return ("Rejeição: Pedido de Cancelamento intempestivo (NF-e autorizada a mais de 7 dias).");
				case 502:
					return ("Rejeição: Erro na Chave de Acesso - Campo Id não corresponde à concatenação dos campos correspondentes.");
				case 503:
					return ("Rejeição: Série utilizada fora da faixa permitida no SCAN (900-999).");
				case 504:
					return ("Rejeição: Data de Entrada/Saída posterior ao permitido.");
				case 505:
					return ("Rejeição: Data de Entrada/Saída anterior ao permitido.");
				case 506:
					return ("Rejeição: Data de Saída menor que a Data de Emissão.");
				case 507:
					return ("Rejeição: O CNPJ do destinatário/remetente não deve ser informado em operação com o exterior.");
				case 508:
					return ("Rejeição: CNPJ do destinatário com conteúdo nulo só é válido em operação com exterior.");
				case 509:
					return ("Rejeição: Informado código de município diferente de “9999999” para operação com o exterior.");
				case 510:
					return ("Rejeição: Operação com Exterior e Código País destinatário é 1058 (Brasil) ou não informado.");
				case 511:
					return ("Rejeição: Não é de Operação com Exterior e Código País destinatário difere de 1058 (Brasil).");
				case 512:
					return ("Rejeição: CNPJ do Local de Retirada inválido.");
				case 513:
					return ("Rejeição: Código Município do Local de Retirada deve ser 9999999 para UF retirada = EX.");
				case 514:
					return ("Rejeição: CNPJ do Local de Entrega inválido.");
				case 515:
					return ("Rejeição: Código Município do Local de Entrega deve ser 9999999 para UF entrega = EX.");
				case 516:
					return ("Rejeição: Falha no schema XML – inexiste a tag raiz esperada para a mensagem.");
				case 517:
					return ("Rejeição: Falha no schema XML – inexiste atributo versao na tag raiz da mensagem.");
				case 518:
					return ("Rejeição: CFOP de entrada para NF-e de saída.");
				case 519:
					return ("Rejeição: CFOP de saída para NF-e de entrada.");
				case 520:
					return ("Rejeição: CFOP de Operação com Exterior e UF destinatário difere de EX.");
				case 521:
					return ("Rejeição: CFOP de Operação Estadual e UF do emitente difere da UF do destinatário para destinatário contribuinte do ICMS..");
				case 522:
					return ("Rejeição: CFOP de Operação Estadual e UF emitente difere da UF remetente para remetente contribuinte do ICMS..");
				case 523:
					return ("Rejeição: CFOP não é de Operação Estadual e UF emitente igual a UF destinatário..");
				case 524:
					return ("Rejeição: CFOP de Operação com Exterior e não informado NCM.");
				case 525:
					return ("Rejeição: CFOP de Importação e não informado dados da DI.");
				case 527:
					return ("Rejeição: Operação de Exportação com informação de ICMS incompatível.");
				case 528:
					return ("Rejeição: Valor do ICMS difere do produto BC e Alíquota.");
				case 529:
					return ("Rejeição: NCM de informação obrigatória para produto tributado pelo IPI.");
				case 530:
					return ("Rejeição: Operação com tributação de ISSQN sem informar a Inscrição Municipal.");
				case 531:
					return ("Rejeição: Total da BC ICMS difere do somatório dos itens.");
				case 532:
					return ("Rejeição: Total do ICMS difere do somatório dos itens.");
				case 533:
					return ("Rejeição: Total da BC ICMS-ST difere do somatório dos itens.");
				case 534:
					return ("Rejeição: Total do ICMS-ST difere do somatório dos itens.");
				case 535:
					return ("Rejeição: Total do Frete difere do somatório dos itens.");
				case 536:
					return ("Rejeição: Total do Seguro difere do somatório dos itens.");
				case 537:
					return ("Rejeição: Total do Desconto difere do somatório dos itens.");
				case 538:
					return ("Rejeição: Total do IPI difere do somatório dos itens.");
				case 539:
					return ("Duplicidade de NF-e com diferença na Chave de Acesso [chNFe: 99999999999999999999999999999999999999999999][nRec:999999999999999].");
				case 540:
					return ("Rejeição: CPF do Local de Retirada inválido.");
				case 541:
					return ("Rejeição: CPF do Local de Entrega inválido.");
				case 542:
					return ("Rejeição: CNPJ do Transportador inválido.");
				case 543:
					return ("Rejeição: CPF do Transportador inválido.");
				case 544:
					return ("Rejeição: IE do Transportador inválida .");
				case 545:
					return ("Rejeição: Falha no schema XML – versão informada na versaoDados do SOAPHeader diverge da versão da mensagem.");
				case 546:
					return ("Rejeição: Erro na Chave de Acesso – Campo Id – falta a literal NFe.");
				case 547:
					return ("Rejeição: Dígito Verificador da Chave de Acesso da NF-e Referenciada inválido.");
				case 548:
					return ("Rejeição: CNPJ da NF referenciada inválido..");
				case 549:
					return ("Rejeição: CNPJ da NF referenciada de produtor inválido..");
				case 550:
					return ("Rejeição: CPF da NF referenciada de produtor inválido..");
				case 551:
					return ("Rejeição: IE da NF referenciada de produtor inválido..");
				case 552:
					return ("Rejeição: Dígito Verificador da Chave de Acesso do CT-e Referenciado inválido.");
				case 553:
					return ("Rejeição: Tipo autorizador do recibo diverge do Órgão Autorizador..");
				case 554:
					return ("Rejeição: Séri555 Rejeição: Tipo autorizador do protocolo diverge do Órgão Autorizador..");
				case 556:
					return ("Rejeição: Justificativa de entrada em contingência não deve ser informada para tipo de emissão normal..");
				case 557:
					return ("Rejeição: A Justificativa de entrada em contingência deve ser informada..");
				case 558:
					return ("Rejeição: Data de entrada em contingência posterior a data de recebimento..");
				case 559:
					return ("Rejeição: UF do Transportador não informada.");
				case 560:
					return ("Rejeição: CNPJ base do emitente difere do CNPJ base da primeira NF-e do lote recebido.");
				case 561:
					return ("Rejeição: Mês de Emissão informado na Chave de Acesso difere do Mês de Emissão da NF-e.");
				case 562:
					return ("Rejeição: Código Numérico informado na Chave de Acesso difere do Código Numérico da NF-e [chNFe:99999999999999999999999999999999999999999999].");
				case 563:
					return ("Rejeição: Já existe pedido de Inutilização com a mesma faixa de inutilização.");
				case 564:
					return ("Rejeição: Total do Produto / Serviço difere do somatório dos itens .");
				case 565:
					return ("Rejeição: Falha no schema XML – inexiste a tag raiz esperada para o lote de NF-e.");
				case 567:
					return ("Rejeição: Falha no schema XML – versão informada na versaoDados do SOAPHeader diverge da versão do lote de NF-e.");
				case 568:
					return ("Rejeição: Falha no schema XML – inexiste atributo versao na tag raiz do lote de NF-e.");
				case 569:
					return ("Rejeição: Data de entrada em contingência muito atrasada.");
				case 570:
					return ("Rejeição: Tipo de Emissão 3, 6 ou 7 só é válido nas contingências SCAN/SVC.");
				case 571:
					return ("Rejeição: O tpEmis informado diferente de 3 para contingência SCAN.");
				case 572:
					return ("Rejeição: Erro Atributo ID do evento não corresponde a concatenação dos campos (“ID” + tpEvento + chNFe + nSeqEvento).");
				case 573:
					return ("Rejeição: Duplicidade de Evento.");
				case 574:
					return ("Rejeição: O autor do evento diverge do emissor da NF-e.");
				case 575:
					return ("Rejeição: O autor do evento diverge do destinatário da NF-e.");
				case 576:
					return ("Rejeição: O autor do evento não é um órgão autorizado a gerar o evento.");
				case 577:
					return ("Rejeição: A data do evento não pode ser menor que a data de emissão da NF-e.");
				case 578:
					return ("Rejeição: A data do evento não pode ser maior que a data do processamento.");
				case 579:
					return ("Rejeição: A data do evento não pode ser menor que a data de autorização para NF-e não emitida em contingência.");
				case 580:
					return ("Rejeição: O evento exige uma NF-e autorizada.");
				case 587:
					return ("Rejeição: Usar somente o namespace padrão da NF-e.");
				case 588:
					return ("Rejeição: Não é permitida a presença de caracteres de edição no início/fim da mensagem ou entre as tags da mensagem.");
				case 589:
					return ("Rejeição: Número do NSU informado superior ao maior NSU da base de dados da SEFAZ.");
				case 590:
					return ("Rejeição: Informado CST para emissor do Simples Nacional (CRT=1).");
				case 591:
					return ("Rejeição: Informado CSOSN para emissor que não é do Simples Nacional (CRT diferente de 1).");
				case 592:
					return ("Rejeição: A NF-e deve ter pelo menos um item de produto sujeito ao ICMS.");
				case 593:
					return ("Rejeição: CNPJ-Base consultado difere do CNPJ-Base do Certificado Digital.");
				case 594:
					return ("Rejeição: O número de sequencia do evento informado é maior que o permitido.");
				case 595:
					return ("Rejeição: Obrigatória a informação da justificativa do evento..");
				case 596:
					return ("Rejeição: Evento apresentado fora do prazo: [prazo vigente].");
				case 597:
					return ("Rejeição: CFOP de Importação e não informado dados de IPI.");
				case 598:
					return ("Rejeição: NF-e emitida em ambiente de homologação com Razão Social do destinatário diferente de NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL.");
				case 599:
					return ("Rejeição: CFOP de Importação e não informado dados de IIe difere da faixa 0-899.");
				case 601:
					return ("Rejeição: Total do II difere do somatório dos itens.");
				case 602:
					return ("Rejeição: Total do PIS difere do somatório dos itens sujeitos ao ICMS.");
				case 603:
					return ("Rejeição: Total do COFINS difere do somatório dos itens sujeitos ao ICMS.");
				case 604:
					return ("Rejeição: Total do vOutro difere do somatório dos itens.");
				case 605:
					return ("Rejeição: Total do vISS difere do somatório do vProd dos itens sujeitos ao ISSQN.");
				case 606:
					return ("Rejeição: Total do vBC do ISS difere do somatório dos itens.");
				case 607:
					return ("Rejeição: Total do ISS difere do somatório dos itens.");
				case 608:
					return ("Rejeição: Total do PIS difere do somatório dos itens sujeitos ao ISSQN.");
				case 609:
					return ("Rejeição: Total do COFINS difere do somatório dos itens sujeitos ao ISSQN.");
				case 610:
					return ("Rejeição: Total da NF difere do somatório dos Valores compõe o valor Total da NF..");
				case 611:
					return ("Rejeição: cEAN inválido.");
				case 612:
					return ("Rejeição: cEANTrib inválido.");
				case 613:
					return ("Rejeição: Chave de Acesso difere da existente em BD.");
				case 614:
					return ("Rejeição: Chave de Acesso inválida (Código UF inválido).");
				case 615:
					return ("Rejeição: Chave de Acesso inválida (Ano menor que 06 ou Ano maior que Ano corrente).");
				case 616:
					return ("Rejeição: Chave de Acesso inválida (Mês menor que 1 ou Mês maior que 12).");
				case 617:
					return ("Rejeição: Chave de Acesso inválida (CNPJ zerado ou dígito inválido).");
				case 618:
					return ("Rejeição: Chave de Acesso inválida (modelo diferente de 55 e 65).");
				case 619:
					return ("Rejeição: Chave de Acesso inválida (número NF = 0).");
				case 620:
					return ("Rejeição: Chave de Acesso difere da existente em BD.");
				case 621:
					return ("Rejeição: CPF Emitente não cadastrado.");
				case 622:
					return ("Rejeição: IE emitente não vinculada ao CPF.");
				case 623:
					return ("Rejeição: CPF Destinatário não cadastrado.");
				case 624:
					return ("Rejeição: IE Destinatário não vinculada ao CPF.");
				case 625:
					return ("Rejeição: Inscrição SUFRAMA deve ser informada na venda com isenção para ZFM.");
				case 626:
					return ("Rejeição: CFOP de operação isenta para ZFM diferente do previsto.");
				case 627:
					return ("Rejeição: O valor do ICMS desonerado deve ser informado.");
				case 628:
					return ("Rejeição: Total da NF superior ao valor limite estabelecido pela SEFAZ [Limite].");
				case 629:
					return ("Rejeição: Valor do Produto difere do produto Valor Unitário de Comercialização e Quantidade Comercial.");
				case 630:
					return ("Rejeição: Valor do Produto difere do produto Valor Unitário de Tributação e Quantidade Tributável.");
				case 631:
					return ("Rejeição: CNPJ-Base do Destinatário difere do CNPJ-Base do Certificado Digital.");
				case 632:
					return ("Rejeição: Solicitação fora de prazo, a NF-e não está mais disponível para download.");
				case 633:
					return ("Rejeição: NF-e indisponível para download devido a ausência de Manifestação do Destinatário.");
				case 634:
					return ("Rejeição: Destinatário da NF-e não tem o mesmo CNPJ raiz do solicitante do download.");
				case 635:
					return ("Rejeição: NF-e com mesmo número e série já transmitida e aguardando processamento.");
				case 650:
					return ("Rejeição: Evento de \"Ciência da Emissão\" para NF-e Cancelada ou Denegada.");
				case 651:
					return ("Rejeição: Evento de \"Desconhecimento da Operação\" para NF-e Cancelada ou Denegada.");
				case 653:
					return ("Rejeição: NF-e Cancelada, arquivo indisponível para download.");
				case 654:
					return ("Rejeição: NF-e Denegada, arquivo indisponível para download.");
				case 655:
					return ("Rejeição: Evento de Ciência da Emissão informado após a manifestação final do destinatário.");
				case 656:
					return ("Rejeição: Consumo Indevido.");
				case 657:
					return ("Rejeição: Código do Órgão diverge do órgão autorizador.");
				case 658:
					return ("Rejeição: UF do destinatário da Chave de Acesso diverge da UF autorizadora.");
				case 660:
					return ("Rejeição: CFOP de Combustível e não informado grupo de combustível da NF-e.");
				case 661:
					return ("Rejeição: NF-e já existente para o número do EPEC informado.");
				case 662:
					return ("Rejeição: Numeração do EPEC está inutilizada na Base de Dados da SEFAZ.");
				case 663:
					return ("Rejeição: Alíquota do ICMS com valor superior a 4 por cento na operação de saída interestadual com produtos importados.");
				case 678:
					return ("Rejeição: NF referenciada com UF diferente da NF-e complementar.");
				case 679:
					return ("Rejeição: Modelo da NF-e referenciada diferente de 55/65.");
				case 680:
					return ("Rejeição: Duplicidade de NF-e referenciada (Chave de Acesso referenciada mais de uma vez).");
				case 681:
					return ("Rejeição: Duplicidade de NF Modelo 1 referenciada (CNPJ, Modelo, Série e Número).");
				case 682:
					return ("Rejeição: Duplicidade de NF de Produtor referenciada (IE, Modelo, Série e Número).");
				case 683:
					return ("Rejeição: Modelo do CT-e referenciado diferente de 57.");
				case 684:
					return ("Rejeição: Duplicidade de Cupom Fiscal referenciado (Modelo, Número de Ordem e COO).");
				case 685:
					return ("Rejeição: Total do Valor Aproximado dos Tributos difere do somatório dos itens.");
				case 686:
					return ("Rejeição: NF Complementar referencia uma NF-e cancelada.");
				case 687:
					return ("Rejeição: NF Complementar referencia uma NF-e denegada.");
				case 688:
					return ("Rejeição: NF referenciada de Produtor com IE inexistente [nRef: xxx].");
				case 689:
					return ("Rejeição: NF referenciada de Produtor com IE não vinculada ao CNPJ/CPF informado [nRef: xxx].");
				case 690:
					return ("Rejeição: Pedido de Cancelamento para NF-e com CT-e.");
				case 691:
					return ("Rejeição: Chave de Acesso da NF-e diverge da Chave de Acesso do EPEC.");
				case 700:
					return ("Rejeição: Mensagem de Lote versão 3.xx. Enviar para o Web Service nfeAutorizacao.");
				case 701:
					return ("Rejeição: NF-e não pode utilizar a versão 3.00.");
				case 702:
					return ("Rejeição: NFC-e não é aceita pela UF do Emitente.");
				case 703:
					return ("Rejeição: Data-Hora de Emissão posterior ao horário de recebimento.");
				case 704:
					return ("Rejeição: NFC-e com Data-Hora de emissão atrasada.");
				case 705:
					return ("Rejeição: NFC-e com data de entrada/saída.");
				case 706:
					return ("Rejeição: NFC-e para operação de entrada.");
				case 707:
					return ("Rejeição: NFC-e para operação interestadual ou com o exterior.");
				case 708:
					return ("Rejeição: NFC-e não pode referenciar documento fiscal.");
				case 709:
					return ("Rejeição: NFC-e com formato de DANFE inválido.");
				case 710:
					return ("Rejeição: NF-e com formato de DANFE inválido.");
				case 711:
					return ("Rejeição: NF-e com contingência off-line.");
				case 712:
					return ("Rejeição: NFC-e com contingência off-line para a UF.");
				case 713:
					return ("Rejeição: Tipo de Emissão diferente de 6 ou 7 para contingência da SVC acessada.");
				case 714:
					return ("Rejeição: NFC-e com contingência DPEC inexistente.");
				case 715:
					return ("Rejeição: NFC-e com finalidade inválida.");
				case 716:
					return ("Rejeição: NFC-e em operação não destinada a consumidor final.");
				case 717:
					return ("Rejeição: NFC-e em operação não presencial.");
				case 718:
					return ("Rejeição: NFC-e não deve informar IE de Substituto Tributário.");
				case 719:
					return ("Rejeição: NF-e sem a identificação do destinatário.");
				case 720:
					return ("Rejeição: Na operação com Exterior deve ser informada tag idEstrangeiro.");
				case 721:
					return ("Rejeição: Operação interestadual deve informar CNPJ ou CPF..");
				case 723:
					return ("Rejeição: Operação interna com idEstrangeiro informado deve ser para consumidor final.");
				case 724:
					return ("Rejeição: NF-e sem o nome do destinatário.");
				case 725:
					return ("Rejeição: NFC-e com CFOP inválido.");
				case 726:
					return ("Rejeição: NF-e sem a informação de endereço do destinatário.");
				case 727:
					return ("Rejeição: Operação com Exterior e UF diferente de EX.");
				case 728:
					return ("Rejeição: NF-e sem informação da IE do destinatário.");
				case 729:
					return ("Rejeição: NFC-e com informação da IE do destinatário.");
				case 730:
					return ("Rejeição: NFC-e com Inscrição Suframa.");
				case 731:
					return ("Rejeição: CFOP de operação com Exterior e idDest <> 3.");
				case 732:
					return ("Rejeição: CFOP de operação interestadual e idDest <> 2.");
				case 733:
					return ("Rejeição: CFOP de operação interna e idDest <> 1.");
				case 734:
					return ("Rejeição: NFC-e com Unidade de Comercialização inválida.");
				case 735:
					return ("Rejeição: NFC-e com Unidade de Tributação inválida.");
				case 736:
					return ("Rejeição: NFC-e com grupo de Veículos novos.");
				case 737:
					return ("Rejeição: NFC-e com grupo de Medicamentos.");
				case 738:
					return ("Rejeição: NFC-e com grupo de Armamentos.");
				case 739:
					return ("Rejeição: NFC-e com grupo de Combustível.");
				case 740:
					return ("Rejeição: NFC-e com CST 51-Diferimento.");
				case 741:
					return ("Rejeição: NFC-e com Partilha de ICMS entre UF.");
				case 742:
					return ("Rejeição: NFC-e com grupo do IPI.");
				case 743:
					return ("Rejeição: NFC-e com grupo do II.");
				case 745:
					return ("Rejeição: NF-e sem grupo do PIS.");
				case 746:
					return ("Rejeição: NFC-e com grupo do PIS-ST.");
				case 748:
					return ("Rejeição: NF-e sem grupo da COFINS.");
				case 749:
					return ("Rejeição: NFC-e com grupo da COFINS-ST.");
				case 750:
					return ("Rejeição: NFC-e com valor total superior ao permitido para destinatário não identificado (Código) [Limite].");
				case 751:
					return ("Rejeição: NFC-e com valor total superior ao permitido para destinatário não identificado (Nome) [Limite].");
				case 752:
					return ("Rejeição: NFC-e com valor total superior ao permitido para destinatário não identificado (Endereço) [Limite].");
				case 753:
					return ("Rejeição: NFC-e com Frete.");
				case 754:
					return ("Rejeição: NFC-e com dados do Transportador.");
				case 755:
					return ("Rejeição: NFC-e com dados de Retenção do ICMS no Transporte.");
				case 756:
					return ("Rejeição: NFC-e com dados do veículo de Transporte.");
				case 757:
					return ("Rejeição: NFC-e com dados de Reboque do veículo de Transporte.");
				case 758:
					return ("Rejeição: NFC-e com dados do Vagão de Transporte.");
				case 759:
					return ("Rejeição: NFC-e com dados da Balsa de Transporte.");
				case 760:
					return ("Rejeição: NFC-e com dados de cobrança (Fatura, Duplicata).");
				case 762:
					return ("Rejeição: NFC-e com dados de compras (Empenho, Pedido, Contrato).");
				case 763:
					return ("Rejeição: NFC-e com dados de aquisição de Cana.");
				case 764:
					return ("Rejeição: Solicitada resposta síncrona para Lote com mais de uma NF-e (indSinc=1).");
				case 765:
					return ("Rejeição: Lote só poderá conter NF-e ou NFC-e.");
				case 766:
					return ("Rejeição: NFC-e com CST 50-Suspensão.");
				case 767:
					return ("Rejeição: NFC-e com somatório dos pagamentos diferente do total da Nota Fiscal.");
				case 768:
					return ("Rejeição: NF-e não deve possuir o grupo de Formas de Pagamento.");
				case 769:
					return ("Rejeição: A critério da UF NFC-e deve possuir o grupo de Formas de Pagamento.");
				case 770:
					return ("Rejeição: NFC-e autorizada há mais de 24 horas..");
				case 771:
					return ("Rejeição: Operação Interestadual e UF de destino com EX.");
				case 772:
					return ("Rejeição: Operação Interestadual e UF de destino igual à UF do emitente.");
				case 773:
					return ("Rejeição: Operação Interna e UF de destino difere da UF do emitente.");
				case 774:
					return ("Rejeição: NFC-e com indicador de item não participante do total.");
				case 775:
					return ("Rejeição: Modelo da NFC-e diferente de 65.");
				case 776:
					return ("Rejeição: Solicitada resposta síncrona para UF que não disponibiliza este atendimento (indSinc=1).");
				case 777:
					return ("Rejeição: Obrigatória a informação do NCM completo.");
				case 778:
					return ("Rejeição: Informado NCM inexistente.");
				case 779:
					return ("Rejeição: NFC-e com NCM incompatível.");
				case 780:
					return ("Rejeição: Total da NFC-e superior ao valor limite estabelecido pela SEFAZ [Limite].");
				case 781:
					return ("Rejeição: Emissor não habilitado para emissão da NFC-e.");
				case 782:
					return ("Rejeição: NFC-e não é autorizada pelo SCAN.");
				case 783:
					return ("Rejeição: NFC-e não é autorizada pela SVC.");
				case 784:
					return ("Rejeição: NFC-e não permite o evento de Carta de Correção.");
				case 785:
					return ("Rejeição: NFC-e com entrega a domicílio não permitida pela UF.");
				case 786:
					return ("Rejeição: NFC-e de entrega a domicílio sem dados do Transportador.");
				case 787:
					return ("Rejeição: NFC-e de entrega a domicílio sem a identificação do destinatário.");
				case 788:
					return ("Rejeição: NFC-e de entrega a domicílio sem o endereço do destinatário.");
				case 789:
					return ("Rejeição: NFC-e para destinatário contribuinte de ICMS.");
				case 790:
					return ("Rejeição: Operação com Exterior para destinatário Contribuinte de ICMS.");
				case 791:
					return ("Rejeição: NF-e com indicação de destinatário isento de IE, com a informação da IE do destinatário.");
				case 792:
					return ("Rejeição: Informada a IE do destinatário para operação com destinatário no Exterior.");
				case 793:
					return ("Rejeição: Informado Capítulo do NCM inexistente.");
				case 794:
					return ("Rejeição: NF-e com indicativo de NFC-e com entrega a domicílio.");
				case 795:
					return ("Rejeição: Total do ICMS desonerado difere do somatório dos itens.");
				case 796:
					return ("Rejeição: Empresa sem Chave de Segurança para o QR-Code.");
				default:
					return ("Código de erro desconhecido");
			}
		}
    }
}
