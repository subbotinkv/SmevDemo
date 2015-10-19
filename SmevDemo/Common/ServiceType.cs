namespace Common
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ServiceType
    {
        [DataMember(Order = 0)]
        public string Mnemonic { get; set; }

        [DataMember(Order = 1)]
        public string Version { get; set; }
    }
}