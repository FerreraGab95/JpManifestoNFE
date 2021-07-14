using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace JpManifestoNFE
{
    public class XmlSign
    {
        private X509Certificate2 clientCertificate;

        public XmlSign(X509Certificate2 certificate)
        {
            clientCertificate = certificate;
        }


        /// <summary>
        /// Assina o objeto de um tipo XML especificado;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlObjectType">Tipo do objeto a ser retornado</param>
        /// <param name="xmlObject">Objeto XML</param>
        /// <param name="defaultNamespace">Namespace padrão do objeto</param>
        /// <returns></returns>
        public T SignXmlObject<T>(Type xmlObjectType, object xmlObject, string defaultNamespace, string referenceURI = "")
        {
            var xmlDoc = XmlHelper.ParseToXmlDocument(xmlObject, xmlObjectType, defaultNamespace);
            SignXml(xmlDoc, referenceURI);
            return XmlHelper.ParseFromXml<T>(xmlDoc, xmlObjectType);
        }


        /// <summary>
        /// Assina o objeto de um tipo XML especificado e o retorna como um documento;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlObjectType">Tipo do objeto a ser retornado</param>
        /// <param name="xmlObject">Documento XML</param>
        /// <param name="defaultNamespace">Namespace padrão do objeto</param>
        /// <returns></returns>
        public XmlDocument SignXmlObject(Type xmlObjectType, object xmlObject, string defaultNamespace, string referenceURI = "")
        {
            var xmlDoc = XmlHelper.ParseToXmlDocument(xmlObject, xmlObjectType, defaultNamespace);
            SignXml(xmlDoc, referenceURI);
            return xmlDoc;
        }


        /// <summary>
        /// Assina o documento XML utilizando o certificado informado;
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <param name="referenceURI"></param>
        /// <returns></returns>
        public void SignXml(XmlDocument xmlDoc, string referenceURI = "")
        {
            if (null == xmlDoc)
                throw new ArgumentNullException("Documento XML");

            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Add the key to the SignedXml document.
            signedXml.SigningKey = clientCertificate.GetRSAPrivateKey();

            //Método de assinatura;
            signedXml.SignedInfo.SignatureMethod = SignedXml.XmlDsigRSASHA1Url;

            //Método de canonização do XML;
            signedXml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigCanonicalizationUrl;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.DigestMethod = SignedXml.XmlDsigSHA1Url; //Algoritmo descrito no XML;
            reference.Uri = referenceURI;

            //Os Xmls enviados para a SEFAZ requerem estes dois Transforms, listados no schema xmldsig;
            XmlDsigEnvelopedSignatureTransform env1 = new XmlDsigEnvelopedSignatureTransform();
            env1.Algorithm = SignedXml.XmlDsigC14NTransformUrl;

            XmlDsigEnvelopedSignatureTransform env2 = new XmlDsigEnvelopedSignatureTransform();
            env2.Algorithm = SignedXml.XmlDsigEnvelopedSignatureTransformUrl;

            reference.AddTransform(env1);
            reference.AddTransform(env2);

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            // Create a new KeyInfo object.
            KeyInfo keyInfo = new KeyInfo();

            // Load the certificate into a KeyInfoX509Data object
            // and add it to the KeyInfo object.
            keyInfo.AddClause(new KeyInfoX509Data(clientCertificate));

            // Add the KeyInfo object to the SignedXml object.
            signedXml.KeyInfo = keyInfo;

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

            if (xmlDoc.FirstChild is XmlDeclaration)
            {
                xmlDoc.RemoveChild(xmlDoc.FirstChild);
            }
        }


        /// <summary>
        /// Assina o documento XML utilizando o certificado informado;
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <param name="referenceURI"></param>
        /// <returns></returns>
        public void SignXml(XmlElement xmlElement, string referenceURI = "")
        {
            if (null == xmlElement)
                throw new ArgumentNullException("Documento XML");

            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(xmlElement);

            // Add the key to the SignedXml document.
            signedXml.SigningKey = clientCertificate.PrivateKey;

            //Método de assinatura;
            signedXml.SignedInfo.SignatureMethod = SignedXml.XmlDsigRSASHA1Url;

            //Método de canonização do XML;
            signedXml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigCanonicalizationUrl;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.DigestMethod = SignedXml.XmlDsigSHA1Url; //Algoritmo descrito no XML;
            reference.Uri = referenceURI;

            //Os Xmls enviados para a SEFAZ requerem estes dois Transforms, listados no schema xmldsig;
            XmlDsigEnvelopedSignatureTransform env1 = new XmlDsigEnvelopedSignatureTransform();
            env1.Algorithm = SignedXml.XmlDsigC14NTransformUrl;

            XmlDsigEnvelopedSignatureTransform env2 = new XmlDsigEnvelopedSignatureTransform();
            env2.Algorithm = SignedXml.XmlDsigEnvelopedSignatureTransformUrl;

            reference.AddTransform(env1);
            reference.AddTransform(env2);

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            // Create a new KeyInfo object.
            KeyInfo keyInfo = new KeyInfo();

            // Load the certificate into a KeyInfoX509Data object
            // and add it to the KeyInfo object.
            keyInfo.AddClause(new KeyInfoX509Data(clientCertificate));

            // Add the KeyInfo object to the SignedXml object.
            signedXml.KeyInfo = keyInfo;

            // Compute the signature.
            signedXml.ComputeSignature();

            if(!signedXml.CheckSignature(clientCertificate, false))
            {
                throw new CryptographicException("A assinatura do documento é inválida");
            }

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            xmlElement.AppendChild(xmlDigitalSignature);
        }


        /// <summary>
        /// Checa a assinatura do arquivo XML:
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public bool VerifyXmlSign(XmlDocument xmlDoc)
        {
            // Check arguments.
            if (xmlDoc == null)
                throw new ArgumentException("Documento XML");

            // Create a new SignedXml object and pass it
            // the XML document class.
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Find the "Signature" node and create a new
            // XmlNodeList object.
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Signature");

            // Throw an exception if no signature was found.
            if (nodeList.Count <= 0)
            {
                throw new CryptographicException("Este documento não possui nenhuma assinatura.");
            }

            // This example only supports one signature for
            // the entire XML document.  Throw an exception
            // if more than one signature was found.
            if (nodeList.Count >= 2)
            {
                throw new CryptographicException("Mais de uma assinatura em um mesmo documento.");
            }

            // Load the first <signature> node.
            signedXml.LoadXml((XmlElement)nodeList[0]);

            // Check the signature and return the result.
            return signedXml.CheckSignature(clientCertificate.PrivateKey);
        }
    }
}
