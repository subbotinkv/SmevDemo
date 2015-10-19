namespace Common
{
    using System.Runtime.Serialization;

    [DataContract]
    public enum StatusType
    {
        [EnumMember]
        REQUEST,

        [EnumMember]
        RESULT,

        [EnumMember]
        REJECT,

        [EnumMember]
        INVALID,

        [EnumMember]
        ACCEPT,

        [EnumMember]
        PING,

        [EnumMember]
        PROCESS,

        [EnumMember]
        NOTIFY,

        [EnumMember]
        FAILURE,

        [EnumMember]
        CANCEL,

        [EnumMember]
        STATE,

        [EnumMember]
        PACKET
    }
}