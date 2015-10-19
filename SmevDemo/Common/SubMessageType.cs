namespace Common
{
    using System;
    using System.Runtime.Serialization;

    [DataContract(Name = "SubMessage")]
    public class SubMessageType
    {
        [DataMember(Order = 0)]
        public string SubRequestNumber { get; set; }

        [DataMember(Order = 1)]
        public StatusType Status { get; set; }

        [DataMember(Order = 2)]
        public OrgExternalType Originator { get; set; }

        [DataMember(Order = 3)]
        public DateTime Date { get; set; }

        [DataMember(Order = 4)]
        public string RequestIdRef { get; set; }

        [DataMember(Order = 5)]
        public string OriginRequestIdRef { get; set; }

        [DataMember(Order = 6)]
        public string ServiceCode { get; set; }

        [DataMember(Order = 7)]
        public string CaseNumber { get; set; }
    }
}