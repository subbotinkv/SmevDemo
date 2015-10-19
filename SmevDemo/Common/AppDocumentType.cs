namespace Common
{
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [DataContract]
    public class AppDocumentType
    {
        [DataMember(Order = 0)]
        public string RequestCode { get; set; }

        [XmlElement("BinaryData", typeof(byte[]), DataType = "base64Binary", Order = 1)]
        [XmlElement("DigestValue", typeof(byte[]), DataType = "base64Binary", Order = 1)]
        [XmlElement("Reference", typeof(ReferenceType), Order = 1)]
        [XmlChoiceIdentifier("ItemsElementName")]
        [DataMember(Order = 1, Name = "BinaryData")]
        public byte[] Items { get; set; }

        [XmlElement("ItemsElementName", Order = 2)]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName { get; set; }
    }
}