using System.Xml;
using System.Xml.Serialization;

namespace SefazSchemasClasses;

// Preserve extension groups without pretending they have already been mapped to business rules.
// Original signed XML must be retained; serializing these objects is not an archival substitute.
public partial class TNFeInfNFe
{
    [XmlAnyElement] public XmlElement[]? ExtensionElements { get; set; }
}
public partial class TNFeInfNFeDet
{
    [XmlAnyElement] public XmlElement[]? ExtensionElements { get; set; }
}
public partial class TNFeInfNFeDetImposto
{
    [XmlAnyElement] public XmlElement[]? ExtensionElements { get; set; }
}
public partial class TNFeInfNFeTotal
{
    [XmlAnyElement] public XmlElement[]? ExtensionElements { get; set; }
}
