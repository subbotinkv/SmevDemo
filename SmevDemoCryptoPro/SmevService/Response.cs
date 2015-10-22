namespace SmevService
{
    using System.ServiceModel;

    [MessageContract(IsWrapped = true, WrapperName = "SmevDemoResponse")]
    public class Response
    {
        [MessageBodyMember]
        public MessageType Message { get; set; }

        [MessageBodyMember]
        public MessageDataType MessageData { get; set; }
    }
}