using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace JpManifestoNFE
{
    public interface ISchemaFactory
    {
        XmlSchemaSet GetSchemas(string defaultNamespace, SchemasNFe schema);
    }

    public enum SchemasNFe
    {
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
    }

}
