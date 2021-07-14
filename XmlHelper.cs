using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace JpManifestoNFE
{
    class XmlHelper
    {
        /// <summary>
        /// Serializa um objeto de tipo presente em XsdClasses para um XmlDocument;
        /// </summary>
        /// <param name="toXmlDoc"></param>
        /// <param name="objType"></param>
        /// <returns></returns>
        public static XmlDocument ParseToXmlDocument(object toXmlDoc, Type objType, string defaultNamespace)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            XmlSerializer xmlSerializer = new XmlSerializer(objType);//, defaultNamespace);

            var defaultEncoding = Encoding.UTF8;

            var writerSettings = new XmlWriterSettings();
            writerSettings.Encoding = defaultEncoding;

            XmlDocument doc = new XmlDocument();

            using (var mStream = new MemoryStream())
            {
                using (var reader = new StreamReader(mStream))
                {
                    using (var xmlWriter = XmlWriter.Create(mStream, writerSettings))
                    {

                        xmlSerializer.Serialize(xmlWriter, toXmlDoc, ns);
                        mStream.Seek(0, SeekOrigin.Begin);

                        string xml = reader.ReadToEnd();
                        doc.PreserveWhitespace = false;
                        /*A deserilização dos objetos diretamente em xml, gerava alguns namespaces indevidos,
                        que ocasionam erros ao assinar os documentos (quando requerido) ex: Asinatura difere do calculado.
                        Por isso, ao serializar o documento, é removido todos os namespaces, porém, ao remove-los todos os 
                        outros namespaces, e o nome das propriedades são inseridos depois de q1: ou :q1, sendo então necessário
                        remove-los manualmente da string representando o arquivo XML.*/
                        doc.LoadXml(xml.Replace(":q1", "").Replace("q1:", ""));
                    }
                }
            }

            return doc;
        }



        /// <summary>
        /// Deserializa um nó Xml para uma instância de um objeto de tipo especificado em XsdClasses;
        /// </summary>
        /// <param name="xmlNode"></param>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public static T ParseFromXml<T>(XmlNode xmlNode, Type typeToConvert)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeToConvert);

            XmlDocument doc = new XmlDocument();
            XmlNode toImport = doc.ImportNode(xmlNode, true);
            doc.AppendChild(toImport);

            using (var sReader = new StringReader(xmlNode.OuterXml))
            {
                var des = xmlSerializer.Deserialize(sReader);
                return (T)des;
            }
        }



        /// <summary>
        /// Deserializa um documento Xml para uma instância de um objeto de tipo especificado em XsdClasses;
        /// </summary>
        /// <param name="xmlNode"></param>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public static T ParseFromXml<T>(XmlDocument xmlDoc, Type typeToConvert)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeToConvert);

            using (var sReader = new StringReader(xmlDoc.OuterXml))
            {
                var des = xmlSerializer.Deserialize(sReader);
                return (T)des;
            }
        }
    }
}
