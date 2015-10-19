namespace Common
{
    using System.Runtime.Serialization;

    [DataContract]
    public enum TypeCodeType
    {
        [EnumMember]
        GSRV,

        [EnumMember]
        GFNC,

        [EnumMember]
        OTHR
    }
}