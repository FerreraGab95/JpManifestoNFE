namespace SefazSchemasClasses
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]

    public enum TipoDoc
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]

    public enum TipoDocDest
    {

        /// <remarks/>
        CNPJDest,

        /// <remarks/>
        CPFDest,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]

    public enum TipoRefDoc
    {

        /// <remarks/>
        refCTe,

        /// <remarks/>
        refECF,

        /// <remarks/>
        refNF,

        /// <remarks/>
        refNFP,

        /// <remarks/>
        refNFe,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]

    public enum TipoQtTributo
    {

        /// <remarks/>
        pCOFINS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]

    public enum TipoTransporte
    {

        /// <remarks/>
        balsa,

        /// <remarks/>
        reboque,

        /// <remarks/>
        vagao,

        /// <remarks/>
        veicTransp,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]

    public enum TipoDocEstrangeiro
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        idEstrangeiro,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]

    public enum TipoQtTributoUn
    {

        /// <remarks/>
        pIPI,

        /// <remarks/>
        qUnid,

        /// <remarks/>
        vBC,

        /// <remarks/>
        vUnid,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]

    public enum ChoiceType_nfe_v4_00_7
    {

        /// <remarks/>
        pPIS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "detEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class detEvento_e210240_v1_00
    {

        private detEventoDescEvento descEventoField;
        private string xJustField;
        private detEventoVersao versaoField;
        public detEventoDescEvento descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }

        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public detEventoVersao versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "detEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class detEvento_e210220_v1_00
    {

        private detEventoDescEvento descEventoField;
        private string xJustField;
        private detEventoVersao versaoField;
        public detEventoDescEvento descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }

        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public detEventoVersao versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "detEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class detEvento_e210210_v1_00
    {

        private detEventoDescEvento descEventoField;
        private detEventoVersao versaoField;
        public detEventoDescEvento descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public detEventoVersao versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "detEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class detEvento_e210200_v1_00
    {

        private detEventoDescEvento descEventoField;
        private detEventoVersao versaoField;
        public detEventoDescEvento descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public detEventoVersao versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum detEventoDescEvento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Operacao nao Realizada")]
        OperacaonaoRealizada,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Desconhecimento da Operacao")]
        DesconhecimentodaOperacao,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ciencia da Operacao")]
        CienciadaOperacao,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Confirmacao da Operacao")]
        ConfirmacaodaOperacao,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum detEventoVersao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class distDFeInt
    {

        private TAmb tpAmbField;
        private TCodUfIBGE cUFAutorField;
        private bool cUFAutorFieldSpecified;
        private string itemField;
        private TipoDoc itemElementNameField;
        private object item1Field;
        private TVerDistDFe versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public TCodUfIBGE cUFAutor
        {
            get
            {
                return this.cUFAutorField;
            }
            set
            {
                this.cUFAutorField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cUFAutorSpecified
        {
            get
            {
                return this.cUFAutorFieldSpecified;
            }
            set
            {
                this.cUFAutorFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("consChNFe", typeof(distDFeIntConsChNFe))]
        [System.Xml.Serialization.XmlElementAttribute("consNSU", typeof(distDFeIntConsNSU))]
        [System.Xml.Serialization.XmlElementAttribute("distNSU", typeof(distDFeIntDistNSU))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerDistDFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class distDFeIntConsChNFe
    {

        private string chNFeField;
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class distDFeIntConsNSU
    {

        private string nSUField;
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string NSU
        {
            get
            {
                return this.nSUField;
            }
            set
            {
                this.nSUField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class distDFeIntDistNSU
    {

        private string ultNSUField;
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string ultNSU
        {
            get
            {
                return this.ultNSUField;
            }
            set
            {
                this.ultNSUField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class KeyInfoType
    {

        private X509DataType x509DataField;
        private string idField;
        public X509DataType X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class ReferenceType
    {

        private TransformType[] transformsField;
        private ReferenceTypeDigestMethod digestMethodField;
        private byte[] digestValueField;
        private string idField;
        private string uRIField;
        private string typeField;
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        public ReferenceTypeDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class ReferenceTypeDigestMethod
    {

        private string algorithmField;
        public ReferenceTypeDigestMethod()
        {
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class resEvento
    {

        private TCOrgaoIBGE cOrgaoField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string chNFeField;
        private string dhEventoField;
        private string tpEventoField;
        private string nSeqEventoField;
        private string xEventoField;
        private string dhRecbtoField;
        private string nProtField;
        private TVerResEvento versaoField;
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public string xEvento
        {
            get
            {
                return this.xEventoField;
            }
            set
            {
                this.xEventoField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerResEvento versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class resNFe
    {

        private string chNFeField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string xNomeField;
        private string ieField;
        private string dhEmiField;
        private resNFeTpNF tpNFField;
        private string vNFField;
        private byte[] digValField;
        private string dhRecbtoField;
        private string nProtField;
        private resNFeCSitNFe cSitNFeField;
        private TVerResNFe versaoField;
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        public string dhEmi
        {
            get
            {
                return this.dhEmiField;
            }
            set
            {
                this.dhEmiField = value;
            }
        }

        public resNFeTpNF tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        public string vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        public resNFeCSitNFe cSitNFe
        {
            get
            {
                return this.cSitNFeField;
            }
            set
            {
                this.cSitNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerResNFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum resNFeCSitNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum resNFeTpNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class retDistDFeInt
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private string dhRespField;
        private string ultNSUField;
        private string maxNSUField;
        private retDistDFeIntLoteDistDFeInt loteDistDFeIntField;
        private TVerDistDFe versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public string dhResp
        {
            get
            {
                return this.dhRespField;
            }
            set
            {
                this.dhRespField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string ultNSU
        {
            get
            {
                return this.ultNSUField;
            }
            set
            {
                this.ultNSUField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string maxNSU
        {
            get
            {
                return this.maxNSUField;
            }
            set
            {
                this.maxNSUField = value;
            }
        }

        public retDistDFeIntLoteDistDFeInt loteDistDFeInt
        {
            get
            {
                return this.loteDistDFeIntField;
            }
            set
            {
                this.loteDistDFeIntField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerDistDFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class retDistDFeIntLoteDistDFeInt
    {

        private retDistDFeIntLoteDistDFeIntDocZip[] docZipField;
        [System.Xml.Serialization.XmlElementAttribute("docZip")]
        public retDistDFeIntLoteDistDFeIntDocZip[] docZip
        {
            get
            {
                return this.docZipField;
            }
            set
            {
                this.docZipField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class retDistDFeIntLoteDistDFeIntDocZip
    {

        private string nSUField;
        private string schemaField;
        private byte[] valueField;
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string NSU
        {
            get
            {
                return this.nSUField;
            }
            set
            {
                this.nSUField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]

    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;
        private SignatureValueType signatureValueField;
        private KeyInfoType keyInfoField;
        private string idField;
        public SignedInfoType SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        public SignatureValueType SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class SignatureValueType
    {

        private string idField;
        private byte[] valueField;
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class SignedInfoType
    {

        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;
        private SignedInfoTypeSignatureMethod signatureMethodField;
        private ReferenceType referenceField;
        private string idField;
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        public SignedInfoTypeSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        public ReferenceType Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class SignedInfoTypeCanonicalizationMethod
    {

        private string algorithmField;
        public SignedInfoTypeCanonicalizationMethod()
        {
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class SignedInfoTypeSignatureMethod
    {

        private string algorithmField;
        public SignedInfoTypeSignatureMethod()
        {
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TAmb
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TCListServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.01")]
        Item0101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.02")]
        Item0102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.03")]
        Item0103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.04")]
        Item0104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.05")]
        Item0105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.06")]
        Item0106,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.07")]
        Item0107,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.08")]
        Item0108,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.09")]
        Item0109,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02.01")]
        Item0201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03.02")]
        Item0302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03.03")]
        Item0303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03.04")]
        Item0304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03.05")]
        Item0305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.01")]
        Item0401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.02")]
        Item0402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.03")]
        Item0403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.04")]
        Item0404,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.05")]
        Item0405,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.06")]
        Item0406,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.07")]
        Item0407,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.08")]
        Item0408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.09")]
        Item0409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.10")]
        Item0410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.11")]
        Item0411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.12")]
        Item0412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.13")]
        Item0413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.14")]
        Item0414,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.15")]
        Item0415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.16")]
        Item0416,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.17")]
        Item0417,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.18")]
        Item0418,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.19")]
        Item0419,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.20")]
        Item0420,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.21")]
        Item0421,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.22")]
        Item0422,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.23")]
        Item0423,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.01")]
        Item0501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.02")]
        Item0502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.03")]
        Item0503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.04")]
        Item0504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.05")]
        Item0505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.06")]
        Item0506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.07")]
        Item0507,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.08")]
        Item0508,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.09")]
        Item0509,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.01")]
        Item0601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.02")]
        Item0602,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.03")]
        Item0603,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.04")]
        Item0604,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.05")]
        Item0605,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.06")]
        Item0606,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.01")]
        Item0701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.02")]
        Item0702,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.03")]
        Item0703,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.04")]
        Item0704,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.05")]
        Item0705,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.06")]
        Item0706,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.07")]
        Item0707,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.08")]
        Item0708,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.09")]
        Item0709,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.10")]
        Item0710,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.11")]
        Item0711,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.12")]
        Item0712,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.13")]
        Item0713,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.16")]
        Item0716,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.17")]
        Item0717,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.18")]
        Item0718,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.19")]
        Item0719,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.20")]
        Item0720,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.21")]
        Item0721,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.22")]
        Item0722,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08.01")]
        Item0801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08.02")]
        Item0802,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09.01")]
        Item0901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09.02")]
        Item0902,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09.03")]
        Item0903,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.01")]
        Item1001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.02")]
        Item1002,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.03")]
        Item1003,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.04")]
        Item1004,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.05")]
        Item1005,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.06")]
        Item1006,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.07")]
        Item1007,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.08")]
        Item1008,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.09")]
        Item1009,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.10")]
        Item1010,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11.01")]
        Item1101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11.02")]
        Item1102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11.03")]
        Item1103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11.04")]
        Item1104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.01")]
        Item1201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.02")]
        Item1202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.03")]
        Item1203,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.04")]
        Item1204,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.05")]
        Item1205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.06")]
        Item1206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.07")]
        Item1207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.08")]
        Item1208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.09")]
        Item1209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.10")]
        Item1210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.11")]
        Item1211,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.12")]
        Item1212,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.13")]
        Item1213,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.14")]
        Item1214,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.15")]
        Item1215,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.16")]
        Item1216,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.17")]
        Item1217,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13.02")]
        Item1302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13.03")]
        Item1303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13.04")]
        Item1304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13.05")]
        Item1305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.01")]
        Item1401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.02")]
        Item1402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.03")]
        Item1403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.04")]
        Item1404,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.05")]
        Item1405,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.06")]
        Item1406,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.07")]
        Item1407,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.08")]
        Item1408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.09")]
        Item1409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.10")]
        Item1410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.11")]
        Item1411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.12")]
        Item1412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.13")]
        Item1413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.14")]
        Item1414,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.01")]
        Item1501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.02")]
        Item1502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.03")]
        Item1503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.04")]
        Item1504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.05")]
        Item1505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.06")]
        Item1506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.07")]
        Item1507,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.08")]
        Item1508,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.09")]
        Item1509,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.10")]
        Item1510,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.11")]
        Item1511,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.12")]
        Item1512,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.13")]
        Item1513,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.14")]
        Item1514,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.15")]
        Item1515,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.16")]
        Item1516,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.17")]
        Item1517,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.18")]
        Item1518,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16.01")]
        Item1601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16.02")]
        Item1602,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.01")]
        Item1701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.02")]
        Item1702,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.03")]
        Item1703,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.04")]
        Item1704,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.05")]
        Item1705,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.06")]
        Item1706,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.08")]
        Item1708,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.09")]
        Item1709,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.10")]
        Item1710,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.11")]
        Item1711,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.12")]
        Item1712,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.13")]
        Item1713,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.14")]
        Item1714,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.15")]
        Item1715,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.16")]
        Item1716,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.17")]
        Item1717,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.18")]
        Item1718,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.19")]
        Item1719,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.20")]
        Item1720,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.21")]
        Item1721,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.22")]
        Item1722,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.23")]
        Item1723,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.24")]
        Item1724,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.25")]
        Item1725,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18.01")]
        Item1801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19.01")]
        Item1901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20.01")]
        Item2001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20.02")]
        Item2002,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20.03")]
        Item2003,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21.01")]
        Item2101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22.01")]
        Item2201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23.01")]
        Item2301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24.01")]
        Item2401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.01")]
        Item2501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.02")]
        Item2502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.03")]
        Item2503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.04")]
        Item2504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.05")]
        Item2505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26.01")]
        Item2601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27.01")]
        Item2701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28.01")]
        Item2801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29.01")]
        Item2901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30.01")]
        Item3001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31.01")]
        Item3101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32.01")]
        Item3201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33.01")]
        Item3301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34.01")]
        Item3401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35.01")]
        Item3501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36.01")]
        Item3601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37.01")]
        Item3701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38.01")]
        Item3801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39.01")]
        Item3901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40.01")]
        Item4001,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TCodUfIBGE
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consNFeDest", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TConsNFeDest
    {

        private TAmb tpAmbField;
        private TConsNFeDestXServ xServField;
        private string cNPJField;
        private TConsNFeDestIndNFe indNFeField;
        private TConsNFeDestIndEmi indEmiField;
        private string ultNSUField;
        private TVeConsNFeDest versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public TConsNFeDestXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public TConsNFeDestIndNFe indNFe
        {
            get
            {
                return this.indNFeField;
            }
            set
            {
                this.indNFeField = value;
            }
        }

        public TConsNFeDestIndEmi indEmi
        {
            get
            {
                return this.indEmiField;
            }
            set
            {
                this.indEmiField = value;
            }
        }

        public string ultNSU
        {
            get
            {
                return this.ultNSUField;
            }
            set
            {
                this.ultNSUField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVeConsNFeDest versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TConsNFeDestIndEmi
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TConsNFeDestIndNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TConsNFeDestXServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CONSULTAR NFE DEST")]
        CONSULTARNFEDEST,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TConsReciNFe
    {

        private TAmb tpAmbField;
        private string nRecField;
        private string versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string nRec
        {
            get
            {
                return this.nRecField;
            }
            set
            {
                this.nRecField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TConsSitNFe
    {

        private TAmb tpAmbField;
        private TConsSitNFeXServ xServField;
        private string chNFeField;
        private TVerConsSitNFe versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public TConsSitNFeXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerConsSitNFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TConsSitNFeXServ
    {

        /// <remarks/>
        CONSULTAR,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TConsStatServ
    {

        private TAmb tpAmbField;
        private TCodUfIBGE cUFField;
        private TConsStatServXServ xServField;
        private string versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public TConsStatServXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TConsStatServXServ
    {

        /// <remarks/>
        STATUS,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TCOrgaoIBGE
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("91")]
        Item91,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("92")]
        Item92,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("downloadNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TDownloadNFe
    {

        private TAmb tpAmbField;
        private TDownloadNFeXServ xServField;
        private string cNPJField;
        private string[] chNFeField;
        private TVerDownloadNFe versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public TDownloadNFeXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("chNFe")]
        public string[] chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerDownloadNFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TDownloadNFeXServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("DOWNLOAD NFE")]
        DOWNLOADNFE,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TEndereco
    {

        private string xLgrField;
        private string nroField;
        private string xCplField;
        private string xBairroField;
        private string cMunField;
        private string xMunField;
        private TUf ufField;
        private string cEPField;
        private string cPaisField;
        private string xPaisField;
        private string foneField;
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        public string cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        public string xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
            }
        }

        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TEnderEmi
    {

        private string xLgrField;
        private string nroField;
        private string xCplField;
        private string xBairroField;
        private string cMunField;
        private string xMunField;
        private TUfEmi ufField;
        private string cEPField;
        private TEnderEmiCPais cPaisField;
        private bool cPaisFieldSpecified;
        private TEnderEmiXPais xPaisField;
        private bool xPaisFieldSpecified;
        private string foneField;
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        public TUfEmi UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        public TEnderEmiCPais cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cPaisSpecified
        {
            get
            {
                return this.cPaisFieldSpecified;
            }
            set
            {
                this.cPaisFieldSpecified = value;
            }
        }

        public TEnderEmiXPais xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xPaisSpecified
        {
            get
            {
                return this.xPaisFieldSpecified;
            }
            set
            {
                this.xPaisFieldSpecified = value;
            }
        }

        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TEnderEmiCPais
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1058")]
        Item1058,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TEnderEmiXPais
    {

        /// <remarks/>
        Brasil,

        /// <remarks/>
        BRASIL,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("envEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TEnvEvento_confRecebto_v1_00
    {

        private string idLoteField;
        private TEvento_confRecebto_v1_00[] eventoField;
        private string versaoField;
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("evento")]
        public TEvento_confRecebto_v1_00[] evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("envEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TEnvEvento_retEnvEvento_v1_00
    {

        private string idLoteField;
        private TEvento_retEnvEvento_v1_00[] eventoField;
        private string versaoField;
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("evento")]
        public TEvento_retEnvEvento_v1_00[] evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("enviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TEnviNFe
    {

        private string idLoteField;
        private TEnviNFeIndSinc indSincField;
        private TNFe[] nFeField;
        private string versaoField;
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        public TEnviNFeIndSinc indSinc
        {
            get
            {
                return this.indSincField;
            }
            set
            {
                this.indSincField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("NFe")]
        public TNFe[] NFe
        {
            get
            {
                return this.nFeField;
            }
            set
            {
                this.nFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TEnviNFeIndSinc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEvento_consSitNFe_v4_00
    {

        private TEventoInfEvento_consSitNFe_v4_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TEventoInfEvento_consSitNFe_v4_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("evento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TEvento_confRecebto_v1_00
    {

        private TEventoInfEvento_confRecebto_v1_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TEventoInfEvento_confRecebto_v1_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEvento_retEnvEvento_v1_00
    {

        private TEventoInfEvento_retEnvEvento_v1_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TEventoInfEvento_retEnvEvento_v1_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEvento_procEventoNFe_v1_00
    {

        private TEventoInfEvento_procEventoNFe_v1_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TEventoInfEvento_procEventoNFe_v1_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEvento_procConfRecebtoNFe_v1_00
    {

        private TEventoInfEvento_procConfRecebtoNFe_v1_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TEventoInfEvento_procConfRecebtoNFe_v1_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEvento_consSitNFe_v4_00
    {

        private TCOrgaoIBGE cOrgaoField;
        private TAmb tpAmbField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string chNFeField;
        private string dhEventoField;
        private string tpEventoField;
        private string nSeqEventoField;
        private string verEventoField;
        private TEventoInfEventoDetEvento_consSitNFe_v4_00 detEventoField;
        private string idField;
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public string verEvento
        {
            get
            {
                return this.verEventoField;
            }
            set
            {
                this.verEventoField = value;
            }
        }

        public TEventoInfEventoDetEvento_consSitNFe_v4_00 detEvento
        {
            get
            {
                return this.detEventoField;
            }
            set
            {
                this.detEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEvento_confRecebto_v1_00
    {

        private TCOrgaoIBGE cOrgaoField;
        private TAmb tpAmbField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string chNFeField;
        private string dhEventoField;
        private TEventoInfEventoTpEvento tpEventoField;
        private string nSeqEventoField;
        private string verEventoField;
        private TEventoInfEventoDetEvento_confRecebto_v1_00 detEventoField;
        private string idField;
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        public TEventoInfEventoTpEvento tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public string verEvento
        {
            get
            {
                return this.verEventoField;
            }
            set
            {
                this.verEventoField = value;
            }
        }

        public TEventoInfEventoDetEvento_confRecebto_v1_00 detEvento
        {
            get
            {
                return this.detEventoField;
            }
            set
            {
                this.detEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEvento_retEnvEvento_v1_00
    {

        private TCOrgaoIBGE cOrgaoField;
        private TAmb tpAmbField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string chNFeField;
        private string dhEventoField;
        private string tpEventoField;
        private string nSeqEventoField;
        private string verEventoField;
        private TEventoInfEventoDetEvento_retEnvEvento_v1_00 detEventoField;
        private string idField;
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public string verEvento
        {
            get
            {
                return this.verEventoField;
            }
            set
            {
                this.verEventoField = value;
            }
        }

        public TEventoInfEventoDetEvento_retEnvEvento_v1_00 detEvento
        {
            get
            {
                return this.detEventoField;
            }
            set
            {
                this.detEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEvento_procEventoNFe_v1_00
    {

        private TCOrgaoIBGE cOrgaoField;
        private TAmb tpAmbField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string chNFeField;
        private string dhEventoField;
        private string tpEventoField;
        private string nSeqEventoField;
        private string verEventoField;
        private TEventoInfEventoDetEvento_procEventoNFe_v1_00 detEventoField;
        private string idField;
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public string verEvento
        {
            get
            {
                return this.verEventoField;
            }
            set
            {
                this.verEventoField = value;
            }
        }

        public TEventoInfEventoDetEvento_procEventoNFe_v1_00 detEvento
        {
            get
            {
                return this.detEventoField;
            }
            set
            {
                this.detEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEvento_procConfRecebtoNFe_v1_00
    {

        private TCOrgaoIBGE cOrgaoField;
        private TAmb tpAmbField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string chNFeField;
        private string dhEventoField;
        private TEventoInfEventoTpEvento tpEventoField;
        private string nSeqEventoField;
        private string verEventoField;
        private TEventoInfEventoDetEvento_procConfRecebtoNFe_v1_00 detEventoField;
        private string idField;
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        public TEventoInfEventoTpEvento tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public string verEvento
        {
            get
            {
                return this.verEventoField;
            }
            set
            {
                this.verEventoField = value;
            }
        }

        public TEventoInfEventoDetEvento_procConfRecebtoNFe_v1_00 detEvento
        {
            get
            {
                return this.detEventoField;
            }
            set
            {
                this.detEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEventoDetEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEventoDetEvento_consSitNFe_v4_00
    {

        private System.Xml.XmlElement[] anyField;
        private System.Xml.XmlAttribute[] anyAttrField;
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEventoDetEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEventoDetEvento_confRecebto_v1_00
    {

        private TEventoInfEventoDetEventoDescEvento descEventoField;
        private string xJustField;
        private TEventoInfEventoDetEventoVersao versaoField;
        public TEventoInfEventoDetEventoDescEvento descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }

        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TEventoInfEventoDetEventoVersao versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEventoDetEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEventoDetEvento_retEnvEvento_v1_00
    {

        private System.Xml.XmlElement[] anyField;
        private System.Xml.XmlAttribute[] anyAttrField;
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEventoDetEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEventoDetEvento_procEventoNFe_v1_00
    {

        private System.Xml.XmlElement[] anyField;
        private System.Xml.XmlAttribute[] anyAttrField;
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TEventoInfEventoDetEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEventoDetEvento_procConfRecebtoNFe_v1_00
    {

        private TEventoInfEventoDetEventoDescEvento descEventoField;
        private string xJustField;
        private TEventoInfEventoDetEventoVersao versaoField;
        public TEventoInfEventoDetEventoDescEvento descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }

        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TEventoInfEventoDetEventoVersao versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TEventoInfEventoDetEventoDescEvento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Confirmacao da Operacao")]
        ConfirmacaodaOperacao,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ciencia da Operacao")]
        CienciadaOperacao,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Desconhecimento da Operacao")]
        DesconhecimentodaOperacao,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Operacao nao Realizada")]
        OperacaonaoRealizada,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TEventoInfEventoDetEventoVersao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TEventoInfEventoTpEvento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("210200")]
        Item210200,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("210210")]
        Item210210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("210220")]
        Item210220,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("210240")]
        Item210240,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TFinNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TInfRespTec
    {

        private string cNPJField;
        private string xContatoField;
        private string emailField;
        private string foneField;
        private string idCSRTField;
        private byte[] hashCSRTField;
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public string xContato
        {
            get
            {
                return this.xContatoField;
            }
            set
            {
                this.xContatoField = value;
            }
        }

        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

        public string idCSRT
        {
            get
            {
                return this.idCSRTField;
            }
            set
            {
                this.idCSRTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] hashCSRT
        {
            get
            {
                return this.hashCSRTField;
            }
            set
            {
                this.hashCSRTField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("inutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TInutNFe
    {

        private TInutNFeInfInut infInutField;
        private SignatureType signatureField;
        private string versaoField;
        public TInutNFeInfInut infInut
        {
            get
            {
                return this.infInutField;
            }
            set
            {
                this.infInutField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TInutNFeInfInut
    {

        private TAmb tpAmbField;
        private TInutNFeInfInutXServ xServField;
        private TCodUfIBGE cUFField;
        private string anoField;
        private string cNPJField;
        private TMod modField;
        private string serieField;
        private string nNFIniField;
        private string nNFFinField;
        private string xJustField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public TInutNFeInfInutXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string ano
        {
            get
            {
                return this.anoField;
            }
            set
            {
                this.anoField = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public TMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        public string nNFIni
        {
            get
            {
                return this.nNFIniField;
            }
            set
            {
                this.nNFIniField = value;
            }
        }

        public string nNFFin
        {
            get
            {
                return this.nNFFinField;
            }
            set
            {
                this.nNFFinField = value;
            }
        }

        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TInutNFeInfInutXServ
    {

        /// <remarks/>
        INUTILIZAR,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TIpi
    {

        private string cNPJProdField;
        private string cSeloField;
        private string qSeloField;
        private string cEnqField;
        private object itemField;
        public string CNPJProd
        {
            get
            {
                return this.cNPJProdField;
            }
            set
            {
                this.cNPJProdField = value;
            }
        }

        public string cSelo
        {
            get
            {
                return this.cSeloField;
            }
            set
            {
                this.cSeloField = value;
            }
        }

        public string qSelo
        {
            get
            {
                return this.qSeloField;
            }
            set
            {
                this.qSeloField = value;
            }
        }

        public string cEnq
        {
            get
            {
                return this.cEnqField;
            }
            set
            {
                this.cEnqField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("IPINT", typeof(TIpiIPINT))]
        [System.Xml.Serialization.XmlElementAttribute("IPITrib", typeof(TIpiIPITrib))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TIpiIPINT
    {

        private TIpiIPINTCST cSTField;
        public TIpiIPINTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TIpiIPINTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TIpiIPITrib
    {

        private TIpiIPITribCST cSTField;
        private string[] itemsField;
        private TipoQtTributoUn[] itemsElementNameField;
        private string vIPIField;
        public TIpiIPITribCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pIPI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qUnid", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vUnid", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoQtTributoUn[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        public string vIPI
        {
            get
            {
                return this.vIPIField;
            }
            set
            {
                this.vIPIField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TIpiIPITribCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TLocal
    {

        private string itemField;
        private TipoDoc itemElementNameField;
        private string xNomeField;
        private string xLgrField;
        private string nroField;
        private string xCplField;
        private string xBairroField;
        private string cMunField;
        private string xMunField;
        private TUf ufField;
        private string cEPField;
        private string cPaisField;
        private string xPaisField;
        private string foneField;
        private string emailField;
        private string ieField;
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        public string cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        public string xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
            }
        }

        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TNFe
    {

        private TNFeInfNFe infNFeField;
        private TNFeInfNFeSupl infNFeSuplField;
        private SignatureType signatureField;
        public TNFeInfNFe infNFe
        {
            get
            {
                return this.infNFeField;
            }
            set
            {
                this.infNFeField = value;
            }
        }

        public TNFeInfNFeSupl infNFeSupl
        {
            get
            {
                return this.infNFeSuplField;
            }
            set
            {
                this.infNFeSuplField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFe
    {

        private TNFeInfNFeIde ideField;
        private TNFeInfNFeEmit emitField;
        private TNFeInfNFeAvulsa avulsaField;
        private TNFeInfNFeDest destField;
        private TLocal retiradaField;
        private TLocal entregaField;
        private TNFeInfNFeAutXML[] autXMLField;
        private TNFeInfNFeDet[] detField;
        private TNFeInfNFeTotal totalField;
        private TNFeInfNFeTransp transpField;
        private TNFeInfNFeCobr cobrField;
        private TNFeInfNFePag pagField;
        private TNFeInfNFeInfIntermed infIntermedField;
        private TNFeInfNFeInfAdic infAdicField;
        private TNFeInfNFeExporta exportaField;
        private TNFeInfNFeCompra compraField;
        private TNFeInfNFeCana canaField;
        private TInfRespTec infRespTecField;
        private string versaoField;
        private string idField;
        public TNFeInfNFeIde ide
        {
            get
            {
                return this.ideField;
            }
            set
            {
                this.ideField = value;
            }
        }

        public TNFeInfNFeEmit emit
        {
            get
            {
                return this.emitField;
            }
            set
            {
                this.emitField = value;
            }
        }

        public TNFeInfNFeAvulsa avulsa
        {
            get
            {
                return this.avulsaField;
            }
            set
            {
                this.avulsaField = value;
            }
        }

        public TNFeInfNFeDest dest
        {
            get
            {
                return this.destField;
            }
            set
            {
                this.destField = value;
            }
        }

        public TLocal retirada
        {
            get
            {
                return this.retiradaField;
            }
            set
            {
                this.retiradaField = value;
            }
        }

        public TLocal entrega
        {
            get
            {
                return this.entregaField;
            }
            set
            {
                this.entregaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("autXML")]
        public TNFeInfNFeAutXML[] autXML
        {
            get
            {
                return this.autXMLField;
            }
            set
            {
                this.autXMLField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("det")]
        public TNFeInfNFeDet[] det
        {
            get
            {
                return this.detField;
            }
            set
            {
                this.detField = value;
            }
        }

        public TNFeInfNFeTotal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        public TNFeInfNFeTransp transp
        {
            get
            {
                return this.transpField;
            }
            set
            {
                this.transpField = value;
            }
        }

        public TNFeInfNFeCobr cobr
        {
            get
            {
                return this.cobrField;
            }
            set
            {
                this.cobrField = value;
            }
        }

        public TNFeInfNFePag pag
        {
            get
            {
                return this.pagField;
            }
            set
            {
                this.pagField = value;
            }
        }

        public TNFeInfNFeInfIntermed infIntermed
        {
            get
            {
                return this.infIntermedField;
            }
            set
            {
                this.infIntermedField = value;
            }
        }

        public TNFeInfNFeInfAdic infAdic
        {
            get
            {
                return this.infAdicField;
            }
            set
            {
                this.infAdicField = value;
            }
        }

        public TNFeInfNFeExporta exporta
        {
            get
            {
                return this.exportaField;
            }
            set
            {
                this.exportaField = value;
            }
        }

        public TNFeInfNFeCompra compra
        {
            get
            {
                return this.compraField;
            }
            set
            {
                this.compraField = value;
            }
        }

        public TNFeInfNFeCana cana
        {
            get
            {
                return this.canaField;
            }
            set
            {
                this.canaField = value;
            }
        }

        public TInfRespTec infRespTec
        {
            get
            {
                return this.infRespTecField;
            }
            set
            {
                this.infRespTecField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeAutXML
    {

        private string itemField;
        private TipoDoc itemElementNameField;
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeAvulsa
    {

        private string cNPJField;
        private string xOrgaoField;
        private string matrField;
        private string xAgenteField;
        private string foneField;
        private TUfEmi ufField;
        private string nDARField;
        private string dEmiField;
        private string vDARField;
        private string repEmiField;
        private string dPagField;
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public string xOrgao
        {
            get
            {
                return this.xOrgaoField;
            }
            set
            {
                this.xOrgaoField = value;
            }
        }

        public string matr
        {
            get
            {
                return this.matrField;
            }
            set
            {
                this.matrField = value;
            }
        }

        public string xAgente
        {
            get
            {
                return this.xAgenteField;
            }
            set
            {
                this.xAgenteField = value;
            }
        }

        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

        public TUfEmi UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        public string nDAR
        {
            get
            {
                return this.nDARField;
            }
            set
            {
                this.nDARField = value;
            }
        }

        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }

        public string vDAR
        {
            get
            {
                return this.vDARField;
            }
            set
            {
                this.vDARField = value;
            }
        }

        public string repEmi
        {
            get
            {
                return this.repEmiField;
            }
            set
            {
                this.repEmiField = value;
            }
        }

        public string dPag
        {
            get
            {
                return this.dPagField;
            }
            set
            {
                this.dPagField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeCana
    {

        private string safraField;
        private string refField;
        private TNFeInfNFeCanaForDia[] forDiaField;
        private string qTotMesField;
        private string qTotAntField;
        private string qTotGerField;
        private TNFeInfNFeCanaDeduc[] deducField;
        private string vForField;
        private string vTotDedField;
        private string vLiqForField;
        public string safra
        {
            get
            {
                return this.safraField;
            }
            set
            {
                this.safraField = value;
            }
        }

        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("forDia")]
        public TNFeInfNFeCanaForDia[] forDia
        {
            get
            {
                return this.forDiaField;
            }
            set
            {
                this.forDiaField = value;
            }
        }

        public string qTotMes
        {
            get
            {
                return this.qTotMesField;
            }
            set
            {
                this.qTotMesField = value;
            }
        }

        public string qTotAnt
        {
            get
            {
                return this.qTotAntField;
            }
            set
            {
                this.qTotAntField = value;
            }
        }

        public string qTotGer
        {
            get
            {
                return this.qTotGerField;
            }
            set
            {
                this.qTotGerField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("deduc")]
        public TNFeInfNFeCanaDeduc[] deduc
        {
            get
            {
                return this.deducField;
            }
            set
            {
                this.deducField = value;
            }
        }

        public string vFor
        {
            get
            {
                return this.vForField;
            }
            set
            {
                this.vForField = value;
            }
        }

        public string vTotDed
        {
            get
            {
                return this.vTotDedField;
            }
            set
            {
                this.vTotDedField = value;
            }
        }

        public string vLiqFor
        {
            get
            {
                return this.vLiqForField;
            }
            set
            {
                this.vLiqForField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeCanaDeduc
    {

        private string xDedField;
        private string vDedField;
        public string xDed
        {
            get
            {
                return this.xDedField;
            }
            set
            {
                this.xDedField = value;
            }
        }

        public string vDed
        {
            get
            {
                return this.vDedField;
            }
            set
            {
                this.vDedField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeCanaForDia
    {

        private string qtdeField;
        private string diaField;
        public string qtde
        {
            get
            {
                return this.qtdeField;
            }
            set
            {
                this.qtdeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dia
        {
            get
            {
                return this.diaField;
            }
            set
            {
                this.diaField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeCobr
    {

        private TNFeInfNFeCobrFat fatField;
        private TNFeInfNFeCobrDup[] dupField;
        public TNFeInfNFeCobrFat fat
        {
            get
            {
                return this.fatField;
            }
            set
            {
                this.fatField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("dup")]
        public TNFeInfNFeCobrDup[] dup
        {
            get
            {
                return this.dupField;
            }
            set
            {
                this.dupField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeCobrDup
    {

        private string nDupField;
        private string dVencField;
        private string vDupField;
        public string nDup
        {
            get
            {
                return this.nDupField;
            }
            set
            {
                this.nDupField = value;
            }
        }

        public string dVenc
        {
            get
            {
                return this.dVencField;
            }
            set
            {
                this.dVencField = value;
            }
        }

        public string vDup
        {
            get
            {
                return this.vDupField;
            }
            set
            {
                this.vDupField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeCobrFat
    {

        private string nFatField;
        private string vOrigField;
        private string vDescField;
        private string vLiqField;
        public string nFat
        {
            get
            {
                return this.nFatField;
            }
            set
            {
                this.nFatField = value;
            }
        }

        public string vOrig
        {
            get
            {
                return this.vOrigField;
            }
            set
            {
                this.vOrigField = value;
            }
        }

        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        public string vLiq
        {
            get
            {
                return this.vLiqField;
            }
            set
            {
                this.vLiqField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeCompra
    {

        private string xNEmpField;
        private string xPedField;
        private string xContField;
        public string xNEmp
        {
            get
            {
                return this.xNEmpField;
            }
            set
            {
                this.xNEmpField = value;
            }
        }

        public string xPed
        {
            get
            {
                return this.xPedField;
            }
            set
            {
                this.xPedField = value;
            }
        }

        public string xCont
        {
            get
            {
                return this.xContField;
            }
            set
            {
                this.xContField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDest
    {

        private string itemField;
        private TipoDocEstrangeiro itemElementNameField;
        private string xNomeField;
        private TEndereco enderDestField;
        private TNFeInfNFeDestIndIEDest indIEDestField;
        private string ieField;
        private string iSUFField;
        private string imField;
        private string emailField;
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("idEstrangeiro", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocEstrangeiro ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        public TEndereco enderDest
        {
            get
            {
                return this.enderDestField;
            }
            set
            {
                this.enderDestField = value;
            }
        }

        public TNFeInfNFeDestIndIEDest indIEDest
        {
            get
            {
                return this.indIEDestField;
            }
            set
            {
                this.indIEDestField = value;
            }
        }

        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        public string ISUF
        {
            get
            {
                return this.iSUFField;
            }
            set
            {
                this.iSUFField = value;
            }
        }

        public string IM
        {
            get
            {
                return this.imField;
            }
            set
            {
                this.imField = value;
            }
        }

        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDestIndIEDest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDet
    {

        private TNFeInfNFeDetProd prodField;
        private TNFeInfNFeDetImposto impostoField;
        private TNFeInfNFeDetImpostoDevol impostoDevolField;
        private string infAdProdField;
        private string nItemField;
        public TNFeInfNFeDetProd prod
        {
            get
            {
                return this.prodField;
            }
            set
            {
                this.prodField = value;
            }
        }

        public TNFeInfNFeDetImposto imposto
        {
            get
            {
                return this.impostoField;
            }
            set
            {
                this.impostoField = value;
            }
        }

        public TNFeInfNFeDetImpostoDevol impostoDevol
        {
            get
            {
                return this.impostoDevolField;
            }
            set
            {
                this.impostoDevolField = value;
            }
        }

        public string infAdProd
        {
            get
            {
                return this.infAdProdField;
            }
            set
            {
                this.infAdProdField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nItem
        {
            get
            {
                return this.nItemField;
            }
            set
            {
                this.nItemField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImposto
    {

        private string vTotTribField;
        private object[] itemsField;
        private TNFeInfNFeDetImpostoPIS pISField;
        private TNFeInfNFeDetImpostoPISST pISSTField;
        private TNFeInfNFeDetImpostoCOFINS cOFINSField;
        private TNFeInfNFeDetImpostoCOFINSST cOFINSSTField;
        private TNFeInfNFeDetImpostoICMSUFDest iCMSUFDestField;
        public string vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
        [System.Xml.Serialization.XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII))]
        [System.Xml.Serialization.XmlElementAttribute("IPI", typeof(TIpi))]
        [System.Xml.Serialization.XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        public TNFeInfNFeDetImpostoPIS PIS
        {
            get
            {
                return this.pISField;
            }
            set
            {
                this.pISField = value;
            }
        }

        public TNFeInfNFeDetImpostoPISST PISST
        {
            get
            {
                return this.pISSTField;
            }
            set
            {
                this.pISSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoCOFINS COFINS
        {
            get
            {
                return this.cOFINSField;
            }
            set
            {
                this.cOFINSField = value;
            }
        }

        public TNFeInfNFeDetImpostoCOFINSST COFINSST
        {
            get
            {
                return this.cOFINSSTField;
            }
            set
            {
                this.cOFINSSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSUFDest ICMSUFDest
        {
            get
            {
                return this.iCMSUFDestField;
            }
            set
            {
                this.iCMSUFDestField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoCOFINS
    {

        private object itemField;
        [System.Xml.Serialization.XmlElementAttribute("COFINSAliq", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliq))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSNT", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNT))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSOutr", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutr))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSQtde", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtde))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST cSTField;
        private string vBCField;
        private string pCOFINSField;
        private string vCOFINSField;
        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pCOFINS
        {
            get
            {
                return this.pCOFINSField;
            }
            set
            {
                this.pCOFINSField = value;
            }
        }

        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSNTCST cSTField;
        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST cSTField;
        private string[] itemsField;
        private TipoQtTributo[] itemsElementNameField;
        private string vCOFINSField;
        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoQtTributo[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST cSTField;
        private string qBCProdField;
        private string vAliqProdField;
        private string vCOFINSField;
        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoCOFINSST
    {

        private string[] itemsField;
        private TipoQtTributo[] itemsElementNameField;
        private string vCOFINSField;
        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoQtTributo[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoDevol
    {

        private string pDevolField;
        private TNFeInfNFeDetImpostoDevolIPI iPIField;
        public string pDevol
        {
            get
            {
                return this.pDevolField;
            }
            set
            {
                this.pDevolField = value;
            }
        }

        public TNFeInfNFeDetImpostoDevolIPI IPI
        {
            get
            {
                return this.iPIField;
            }
            set
            {
                this.iPIField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoDevolIPI
    {

        private string vIPIDevolField;
        public string vIPIDevol
        {
            get
            {
                return this.vIPIDevolField;
            }
            set
            {
                this.vIPIDevolField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMS
    {

        private object itemField;
        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS00
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS00CST cSTField;
        private TNFeInfNFeDetImpostoICMSICMS00ModBC modBCField;
        private string vBCField;
        private string pICMSField;
        private string vICMSField;
        private string pFCPField;
        private string vFCPField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS00CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS00CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS00ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS10
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS10CST cSTField;
        private TNFeInfNFeDetImpostoICMSICMS10ModBC modBCField;
        private string vBCField;
        private string pICMSField;
        private string vICMSField;
        private string vBCFCPField;
        private string pFCPField;
        private string vFCPField;
        private TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCSTField;
        private string pMVASTField;
        private string pRedBCSTField;
        private string vBCSTField;
        private string pICMSSTField;
        private string vICMSSTField;
        private string vBCFCPSTField;
        private string pFCPSTField;
        private string vFCPSTField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS10CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public string vBCFCP
        {
            get
            {
                return this.vBCFCPField;
            }
            set
            {
                this.vBCFCPField = value;
            }
        }

        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        public string vBCFCPST
        {
            get
            {
                return this.vBCFCPSTField;
            }
            set
            {
                this.vBCFCPSTField = value;
            }
        }

        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS10CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS10ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS10ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS20
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS20CST cSTField;
        private TNFeInfNFeDetImpostoICMSICMS20ModBC modBCField;
        private string pRedBCField;
        private string vBCField;
        private string pICMSField;
        private string vICMSField;
        private string vBCFCPField;
        private string pFCPField;
        private string vFCPField;
        private string vICMSDesonField;
        private TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMSField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS20CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public string vBCFCP
        {
            get
            {
                return this.vBCFCPField;
            }
            set
            {
                this.vBCFCPField = value;
            }
        }

        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS20CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS20ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS30
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS30CST cSTField;
        private TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCSTField;
        private string pMVASTField;
        private string pRedBCSTField;
        private string vBCSTField;
        private string pICMSSTField;
        private string vICMSSTField;
        private string vBCFCPSTField;
        private string pFCPSTField;
        private string vFCPSTField;
        private string vICMSDesonField;
        private TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMSField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS30CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        public string vBCFCPST
        {
            get
            {
                return this.vBCFCPSTField;
            }
            set
            {
                this.vBCFCPSTField = value;
            }
        }

        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS30CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS40
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS40CST cSTField;
        private string vICMSDesonField;
        private TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMSField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS40CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS40CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS51
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS51CST cSTField;
        private TNFeInfNFeDetImpostoICMSICMS51ModBC modBCField;
        private bool modBCFieldSpecified;
        private string pRedBCField;
        private string vBCField;
        private string pICMSField;
        private string vICMSOpField;
        private string pDifField;
        private string vICMSDifField;
        private string vICMSField;
        private string vBCFCPField;
        private string pFCPField;
        private string vFCPField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS51CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modBCSpecified
        {
            get
            {
                return this.modBCFieldSpecified;
            }
            set
            {
                this.modBCFieldSpecified = value;
            }
        }

        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        public string vICMSOp
        {
            get
            {
                return this.vICMSOpField;
            }
            set
            {
                this.vICMSOpField = value;
            }
        }

        public string pDif
        {
            get
            {
                return this.pDifField;
            }
            set
            {
                this.pDifField = value;
            }
        }

        public string vICMSDif
        {
            get
            {
                return this.vICMSDifField;
            }
            set
            {
                this.vICMSDifField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public string vBCFCP
        {
            get
            {
                return this.vBCFCPField;
            }
            set
            {
                this.vBCFCPField = value;
            }
        }

        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS51CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS60
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS60CST cSTField;
        private string vBCSTRetField;
        private string pSTField;
        private string vICMSSubstitutoField;
        private string vICMSSTRetField;
        private string vBCFCPSTRetField;
        private string pFCPSTRetField;
        private string vFCPSTRetField;
        private string pRedBCEfetField;
        private string vBCEfetField;
        private string pICMSEfetField;
        private string vICMSEfetField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS60CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        public string pST
        {
            get
            {
                return this.pSTField;
            }
            set
            {
                this.pSTField = value;
            }
        }

        public string vICMSSubstituto
        {
            get
            {
                return this.vICMSSubstitutoField;
            }
            set
            {
                this.vICMSSubstitutoField = value;
            }
        }

        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }

        public string vBCFCPSTRet
        {
            get
            {
                return this.vBCFCPSTRetField;
            }
            set
            {
                this.vBCFCPSTRetField = value;
            }
        }

        public string pFCPSTRet
        {
            get
            {
                return this.pFCPSTRetField;
            }
            set
            {
                this.pFCPSTRetField = value;
            }
        }

        public string vFCPSTRet
        {
            get
            {
                return this.vFCPSTRetField;
            }
            set
            {
                this.vFCPSTRetField = value;
            }
        }

        public string pRedBCEfet
        {
            get
            {
                return this.pRedBCEfetField;
            }
            set
            {
                this.pRedBCEfetField = value;
            }
        }

        public string vBCEfet
        {
            get
            {
                return this.vBCEfetField;
            }
            set
            {
                this.vBCEfetField = value;
            }
        }

        public string pICMSEfet
        {
            get
            {
                return this.pICMSEfetField;
            }
            set
            {
                this.pICMSEfetField = value;
            }
        }

        public string vICMSEfet
        {
            get
            {
                return this.vICMSEfetField;
            }
            set
            {
                this.vICMSEfetField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS60CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS70
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS70CST cSTField;
        private TNFeInfNFeDetImpostoICMSICMS70ModBC modBCField;
        private string pRedBCField;
        private string vBCField;
        private string pICMSField;
        private string vICMSField;
        private string vBCFCPField;
        private string pFCPField;
        private string vFCPField;
        private TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCSTField;
        private string pMVASTField;
        private string pRedBCSTField;
        private string vBCSTField;
        private string pICMSSTField;
        private string vICMSSTField;
        private string vBCFCPSTField;
        private string pFCPSTField;
        private string vFCPSTField;
        private string vICMSDesonField;
        private TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMSField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS70CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public string vBCFCP
        {
            get
            {
                return this.vBCFCPField;
            }
            set
            {
                this.vBCFCPField = value;
            }
        }

        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        public string vBCFCPST
        {
            get
            {
                return this.vBCFCPSTField;
            }
            set
            {
                this.vBCFCPSTField = value;
            }
        }

        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS70CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMS90
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMS90CST cSTField;
        private TNFeInfNFeDetImpostoICMSICMS90ModBC modBCField;
        private string vBCField;
        private string pRedBCField;
        private string pICMSField;
        private string vICMSField;
        private string vBCFCPField;
        private string pFCPField;
        private string vFCPField;
        private TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCSTField;
        private string pMVASTField;
        private string pRedBCSTField;
        private string vBCSTField;
        private string pICMSSTField;
        private string vICMSSTField;
        private string vBCFCPSTField;
        private string pFCPSTField;
        private string vFCPSTField;
        private string vICMSDesonField;
        private TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMSField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS90CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public string vBCFCP
        {
            get
            {
                return this.vBCFCPField;
            }
            set
            {
                this.vBCFCPField = value;
            }
        }

        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        public string vBCFCPST
        {
            get
            {
                return this.vBCFCPSTField;
            }
            set
            {
                this.vBCFCPSTField = value;
            }
        }

        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS90CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMSPart
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMSPartCST cSTField;
        private TNFeInfNFeDetImpostoICMSICMSPartModBC modBCField;
        private string vBCField;
        private string pRedBCField;
        private string pICMSField;
        private string vICMSField;
        private TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCSTField;
        private string pMVASTField;
        private string pRedBCSTField;
        private string vBCSTField;
        private string pICMSSTField;
        private string vICMSSTField;
        private string pBCOpField;
        private TUf uFSTField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSPartCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        public string pBCOp
        {
            get
            {
                return this.pBCOpField;
            }
            set
            {
                this.pBCOpField = value;
            }
        }

        public TUf UFST
        {
            get
            {
                return this.uFSTField;
            }
            set
            {
                this.uFSTField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMSSN101
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMSSN101CSOSN cSOSNField;
        private string pCredSNField;
        private string vCredICMSSNField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("101")]
        Item101,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMSSN102
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMSSN102CSOSN cSOSNField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("102")]
        Item102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("103")]
        Item103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMSSN201
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMSSN201CSOSN cSOSNField;
        private TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCSTField;
        private string pMVASTField;
        private string pRedBCSTField;
        private string vBCSTField;
        private string pICMSSTField;
        private string vICMSSTField;
        private string vBCFCPSTField;
        private string pFCPSTField;
        private string vFCPSTField;
        private string pCredSNField;
        private string vCredICMSSNField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        public string vBCFCPST
        {
            get
            {
                return this.vBCFCPSTField;
            }
            set
            {
                this.vBCFCPSTField = value;
            }
        }

        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("201")]
        Item201,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMSSN202
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMSSN202CSOSN cSOSNField;
        private TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCSTField;
        private string pMVASTField;
        private string pRedBCSTField;
        private string vBCSTField;
        private string pICMSSTField;
        private string vICMSSTField;
        private string vBCFCPSTField;
        private string pFCPSTField;
        private string vFCPSTField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        public string vBCFCPST
        {
            get
            {
                return this.vBCFCPSTField;
            }
            set
            {
                this.vBCFCPSTField = value;
            }
        }

        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("202")]
        Item202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("203")]
        Item203,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMSSN500
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMSSN500CSOSN cSOSNField;
        private string vBCSTRetField;
        private string pSTField;
        private string vICMSSubstitutoField;
        private string vICMSSTRetField;
        private string vBCFCPSTRetField;
        private string pFCPSTRetField;
        private string vFCPSTRetField;
        private string pRedBCEfetField;
        private string vBCEfetField;
        private string pICMSEfetField;
        private string vICMSEfetField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        public string pST
        {
            get
            {
                return this.pSTField;
            }
            set
            {
                this.pSTField = value;
            }
        }

        public string vICMSSubstituto
        {
            get
            {
                return this.vICMSSubstitutoField;
            }
            set
            {
                this.vICMSSubstitutoField = value;
            }
        }

        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }

        public string vBCFCPSTRet
        {
            get
            {
                return this.vBCFCPSTRetField;
            }
            set
            {
                this.vBCFCPSTRetField = value;
            }
        }

        public string pFCPSTRet
        {
            get
            {
                return this.pFCPSTRetField;
            }
            set
            {
                this.pFCPSTRetField = value;
            }
        }

        public string vFCPSTRet
        {
            get
            {
                return this.vFCPSTRetField;
            }
            set
            {
                this.vFCPSTRetField = value;
            }
        }

        public string pRedBCEfet
        {
            get
            {
                return this.pRedBCEfetField;
            }
            set
            {
                this.pRedBCEfetField = value;
            }
        }

        public string vBCEfet
        {
            get
            {
                return this.vBCEfetField;
            }
            set
            {
                this.vBCEfetField = value;
            }
        }

        public string pICMSEfet
        {
            get
            {
                return this.pICMSEfetField;
            }
            set
            {
                this.pICMSEfetField = value;
            }
        }

        public string vICMSEfet
        {
            get
            {
                return this.vICMSEfetField;
            }
            set
            {
                this.vICMSEfetField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("500")]
        Item500,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMSSN900
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMSSN900CSOSN cSOSNField;
        private TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBCField;
        private string vBCField;
        private string pRedBCField;
        private string pICMSField;
        private string vICMSField;
        private TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCSTField;
        private string pMVASTField;
        private string pRedBCSTField;
        private string vBCSTField;
        private string pICMSSTField;
        private string vICMSSTField;
        private string vBCFCPSTField;
        private string pFCPSTField;
        private string vFCPSTField;
        private string pCredSNField;
        private string vCredICMSSNField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        public string vBCFCPST
        {
            get
            {
                return this.vBCFCPSTField;
            }
            set
            {
                this.vBCFCPSTField = value;
            }
        }

        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("900")]
        Item900,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSICMSST
    {

        private Torig origField;
        private TNFeInfNFeDetImpostoICMSICMSSTCST cSTField;
        private string vBCSTRetField;
        private string pSTField;
        private string vICMSSubstitutoField;
        private string vICMSSTRetField;
        private string vBCFCPSTRetField;
        private string pFCPSTRetField;
        private string vFCPSTRetField;
        private string vBCSTDestField;
        private string vICMSSTDestField;
        private string pRedBCEfetField;
        private string vBCEfetField;
        private string pICMSEfetField;
        private string vICMSEfetField;
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSICMSSTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        public string pST
        {
            get
            {
                return this.pSTField;
            }
            set
            {
                this.pSTField = value;
            }
        }

        public string vICMSSubstituto
        {
            get
            {
                return this.vICMSSubstitutoField;
            }
            set
            {
                this.vICMSSubstitutoField = value;
            }
        }

        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }

        public string vBCFCPSTRet
        {
            get
            {
                return this.vBCFCPSTRetField;
            }
            set
            {
                this.vBCFCPSTRetField = value;
            }
        }

        public string pFCPSTRet
        {
            get
            {
                return this.pFCPSTRetField;
            }
            set
            {
                this.pFCPSTRetField = value;
            }
        }

        public string vFCPSTRet
        {
            get
            {
                return this.vFCPSTRetField;
            }
            set
            {
                this.vFCPSTRetField = value;
            }
        }

        public string vBCSTDest
        {
            get
            {
                return this.vBCSTDestField;
            }
            set
            {
                this.vBCSTDestField = value;
            }
        }

        public string vICMSSTDest
        {
            get
            {
                return this.vICMSSTDestField;
            }
            set
            {
                this.vICMSSTDestField = value;
            }
        }

        public string pRedBCEfet
        {
            get
            {
                return this.pRedBCEfetField;
            }
            set
            {
                this.pRedBCEfetField = value;
            }
        }

        public string vBCEfet
        {
            get
            {
                return this.vBCEfetField;
            }
            set
            {
                this.vBCEfetField = value;
            }
        }

        public string pICMSEfet
        {
            get
            {
                return this.pICMSEfetField;
            }
            set
            {
                this.pICMSEfetField = value;
            }
        }

        public string vICMSEfet
        {
            get
            {
                return this.vICMSEfetField;
            }
            set
            {
                this.vICMSEfetField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoICMSUFDest
    {

        private string vBCUFDestField;
        private string vBCFCPUFDestField;
        private string pFCPUFDestField;
        private string pICMSUFDestField;
        private TNFeInfNFeDetImpostoICMSUFDestPICMSInter pICMSInterField;
        private string pICMSInterPartField;
        private string vFCPUFDestField;
        private string vICMSUFDestField;
        private string vICMSUFRemetField;
        public string vBCUFDest
        {
            get
            {
                return this.vBCUFDestField;
            }
            set
            {
                this.vBCUFDestField = value;
            }
        }

        public string vBCFCPUFDest
        {
            get
            {
                return this.vBCFCPUFDestField;
            }
            set
            {
                this.vBCFCPUFDestField = value;
            }
        }

        public string pFCPUFDest
        {
            get
            {
                return this.pFCPUFDestField;
            }
            set
            {
                this.pFCPUFDestField = value;
            }
        }

        public string pICMSUFDest
        {
            get
            {
                return this.pICMSUFDestField;
            }
            set
            {
                this.pICMSUFDestField = value;
            }
        }

        public TNFeInfNFeDetImpostoICMSUFDestPICMSInter pICMSInter
        {
            get
            {
                return this.pICMSInterField;
            }
            set
            {
                this.pICMSInterField = value;
            }
        }

        public string pICMSInterPart
        {
            get
            {
                return this.pICMSInterPartField;
            }
            set
            {
                this.pICMSInterPartField = value;
            }
        }

        public string vFCPUFDest
        {
            get
            {
                return this.vFCPUFDestField;
            }
            set
            {
                this.vFCPUFDestField = value;
            }
        }

        public string vICMSUFDest
        {
            get
            {
                return this.vICMSUFDestField;
            }
            set
            {
                this.vICMSUFDestField = value;
            }
        }

        public string vICMSUFRemet
        {
            get
            {
                return this.vICMSUFRemetField;
            }
            set
            {
                this.vICMSUFRemetField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoICMSUFDestPICMSInter
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4.00")]
        Item400,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7.00")]
        Item700,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.00")]
        Item1200,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoII
    {

        private string vBCField;
        private string vDespAduField;
        private string vIIField;
        private string vIOFField;
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string vDespAdu
        {
            get
            {
                return this.vDespAduField;
            }
            set
            {
                this.vDespAduField = value;
            }
        }

        public string vII
        {
            get
            {
                return this.vIIField;
            }
            set
            {
                this.vIIField = value;
            }
        }

        public string vIOF
        {
            get
            {
                return this.vIOFField;
            }
            set
            {
                this.vIOFField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoISSQN
    {

        private string vBCField;
        private string vAliqField;
        private string vISSQNField;
        private string cMunFGField;
        private TCListServ cListServField;
        private string vDeducaoField;
        private string vOutroField;
        private string vDescIncondField;
        private string vDescCondField;
        private string vISSRetField;
        private TNFeInfNFeDetImpostoISSQNIndISS indISSField;
        private string cServicoField;
        private string cMunField;
        private string cPaisField;
        private string nProcessoField;
        private TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivoField;
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string vAliq
        {
            get
            {
                return this.vAliqField;
            }
            set
            {
                this.vAliqField = value;
            }
        }

        public string vISSQN
        {
            get
            {
                return this.vISSQNField;
            }
            set
            {
                this.vISSQNField = value;
            }
        }

        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        public TCListServ cListServ
        {
            get
            {
                return this.cListServField;
            }
            set
            {
                this.cListServField = value;
            }
        }

        public string vDeducao
        {
            get
            {
                return this.vDeducaoField;
            }
            set
            {
                this.vDeducaoField = value;
            }
        }

        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        public string vDescIncond
        {
            get
            {
                return this.vDescIncondField;
            }
            set
            {
                this.vDescIncondField = value;
            }
        }

        public string vDescCond
        {
            get
            {
                return this.vDescCondField;
            }
            set
            {
                this.vDescCondField = value;
            }
        }

        public string vISSRet
        {
            get
            {
                return this.vISSRetField;
            }
            set
            {
                this.vISSRetField = value;
            }
        }

        public TNFeInfNFeDetImpostoISSQNIndISS indISS
        {
            get
            {
                return this.indISSField;
            }
            set
            {
                this.indISSField = value;
            }
        }

        public string cServico
        {
            get
            {
                return this.cServicoField;
            }
            set
            {
                this.cServicoField = value;
            }
        }

        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        public string cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        public string nProcesso
        {
            get
            {
                return this.nProcessoField;
            }
            set
            {
                this.nProcessoField = value;
            }
        }

        public TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivo
        {
            get
            {
                return this.indIncentivoField;
            }
            set
            {
                this.indIncentivoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoISSQNIndIncentivo
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoISSQNIndISS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoPIS
    {

        private object itemField;
        [System.Xml.Serialization.XmlElementAttribute("PISAliq", typeof(TNFeInfNFeDetImpostoPISPISAliq))]
        [System.Xml.Serialization.XmlElementAttribute("PISNT", typeof(TNFeInfNFeDetImpostoPISPISNT))]
        [System.Xml.Serialization.XmlElementAttribute("PISOutr", typeof(TNFeInfNFeDetImpostoPISPISOutr))]
        [System.Xml.Serialization.XmlElementAttribute("PISQtde", typeof(TNFeInfNFeDetImpostoPISPISQtde))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoPISPISAliq
    {

        private TNFeInfNFeDetImpostoPISPISAliqCST cSTField;
        private string vBCField;
        private string pPISField;
        private string vPISField;
        public TNFeInfNFeDetImpostoPISPISAliqCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string pPIS
        {
            get
            {
                return this.pPISField;
            }
            set
            {
                this.pPISField = value;
            }
        }

        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoPISPISAliqCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoPISPISNT
    {

        private TNFeInfNFeDetImpostoPISPISNTCST cSTField;
        public TNFeInfNFeDetImpostoPISPISNTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoPISPISNTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoPISPISOutr
    {

        private TNFeInfNFeDetImpostoPISPISOutrCST cSTField;
        private string[] itemsField;
        private ChoiceType_nfe_v4_00_7[] itemsElementNameField;
        private string vPISField;
        public TNFeInfNFeDetImpostoPISPISOutrCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ChoiceType_nfe_v4_00_7[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoPISPISOutrCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoPISPISQtde
    {

        private TNFeInfNFeDetImpostoPISPISQtdeCST cSTField;
        private string qBCProdField;
        private string vAliqProdField;
        private string vPISField;
        public TNFeInfNFeDetImpostoPISPISQtdeCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetImpostoPISST
    {

        private string[] itemsField;
        private ChoiceType_nfe_v4_00_7[] itemsElementNameField;
        private string vPISField;
        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ChoiceType_nfe_v4_00_7[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProd
    {

        private string cProdField;
        private string cEANField;
        private string xProdField;
        private string nCMField;
        private string[] nVEField;
        private string cESTField;
        private TNFeInfNFeDetProdIndEscala indEscalaField;
        private bool indEscalaFieldSpecified;
        private string cNPJFabField;
        private string cBenefField;
        private string eXTIPIField;
        private string cFOPField;
        private string uComField;
        private string qComField;
        private string vUnComField;
        private string vProdField;
        private string cEANTribField;
        private string uTribField;
        private string qTribField;
        private string vUnTribField;
        private string vFreteField;
        private string vSegField;
        private string vDescField;
        private string vOutroField;
        private TNFeInfNFeDetProdIndTot indTotField;
        private TNFeInfNFeDetProdDI[] diField;
        private TNFeInfNFeDetProdDetExport[] detExportField;
        private string xPedField;
        private string nItemPedField;
        private string nFCIField;
        private TNFeInfNFeDetProdRastro[] rastroField;
        private object[] itemsField;
        public string cProd
        {
            get
            {
                return this.cProdField;
            }
            set
            {
                this.cProdField = value;
            }
        }

        public string cEAN
        {
            get
            {
                return this.cEANField;
            }
            set
            {
                this.cEANField = value;
            }
        }

        public string xProd
        {
            get
            {
                return this.xProdField;
            }
            set
            {
                this.xProdField = value;
            }
        }

        public string NCM
        {
            get
            {
                return this.nCMField;
            }
            set
            {
                this.nCMField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("NVE")]
        public string[] NVE
        {
            get
            {
                return this.nVEField;
            }
            set
            {
                this.nVEField = value;
            }
        }

        public string CEST
        {
            get
            {
                return this.cESTField;
            }
            set
            {
                this.cESTField = value;
            }
        }

        public TNFeInfNFeDetProdIndEscala indEscala
        {
            get
            {
                return this.indEscalaField;
            }
            set
            {
                this.indEscalaField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indEscalaSpecified
        {
            get
            {
                return this.indEscalaFieldSpecified;
            }
            set
            {
                this.indEscalaFieldSpecified = value;
            }
        }

        public string CNPJFab
        {
            get
            {
                return this.cNPJFabField;
            }
            set
            {
                this.cNPJFabField = value;
            }
        }

        public string cBenef
        {
            get
            {
                return this.cBenefField;
            }
            set
            {
                this.cBenefField = value;
            }
        }

        public string EXTIPI
        {
            get
            {
                return this.eXTIPIField;
            }
            set
            {
                this.eXTIPIField = value;
            }
        }

        public string CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        public string uCom
        {
            get
            {
                return this.uComField;
            }
            set
            {
                this.uComField = value;
            }
        }

        public string qCom
        {
            get
            {
                return this.qComField;
            }
            set
            {
                this.qComField = value;
            }
        }

        public string vUnCom
        {
            get
            {
                return this.vUnComField;
            }
            set
            {
                this.vUnComField = value;
            }
        }

        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        public string cEANTrib
        {
            get
            {
                return this.cEANTribField;
            }
            set
            {
                this.cEANTribField = value;
            }
        }

        public string uTrib
        {
            get
            {
                return this.uTribField;
            }
            set
            {
                this.uTribField = value;
            }
        }

        public string qTrib
        {
            get
            {
                return this.qTribField;
            }
            set
            {
                this.qTribField = value;
            }
        }

        public string vUnTrib
        {
            get
            {
                return this.vUnTribField;
            }
            set
            {
                this.vUnTribField = value;
            }
        }

        public string vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }

        public string vSeg
        {
            get
            {
                return this.vSegField;
            }
            set
            {
                this.vSegField = value;
            }
        }

        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        public TNFeInfNFeDetProdIndTot indTot
        {
            get
            {
                return this.indTotField;
            }
            set
            {
                this.indTotField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("DI")]
        public TNFeInfNFeDetProdDI[] DI
        {
            get
            {
                return this.diField;
            }
            set
            {
                this.diField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("detExport")]
        public TNFeInfNFeDetProdDetExport[] detExport
        {
            get
            {
                return this.detExportField;
            }
            set
            {
                this.detExportField = value;
            }
        }

        public string xPed
        {
            get
            {
                return this.xPedField;
            }
            set
            {
                this.xPedField = value;
            }
        }

        public string nItemPed
        {
            get
            {
                return this.nItemPedField;
            }
            set
            {
                this.nItemPedField = value;
            }
        }

        public string nFCI
        {
            get
            {
                return this.nFCIField;
            }
            set
            {
                this.nFCIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("rastro")]
        public TNFeInfNFeDetProdRastro[] rastro
        {
            get
            {
                return this.rastroField;
            }
            set
            {
                this.rastroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma))]
        [System.Xml.Serialization.XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb))]
        [System.Xml.Serialization.XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed))]
        [System.Xml.Serialization.XmlElementAttribute("nRECOPI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdArma
    {

        private TNFeInfNFeDetProdArmaTpArma tpArmaField;
        private string nSerieField;
        private string nCanoField;
        private string descrField;
        public TNFeInfNFeDetProdArmaTpArma tpArma
        {
            get
            {
                return this.tpArmaField;
            }
            set
            {
                this.tpArmaField = value;
            }
        }

        public string nSerie
        {
            get
            {
                return this.nSerieField;
            }
            set
            {
                this.nSerieField = value;
            }
        }

        public string nCano
        {
            get
            {
                return this.nCanoField;
            }
            set
            {
                this.nCanoField = value;
            }
        }

        public string descr
        {
            get
            {
                return this.descrField;
            }
            set
            {
                this.descrField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdArmaTpArma
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdComb
    {

        private string cProdANPField;
        private string descANPField;
        private string pGLPField;
        private string pGNnField;
        private string pGNiField;
        private string vPartField;
        private string cODIFField;
        private string qTempField;
        private TUf uFConsField;
        private TNFeInfNFeDetProdCombCIDE cIDEField;
        private TNFeInfNFeDetProdCombEncerrante encerranteField;
        public string cProdANP
        {
            get
            {
                return this.cProdANPField;
            }
            set
            {
                this.cProdANPField = value;
            }
        }

        public string descANP
        {
            get
            {
                return this.descANPField;
            }
            set
            {
                this.descANPField = value;
            }
        }

        public string pGLP
        {
            get
            {
                return this.pGLPField;
            }
            set
            {
                this.pGLPField = value;
            }
        }

        public string pGNn
        {
            get
            {
                return this.pGNnField;
            }
            set
            {
                this.pGNnField = value;
            }
        }

        public string pGNi
        {
            get
            {
                return this.pGNiField;
            }
            set
            {
                this.pGNiField = value;
            }
        }

        public string vPart
        {
            get
            {
                return this.vPartField;
            }
            set
            {
                this.vPartField = value;
            }
        }

        public string CODIF
        {
            get
            {
                return this.cODIFField;
            }
            set
            {
                this.cODIFField = value;
            }
        }

        public string qTemp
        {
            get
            {
                return this.qTempField;
            }
            set
            {
                this.qTempField = value;
            }
        }

        public TUf UFCons
        {
            get
            {
                return this.uFConsField;
            }
            set
            {
                this.uFConsField = value;
            }
        }

        public TNFeInfNFeDetProdCombCIDE CIDE
        {
            get
            {
                return this.cIDEField;
            }
            set
            {
                this.cIDEField = value;
            }
        }

        public TNFeInfNFeDetProdCombEncerrante encerrante
        {
            get
            {
                return this.encerranteField;
            }
            set
            {
                this.encerranteField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdCombCIDE
    {

        private string qBCProdField;
        private string vAliqProdField;
        private string vCIDEField;
        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        public string vCIDE
        {
            get
            {
                return this.vCIDEField;
            }
            set
            {
                this.vCIDEField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdCombEncerrante
    {

        private string nBicoField;
        private string nBombaField;
        private string nTanqueField;
        private string vEncIniField;
        private string vEncFinField;
        public string nBico
        {
            get
            {
                return this.nBicoField;
            }
            set
            {
                this.nBicoField = value;
            }
        }

        public string nBomba
        {
            get
            {
                return this.nBombaField;
            }
            set
            {
                this.nBombaField = value;
            }
        }

        public string nTanque
        {
            get
            {
                return this.nTanqueField;
            }
            set
            {
                this.nTanqueField = value;
            }
        }

        public string vEncIni
        {
            get
            {
                return this.vEncIniField;
            }
            set
            {
                this.vEncIniField = value;
            }
        }

        public string vEncFin
        {
            get
            {
                return this.vEncFinField;
            }
            set
            {
                this.vEncFinField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdDetExport
    {

        private string nDrawField;
        private TNFeInfNFeDetProdDetExportExportInd exportIndField;
        public string nDraw
        {
            get
            {
                return this.nDrawField;
            }
            set
            {
                this.nDrawField = value;
            }
        }

        public TNFeInfNFeDetProdDetExportExportInd exportInd
        {
            get
            {
                return this.exportIndField;
            }
            set
            {
                this.exportIndField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdDetExportExportInd
    {

        private string nREField;
        private string chNFeField;
        private string qExportField;
        public string nRE
        {
            get
            {
                return this.nREField;
            }
            set
            {
                this.nREField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string qExport
        {
            get
            {
                return this.qExportField;
            }
            set
            {
                this.qExportField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdDI
    {

        private string nDIField;
        private string dDIField;
        private string xLocDesembField;
        private TUfEmi uFDesembField;
        private string dDesembField;
        private TNFeInfNFeDetProdDITpViaTransp tpViaTranspField;
        private string vAFRMMField;
        private TNFeInfNFeDetProdDITpIntermedio tpIntermedioField;
        private string cNPJField;
        private TUfEmi uFTerceiroField;
        private bool uFTerceiroFieldSpecified;
        private string cExportadorField;
        private TNFeInfNFeDetProdDIAdi[] adiField;
        public string nDI
        {
            get
            {
                return this.nDIField;
            }
            set
            {
                this.nDIField = value;
            }
        }

        public string dDI
        {
            get
            {
                return this.dDIField;
            }
            set
            {
                this.dDIField = value;
            }
        }

        public string xLocDesemb
        {
            get
            {
                return this.xLocDesembField;
            }
            set
            {
                this.xLocDesembField = value;
            }
        }

        public TUfEmi UFDesemb
        {
            get
            {
                return this.uFDesembField;
            }
            set
            {
                this.uFDesembField = value;
            }
        }

        public string dDesemb
        {
            get
            {
                return this.dDesembField;
            }
            set
            {
                this.dDesembField = value;
            }
        }

        public TNFeInfNFeDetProdDITpViaTransp tpViaTransp
        {
            get
            {
                return this.tpViaTranspField;
            }
            set
            {
                this.tpViaTranspField = value;
            }
        }

        public string vAFRMM
        {
            get
            {
                return this.vAFRMMField;
            }
            set
            {
                this.vAFRMMField = value;
            }
        }

        public TNFeInfNFeDetProdDITpIntermedio tpIntermedio
        {
            get
            {
                return this.tpIntermedioField;
            }
            set
            {
                this.tpIntermedioField = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public TUfEmi UFTerceiro
        {
            get
            {
                return this.uFTerceiroField;
            }
            set
            {
                this.uFTerceiroField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFTerceiroSpecified
        {
            get
            {
                return this.uFTerceiroFieldSpecified;
            }
            set
            {
                this.uFTerceiroFieldSpecified = value;
            }
        }

        public string cExportador
        {
            get
            {
                return this.cExportadorField;
            }
            set
            {
                this.cExportadorField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("adi")]
        public TNFeInfNFeDetProdDIAdi[] adi
        {
            get
            {
                return this.adiField;
            }
            set
            {
                this.adiField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdDIAdi
    {

        private string nAdicaoField;
        private string nSeqAdicField;
        private string cFabricanteField;
        private string vDescDIField;
        private string nDrawField;
        public string nAdicao
        {
            get
            {
                return this.nAdicaoField;
            }
            set
            {
                this.nAdicaoField = value;
            }
        }

        public string nSeqAdic
        {
            get
            {
                return this.nSeqAdicField;
            }
            set
            {
                this.nSeqAdicField = value;
            }
        }

        public string cFabricante
        {
            get
            {
                return this.cFabricanteField;
            }
            set
            {
                this.cFabricanteField = value;
            }
        }

        public string vDescDI
        {
            get
            {
                return this.vDescDIField;
            }
            set
            {
                this.vDescDIField = value;
            }
        }

        public string nDraw
        {
            get
            {
                return this.nDrawField;
            }
            set
            {
                this.nDrawField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdDITpIntermedio
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdDITpViaTransp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdIndEscala
    {

        /// <remarks/>
        S,

        /// <remarks/>
        N,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdIndTot
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdMed
    {

        private string cProdANVISAField;
        private string xMotivoIsencaoField;
        private string vPMCField;
        public string cProdANVISA
        {
            get
            {
                return this.cProdANVISAField;
            }
            set
            {
                this.cProdANVISAField = value;
            }
        }

        public string xMotivoIsencao
        {
            get
            {
                return this.xMotivoIsencaoField;
            }
            set
            {
                this.xMotivoIsencaoField = value;
            }
        }

        public string vPMC
        {
            get
            {
                return this.vPMCField;
            }
            set
            {
                this.vPMCField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdRastro
    {

        private string nLoteField;
        private string qLoteField;
        private string dFabField;
        private string dValField;
        private string cAgregField;
        public string nLote
        {
            get
            {
                return this.nLoteField;
            }
            set
            {
                this.nLoteField = value;
            }
        }

        public string qLote
        {
            get
            {
                return this.qLoteField;
            }
            set
            {
                this.qLoteField = value;
            }
        }

        public string dFab
        {
            get
            {
                return this.dFabField;
            }
            set
            {
                this.dFabField = value;
            }
        }

        public string dVal
        {
            get
            {
                return this.dValField;
            }
            set
            {
                this.dValField = value;
            }
        }

        public string cAgreg
        {
            get
            {
                return this.cAgregField;
            }
            set
            {
                this.cAgregField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeDetProdVeicProd
    {

        private TNFeInfNFeDetProdVeicProdTpOp tpOpField;
        private string chassiField;
        private string cCorField;
        private string xCorField;
        private string potField;
        private string cilinField;
        private string pesoLField;
        private string pesoBField;
        private string nSerieField;
        private string tpCombField;
        private string nMotorField;
        private string cMTField;
        private string distField;
        private string anoModField;
        private string anoFabField;
        private string tpPintField;
        private string tpVeicField;
        private string espVeicField;
        private TNFeInfNFeDetProdVeicProdVIN vINField;
        private TNFeInfNFeDetProdVeicProdCondVeic condVeicField;
        private string cModField;
        private string cCorDENATRANField;
        private string lotaField;
        private TNFeInfNFeDetProdVeicProdTpRest tpRestField;
        public TNFeInfNFeDetProdVeicProdTpOp tpOp
        {
            get
            {
                return this.tpOpField;
            }
            set
            {
                this.tpOpField = value;
            }
        }

        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
            }
        }

        public string cCor
        {
            get
            {
                return this.cCorField;
            }
            set
            {
                this.cCorField = value;
            }
        }

        public string xCor
        {
            get
            {
                return this.xCorField;
            }
            set
            {
                this.xCorField = value;
            }
        }

        public string pot
        {
            get
            {
                return this.potField;
            }
            set
            {
                this.potField = value;
            }
        }

        public string cilin
        {
            get
            {
                return this.cilinField;
            }
            set
            {
                this.cilinField = value;
            }
        }

        public string pesoL
        {
            get
            {
                return this.pesoLField;
            }
            set
            {
                this.pesoLField = value;
            }
        }

        public string pesoB
        {
            get
            {
                return this.pesoBField;
            }
            set
            {
                this.pesoBField = value;
            }
        }

        public string nSerie
        {
            get
            {
                return this.nSerieField;
            }
            set
            {
                this.nSerieField = value;
            }
        }

        public string tpComb
        {
            get
            {
                return this.tpCombField;
            }
            set
            {
                this.tpCombField = value;
            }
        }

        public string nMotor
        {
            get
            {
                return this.nMotorField;
            }
            set
            {
                this.nMotorField = value;
            }
        }

        public string CMT
        {
            get
            {
                return this.cMTField;
            }
            set
            {
                this.cMTField = value;
            }
        }

        public string dist
        {
            get
            {
                return this.distField;
            }
            set
            {
                this.distField = value;
            }
        }

        public string anoMod
        {
            get
            {
                return this.anoModField;
            }
            set
            {
                this.anoModField = value;
            }
        }

        public string anoFab
        {
            get
            {
                return this.anoFabField;
            }
            set
            {
                this.anoFabField = value;
            }
        }

        public string tpPint
        {
            get
            {
                return this.tpPintField;
            }
            set
            {
                this.tpPintField = value;
            }
        }

        public string tpVeic
        {
            get
            {
                return this.tpVeicField;
            }
            set
            {
                this.tpVeicField = value;
            }
        }

        public string espVeic
        {
            get
            {
                return this.espVeicField;
            }
            set
            {
                this.espVeicField = value;
            }
        }

        public TNFeInfNFeDetProdVeicProdVIN VIN
        {
            get
            {
                return this.vINField;
            }
            set
            {
                this.vINField = value;
            }
        }

        public TNFeInfNFeDetProdVeicProdCondVeic condVeic
        {
            get
            {
                return this.condVeicField;
            }
            set
            {
                this.condVeicField = value;
            }
        }

        public string cMod
        {
            get
            {
                return this.cModField;
            }
            set
            {
                this.cModField = value;
            }
        }

        public string cCorDENATRAN
        {
            get
            {
                return this.cCorDENATRANField;
            }
            set
            {
                this.cCorDENATRANField = value;
            }
        }

        public string lota
        {
            get
            {
                return this.lotaField;
            }
            set
            {
                this.lotaField = value;
            }
        }

        public TNFeInfNFeDetProdVeicProdTpRest tpRest
        {
            get
            {
                return this.tpRestField;
            }
            set
            {
                this.tpRestField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdVeicProdCondVeic
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdVeicProdTpOp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdVeicProdTpRest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeDetProdVeicProdVIN
    {

        /// <remarks/>
        R,

        /// <remarks/>
        N,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeEmit
    {

        private string itemField;
        private TipoDoc itemElementNameField;
        private string xNomeField;
        private string xFantField;
        private TEnderEmi enderEmitField;
        private string ieField;
        private string iESTField;
        private string imField;
        private string cNAEField;
        private TNFeInfNFeEmitCRT cRTField;
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        public string xFant
        {
            get
            {
                return this.xFantField;
            }
            set
            {
                this.xFantField = value;
            }
        }

        public TEnderEmi enderEmit
        {
            get
            {
                return this.enderEmitField;
            }
            set
            {
                this.enderEmitField = value;
            }
        }

        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        public string IEST
        {
            get
            {
                return this.iESTField;
            }
            set
            {
                this.iESTField = value;
            }
        }

        public string IM
        {
            get
            {
                return this.imField;
            }
            set
            {
                this.imField = value;
            }
        }

        public string CNAE
        {
            get
            {
                return this.cNAEField;
            }
            set
            {
                this.cNAEField = value;
            }
        }

        public TNFeInfNFeEmitCRT CRT
        {
            get
            {
                return this.cRTField;
            }
            set
            {
                this.cRTField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeEmitCRT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeExporta
    {

        private TUfEmi uFSaidaPaisField;
        private string xLocExportaField;
        private string xLocDespachoField;
        public TUfEmi UFSaidaPais
        {
            get
            {
                return this.uFSaidaPaisField;
            }
            set
            {
                this.uFSaidaPaisField = value;
            }
        }

        public string xLocExporta
        {
            get
            {
                return this.xLocExportaField;
            }
            set
            {
                this.xLocExportaField = value;
            }
        }

        public string xLocDespacho
        {
            get
            {
                return this.xLocDespachoField;
            }
            set
            {
                this.xLocDespachoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeIde
    {

        private TCodUfIBGE cUFField;
        private string cNFField;
        private string natOpField;
        private TMod modField;
        private string serieField;
        private string nNFField;
        private string dhEmiField;
        private string dhSaiEntField;
        private TNFeInfNFeIdeTpNF tpNFField;
        private TNFeInfNFeIdeIdDest idDestField;
        private string cMunFGField;
        private TNFeInfNFeIdeTpImp tpImpField;
        private TNFeInfNFeIdeTpEmis tpEmisField;
        private string cDVField;
        private TAmb tpAmbField;
        private TFinNFe finNFeField;
        private TNFeInfNFeIdeIndFinal indFinalField;
        private TNFeInfNFeIdeIndPres indPresField;
        private TNFeInfNFeIdeIndIntermed indIntermedField;
        private bool indIntermedFieldSpecified;
        private TProcEmi procEmiField;
        private string verProcField;
        private string dhContField;
        private string xJustField;
        private TNFeInfNFeIdeNFref[] nFrefField;
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string cNF
        {
            get
            {
                return this.cNFField;
            }
            set
            {
                this.cNFField = value;
            }
        }

        public string natOp
        {
            get
            {
                return this.natOpField;
            }
            set
            {
                this.natOpField = value;
            }
        }

        public TMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

        public string dhEmi
        {
            get
            {
                return this.dhEmiField;
            }
            set
            {
                this.dhEmiField = value;
            }
        }

        public string dhSaiEnt
        {
            get
            {
                return this.dhSaiEntField;
            }
            set
            {
                this.dhSaiEntField = value;
            }
        }

        public TNFeInfNFeIdeTpNF tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        public TNFeInfNFeIdeIdDest idDest
        {
            get
            {
                return this.idDestField;
            }
            set
            {
                this.idDestField = value;
            }
        }

        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        public TNFeInfNFeIdeTpImp tpImp
        {
            get
            {
                return this.tpImpField;
            }
            set
            {
                this.tpImpField = value;
            }
        }

        public TNFeInfNFeIdeTpEmis tpEmis
        {
            get
            {
                return this.tpEmisField;
            }
            set
            {
                this.tpEmisField = value;
            }
        }

        public string cDV
        {
            get
            {
                return this.cDVField;
            }
            set
            {
                this.cDVField = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public TFinNFe finNFe
        {
            get
            {
                return this.finNFeField;
            }
            set
            {
                this.finNFeField = value;
            }
        }

        public TNFeInfNFeIdeIndFinal indFinal
        {
            get
            {
                return this.indFinalField;
            }
            set
            {
                this.indFinalField = value;
            }
        }

        public TNFeInfNFeIdeIndPres indPres
        {
            get
            {
                return this.indPresField;
            }
            set
            {
                this.indPresField = value;
            }
        }

        public TNFeInfNFeIdeIndIntermed indIntermed
        {
            get
            {
                return this.indIntermedField;
            }
            set
            {
                this.indIntermedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indIntermedSpecified
        {
            get
            {
                return this.indIntermedFieldSpecified;
            }
            set
            {
                this.indIntermedFieldSpecified = value;
            }
        }

        public TProcEmi procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
            }
        }

        public string verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }

        public string dhCont
        {
            get
            {
                return this.dhContField;
            }
            set
            {
                this.dhContField = value;
            }
        }

        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("NFref")]
        public TNFeInfNFeIdeNFref[] NFref
        {
            get
            {
                return this.nFrefField;
            }
            set
            {
                this.nFrefField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeIdDest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeIndFinal
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeIndIntermed
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeIndPres
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeIdeNFref
    {

        private object itemField;
        private TipoRefDoc itemElementNameField;
        [System.Xml.Serialization.XmlElementAttribute("refCTe", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("refECF", typeof(TNFeInfNFeIdeNFrefRefECF))]
        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TNFeInfNFeIdeNFrefRefNF))]
        [System.Xml.Serialization.XmlElementAttribute("refNFP", typeof(TNFeInfNFeIdeNFrefRefNFP))]
        [System.Xml.Serialization.XmlElementAttribute("refNFe", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoRefDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeIdeNFrefRefECF
    {

        private TNFeInfNFeIdeNFrefRefECFMod modField;
        private string nECFField;
        private string nCOOField;
        public TNFeInfNFeIdeNFrefRefECFMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        public string nECF
        {
            get
            {
                return this.nECFField;
            }
            set
            {
                this.nECFField = value;
            }
        }

        public string nCOO
        {
            get
            {
                return this.nCOOField;
            }
            set
            {
                this.nCOOField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeNFrefRefECFMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2B")]
        Item2B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2C")]
        Item2C,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2D")]
        Item2D,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeIdeNFrefRefNF
    {

        private TCodUfIBGE cUFField;
        private string aAMMField;
        private string cNPJField;
        private TNFeInfNFeIdeNFrefRefNFMod modField;
        private string serieField;
        private string nNFField;
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string AAMM
        {
            get
            {
                return this.aAMMField;
            }
            set
            {
                this.aAMMField = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public TNFeInfNFeIdeNFrefRefNFMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeNFrefRefNFMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeIdeNFrefRefNFP
    {

        private TCodUfIBGE cUFField;
        private string aAMMField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string ieField;
        private TNFeInfNFeIdeNFrefRefNFPMod modField;
        private string serieField;
        private string nNFField;
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string AAMM
        {
            get
            {
                return this.aAMMField;
            }
            set
            {
                this.aAMMField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        public TNFeInfNFeIdeNFrefRefNFPMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeNFrefRefNFPMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeTpEmis
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeTpImp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeIdeTpNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeInfAdic
    {

        private string infAdFiscoField;
        private string infCplField;
        private TNFeInfNFeInfAdicObsCont[] obsContField;
        private TNFeInfNFeInfAdicObsFisco[] obsFiscoField;
        private TNFeInfNFeInfAdicProcRef[] procRefField;
        public string infAdFisco
        {
            get
            {
                return this.infAdFiscoField;
            }
            set
            {
                this.infAdFiscoField = value;
            }
        }

        public string infCpl
        {
            get
            {
                return this.infCplField;
            }
            set
            {
                this.infCplField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("obsCont")]
        public TNFeInfNFeInfAdicObsCont[] obsCont
        {
            get
            {
                return this.obsContField;
            }
            set
            {
                this.obsContField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("obsFisco")]
        public TNFeInfNFeInfAdicObsFisco[] obsFisco
        {
            get
            {
                return this.obsFiscoField;
            }
            set
            {
                this.obsFiscoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("procRef")]
        public TNFeInfNFeInfAdicProcRef[] procRef
        {
            get
            {
                return this.procRefField;
            }
            set
            {
                this.procRefField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeInfAdicObsCont
    {

        private string xTextoField;
        private string xCampoField;
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeInfAdicObsFisco
    {

        private string xTextoField;
        private string xCampoField;
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeInfAdicProcRef
    {

        private string nProcField;
        private TNFeInfNFeInfAdicProcRefIndProc indProcField;
        public string nProc
        {
            get
            {
                return this.nProcField;
            }
            set
            {
                this.nProcField = value;
            }
        }

        public TNFeInfNFeInfAdicProcRefIndProc indProc
        {
            get
            {
                return this.indProcField;
            }
            set
            {
                this.indProcField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeInfAdicProcRefIndProc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeInfIntermed
    {

        private string cNPJField;
        private string idCadIntTranField;
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public string idCadIntTran
        {
            get
            {
                return this.idCadIntTranField;
            }
            set
            {
                this.idCadIntTranField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFePag
    {

        private TNFeInfNFePagDetPag[] detPagField;
        private string vTrocoField;
        [System.Xml.Serialization.XmlElementAttribute("detPag")]
        public TNFeInfNFePagDetPag[] detPag
        {
            get
            {
                return this.detPagField;
            }
            set
            {
                this.detPagField = value;
            }
        }

        public string vTroco
        {
            get
            {
                return this.vTrocoField;
            }
            set
            {
                this.vTrocoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFePagDetPag
    {

        private TNFeInfNFePagDetPagIndPag indPagField;
        private bool indPagFieldSpecified;
        private TNFeInfNFePagDetPagTPag tPagField;
        private string vPagField;
        private TNFeInfNFePagDetPagCard cardField;
        public TNFeInfNFePagDetPagIndPag indPag
        {
            get
            {
                return this.indPagField;
            }
            set
            {
                this.indPagField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indPagSpecified
        {
            get
            {
                return this.indPagFieldSpecified;
            }
            set
            {
                this.indPagFieldSpecified = value;
            }
        }

        public TNFeInfNFePagDetPagTPag tPag
        {
            get
            {
                return this.tPagField;
            }
            set
            {
                this.tPagField = value;
            }
        }

        public string vPag
        {
            get
            {
                return this.vPagField;
            }
            set
            {
                this.vPagField = value;
            }
        }

        public TNFeInfNFePagDetPagCard card
        {
            get
            {
                return this.cardField;
            }
            set
            {
                this.cardField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFePagDetPagCard
    {

        private TNFeInfNFePagDetPagCardTpIntegra tpIntegraField;
        private string cNPJField;
        private TNFeInfNFePagDetPagCardTBand tBandField;
        private bool tBandFieldSpecified;
        private string cAutField;
        public TNFeInfNFePagDetPagCardTpIntegra tpIntegra
        {
            get
            {
                return this.tpIntegraField;
            }
            set
            {
                this.tpIntegraField = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public TNFeInfNFePagDetPagCardTBand tBand
        {
            get
            {
                return this.tBandField;
            }
            set
            {
                this.tBandField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tBandSpecified
        {
            get
            {
                return this.tBandFieldSpecified;
            }
            set
            {
                this.tBandFieldSpecified = value;
            }
        }

        public string cAut
        {
            get
            {
                return this.cAutField;
            }
            set
            {
                this.cAutField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFePagDetPagCardTBand
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFePagDetPagCardTpIntegra
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFePagDetPagIndPag
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFePagDetPagTPag
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeSupl
    {

        private string qrCodeField;
        private string urlChaveField;
        public string qrCode
        {
            get
            {
                return this.qrCodeField;
            }
            set
            {
                this.qrCodeField = value;
            }
        }

        public string urlChave
        {
            get
            {
                return this.urlChaveField;
            }
            set
            {
                this.urlChaveField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTotal
    {

        private TNFeInfNFeTotalICMSTot iCMSTotField;
        private TNFeInfNFeTotalISSQNtot iSSQNtotField;
        private TNFeInfNFeTotalRetTrib retTribField;
        public TNFeInfNFeTotalICMSTot ICMSTot
        {
            get
            {
                return this.iCMSTotField;
            }
            set
            {
                this.iCMSTotField = value;
            }
        }

        public TNFeInfNFeTotalISSQNtot ISSQNtot
        {
            get
            {
                return this.iSSQNtotField;
            }
            set
            {
                this.iSSQNtotField = value;
            }
        }

        public TNFeInfNFeTotalRetTrib retTrib
        {
            get
            {
                return this.retTribField;
            }
            set
            {
                this.retTribField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTotalICMSTot
    {

        private string vBCField;
        private string vICMSField;
        private string vICMSDesonField;
        private string vFCPUFDestField;
        private string vICMSUFDestField;
        private string vICMSUFRemetField;
        private string vFCPField;
        private string vBCSTField;
        private string vSTField;
        private string vFCPSTField;
        private string vFCPSTRetField;
        private string vProdField;
        private string vFreteField;
        private string vSegField;
        private string vDescField;
        private string vIIField;
        private string vIPIField;
        private string vIPIDevolField;
        private string vPISField;
        private string vCOFINSField;
        private string vOutroField;
        private string vNFField;
        private string vTotTribField;
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        public string vFCPUFDest
        {
            get
            {
                return this.vFCPUFDestField;
            }
            set
            {
                this.vFCPUFDestField = value;
            }
        }

        public string vICMSUFDest
        {
            get
            {
                return this.vICMSUFDestField;
            }
            set
            {
                this.vICMSUFDestField = value;
            }
        }

        public string vICMSUFRemet
        {
            get
            {
                return this.vICMSUFRemetField;
            }
            set
            {
                this.vICMSUFRemetField = value;
            }
        }

        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        public string vST
        {
            get
            {
                return this.vSTField;
            }
            set
            {
                this.vSTField = value;
            }
        }

        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        public string vFCPSTRet
        {
            get
            {
                return this.vFCPSTRetField;
            }
            set
            {
                this.vFCPSTRetField = value;
            }
        }

        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        public string vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }

        public string vSeg
        {
            get
            {
                return this.vSegField;
            }
            set
            {
                this.vSegField = value;
            }
        }

        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        public string vII
        {
            get
            {
                return this.vIIField;
            }
            set
            {
                this.vIIField = value;
            }
        }

        public string vIPI
        {
            get
            {
                return this.vIPIField;
            }
            set
            {
                this.vIPIField = value;
            }
        }

        public string vIPIDevol
        {
            get
            {
                return this.vIPIDevolField;
            }
            set
            {
                this.vIPIDevolField = value;
            }
        }

        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        public string vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }

        public string vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTotalISSQNtot
    {

        private string vServField;
        private string vBCField;
        private string vISSField;
        private string vPISField;
        private string vCOFINSField;
        private string dCompetField;
        private string vDeducaoField;
        private string vOutroField;
        private string vDescIncondField;
        private string vDescCondField;
        private string vISSRetField;
        private TNFeInfNFeTotalISSQNtotCRegTrib cRegTribField;
        private bool cRegTribFieldSpecified;
        public string vServ
        {
            get
            {
                return this.vServField;
            }
            set
            {
                this.vServField = value;
            }
        }

        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        public string vISS
        {
            get
            {
                return this.vISSField;
            }
            set
            {
                this.vISSField = value;
            }
        }

        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        public string dCompet
        {
            get
            {
                return this.dCompetField;
            }
            set
            {
                this.dCompetField = value;
            }
        }

        public string vDeducao
        {
            get
            {
                return this.vDeducaoField;
            }
            set
            {
                this.vDeducaoField = value;
            }
        }

        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        public string vDescIncond
        {
            get
            {
                return this.vDescIncondField;
            }
            set
            {
                this.vDescIncondField = value;
            }
        }

        public string vDescCond
        {
            get
            {
                return this.vDescCondField;
            }
            set
            {
                this.vDescCondField = value;
            }
        }

        public string vISSRet
        {
            get
            {
                return this.vISSRetField;
            }
            set
            {
                this.vISSRetField = value;
            }
        }

        public TNFeInfNFeTotalISSQNtotCRegTrib cRegTrib
        {
            get
            {
                return this.cRegTribField;
            }
            set
            {
                this.cRegTribField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cRegTribSpecified
        {
            get
            {
                return this.cRegTribFieldSpecified;
            }
            set
            {
                this.cRegTribFieldSpecified = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeTotalISSQNtotCRegTrib
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTotalRetTrib
    {

        private string vRetPISField;
        private string vRetCOFINSField;
        private string vRetCSLLField;
        private string vBCIRRFField;
        private string vIRRFField;
        private string vBCRetPrevField;
        private string vRetPrevField;
        public string vRetPIS
        {
            get
            {
                return this.vRetPISField;
            }
            set
            {
                this.vRetPISField = value;
            }
        }

        public string vRetCOFINS
        {
            get
            {
                return this.vRetCOFINSField;
            }
            set
            {
                this.vRetCOFINSField = value;
            }
        }

        public string vRetCSLL
        {
            get
            {
                return this.vRetCSLLField;
            }
            set
            {
                this.vRetCSLLField = value;
            }
        }

        public string vBCIRRF
        {
            get
            {
                return this.vBCIRRFField;
            }
            set
            {
                this.vBCIRRFField = value;
            }
        }

        public string vIRRF
        {
            get
            {
                return this.vIRRFField;
            }
            set
            {
                this.vIRRFField = value;
            }
        }

        public string vBCRetPrev
        {
            get
            {
                return this.vBCRetPrevField;
            }
            set
            {
                this.vBCRetPrevField = value;
            }
        }

        public string vRetPrev
        {
            get
            {
                return this.vRetPrevField;
            }
            set
            {
                this.vRetPrevField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTransp
    {

        private TNFeInfNFeTranspModFrete modFreteField;
        private TNFeInfNFeTranspTransporta transportaField;
        private TNFeInfNFeTranspRetTransp retTranspField;
        private object[] itemsField;
        private TipoTransporte[] itemsElementNameField;
        private TNFeInfNFeTranspVol[] volField;
        public TNFeInfNFeTranspModFrete modFrete
        {
            get
            {
                return this.modFreteField;
            }
            set
            {
                this.modFreteField = value;
            }
        }

        public TNFeInfNFeTranspTransporta transporta
        {
            get
            {
                return this.transportaField;
            }
            set
            {
                this.transportaField = value;
            }
        }

        public TNFeInfNFeTranspRetTransp retTransp
        {
            get
            {
                return this.retTranspField;
            }
            set
            {
                this.retTranspField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("balsa", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("reboque", typeof(TVeiculo))]
        [System.Xml.Serialization.XmlElementAttribute("vagao", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("veicTransp", typeof(TVeiculo))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoTransporte[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("vol")]
        public TNFeInfNFeTranspVol[] vol
        {
            get
            {
                return this.volField;
            }
            set
            {
                this.volField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TNFeInfNFeTranspModFrete
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTranspRetTransp
    {

        private string vServField;
        private string vBCRetField;
        private string pICMSRetField;
        private string vICMSRetField;
        private string cFOPField;
        private string cMunFGField;
        public string vServ
        {
            get
            {
                return this.vServField;
            }
            set
            {
                this.vServField = value;
            }
        }

        public string vBCRet
        {
            get
            {
                return this.vBCRetField;
            }
            set
            {
                this.vBCRetField = value;
            }
        }

        public string pICMSRet
        {
            get
            {
                return this.pICMSRetField;
            }
            set
            {
                this.pICMSRetField = value;
            }
        }

        public string vICMSRet
        {
            get
            {
                return this.vICMSRetField;
            }
            set
            {
                this.vICMSRetField = value;
            }
        }

        public string CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTranspTransporta
    {

        private string itemField;
        private TipoDoc itemElementNameField;
        private string xNomeField;
        private string ieField;
        private string xEnderField;
        private string xMunField;
        private TUf ufField;
        private bool ufFieldSpecified;
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        public string xEnder
        {
            get
            {
                return this.xEnderField;
            }
            set
            {
                this.xEnderField = value;
            }
        }

        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFSpecified
        {
            get
            {
                return this.ufFieldSpecified;
            }
            set
            {
                this.ufFieldSpecified = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTranspVol
    {

        private string qVolField;
        private string espField;
        private string marcaField;
        private string nVolField;
        private string pesoLField;
        private string pesoBField;
        private TNFeInfNFeTranspVolLacres[] lacresField;
        public string qVol
        {
            get
            {
                return this.qVolField;
            }
            set
            {
                this.qVolField = value;
            }
        }

        public string esp
        {
            get
            {
                return this.espField;
            }
            set
            {
                this.espField = value;
            }
        }

        public string marca
        {
            get
            {
                return this.marcaField;
            }
            set
            {
                this.marcaField = value;
            }
        }

        public string nVol
        {
            get
            {
                return this.nVolField;
            }
            set
            {
                this.nVolField = value;
            }
        }

        public string pesoL
        {
            get
            {
                return this.pesoLField;
            }
            set
            {
                this.pesoLField = value;
            }
        }

        public string pesoB
        {
            get
            {
                return this.pesoBField;
            }
            set
            {
                this.pesoBField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("lacres")]
        public TNFeInfNFeTranspVolLacres[] lacres
        {
            get
            {
                return this.lacresField;
            }
            set
            {
                this.lacresField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TNFeInfNFeTranspVolLacres
    {

        private string nLacreField;
        public string nLacre
        {
            get
            {
                return this.nLacreField;
            }
            set
            {
                this.nLacreField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TNfeProc
    {

        private TNFe nFeField;
        private TProtNFe_nfe_v4_00 protNFeField;
        private string versaoField;
        public TNFe NFe
        {
            get
            {
                return this.nFeField;
            }
            set
            {
                this.nFeField = value;
            }
        }

        public TProtNFe_nfe_v4_00 protNFe
        {
            get
            {
                return this.protNFeField;
            }
            set
            {
                this.protNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum Torig
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TProcEmi
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProcEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProcEvento_consSitNFe_v4_00
    {

        private TEvento_consSitNFe_v4_00 eventoField;
        private TRetEvento_consSitNFe_v4_00 retEventoField;
        private string versaoField;
        public TEvento_consSitNFe_v4_00 evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }

        public TRetEvento_consSitNFe_v4_00 retEvento
        {
            get
            {
                return this.retEventoField;
            }
            set
            {
                this.retEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProcEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("procEventoNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TProcEvento_procEventoNFe_v1_00
    {

        private TEvento_procEventoNFe_v1_00 eventoField;
        private TRetEvento_procEventoNFe_v1_00 retEventoField;
        private string versaoField;
        public TEvento_procEventoNFe_v1_00 evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }

        public TRetEvento_procEventoNFe_v1_00 retEvento
        {
            get
            {
                return this.retEventoField;
            }
            set
            {
                this.retEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProcEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("procEventoNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TProcEvento_procConfRecebtoNFe_v1_00
    {

        private TEvento_procConfRecebtoNFe_v1_00 eventoField;
        private TretEvento_procConfRecebtoNFe_v1_00 retEventoField;
        private string versaoField;
        public TEvento_procConfRecebtoNFe_v1_00 evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }

        public TretEvento_procConfRecebtoNFe_v1_00 retEvento
        {
            get
            {
                return this.retEventoField;
            }
            set
            {
                this.retEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("ProcInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TProcInutNFe
    {

        private TInutNFe inutNFeField;
        private TRetInutNFe retInutNFeField;
        private string versaoField;
        public TInutNFe inutNFe
        {
            get
            {
                return this.inutNFeField;
            }
            set
            {
                this.inutNFeField = value;
            }
        }

        public TRetInutNFe retInutNFe
        {
            get
            {
                return this.retInutNFeField;
            }
            set
            {
                this.retInutNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProtNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFe_nfe_v4_00
    {

        private TProtNFeInfProt_nfe_v4_00 infProtField;
        private SignatureType signatureField;
        private string versaoField;
        public TProtNFeInfProt_nfe_v4_00 infProt
        {
            get
            {
                return this.infProtField;
            }
            set
            {
                this.infProtField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProtNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFe_consReciNFe_v4_00
    {

        private TProtNFeInfProt_consReciNFe_v4_00 infProtField;
        private SignatureType signatureField;
        private string versaoField;
        public TProtNFeInfProt_consReciNFe_v4_00 infProt
        {
            get
            {
                return this.infProtField;
            }
            set
            {
                this.infProtField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProtNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFe_consSitNFe_v4_00
    {

        private TProtNFeInfProt_consSitNFe_v4_00 infProtField;
        private SignatureType signatureField;
        private string versaoField;
        public TProtNFeInfProt_consSitNFe_v4_00 infProt
        {
            get
            {
                return this.infProtField;
            }
            set
            {
                this.infProtField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProtNFeInfProt", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFeInfProt_nfe_v4_00
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string chNFeField;
        private string dhRecbtoField;
        private string nProtField;
        private byte[] digValField;
        private string cStatField;
        private string xMotivoField;
        private string cMsgField;
        private string xMsgField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public string cMsg
        {
            get
            {
                return this.cMsgField;
            }
            set
            {
                this.cMsgField = value;
            }
        }

        public string xMsg
        {
            get
            {
                return this.xMsgField;
            }
            set
            {
                this.xMsgField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProtNFeInfProt", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFeInfProt_consReciNFe_v4_00
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string chNFeField;
        private string dhRecbtoField;
        private string nProtField;
        private byte[] digValField;
        private string cStatField;
        private string xMotivoField;
        private string cMsgField;
        private string xMsgField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public string cMsg
        {
            get
            {
                return this.cMsgField;
            }
            set
            {
                this.cMsgField = value;
            }
        }

        public string xMsg
        {
            get
            {
                return this.xMsgField;
            }
            set
            {
                this.xMsgField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TProtNFeInfProt", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFeInfProt_consSitNFe_v4_00
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string chNFeField;
        private System.DateTime dhRecbtoField;
        private string nProtField;
        private byte[] digValField;
        private string cStatField;
        private string xMotivoField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class TransformType
    {

        private string[] xPathField;
        private TTransformURI algorithmField;
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public string[] XPath
        {
            get
            {
                return this.xPathField;
            }
            set
            {
                this.xPathField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetCancNFe
    {

        private TRetCancNFeInfCanc infCancField;
        private SignatureType signatureField;
        private string versaoField;
        public TRetCancNFeInfCanc infCanc
        {
            get
            {
                return this.infCancField;
            }
            set
            {
                this.infCancField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetCancNFeInfCanc
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private TCodUfIBGE cUFField;
        private string chNFeField;
        private System.DateTime dhRecbtoField;
        private bool dhRecbtoFieldSpecified;
        private string nProtField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified
        {
            get
            {
                return this.dhRecbtoFieldSpecified;
            }
            set
            {
                this.dhRecbtoFieldSpecified = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retConsNFeDest", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetConsNFeDest
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private System.DateTime dhRespField;
        private TRetConsNFeDestIndCont indContField;
        private bool indContFieldSpecified;
        private string ultNSUField;
        private TRetConsNFeDestRet[] retField;
        private TVeConsNFeDest versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public System.DateTime dhResp
        {
            get
            {
                return this.dhRespField;
            }
            set
            {
                this.dhRespField = value;
            }
        }

        public TRetConsNFeDestIndCont indCont
        {
            get
            {
                return this.indContField;
            }
            set
            {
                this.indContField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indContSpecified
        {
            get
            {
                return this.indContFieldSpecified;
            }
            set
            {
                this.indContFieldSpecified = value;
            }
        }

        public string ultNSU
        {
            get
            {
                return this.ultNSUField;
            }
            set
            {
                this.ultNSUField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ret")]
        public TRetConsNFeDestRet[] ret
        {
            get
            {
                return this.retField;
            }
            set
            {
                this.retField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVeConsNFeDest versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestIndCont
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetConsNFeDestRet
    {

        private object itemField;
        [System.Xml.Serialization.XmlElementAttribute("resCCe", typeof(TRetConsNFeDestRetResCCe))]
        [System.Xml.Serialization.XmlElementAttribute("resCanc", typeof(TRetConsNFeDestRetResCanc))]
        [System.Xml.Serialization.XmlElementAttribute("resNFe", typeof(TRetConsNFeDestRetResNFe))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetConsNFeDestRetResCanc
    {

        private string chNFeField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string xNomeField;
        private string ieField;
        private string dEmiField;
        private TRetConsNFeDestRetResCancTpNF tpNFField;
        private string vNFField;
        private string digValField;
        private System.DateTime dhRecbtoField;
        private TRetConsNFeDestRetResCancCSitNFe cSitNFeField;
        private TRetConsNFeDestRetResCancCSitConf cSitConfField;
        private string nSUField;
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }

        public TRetConsNFeDestRetResCancTpNF tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        public string vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }

        public string digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public TRetConsNFeDestRetResCancCSitNFe cSitNFe
        {
            get
            {
                return this.cSitNFeField;
            }
            set
            {
                this.cSitNFeField = value;
            }
        }

        public TRetConsNFeDestRetResCancCSitConf cSitConf
        {
            get
            {
                return this.cSitConfField;
            }
            set
            {
                this.cSitConfField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NSU
        {
            get
            {
                return this.nSUField;
            }
            set
            {
                this.nSUField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResCancCSitConf
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResCancCSitNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResCancTpNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetConsNFeDestRetResCCe
    {

        private string chNFeField;
        private string dhEventoField;
        private TRetConsNFeDestRetResCCeTpEvento tpEventoField;
        private string nSeqEventoField;
        private TRetConsNFeDestRetResCCeDescEvento descEventoField;
        private string xCorrecaoField;
        private TRetConsNFeDestRetResCCeTpNF tpNFField;
        private System.DateTime dhRecbtoField;
        private string nSUField;
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        public TRetConsNFeDestRetResCCeTpEvento tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public TRetConsNFeDestRetResCCeDescEvento descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }

        public string xCorrecao
        {
            get
            {
                return this.xCorrecaoField;
            }
            set
            {
                this.xCorrecaoField = value;
            }
        }

        public TRetConsNFeDestRetResCCeTpNF tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NSU
        {
            get
            {
                return this.nSUField;
            }
            set
            {
                this.nSUField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResCCeDescEvento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carta de Correção")]
        CartadeCorreção,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carta de Correcao")]
        CartadeCorrecao,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResCCeTpEvento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("110110")]
        Item110110,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResCCeTpNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetConsNFeDestRetResNFe
    {

        private string chNFeField;
        private string itemField;
        private TipoDoc itemElementNameField;
        private string xNomeField;
        private string ieField;
        private string dEmiField;
        private TRetConsNFeDestRetResNFeTpNF tpNFField;
        private string vNFField;
        private string digValField;
        private System.DateTime dhRecbtoField;
        private TRetConsNFeDestRetResNFeCSitNFe cSitNFeField;
        private TRetConsNFeDestRetResNFeCSitConf cSitConfField;
        private string nSUField;
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDoc ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }

        public TRetConsNFeDestRetResNFeTpNF tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        public string vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }

        public string digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public TRetConsNFeDestRetResNFeCSitNFe cSitNFe
        {
            get
            {
                return this.cSitNFeField;
            }
            set
            {
                this.cSitNFeField = value;
            }
        }

        public TRetConsNFeDestRetResNFeCSitConf cSitConf
        {
            get
            {
                return this.cSitConfField;
            }
            set
            {
                this.cSitConfField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NSU
        {
            get
            {
                return this.nSUField;
            }
            set
            {
                this.nSUField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResNFeCSitConf
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResNFeCSitNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TRetConsNFeDestRetResNFeTpNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retConsReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetConsReciNFe
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string nRecField;
        private string cStatField;
        private string xMotivoField;
        private TCodUfIBGE cUFField;
        private string dhRecbtoField;
        private string cMsgField;
        private string xMsgField;
        private TProtNFe_consReciNFe_v4_00[] protNFeField;
        private string versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string nRec
        {
            get
            {
                return this.nRecField;
            }
            set
            {
                this.nRecField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string cMsg
        {
            get
            {
                return this.cMsgField;
            }
            set
            {
                this.cMsgField = value;
            }
        }

        public string xMsg
        {
            get
            {
                return this.xMsgField;
            }
            set
            {
                this.xMsgField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("protNFe")]
        public TProtNFe_consReciNFe_v4_00[] protNFe
        {
            get
            {
                return this.protNFeField;
            }
            set
            {
                this.protNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retConsSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetConsSitNFe
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private TCodUfIBGE cUFField;
        private string dhRecbtoField;
        private string chNFeField;
        private TProtNFe_consSitNFe_v4_00 protNFeField;
        private TRetCancNFe retCancNFeField;
        private TProcEvento_consSitNFe_v4_00[] procEventoNFeField;
        private TVerConsSitNFe versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public TProtNFe_consSitNFe_v4_00 protNFe
        {
            get
            {
                return this.protNFeField;
            }
            set
            {
                this.protNFeField = value;
            }
        }

        public TRetCancNFe retCancNFe
        {
            get
            {
                return this.retCancNFeField;
            }
            set
            {
                this.retCancNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("procEventoNFe")]
        public TProcEvento_consSitNFe_v4_00[] procEventoNFe
        {
            get
            {
                return this.procEventoNFeField;
            }
            set
            {
                this.procEventoNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerConsSitNFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retConsStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetConsStatServ
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private TCodUfIBGE cUFField;
        private string dhRecbtoField;
        private string tMedField;
        private string dhRetornoField;
        private string xObsField;
        private string versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string tMed
        {
            get
            {
                return this.tMedField;
            }
            set
            {
                this.tMedField = value;
            }
        }

        public string dhRetorno
        {
            get
            {
                return this.dhRetornoField;
            }
            set
            {
                this.dhRetornoField = value;
            }
        }

        public string xObs
        {
            get
            {
                return this.xObsField;
            }
            set
            {
                this.xObsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retDownloadNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetDownloadNFe
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private System.DateTime dhRespField;
        private TRetDownloadNFeRetNFe[] retNFeField;
        private TVerDownloadNFe versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public System.DateTime dhResp
        {
            get
            {
                return this.dhRespField;
            }
            set
            {
                this.dhRespField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("retNFe")]
        public TRetDownloadNFeRetNFe[] retNFe
        {
            get
            {
                return this.retNFeField;
            }
            set
            {
                this.retNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerDownloadNFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetDownloadNFeRetNFe
    {

        private string chNFeField;
        private string cStatField;
        private string xMotivoField;
        private object itemField;
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("procNFe", typeof(TRetDownloadNFeRetNFeProcNFe))]
        [System.Xml.Serialization.XmlElementAttribute("procNFeGrupoZip", typeof(TRetDownloadNFeRetNFeProcNFeGrupoZip))]
        [System.Xml.Serialization.XmlElementAttribute("procNFeZip", typeof(byte[]), DataType = "base64Binary")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetDownloadNFeRetNFeProcNFe
    {

        private System.Xml.XmlElement anyField;
        private string schemaField;
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetDownloadNFeRetNFeProcNFeGrupoZip
    {

        private byte[] nFeZipField;
        private byte[] protNFeZipField;
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] NFeZip
        {
            get
            {
                return this.nFeZipField;
            }
            set
            {
                this.nFeZipField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] protNFeZip
        {
            get
            {
                return this.protNFeZipField;
            }
            set
            {
                this.protNFeZipField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TRetEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetEnvEvento_confRecebto_v1_00
    {

        private string idLoteField;
        private TAmb tpAmbField;
        private string verAplicField;
        private TCOrgaoIBGE cOrgaoField;
        private string cStatField;
        private string xMotivoField;
        private TretEvento_confRecebto_v1_00[] retEventoField;
        private string versaoField;
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("retEvento")]
        public TretEvento_confRecebto_v1_00[] retEvento
        {
            get
            {
                return this.retEventoField;
            }
            set
            {
                this.retEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TRetEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetEnvEvento_retEnvEvento_v1_00
    {

        private string idLoteField;
        private TAmb tpAmbField;
        private string verAplicField;
        private TCOrgaoIBGE cOrgaoField;
        private string cStatField;
        private string xMotivoField;
        private TRetEvento_retEnvEvento_v1_00[] retEventoField;
        private string versaoField;
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("retEvento")]
        public TRetEvento_retEnvEvento_v1_00[] retEvento
        {
            get
            {
                return this.retEventoField;
            }
            set
            {
                this.retEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetEnviNFe
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private TCodUfIBGE cUFField;
        private string dhRecbtoField;
        private object itemField;
        private string versaoField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("infRec", typeof(TRetEnviNFeInfRec))]
        [System.Xml.Serialization.XmlElementAttribute("protNFe", typeof(TProtNFe_nfe_v4_00))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetEnviNFeInfRec
    {

        private string nRecField;
        private string tMedField;
        public string nRec
        {
            get
            {
                return this.nRecField;
            }
            set
            {
                this.nRecField = value;
            }
        }

        public string tMed
        {
            get
            {
                return this.tMedField;
            }
            set
            {
                this.tMedField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TRetEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEvento_consSitNFe_v4_00
    {

        private TRetEventoInfEvento_consSitNFe_v4_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TRetEventoInfEvento_consSitNFe_v4_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TretEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEvento_confRecebto_v1_00
    {

        private TretEventoInfEvento_confRecebto_v1_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TretEventoInfEvento_confRecebto_v1_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TRetEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEvento_retEnvEvento_v1_00
    {

        private TRetEventoInfEvento_retEnvEvento_v1_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TRetEventoInfEvento_retEnvEvento_v1_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TRetEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEvento_procEventoNFe_v1_00
    {

        private TRetEventoInfEvento_procEventoNFe_v1_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TRetEventoInfEvento_procEventoNFe_v1_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TretEvento", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEvento_procConfRecebtoNFe_v1_00
    {

        private TretEventoInfEvento_procConfRecebtoNFe_v1_00 infEventoField;
        private SignatureType signatureField;
        private string versaoField;
        public TretEventoInfEvento_procConfRecebtoNFe_v1_00 infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TRetEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEventoInfEvento_consSitNFe_v4_00
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private TCOrgaoIBGE cOrgaoField;
        private string cStatField;
        private string xMotivoField;
        private string chNFeField;
        private string tpEventoField;
        private string xEventoField;
        private string nSeqEventoField;
        private string itemField;
        private TipoDocDest itemElementNameField;
        private string emailDestField;
        private string dhRegEventoField;
        private string nProtField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string xEvento
        {
            get
            {
                return this.xEventoField;
            }
            set
            {
                this.xEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocDest ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string emailDest
        {
            get
            {
                return this.emailDestField;
            }
            set
            {
                this.emailDestField = value;
            }
        }

        public string dhRegEvento
        {
            get
            {
                return this.dhRegEventoField;
            }
            set
            {
                this.dhRegEventoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TretEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEventoInfEvento_confRecebto_v1_00
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private TCOrgaoIBGE cOrgaoField;
        private string cStatField;
        private string xMotivoField;
        private string chNFeField;
        private string tpEventoField;
        private string xEventoField;
        private string nSeqEventoField;
        private string itemField;
        private TipoDocDest itemElementNameField;
        private string emailDestField;
        private string dhRegEventoField;
        private string nProtField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string xEvento
        {
            get
            {
                return this.xEventoField;
            }
            set
            {
                this.xEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocDest ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string emailDest
        {
            get
            {
                return this.emailDestField;
            }
            set
            {
                this.emailDestField = value;
            }
        }

        public string dhRegEvento
        {
            get
            {
                return this.dhRegEventoField;
            }
            set
            {
                this.dhRegEventoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TRetEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEventoInfEvento_retEnvEvento_v1_00
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private TCOrgaoIBGE cOrgaoField;
        private string cStatField;
        private string xMotivoField;
        private string chNFeField;
        private string tpEventoField;
        private string xEventoField;
        private string nSeqEventoField;
        private TCOrgaoIBGE cOrgaoAutorField;
        private bool cOrgaoAutorFieldSpecified;
        private string itemField;
        private TipoDocDest itemElementNameField;
        private string emailDestField;
        private string dhRegEventoField;
        private string nProtField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string xEvento
        {
            get
            {
                return this.xEventoField;
            }
            set
            {
                this.xEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public TCOrgaoIBGE cOrgaoAutor
        {
            get
            {
                return this.cOrgaoAutorField;
            }
            set
            {
                this.cOrgaoAutorField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cOrgaoAutorSpecified
        {
            get
            {
                return this.cOrgaoAutorFieldSpecified;
            }
            set
            {
                this.cOrgaoAutorFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocDest ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string emailDest
        {
            get
            {
                return this.emailDestField;
            }
            set
            {
                this.emailDestField = value;
            }
        }

        public string dhRegEvento
        {
            get
            {
                return this.dhRegEventoField;
            }
            set
            {
                this.dhRegEventoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TRetEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEventoInfEvento_procEventoNFe_v1_00
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private TCOrgaoIBGE cOrgaoField;
        private string cStatField;
        private string xMotivoField;
        private string chNFeField;
        private string tpEventoField;
        private string xEventoField;
        private string nSeqEventoField;
        private TCOrgaoIBGE cOrgaoAutorField;
        private bool cOrgaoAutorFieldSpecified;
        private string itemField;
        private TipoDocDest itemElementNameField;
        private string emailDestField;
        private string dhRegEventoField;
        private string nProtField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string xEvento
        {
            get
            {
                return this.xEventoField;
            }
            set
            {
                this.xEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        public TCOrgaoIBGE cOrgaoAutor
        {
            get
            {
                return this.cOrgaoAutorField;
            }
            set
            {
                this.cOrgaoAutorField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cOrgaoAutorSpecified
        {
            get
            {
                return this.cOrgaoAutorFieldSpecified;
            }
            set
            {
                this.cOrgaoAutorFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocDest ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string emailDest
        {
            get
            {
                return this.emailDestField;
            }
            set
            {
                this.emailDestField = value;
            }
        }

        public string dhRegEvento
        {
            get
            {
                return this.dhRegEventoField;
            }
            set
            {
                this.dhRegEventoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TretEventoInfEvento", AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEventoInfEvento_procConfRecebtoNFe_v1_00
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private TCOrgaoIBGE cOrgaoField;
        private string cStatField;
        private string xMotivoField;
        private string chNFeField;
        private string tpEventoField;
        private string xEventoField;
        private string nSeqEventoField;
        private string itemField;
        private TipoDocDest itemElementNameField;
        private string emailDestField;
        private string dhRegEventoField;
        private string nProtField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        public string xEvento
        {
            get
            {
                return this.xEventoField;
            }
            set
            {
                this.xEventoField = value;
            }
        }

        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocDest ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        public string emailDest
        {
            get
            {
                return this.emailDestField;
            }
            set
            {
                this.emailDestField = value;
            }
        }

        public string dhRegEvento
        {
            get
            {
                return this.dhRegEventoField;
            }
            set
            {
                this.dhRegEventoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]

    public partial class TRetInutNFe
    {

        private TRetInutNFeInfInut infInutField;
        private SignatureType signatureField;
        private string versaoField;
        public TRetInutNFeInfInut infInut
        {
            get
            {
                return this.infInutField;
            }
            set
            {
                this.infInutField = value;
            }
        }

        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TRetInutNFeInfInut
    {

        private TAmb tpAmbField;
        private string verAplicField;
        private string cStatField;
        private string xMotivoField;
        private TCodUfIBGE cUFField;
        private string anoField;
        private string cNPJField;
        private TMod modField;
        private bool modFieldSpecified;
        private string serieField;
        private string nNFIniField;
        private string nNFFinField;
        private string dhRecbtoField;
        private string nProtField;
        private string idField;
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        public string ano
        {
            get
            {
                return this.anoField;
            }
            set
            {
                this.anoField = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        public TMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modSpecified
        {
            get
            {
                return this.modFieldSpecified;
            }
            set
            {
                this.modFieldSpecified = value;
            }
        }

        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        public string nNFIni
        {
            get
            {
                return this.nNFIniField;
            }
            set
            {
                this.nNFIniField = value;
            }
        }

        public string nNFFin
        {
            get
            {
                return this.nNFFinField;
            }
            set
            {
                this.nNFFinField = value;
            }
        }

        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public enum TTransformURI
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TUf
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,

        /// <remarks/>
        EX,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TUfEmi
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TVeConsNFeDest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.01")]
        Item101,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public partial class TVeiculo
    {

        private string placaField;
        private TUf ufField;
        private string rNTCField;
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
            }
        }

        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        public string RNTC
        {
            get
            {
                return this.rNTCField;
            }
            set
            {
                this.rNTCField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TVerConsSitNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4.00")]
        Item400,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TVerDistDFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.01")]
        Item101,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TVerDownloadNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TVerResEvento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.01")]
        Item101,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]

    public enum TVerResNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.01")]
        Item101,

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]

    public partial class X509DataType
    {

        private byte[] x509CertificateField;
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }

    }

}