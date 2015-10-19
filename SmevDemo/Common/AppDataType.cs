namespace Common
{
    using System.Runtime.Serialization;
    using System.Xml;

    [DataContract]
    public class AppDataType
    {
        [DataMember(Order = 0)]
        public XmlElement[] Any { get; set; }
    }
}