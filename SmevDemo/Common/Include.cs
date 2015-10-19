namespace Common
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2004/08/xop/include")]
    [XmlRoot(Namespace = "http://www.w3.org/2004/08/xop/include", IsNullable = false)]
    public class Include
    {
        [XmlAnyElement(Order = 0)]
        public XmlElement[] Any { get; set; }
        
        [XmlAttribute(DataType = "anyURI",AttributeName = "href")]
        public string Href { get; set; }
        
        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttr { get; set; }
    }
}