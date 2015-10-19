namespace Common
{
    using System.Runtime.Serialization;

    [DataContract(Name = "orgExternalType")]
    public class OrgExternalType
    {
        [DataMember(Order = 0)]
        public string Code { get; set; }

        [DataMember(Order = 1)]
        public string Name { get; set; }
    }
}