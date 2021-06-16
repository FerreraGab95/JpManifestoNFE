using System;
using System.Collections.Generic;
using System.Text;

namespace JpManifestoNFE
{
    public static class CodRetornoSefaz
    {

        /// <summary>
        /// Lança uma exceção caso o código de retonro
        /// </summary>
        /// <param name="sefazReturnCode"></param>
        public static void ThrowIfCodeIsError(int sefazReturnCode)
        {
			// Obs: Arquivo gerado via script, verificar se existe algum erro.
            switch(sefazReturnCode)
            {
				case 100:
					throw new SefazCodeErrorException("Autorizado o uso da NF-e.");
				case 101:
					throw new SefazCodeErrorException("Cancelamento de NF-e homologado.");
				case 102:
					throw new SefazCodeErrorException("Inutilização de número homologado.");
				case 103:
					throw new SefazCodeErrorException("Lote recebido com sucesso.");
				case 104:
					throw new SefazCodeErrorException("Lote processado.");
				case 105:
					throw new SefazCodeErrorException("Lote em processamento.");
				case 106:
					throw new SefazCodeErrorException("Lote não localizado.");
				case 107:
					throw new SefazCodeErrorException("Serviço em Operação.");
				case 108:
					throw new SefazCodeErrorException("Serviço Paralisado Momentaneamente (curto prazo).");
				case 109:
					throw new SefazCodeErrorException("Serviço Paralisado sem Previsão.");
				case 110:
					throw new SefazCodeErrorException("Uso Denegado.");
				case 111:
					throw new SefazCodeErrorException("Consulta cadastro com uma ocorrência.");
				case 112:
					throw new SefazCodeErrorException("Consulta cadastro com mais de uma ocorrência.");
				case 124:
					throw new SefazCodeErrorException("EPEC Autorizado.");
				case 128:
					throw new SefazCodeErrorException("Lote de Evento Processado.");
				case 135:
					throw new SefazCodeErrorException("Evento registrado e vinculado a NF-e.");
				case 136:
					throw new SefazCodeErrorException("Evento registrado, mas não vinculado a NF-e.");
				case 137:
					throw new SefazCodeErrorException("Nenhum documento localizado para o Destinatário.");
				case 138:
					throw new SefazCodeErrorException("Documento localizado para o Destinatário.");
				case 139:
					throw new SefazCodeErrorException("Pedido de Download processado.");
				case 140:
					throw new SefazCodeErrorException("Download disponibilizado.");
				case 142:
					throw new SefazCodeErrorException("Ambiente de Contingência EPEC bloqueado para o Emitente.");
				case 150:
					throw new SefazCodeErrorException("Autorizado o uso da NF-e, autorização fora de prazo.");
				case 151:
					throw new SefazCodeErrorException("Cancelamento de NF-e homologado fora de prazoRejeição: Número máximo de numeração a inutilizar ultrapassou o limite.");
				case 202:
					throw new SefazCodeErrorException("Rejeição: Falha no reconhecimento da autoria ou integridade do arquivo digital.");
				case 203:
					throw new SefazCodeErrorException("Rejeição: Emissor não habilitado para emissão de NF-e.");
				case 204:
					throw new SefazCodeErrorException("Duplicidade de NF-e [nRec:999999999999999].");
				case 205:
					throw new SefazCodeErrorException("NF-e está denegada na base de dados da SEFAZ [nRec:999999999999999].");
				case 206:
					throw new SefazCodeErrorException("Rejeição: NF-e já está inutilizada na Base de dados da SEFAZ.");
				case 207:
					throw new SefazCodeErrorException("Rejeição: CNPJ do emitente inválido.");
				case 208:
					throw new SefazCodeErrorException("Rejeição: CNPJ do destinatário inválido.");
				case 209:
					throw new SefazCodeErrorException("Rejeição: IE do emitente inválida.");
				case 210:
					throw new SefazCodeErrorException("Rejeição: IE do destinatário inválida.");
				case 211:
					throw new SefazCodeErrorException("Rejeição: IE do substituto inválida.");
				case 212:
					throw new SefazCodeErrorException("Rejeição: Data de emissão NF-e posterior a data de recebimento.");
				case 213:
					throw new SefazCodeErrorException("Rejeição: CNPJ-Base do Emitente difere do CNPJ-Base do Certificado Digital.");
				case 214:
					throw new SefazCodeErrorException("Rejeição: Tamanho da mensagem excedeu o limite estabelecido.");
				case 215:
					throw new SefazCodeErrorException("Rejeição: Falha no schema XML.");
				case 216:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso difere da cadastrada.");
				case 217:
					throw new SefazCodeErrorException("Rejeição: NF-e não consta na base de dados da SEFAZ.");
				case 218:
					throw new SefazCodeErrorException("NF-e já está cancelada na base de dados da SEFAZ [nRec:999999999999999].");
				case 219:
					throw new SefazCodeErrorException("Rejeição: Circulação da NF-e verificada.");
				case 220:
					throw new SefazCodeErrorException("Rejeição: Prazo de Cancelamento superior ao previsto na Legislação.");
				case 221:
					throw new SefazCodeErrorException("Rejeição: Confirmado o recebimento da NF-e pelo destinatário.");
				case 222:
					throw new SefazCodeErrorException("Rejeição: Protocolo de Autorização de Uso difere do cadastrado.");
				case 223:
					throw new SefazCodeErrorException("Rejeição: CNPJ do transmissor do lote difere do CNPJ do transmissor da consulta.");
				case 224:
					throw new SefazCodeErrorException("Rejeição: A faixa inicial é maior que a faixa final.");
				case 225:
					throw new SefazCodeErrorException("Rejeição: Falha no Schema XML do lote de NFe.");
				case 226:
					throw new SefazCodeErrorException("Rejeição: Código da UF do Emitente diverge da UF autorizadora.");
				case 227:
					throw new SefazCodeErrorException("Rejeição: Erro na Chave de Acesso - Campo Id – falta a literal NFe.");
				case 228:
					throw new SefazCodeErrorException("Rejeição: Data de Emissão muito atrasada.");
				case 229:
					throw new SefazCodeErrorException("Rejeição: IE do emitente não informada.");
				case 230:
					throw new SefazCodeErrorException("Rejeição: IE do emitente não cadastrada.");
				case 231:
					throw new SefazCodeErrorException("Rejeição: IE do emitente não vinculada ao CNPJ.");
				case 232:
					throw new SefazCodeErrorException("Rejeição: IE do destinatário não informada.");
				case 233:
					throw new SefazCodeErrorException("Rejeição: IE do destinatário não cadastrada.");
				case 234:
					throw new SefazCodeErrorException("Rejeição: IE do destinatário não vinculada ao CNPJ.");
				case 235:
					throw new SefazCodeErrorException("Rejeição: Inscrição SUFRAMA inválida.");
				case 236:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso com dígito verificador inválido.");
				case 237:
					throw new SefazCodeErrorException("Rejeição: CPF do destinatário inválido.");
				case 238:
					throw new SefazCodeErrorException("Rejeição: Cabeçalho - Versão do arquivo XML superior a Versão vigente.");
				case 239:
					throw new SefazCodeErrorException("Rejeição: Cabeçalho - Versão do arquivo XML não suportada.");
				case 240:
					throw new SefazCodeErrorException("Rejeição: Cancelamento/Inutilização - Irregularidade Fiscal do Emitente.");
				case 241:
					throw new SefazCodeErrorException("Rejeição: Um número da faixa já foi utilizado.");
				case 242:
					throw new SefazCodeErrorException("Rejeição: Cabeçalho - Falha no Schema XML.");
				case 243:
					throw new SefazCodeErrorException("Rejeição: XML Mal Formado.");
				case 244:
					throw new SefazCodeErrorException("Rejeição: CNPJ do Certificado Digital difere do CNPJ da Matriz e do CNPJ do Emitente.");
				case 245:
					throw new SefazCodeErrorException("Rejeição: CNPJ Emitente não cadastrado.");
				case 246:
					throw new SefazCodeErrorException("Rejeição: CNPJ Destinatário não cadastrado.");
				case 247:
					throw new SefazCodeErrorException("Rejeição: Sigla da UF do Emitente diverge da UF autorizadora.");
				case 248:
					throw new SefazCodeErrorException("Rejeição: UF do Recibo diverge da UF autorizadora.");
				case 249:
					throw new SefazCodeErrorException("Rejeição: UF da Chave de Acesso diverge da UF autorizadoraRejeição: UF diverge da UF autorizadora.");
				case 251:
					throw new SefazCodeErrorException("Rejeição: UF/Município destinatário não pertence a SUFRAMA.");
				case 252:
					throw new SefazCodeErrorException("Rejeição: Ambiente informado diverge do Ambiente de recebimento.");
				case 253:
					throw new SefazCodeErrorException("Rejeição: Digito Verificador da chave de acesso composta inválida.");
				case 254:
					throw new SefazCodeErrorException("Rejeição: NF-e complementar não possui NF referenciada.");
				case 255:
					throw new SefazCodeErrorException("Rejeição: NF-e complementar possui mais de uma NF referenciada.");
				case 256:
					throw new SefazCodeErrorException("Rejeição: Uma NF-e da faixa já está inutilizada na Base de dados da SEFAZ.");
				case 257:
					throw new SefazCodeErrorException("Rejeição: Solicitante não habilitado para emissão da NF-e.");
				case 258:
					throw new SefazCodeErrorException("Rejeição: CNPJ da consulta inválido.");
				case 259:
					throw new SefazCodeErrorException("Rejeição: CNPJ da consulta não cadastrado como contribuinte na UF.");
				case 260:
					throw new SefazCodeErrorException("Rejeição: IE da consulta inválida.");
				case 261:
					throw new SefazCodeErrorException("Rejeição: IE da consulta não cadastrada como contribuinte na UF.");
				case 262:
					throw new SefazCodeErrorException("Rejeição: UF não fornece consulta por CPF.");
				case 263:
					throw new SefazCodeErrorException("Rejeição: CPF da consulta inválido.");
				case 264:
					throw new SefazCodeErrorException("Rejeição: CPF da consulta não cadastrado como contribuinte na UF.");
				case 265:
					throw new SefazCodeErrorException("Rejeição: Sigla da UF da consulta difere da UF do Web Service.");
				case 266:
					throw new SefazCodeErrorException("Rejeição: Série utilizada não permitida no Web Service.");
				case 267:
					throw new SefazCodeErrorException("Rejeição: NF Complementar referencia uma NF-e inexistente.");
				case 268:
					throw new SefazCodeErrorException("Rejeição: NF Complementar referencia outra NF-e Complementar.");
				case 269:
					throw new SefazCodeErrorException("Rejeição: CNPJ Emitente da NF Complementar difere do CNPJ da NF Referenciada.");
				case 270:
					throw new SefazCodeErrorException("Rejeição: Código Município do Fato Gerador: dígito inválido.");
				case 271:
					throw new SefazCodeErrorException("Rejeição: Código Município do Fato Gerador: difere da UF do emitente.");
				case 272:
					throw new SefazCodeErrorException("Rejeição: Código Município do Emitente: dígito inválido.");
				case 273:
					throw new SefazCodeErrorException("Rejeição: Código Município do Emitente: difere da UF do emitente.");
				case 274:
					throw new SefazCodeErrorException("Rejeição: Código Município do Destinatário: dígito inválido.");
				case 275:
					throw new SefazCodeErrorException("Rejeição: Código Município do Destinatário: difere da UF do Destinatário.");
				case 276:
					throw new SefazCodeErrorException("Rejeição: Código Município do Local de Retirada: dígito inválido.");
				case 277:
					throw new SefazCodeErrorException("Rejeição: Código Município do Local de Retirada: difere da UF do Local de Retirada.");
				case 278:
					throw new SefazCodeErrorException("Rejeição: Código Município do Local de Entrega: dígito inválido.");
				case 279:
					throw new SefazCodeErrorException("Rejeição: Código Município do Local de Entrega: difere da UF do Local de Entrega.");
				case 280:
					throw new SefazCodeErrorException("Rejeição: Certificado Transmissor inválido.");
				case 281:
					throw new SefazCodeErrorException("Rejeição: Certificado Transmissor Data Validade.");
				case 282:
					throw new SefazCodeErrorException("Rejeição: Certificado Transmissor sem CNPJ.");
				case 283:
					throw new SefazCodeErrorException("Rejeição: Certificado Transmissor - erro Cadeia de Certificação.");
				case 284:
					throw new SefazCodeErrorException("Rejeição: Certificado Transmissor revogado.");
				case 285:
					throw new SefazCodeErrorException("Rejeição: Certificado Transmissor difere ICP-Brasil.");
				case 286:
					throw new SefazCodeErrorException("Rejeição: Certificado Transmissor erro no acesso a LCR.");
				case 287:
					throw new SefazCodeErrorException("Rejeição: Código Município do FG - ISSQN: dígito inválido.");
				case 288:
					throw new SefazCodeErrorException("Rejeição: Código Município do FG - Transporte: dígito inválido.");
				case 289:
					throw new SefazCodeErrorException("Rejeição: Código da UF informada diverge da UF solicitada.");
				case 290:
					throw new SefazCodeErrorException("Rejeição: Certificado Assinatura inválido.");
				case 291:
					throw new SefazCodeErrorException("Rejeição: Certificado Assinatura Data Validade.");
				case 292:
					throw new SefazCodeErrorException("Rejeição: Certificado Assinatura sem CNPJ.");
				case 293:
					throw new SefazCodeErrorException("Rejeição: Certificado Assinatura - erro Cadeia de Certificação.");
				case 294:
					throw new SefazCodeErrorException("Rejeição: Certificado Assinatura revogado.");
				case 295:
					throw new SefazCodeErrorException("Rejeição: Certificado Assinatura difere ICP-Brasil.");
				case 296:
					throw new SefazCodeErrorException("Rejeição: Certificado Assinatura erro no acesso a LCR.");
				case 297:
					throw new SefazCodeErrorException("Rejeição: Assinatura difere do calculado.");
				case 298:
					throw new SefazCodeErrorException("Rejeição: Assinatura difere do padrão do Sistema.");
				case 299:
					throw new SefazCodeErrorException("Rejeição: XML da área de cabeçalho com codificação diferente de UTF-8.");
				case 301:
					throw new SefazCodeErrorException("Uso Denegado: Irregularidade fiscal do emitente.");
				case 302:
					throw new SefazCodeErrorException("Rejeição: Irregularidade fiscal do destinatário.");
				case 303:
					throw new SefazCodeErrorException("Uso Denegado: Destinatário não habilitado a operar na UF.");
				case 304:
					throw new SefazCodeErrorException("Rejeição: Pedido de Cancelamento para NF-e com evento da Suframa.");
				case 321:
					throw new SefazCodeErrorException("Rejeição: NF-e de devolução de mercadoria não possui documento fiscal referenciado.");
				case 323:
					throw new SefazCodeErrorException("Rejeição: CNPJ autorizado para download inválido.");
				case 324:
					throw new SefazCodeErrorException("Rejeição: CNPJ do destinatário já autorizado para download.");
				case 325:
					throw new SefazCodeErrorException("Rejeição: CPF autorizado para download inválido.");
				case 326:
					throw new SefazCodeErrorException("Rejeição: CPF do destinatário já autorizado para download.");
				case 327:
					throw new SefazCodeErrorException("Rejeição: CFOP inválido para NF-e com finalidade de devolução de mercadoria.");
				case 328:
					throw new SefazCodeErrorException("Rejeição: CFOP de devolução de mercadoria para NF-e que não tem finalidade de devolução demercadoria.");
				case 329:
					throw new SefazCodeErrorException("Rejeição: Número da DI /DSI inválido.");
				case 330:
					throw new SefazCodeErrorException("Rejeição: Informar o Valor da AFRMM na importação por via marítima.");
				case 331:
					throw new SefazCodeErrorException("Rejeição: Informar o CNPJ do adquirente ou do encomendante nesta forma de importação.");
				case 332:
					throw new SefazCodeErrorException("Rejeição: CNPJ do adquirente ou do encomendante da importação inválido.");
				case 333:
					throw new SefazCodeErrorException("Rejeição: Informar a UF do adquirente ou do encomendante nesta forma de importação.");
				case 334:
					throw new SefazCodeErrorException("Rejeição: Número do processo de drawback não informado na importação.");
				case 335:
					throw new SefazCodeErrorException("Rejeição: Número do processo de drawback na importação inválido.");
				case 336:
					throw new SefazCodeErrorException("Rejeição: Informado o grupo de exportação no item para CFOP que não é de exportação.");
				case 337:
					throw new SefazCodeErrorException("Rejeição: Não informado o grupo de exportação no item.");
				case 338:
					throw new SefazCodeErrorException("Rejeição: Número do processo de drawback não informado na exportação.");
				case 339:
					throw new SefazCodeErrorException("Rejeição: Número do processo de drawback na exportação inválido.");
				case 340:
					throw new SefazCodeErrorException("Rejeição: Não informado o grupo de exportação indireta no item.");
				case 341:
					throw new SefazCodeErrorException("Rejeição: Número do registro de exportação inválido.");
				case 342:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso informada na Exportação Indireta com DV inválido.");
				case 343:
					throw new SefazCodeErrorException("Rejeição: Modelo da NF-e informada na Exportação Indireta diferente de 55.");
				case 344:
					throw new SefazCodeErrorException("Rejeição: Duplicidade de NF-e informada na Exportação Indireta (Chave de Acesso informada maisde uma vez).");
				case 345:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso informada na Exportação Indireta não consta como NF-e referenciadaRejeição: Somatório das quantidades informadas na Exportação Indireta não corresponde aquantidade total do item.");
				case 347:
					throw new SefazCodeErrorException("Rejeição: Descrição do Combustível diverge da descrição adotada pela ANP.");
				case 348:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo RECOPI.");
				case 349:
					throw new SefazCodeErrorException("Rejeição: Número RECOPI não informado.");
				case 350:
					throw new SefazCodeErrorException("Rejeição: Número RECOPI inválido.");
				case 351:
					throw new SefazCodeErrorException("Rejeição: Valor do ICMS da Operação no CST=51 difere do produto BC e Alíquota.");
				case 352:
					throw new SefazCodeErrorException("Rejeição: Valor do ICMS Diferido no CST=51 difere do produto Valor ICMS Operação e percentualdiferimento.");
				case 353:
					throw new SefazCodeErrorException("Rejeição: Valor do ICMS no CST=51 não corresponde a diferença do ICMS operação e ICMSdiferido.");
				case 354:
					throw new SefazCodeErrorException("Rejeição: Informado grupo de devolução de tributos para NF-e que não tem finalidade dedevolução de mercadoria.");
				case 355:
					throw new SefazCodeErrorException("Rejeição: Informar o local de saída do Pais no caso da exportação.");
				case 356:
					throw new SefazCodeErrorException("Rejeição: Informar o local de saída do Pais somente no caso da exportação.");
				case 357:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso do grupo de Exportação Indireta inexistente [nRef: xxx].");
				case 358:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso do grupo de Exportação Indireta cancelada ou denegada [nRef: xxx].");
				case 359:
					throw new SefazCodeErrorException("Rejeição: NF-e de venda a Órgão Público sem informar a Nota de Empenho.");
				case 360:
					throw new SefazCodeErrorException("Rejeição: NF-e com Nota de Empenho inválida para a UF..");
				case 361:
					throw new SefazCodeErrorException("Rejeição: NF-e com Nota de Empenho inexistente na UF..");
				case 362:
					throw new SefazCodeErrorException("Rejeição: Venda de combustível sem informação do Transportador.");
				case 364:
					throw new SefazCodeErrorException("Rejeição: Total do valor da dedução do ISS difere do somatório dos itens.");
				case 365:
					throw new SefazCodeErrorException("Rejeição: Total de outras retenções difere do somatório dos itens.");
				case 366:
					throw new SefazCodeErrorException("Rejeição: Total do desconto incondicionado ISS difere do somatório dos itens.");
				case 367:
					throw new SefazCodeErrorException("Rejeição: Total do desconto condicionado ISS difere do somatório dos itens.");
				case 368:
					throw new SefazCodeErrorException("Rejeição: Total de ISS retido difere do somatório dos itens.");
				case 369:
					throw new SefazCodeErrorException("Rejeição: Não informado o grupo avulsa na emissão pelo Fisco.");
				case 370:
					throw new SefazCodeErrorException("Rejeição: Nota Fiscal Avulsa com tipo de emissão inválido.");
				case 401:
					throw new SefazCodeErrorException("Rejeição: CPF do remetente inválido.");
				case 402:
					throw new SefazCodeErrorException("Rejeição: XML da área de dados com codificação diferente de UTF-8.");
				case 403:
					throw new SefazCodeErrorException("Rejeição: O grupo de informações da NF-e avulsa é de uso exclusivo do Fisco.");
				case 404:
					throw new SefazCodeErrorException("Rejeição: Uso de prefixo de namespace não permitido.");
				case 405:
					throw new SefazCodeErrorException("Rejeição: Código do país do emitente: dígito inválido.");
				case 406:
					throw new SefazCodeErrorException("Rejeição: Código do país do destinatário: dígito inválido.");
				case 407:
					throw new SefazCodeErrorException("Rejeição: O CPF só pode ser informado no campo emitente para a NF-e avulsa.");
				case 408:
					throw new SefazCodeErrorException("Rejeição: Evento não disponível para Autor pessoa física.");
				case 409:
					throw new SefazCodeErrorException("Rejeição: Campo cUF inexistente no elemento nfeCabecMsg do SOAP Header.");
				case 410:
					throw new SefazCodeErrorException("Rejeição: UF informada no campo cUF não é atendida pelo Web Service.");
				case 411:
					throw new SefazCodeErrorException("Rejeição: Campo versaoDados inexistente no elemento nfeCabecMsg do SOAP Header.");
				case 416:
					throw new SefazCodeErrorException("Rejeição: Falha na descompactação da área de dados.");
				case 417:
					throw new SefazCodeErrorException("Rejeição: Total do ICMS superior ao valor limite estabelecido.");
				case 418:
					throw new SefazCodeErrorException("Rejeição: Total do ICMS ST superior ao valor limite estabelecidoRejeição: Cancelamento para NF-e já cancelada.");
				case 450:
					throw new SefazCodeErrorException("Rejeição: Modelo da NF-e diferente de 55.");
				case 451:
					throw new SefazCodeErrorException("Rejeição: Processo de emissão informado inválido.");
				case 452:
					throw new SefazCodeErrorException("Rejeição: Tipo Autorizador do Recibo diverge do Órgão Autorizador.");
				case 453:
					throw new SefazCodeErrorException("Rejeição: Ano de inutilização não pode ser superior ao Ano atual.");
				case 454:
					throw new SefazCodeErrorException("Rejeição: Ano de inutilização não pode ser inferior a 2006.");
				case 455:
					throw new SefazCodeErrorException("Rejeição: Órgão Autor do evento diferente da UF da Chave de Acesso.");
				case 461:
					throw new SefazCodeErrorException("Rejeição: Informado percentual de Gás Natural na mistura para produto diferente de GLP.");
				case 465:
					throw new SefazCodeErrorException("Rejeição: Número de Controle da FCI inexistente.");
				case 466:
					throw new SefazCodeErrorException("Rejeição: Evento com Tipo de Autor incompatível.");
				case 467:
					throw new SefazCodeErrorException("Rejeição: Dados da NF-e divergentes do EPEC.");
				case 468:
					throw new SefazCodeErrorException("Rejeição: NF-e com Tipo Emissão = 4, sem EPEC correspondente.");
				case 471:
					throw new SefazCodeErrorException("Rejeição: Informado NCM=00 indevidamente.");
				case 476:
					throw new SefazCodeErrorException("Rejeição: Código da UF diverge da UF da primeira NF-e do Lote.");
				case 477:
					throw new SefazCodeErrorException("Rejeição: Código do órgão diverge do órgão do primeiro evento do Lote.");
				case 478:
					throw new SefazCodeErrorException("Rejeição: Local da entrega não informado para faturamento direto de veículos novos.");
				case 484:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso com tipo de emissão diferente de 4 (posição 35 da Chave de Acesso).");
				case 485:
					throw new SefazCodeErrorException("Rejeição: Duplicidade de numeração do EPEC (Modelo, CNPJ, Série e Número).");
				case 489:
					throw new SefazCodeErrorException("Rejeição: CNPJ informado inválido (DV ou zeros).");
				case 490:
					throw new SefazCodeErrorException("Rejeição: CPF informado inválido (DV ou zeros).");
				case 491:
					throw new SefazCodeErrorException("Rejeição: O tpEvento informado inválido.");
				case 492:
					throw new SefazCodeErrorException("Rejeição: O verEvento informado inválido.");
				case 493:
					throw new SefazCodeErrorException("Rejeição: Evento não atende o Schema XML específico.");
				case 494:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso inexistente.");
				case 501:
					throw new SefazCodeErrorException("Rejeição: Pedido de Cancelamento intempestivo (NF-e autorizada a mais de 7 dias).");
				case 502:
					throw new SefazCodeErrorException("Rejeição: Erro na Chave de Acesso - Campo Id não corresponde à concatenação dos camposcorrespondentes.");
				case 503:
					throw new SefazCodeErrorException("Rejeição: Série utilizada fora da faixa permitida no SCAN (900-999).");
				case 504:
					throw new SefazCodeErrorException("Rejeição: Data de Entrada/Saída posterior ao permitido.");
				case 505:
					throw new SefazCodeErrorException("Rejeição: Data de Entrada/Saída anterior ao permitido.");
				case 506:
					throw new SefazCodeErrorException("Rejeição: Data de Saída menor que a Data de Emissão.");
				case 507:
					throw new SefazCodeErrorException("Rejeição: O CNPJ do destinatário/remetente não deve ser informado em operação com o exterior.");
				case 508:
					throw new SefazCodeErrorException("Rejeição: CNPJ do destinatário com conteúdo nulo só é válido em operação com exterior.");
				case 509:
					throw new SefazCodeErrorException("Rejeição: Informado código de município diferente de “9999999” para operação com o exterior.");
				case 510:
					throw new SefazCodeErrorException("Rejeição: Operação com Exterior e Código País destinatário é 1058 (Brasil) ou não informado.");
				case 511:
					throw new SefazCodeErrorException("Rejeição: Não é de Operação com Exterior e Código País destinatário difere de 1058 (Brasil).");
				case 512:
					throw new SefazCodeErrorException("Rejeição: CNPJ do Local de Retirada inválido.");
				case 513:
					throw new SefazCodeErrorException("Rejeição: Código Município do Local de Retirada deve ser 9999999 para UF retirada = EX.");
				case 514:
					throw new SefazCodeErrorException("Rejeição: CNPJ do Local de Entrega inválido.");
				case 515:
					throw new SefazCodeErrorException("Rejeição: Código Município do Local de Entrega deve ser 9999999 para UF entrega = EX.");
				case 516:
					throw new SefazCodeErrorException("Rejeição: Falha no schema XML – inexiste a tag raiz esperada para a mensagem.");
				case 517:
					throw new SefazCodeErrorException("Rejeição: Falha no schema XML – inexiste atributo versao na tag raiz da mensagem.");
				case 518:
					throw new SefazCodeErrorException("Rejeição: CFOP de entrada para NF-e de saída.");
				case 519:
					throw new SefazCodeErrorException("Rejeição: CFOP de saída para NF-e de entrada.");
				case 520:
					throw new SefazCodeErrorException("Rejeição: CFOP de Operação com Exterior e UF destinatário difere de EX.");
				case 521:
					throw new SefazCodeErrorException("Rejeição: CFOP de Operação Estadual e UF do emitente difere da UF do destinatário paradestinatário contribuinte do ICMS..");
				case 522:
					throw new SefazCodeErrorException("Rejeição: CFOP de Operação Estadual e UF emitente difere da UF remetente para remetentecontribuinte do ICMS..");
				case 523:
					throw new SefazCodeErrorException("Rejeição: CFOP não é de Operação Estadual e UF emitente igual a UF destinatário..");
				case 524:
					throw new SefazCodeErrorException("Rejeição: CFOP de Operação com Exterior e não informado NCM.");
				case 525:
					throw new SefazCodeErrorException("Rejeição: CFOP de Importação e não informado dados da DI.");
				case 527:
					throw new SefazCodeErrorException("Rejeição: Operação de Exportação com informação de ICMS incompatível.");
				case 528:
					throw new SefazCodeErrorException("Rejeição: Valor do ICMS difere do produto BC e Alíquota.");
				case 529:
					throw new SefazCodeErrorException("Rejeição: NCM de informação obrigatória para produto tributado pelo IPI.");
				case 530:
					throw new SefazCodeErrorException("Rejeição: Operação com tributação de ISSQN sem informar a Inscrição Municipal.");
				case 531:
					throw new SefazCodeErrorException("Rejeição: Total da BC ICMS difere do somatório dos itens.");
				case 532:
					throw new SefazCodeErrorException("Rejeição: Total do ICMS difere do somatório dos itens.");
				case 533:
					throw new SefazCodeErrorException("Rejeição: Total da BC ICMS-ST difere do somatório dos itens.");
				case 534:
					throw new SefazCodeErrorException("Rejeição: Total do ICMS-ST difere do somatório dos itens.");
				case 535:
					throw new SefazCodeErrorException("Rejeição: Total do Frete difere do somatório dos itens.");
				case 536:
					throw new SefazCodeErrorException("Rejeição: Total do Seguro difere do somatório dos itens.");
				case 537:
					throw new SefazCodeErrorException("Rejeição: Total do Desconto difere do somatório dos itens.");
				case 538:
					throw new SefazCodeErrorException("Rejeição: Total do IPI difere do somatório dos itens.");
				case 539:
					throw new SefazCodeErrorException("Duplicidade de NF-e com diferença na Chave de Acesso [chNFe:99999999999999999999999999999999999999999999][nRec:999999999999999].");
				case 540:
					throw new SefazCodeErrorException("Rejeição: CPF do Local de Retirada inválido.");
				case 541:
					throw new SefazCodeErrorException("Rejeição: CPF do Local de Entrega inválido.");
				case 542:
					throw new SefazCodeErrorException("Rejeição: CNPJ do Transportador inválido.");
				case 543:
					throw new SefazCodeErrorException("Rejeição: CPF do Transportador inválido.");
				case 544:
					throw new SefazCodeErrorException("Rejeição: IE do Transportador inválida.");
				case 545:
					throw new SefazCodeErrorException("Rejeição: Falha no schema XML – versão informada na versaoDados do SOAPHeader diverge daversão da mensagem.");
				case 546:
					throw new SefazCodeErrorException("Rejeição: Erro na Chave de Acesso – Campo Id – falta a literal NFe.");
				case 547:
					throw new SefazCodeErrorException("Rejeição: Dígito Verificador da Chave de Acesso da NF-e Referenciada inválido.");
				case 548:
					throw new SefazCodeErrorException("Rejeição: CNPJ da NF referenciada inválido..");
				case 549:
					throw new SefazCodeErrorException("Rejeição: CNPJ da NF referenciada de produtor inválido..");
				case 550:
					throw new SefazCodeErrorException("Rejeição: CPF da NF referenciada de produtor inválido..");
				case 551:
					throw new SefazCodeErrorException("Rejeição: IE da NF referenciada de produtor inválido..");
				case 552:
					throw new SefazCodeErrorException("Rejeição: Dígito Verificador da Chave de Acesso do CT-e Referenciado inválido.");
				case 553:
					throw new SefazCodeErrorException("Rejeição: Tipo autorizador do recibo diverge do Órgão Autorizador..");
				case 554:
					throw new SefazCodeErrorException("Rejeição: Série difere da faixa 0-899.");
				case 555:
					throw new SefazCodeErrorException("Rejeição: Tipo autorizador do protocolo diverge do Órgão Autorizador..");
				case 556:
					throw new SefazCodeErrorException("Rejeição: Justificativa de entrada em contingência não deve ser informada para tipo de emissãonormal..");
				case 557:
					throw new SefazCodeErrorException("Rejeição: A Justificativa de entrada em contingência deve ser informada..");
				case 558:
					throw new SefazCodeErrorException("Rejeição: Data de entrada em contingência posterior a data de recebimento..");
				case 559:
					throw new SefazCodeErrorException("Rejeição: UF do Transportador não informada.");
				case 560:
					throw new SefazCodeErrorException("Rejeição: CNPJ base do emitente difere do CNPJ base da primeira NF-e do lote recebido.");
				case 561:
					throw new SefazCodeErrorException("Rejeição: Mês de Emissão informado na Chave de Acesso difere do Mês de Emissão da NF-e.");
				case 562:
					throw new SefazCodeErrorException("Rejeição: Código Numérico informado na Chave de Acesso difere do Código Numérico da NF-e[chNFe:99999999999999999999999999999999999999999999].");
				case 563:
					throw new SefazCodeErrorException("Rejeição: Já existe pedido de Inutilização com a mesma faixa de inutilização.");
				case 564:
					throw new SefazCodeErrorException("Rejeição: Total do Produto / Serviço difere do somatório dos itens.");
				case 565:
					throw new SefazCodeErrorException("Rejeição: Falha no schema XML – inexiste a tag raiz esperada para o lote de NF-e.");
				case 567:
					throw new SefazCodeErrorException("Rejeição: Falha no schema XML – versão informada na versaoDados do SOAPHeader diverge daversão do lote de NF-e.");
				case 568:
					throw new SefazCodeErrorException("Rejeição: Falha no schema XML – inexiste atributo versao na tag raiz do lote de NF-e.");
				case 569:
					throw new SefazCodeErrorException("Rejeição: Data de entrada em contingência muito atrasada.");
				case 570:
					throw new SefazCodeErrorException("Rejeição: Tipo de Emissão 3, 6 ou 7 só é válido nas contingências SCAN/SVC.");
				case 571:
					throw new SefazCodeErrorException("Rejeição: O tpEmis informado diferente de 3 para contingência SCAN.");
				case 572:
					throw new SefazCodeErrorException("Rejeição: Erro Atributo ID do evento não corresponde a concatenação dos campos (“ID” + tpEvento+ chNFe + nSeqEvento).");
				case 573:
					throw new SefazCodeErrorException("Rejeição: Duplicidade de Evento.");
				case 574:
					throw new SefazCodeErrorException("Rejeição: O autor do evento diverge do emissor da NF-e.");
				case 575:
					throw new SefazCodeErrorException("Rejeição: O autor do evento diverge do destinatário da NF-e.");
				case 576:
					throw new SefazCodeErrorException("Rejeição: O autor do evento não é um órgão autorizado a gerar o evento.");
				case 577:
					throw new SefazCodeErrorException("Rejeição: A data do evento não pode ser menor que a data de emissão da NF-e.");
				case 578:
					throw new SefazCodeErrorException("Rejeição: A data do evento não pode ser maior que a data do processamento.");
				case 579:
					throw new SefazCodeErrorException("Rejeição: A data do evento não pode ser menor que a data de autorização para NF-e não emitidaem contingência.");
				case 580:
					throw new SefazCodeErrorException("Rejeição: O evento exige uma NF-e autorizada.");
				case 587:
					throw new SefazCodeErrorException("Rejeição: Usar somente o namespace padrão da NF-e.");
				case 588:
					throw new SefazCodeErrorException("Rejeição: Não é permitida a presença de caracteres de edição no início/fim da mensagem ou entreas tags da mensagem.");
				case 589:
					throw new SefazCodeErrorException("Rejeição: Número do NSU informado superior ao maior NSU da base de dados da SEFAZ.");
				case 590:
					throw new SefazCodeErrorException("Rejeição: Informado CST para emissor do Simples Nacional (CRT=1).");
				case 591:
					throw new SefazCodeErrorException("Rejeição: Informado CSOSN para emissor que não é do Simples Nacional (CRT diferente de 1).");
				case 592:
					throw new SefazCodeErrorException("Rejeição: A NF-e deve ter pelo menos um item de produto sujeito ao ICMS.");
				case 593:
					throw new SefazCodeErrorException("Rejeição: CNPJ-Base consultado difere do CNPJ-Base do Certificado Digital.");
				case 594:
					throw new SefazCodeErrorException("Rejeição: O número de sequencia do evento informado é maior que o permitido.");
				case 595:
					throw new SefazCodeErrorException("Rejeição: Obrigatória a informação da justificativa do evento..");
				case 596:
					throw new SefazCodeErrorException("Rejeição: Evento apresentado fora do prazo: [prazo vigente].");
				case 597:
					throw new SefazCodeErrorException("Rejeição: CFOP de Importação e não informado dados de IPI.");
				case 598:
					throw new SefazCodeErrorException("Rejeição: NF-e emitida em ambiente de homologação com Razão Social do destinatário diferentede NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL.");
				case 599:
					throw new SefazCodeErrorException("Rejeição: CFOP de Importação e não informado dados de II.");
				case 601:
					throw new SefazCodeErrorException("Rejeição: Total do II difere do somatório dos itens.");
				case 602:
					throw new SefazCodeErrorException("Rejeição: Total do PIS difere do somatório dos itens sujeitos ao ICMS.");
				case 603:
					throw new SefazCodeErrorException("Rejeição: Total do COFINS difere do somatório dos itens sujeitos ao ICMS.");
				case 604:
					throw new SefazCodeErrorException("Rejeição: Total do vOutro difere do somatório dos itens.");
				case 605:
					throw new SefazCodeErrorException("Rejeição: Total do vISS difere do somatório do vProd dos itens sujeitos ao ISSQN.");
				case 606:
					throw new SefazCodeErrorException("Rejeição: Total do vBC do ISS difere do somatório dos itens.");
				case 607:
					throw new SefazCodeErrorException("Rejeição: Total do ISS difere do somatório dos itens.");
				case 608:
					throw new SefazCodeErrorException("Rejeição: Total do PIS difere do somatório dos itens sujeitos ao ISSQN.");
				case 609:
					throw new SefazCodeErrorException("Rejeição: Total do COFINS difere do somatório dos itens sujeitos ao ISSQN.");
				case 610:
					throw new SefazCodeErrorException("Rejeição: Total da NF difere do somatório dos Valores compõe o valor Total da NF..");
				case 611:
					throw new SefazCodeErrorException("Rejeição: cEAN inválido.");
				case 612:
					throw new SefazCodeErrorException("Rejeição: cEANTrib inválido.");
				case 613:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso difere da existente em BD.");
				case 614:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso inválida (Código UF inválido).");
				case 615:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso inválida (Ano menor que 06 ou Ano maior que Ano corrente).");
				case 616:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso inválida (Mês menor que 1 ou Mês maior que 12).");
				case 617:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso inválida (CNPJ zerado ou dígito inválido).");
				case 618:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso inválida (modelo diferente de 55 e 65).");
				case 619:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso inválida (número NF = 0).");
				case 620:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso difere da existente em BD.");
				case 621:
					throw new SefazCodeErrorException("Rejeição: CPF Emitente não cadastrado.");
				case 622:
					throw new SefazCodeErrorException("Rejeição: IE emitente não vinculada ao CPF.");
				case 623:
					throw new SefazCodeErrorException("Rejeição: CPF Destinatário não cadastrado.");
				case 624:
					throw new SefazCodeErrorException("Rejeição: IE Destinatário não vinculada ao CPF.");
				case 625:
					throw new SefazCodeErrorException("Rejeição: Inscrição SUFRAMA deve ser informada na venda com isenção para ZFM.");
				case 626:
					throw new SefazCodeErrorException("Rejeição: CFOP de operação isenta para ZFM diferente do previsto.");
				case 627:
					throw new SefazCodeErrorException("Rejeição: O valor do ICMS desonerado deve ser informado.");
				case 628:
					throw new SefazCodeErrorException("Rejeição: Total da NF superior ao valor limite estabelecido pela SEFAZ [Limite].");
				case 629:
					throw new SefazCodeErrorException("Rejeição: Valor do Produto difere do produto Valor Unitário de Comercialização e QuantidadeComercial.");
				case 630:
					throw new SefazCodeErrorException("Rejeição: Valor do Produto difere do produto Valor Unitário de Tributação e Quantidade Tributável.");
				case 631:
					throw new SefazCodeErrorException("Rejeição: CNPJ-Base do Destinatário difere do CNPJ-Base do Certificado Digital.");
				case 632:
					throw new SefazCodeErrorException("Rejeição: Solicitação fora de prazo, a NF-e não está mais disponível para download.");
				case 633:
					throw new SefazCodeErrorException("Rejeição: NF-e indisponível para download devido a ausência de Manifestação do Destinatário.");
				case 634:
					throw new SefazCodeErrorException("Rejeição: Destinatário da NF-e não tem o mesmo CNPJ raiz do solicitante do download.");
				case 635:
					throw new SefazCodeErrorException("Rejeição: NF-e com mesmo número e série já transmitida e aguardando processamento.");
				case 650:
					throw new SefazCodeErrorException("Rejeição: Evento de \"Ciência da Emissão\" para NF-e Cancelada ou Denegada.");
				case 651:
					throw new SefazCodeErrorException("Rejeição: Evento de \"Desconhecimento da Operação\" para NF-e Cancelada ou Denegada.");
				case 653:
					throw new SefazCodeErrorException("Rejeição: NF-e Cancelada, arquivo indisponível para download.");
				case 654:
					throw new SefazCodeErrorException("Rejeição: NF-e Denegada, arquivo indisponível para download.");
				case 655:
					throw new SefazCodeErrorException("Rejeição: Evento de Ciência da Emissão informado após a manifestação final do destinatário.");
				case 656:
					throw new SefazCodeErrorException("Rejeição: Consumo Indevido.");
				case 657:
					throw new SefazCodeErrorException("Rejeição: Código do Órgão diverge do órgão autorizador.");
				case 658:
					throw new SefazCodeErrorException("Rejeição: UF do destinatário da Chave de Acesso diverge da UF autorizadora.");
				case 660:
					throw new SefazCodeErrorException("Rejeição: CFOP de Combustível e não informado grupo de combustível da NF-e.");
				case 661:
					throw new SefazCodeErrorException("Rejeição: NF-e já existente para o número do EPEC informado.");
				case 662:
					throw new SefazCodeErrorException("Rejeição: Numeração do EPEC está inutilizada na Base de Dados da SEFAZ.");
				case 663:
					throw new SefazCodeErrorException("Rejeição: Alíquota do ICMS com valor superior a 4 por cento na operação de saída interestadualcom produtos importados.");
				case 678:
					throw new SefazCodeErrorException("Rejeição: NF referenciada com UF diferente da NF-e complementar.");
				case 679:
					throw new SefazCodeErrorException("Rejeição: Modelo da NF-e referenciada diferente de 55/65.");
				case 680:
					throw new SefazCodeErrorException("Rejeição: Duplicidade de NF-e referenciada (Chave de Acesso referenciada mais de uma vez).");
				case 681:
					throw new SefazCodeErrorException("Rejeição: Duplicidade de NF Modelo 1 referenciada (CNPJ, Modelo, Série e Número).");
				case 682:
					throw new SefazCodeErrorException("Rejeição: Duplicidade de NF de Produtor referenciada (IE, Modelo, Série e Número).");
				case 683:
					throw new SefazCodeErrorException("Rejeição: Modelo do CT-e referenciado diferente de 57.");
				case 684:
					throw new SefazCodeErrorException("Rejeição: Duplicidade de Cupom Fiscal referenciado (Modelo, Número de Ordem e COO).");
				case 685:
					throw new SefazCodeErrorException("Rejeição: Total do Valor Aproximado dos Tributos difere do somatório dos itens.");
				case 686:
					throw new SefazCodeErrorException("Rejeição: NF Complementar referencia uma NF-e cancelada.");
				case 687:
					throw new SefazCodeErrorException("Rejeição: NF Complementar referencia uma NF-e denegada.");
				case 688:
					throw new SefazCodeErrorException("Rejeição: NF referenciada de Produtor com IE inexistente [nRef: xxx].");
				case 689:
					throw new SefazCodeErrorException("Rejeição: NF referenciada de Produtor com IE não vinculada ao CNPJ/CPF informado [nRef: xxx].");
				case 690:
					throw new SefazCodeErrorException("Rejeição: Pedido de Cancelamento para NF-e com CT-e.");
				case 691:
					throw new SefazCodeErrorException("Rejeição: Chave de Acesso da NF-e diverge da Chave de Acesso do EPEC.");
				case 700:
					throw new SefazCodeErrorException("Rejeição: Mensagem de Lote versão 3.xx. Enviar para o Web Service nfeAutorizacao.");
				case 701:
					throw new SefazCodeErrorException("Rejeição: NF-e não pode utilizar a versão 3.00.");
				case 702:
					throw new SefazCodeErrorException("Rejeição: NFC-e não é aceita pela UF do Emitente.");
				case 703:
					throw new SefazCodeErrorException("Rejeição: Data-Hora de Emissão posterior ao horário de recebimento.");
				case 704:
					throw new SefazCodeErrorException("Rejeição: NFC-e com Data-Hora de emissão atrasada.");
				case 705:
					throw new SefazCodeErrorException("Rejeição: NFC-e com data de entrada/saída.");
				case 706:
					throw new SefazCodeErrorException("Rejeição: NFC-e para operação de entrada.");
				case 707:
					throw new SefazCodeErrorException("Rejeição: NFC-e para operação interestadual ou com o exterior.");
				case 708:
					throw new SefazCodeErrorException("Rejeição: NFC-e não pode referenciar documento fiscal.");
				case 709:
					throw new SefazCodeErrorException("Rejeição: NFC-e com formato de DANFE inválido.");
				case 710:
					throw new SefazCodeErrorException("Rejeição: NF-e com formato de DANFE inválido.");
				case 711:
					throw new SefazCodeErrorException("Rejeição: NF-e com contingência off-line.");
				case 712:
					throw new SefazCodeErrorException("Rejeição: NFC-e com contingência off-line para a UF.");
				case 713:
					throw new SefazCodeErrorException("Rejeição: Tipo de Emissão diferente de 6 ou 7 para contingência da SVC acessada.");
				case 714:
					throw new SefazCodeErrorException("Rejeição: NFC-e com contingência DPEC inexistente.");
				case 715:
					throw new SefazCodeErrorException("Rejeição: NFC-e com finalidade inválida.");
				case 716:
					throw new SefazCodeErrorException("Rejeição: NFC-e em operação não destinada a consumidor final.");
				case 717:
					throw new SefazCodeErrorException("Rejeição: NFC-e em operação não presencial.");
				case 718:
					throw new SefazCodeErrorException("Rejeição: NFC-e não deve informar IE de Substituto Tributário.");
				case 719:
					throw new SefazCodeErrorException("Rejeição: NF-e sem a identificação do destinatário.");
				case 720:
					throw new SefazCodeErrorException("Rejeição: Na operação com Exterior deve ser informada tag idEstrangeiro.");
				case 721:
					throw new SefazCodeErrorException("Rejeição: Operação interestadual deve informar CNPJ ou CPF..");
				case 723:
					throw new SefazCodeErrorException("Rejeição: Operação interna com idEstrangeiro informado deve ser para consumidor final.");
				case 724:
					throw new SefazCodeErrorException("Rejeição: NF-e sem o nome do destinatário.");
				case 725:
					throw new SefazCodeErrorException("Rejeição: NFC-e com CFOP inválido.");
				case 726:
					throw new SefazCodeErrorException("Rejeição: NF-e sem a informação de endereço do destinatário.");
				case 727:
					throw new SefazCodeErrorException("Rejeição: Operação com Exterior e UF diferente de EX.");
				case 728:
					throw new SefazCodeErrorException("Rejeição: NF-e sem informação da IE do destinatário.");
				case 729:
					throw new SefazCodeErrorException("Rejeição: NFC-e com informação da IE do destinatário.");
				case 730:
					throw new SefazCodeErrorException("Rejeição: NFC-e com Inscrição Suframa.");
				case 731:
					throw new SefazCodeErrorException("Rejeição: CFOP de operação com Exterior e idDest <> 3.");
				case 732:
					throw new SefazCodeErrorException("Rejeição: CFOP de operação interestadual e idDest <> 2.");
				case 733:
					throw new SefazCodeErrorException("Rejeição: CFOP de operação interna e idDest <> 1.");
				case 734:
					throw new SefazCodeErrorException("Rejeição: NFC-e com Unidade de Comercialização inválida.");
				case 735:
					throw new SefazCodeErrorException("Rejeição: NFC-e com Unidade de Tributação inválida.");
				case 736:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo de Veículos novos.");
				case 737:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo de Medicamentos.");
				case 738:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo de Armamentos.");
				case 739:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo de Combustível.");
				case 740:
					throw new SefazCodeErrorException("Rejeição: NFC-e com CST 51-Diferimento.");
				case 741:
					throw new SefazCodeErrorException("Rejeição: NFC-e com Partilha de ICMS entre UF.");
				case 742:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo do IPI.");
				case 743:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo do II.");
				case 745:
					throw new SefazCodeErrorException("Rejeição: NF-e sem grupo do PIS.");
				case 746:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo do PIS-ST.");
				case 748:
					throw new SefazCodeErrorException("Rejeição: NF-e sem grupo da COFINS.");
				case 749:
					throw new SefazCodeErrorException("Rejeição: NFC-e com grupo da COFINS-ST.");
				case 750:
					throw new SefazCodeErrorException("Rejeição: NFC-e com valor total superior ao permitido para destinatário não identificado (Código)[Limite].");
				case 751:
					throw new SefazCodeErrorException("Rejeição: NFC-e com valor total superior ao permitido para destinatário não identificado (Nome)[Limite].");
				case 752:
					throw new SefazCodeErrorException("Rejeição: NFC-e com valor total superior ao permitido para destinatário não identificado (Endereço)[Limite].");
				case 753:
					throw new SefazCodeErrorException("Rejeição: NFC-e com Frete.");
				case 754:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados do Transportador.");
				case 755:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados de Retenção do ICMS no Transporte.");
				case 756:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados do veículo de Transporte.");
				case 757:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados de Reboque do veículo de Transporte.");
				case 758:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados do Vagão de Transporte.");
				case 759:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados da Balsa de Transporte.");
				case 760:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados de cobrança (Fatura, Duplicata).");
				case 762:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados de compras (Empenho, Pedido, Contrato).");
				case 763:
					throw new SefazCodeErrorException("Rejeição: NFC-e com dados de aquisição de Cana.");
				case 764:
					throw new SefazCodeErrorException("Rejeição: Solicitada resposta síncrona para Lote com mais de uma NF-e (indSinc=1).");
				case 765:
					throw new SefazCodeErrorException("Rejeição: Lote só poderá conter NF-e ou NFC-e.");
				case 766:
					throw new SefazCodeErrorException("Rejeição: NFC-e com CST 50-Suspensão.");
				case 767:
					throw new SefazCodeErrorException("Rejeição: NFC-e com somatório dos pagamentos diferente do total da Nota Fiscal.");
				case 768:
					throw new SefazCodeErrorException("Rejeição: NF-e não deve possuir o grupo de Formas de Pagamento.");
				case 769:
					throw new SefazCodeErrorException("Rejeição: A critério da UF NFC-e deve possuir o grupo de Formas de Pagamento.");
				case 770:
					throw new SefazCodeErrorException("Rejeição: NFC-e autorizada há mais de 24 horas..");
				case 771:
					throw new SefazCodeErrorException("Rejeição: Operação Interestadual e UF de destino com EX.");
				case 772:
					throw new SefazCodeErrorException("Rejeição: Operação Interestadual e UF de destino igual à UF do emitente.");
				case 773:
					throw new SefazCodeErrorException("Rejeição: Operação Interna e UF de destino difere da UF do emitente.");
				case 774:
					throw new SefazCodeErrorException("Rejeição: NFC-e com indicador de item não participante do total.");
				case 775:
					throw new SefazCodeErrorException("Rejeição: Modelo da NFC-e diferente de 65.");
				case 776:
					throw new SefazCodeErrorException("Rejeição: Solicitada resposta síncrona para UF que não disponibiliza este atendimento (indSinc=1).");
				case 777:
					throw new SefazCodeErrorException("Rejeição: Obrigatória a informação do NCM completo.");
				case 778:
					throw new SefazCodeErrorException("Rejeição: Informado NCM inexistente.");
				case 779:
					throw new SefazCodeErrorException("Rejeição: NFC-e com NCM incompatível.");
				case 780:
					throw new SefazCodeErrorException("Rejeição: Total da NFC-e superior ao valor limite estabelecido pela SEFAZ [Limite].");
				case 781:
					throw new SefazCodeErrorException("Rejeição: Emissor não habilitado para emissão da NFC-e.");
				case 782:
					throw new SefazCodeErrorException("Rejeição: NFC-e não é autorizada pelo SCAN.");
				case 783:
					throw new SefazCodeErrorException("Rejeição: NFC-e não é autorizada pela SVC.");
				case 784:
					throw new SefazCodeErrorException("Rejeição: NFC-e não permite o evento de Carta de Correção.");
				case 785:
					throw new SefazCodeErrorException("Rejeição: NFC-e com entrega a domicílio não permitida pela UF.");
				case 786:
					throw new SefazCodeErrorException("Rejeição: NFC-e de entrega a domicílio sem dados do Transportador.");
				case 787:
					throw new SefazCodeErrorException("Rejeição: NFC-e de entrega a domicílio sem a identificação do destinatário.");
				case 788:
					throw new SefazCodeErrorException("Rejeição: NFC-e de entrega a domicílio sem o endereço do destinatário.");
				case 789:
					throw new SefazCodeErrorException("Rejeição: NFC-e para destinatário contribuinte de ICMS.");
				case 790:
					throw new SefazCodeErrorException("Rejeição: Operação com Exterior para destinatário Contribuinte de ICMS.");
				case 791:
					throw new SefazCodeErrorException("Rejeição: NF-e com indicação de destinatário isento de IE, com a informação da IE do destinatário.");
				case 792:
					throw new SefazCodeErrorException("Rejeição: Informada a IE do destinatário para operação com destinatário no Exterior.");
				case 793:
					throw new SefazCodeErrorException("Rejeição: Informado Capítulo do NCM inexistente.");
				case 794:
					throw new SefazCodeErrorException("Rejeição: NF-e com indicativo de NFC-e com entrega a domicílio.");
				case 795:
					throw new SefazCodeErrorException("Rejeição: Total do ICMS desonerado difere do somatório dos itens.");
				case 796:
					throw new SefazCodeErrorException("Rejeição: Empresa sem Chave de Segurança para o QR-Code.");

			}
		}
    }
}
