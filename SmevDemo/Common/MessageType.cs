namespace Common
{
    using System;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [DataContract]
    public class MessageType
    {
        [XmlElement(Order = 0)]
        [DataMember(Order = 0, IsRequired = true)]
        public OrgExternalType Sender { get; set; }

        [DataMember(Order = 1, IsRequired = true)]
        public OrgExternalType Recipient { get; set; }

        [DataMember(Order = 2, IsRequired = true)]
        public OrgExternalType Originator { get; set; }

        [XmlElement("Service", typeof(ServiceType), Order = 3)]
        [XmlElement("ServiceName", typeof(string), Order = 3)]
        public object Item { get; set; }

        [DataMember(Order = 4)]
        public TypeCodeType TypeCode { get; set; }

        [DataMember(Order = 5)]
        public StatusType Status { get; set; }

        [DataMember(Order = 6)]
        public DateTime Date { get; set; }

        [DataMember(Order = 7)]
        public string ExchangeType { get; set; }

        [DataMember(Order = 8)]
        public string RequestIdRef { get; set; }

        [DataMember(Order = 9)]
        public string OriginRequestIdRef { get; set; }

        [DataMember(Order = 10)]
        public string ServiceCode { get; set; }

        [DataMember(Order = 11)]
        public string CaseNumber { get; set; }

        [DataMember(Order = 12, IsRequired = true)]
        public SubMessageType[] SubMessages { get; set; }

        [DataMember(Order = 13)]
        public string TestMsg { get; set; }

        [DataMember(Order = 14)]
        public string OKTMO { get; set; }
    }
}