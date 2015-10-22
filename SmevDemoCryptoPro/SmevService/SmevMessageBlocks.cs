#pragma warning disable
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute(
                                            "http://smev.gosuslugi.ru/rev120315",
                                            ClrNamespace = "SmevService")]

namespace SmevService
{
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [System.Xml.Serialization.XmlRootAttribute("Header", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public partial class HeaderType
    {

        private string nodeIdField;

        private string messageIdField;

        private System.DateTime timeStampField;

        private MessageClassType messageClassField;

        private PacketIdType[] packetIdsField;

        private string actorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NodeId
        {
            get
            {
                return this.nodeIdField;
            }
            set
            {
                this.nodeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string MessageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public MessageClassType MessageClass
        {
            get
            {
                return this.messageClassField;
            }
            set
            {
                this.messageClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Id", IsNullable = false)]
        public PacketIdType[] PacketIds
        {
            get
            {
                return this.packetIdsField;
            }
            set
            {
                this.packetIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string actor
        {
            get
            {
                return this.actorField;
            }
            set
            {
                this.actorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [System.Xml.Serialization.XmlRootAttribute("MessageClass", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public enum MessageClassType
    {

        /// <remarks/>
        REQUEST,

        /// <remarks/>
        RESPONSE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [System.Xml.Serialization.XmlRootAttribute("Id", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public partial class PacketIdType
    {

        private string messageIdField;

        private string subRequestNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string MessageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string SubRequestNumber
        {
            get
            {
                return this.subRequestNumberField;
            }
            set
            {
                this.subRequestNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2004/08/xop/include")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2004/08/xop/include", IsNullable = false)]
    public partial class Include
    {

        private System.Xml.XmlElement[] anyField;

        private string hrefField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [System.Xml.Serialization.XmlRootAttribute("BaseMessage", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public partial class BaseMessageType
    {

        private MessageType messageField;

        private MessageDataType messageDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public MessageType Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public MessageDataType MessageData
        {
            get
            {
                return this.messageDataField;
            }
            set
            {
                this.messageDataField = value;
            }
        }
    }

    [DataContract]
    public partial class MessageType
    {

        private orgExternalType senderField;

        private orgExternalType recipientField;

        private orgExternalType originatorField;

        private object itemField;

        private TypeCodeType typeCodeField;

        private StatusType statusField;

        private System.DateTime dateField;

        private string exchangeTypeField;

        private string requestIdRefField;

        private string originRequestIdRefField;

        private string serviceCodeField;

        private string caseNumberField;

        private SubMessageType[] subMessagesField;

        private string testMsgField;

        private string oKTMOField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [DataMember(Order = 0, IsRequired = true)]
        public orgExternalType Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 1, IsRequired = true)]
        public orgExternalType Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 2, IsRequired = true)]
        public orgExternalType Originator
        {
            get
            {
                return this.originatorField;
            }
            set
            {
                this.originatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service", typeof(ServiceType), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("ServiceName", typeof(string), Order = 3)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 4)]
        public TypeCodeType TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 5)]
        public StatusType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 6)]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 7)]
        public string ExchangeType
        {
            get
            {
                return this.exchangeTypeField;
            }
            set
            {
                this.exchangeTypeField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 8)]
        public string RequestIdRef
        {
            get
            {
                return this.requestIdRefField;
            }
            set
            {
                this.requestIdRefField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 9)]
        public string OriginRequestIdRef
        {
            get
            {
                return this.originRequestIdRefField;
            }
            set
            {
                this.originRequestIdRefField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 10)]
        public string ServiceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 11)]
        public string CaseNumber
        {
            get
            {
                return this.caseNumberField;
            }
            set
            {
                this.caseNumberField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 12, IsRequired = true)]
        public SubMessageType[] SubMessages
        {
            get
            {
                return this.subMessagesField;
            }
            set
            {
                this.subMessagesField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 13)]
        public string TestMsg
        {
            get
            {
                return this.testMsgField;
            }
            set
            {
                this.testMsgField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 14)]
        public string OKTMO
        {
            get
            {
                return this.oKTMOField;
            }
            set
            {
                this.oKTMOField = value;
            }
        }
    }

    [DataContract]
    public partial class orgExternalType
    {

        private string codeField;

        private string nameField;

        /// <remarks/>
        [DataMember(Order = 0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    [DataContract]
    public partial class ServiceType
    {

        private string mnemonicField;

        private string versionField;

        /// <remarks/>
        [DataMember(Order = 0)]
        public string Mnemonic
        {
            get
            {
                return this.mnemonicField;
            }
            set
            {
                this.mnemonicField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 1)]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    [DataContract]
    public enum TypeCodeType
    {

        [EnumMember]
        GSRV,

        [EnumMember]
        GFNC,

        [EnumMember]
        OTHR,
    }

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
        PACKET,
    }

    [DataContract(Name = "SubMessage")]
    public partial class SubMessageType
    {

        private string subRequestNumberField;

        private StatusType statusField;

        private orgExternalType originatorField;

        private System.DateTime dateField;

        private string requestIdRefField;

        private string originRequestIdRefField;

        private string serviceCodeField;

        private string caseNumberField;

        /// <remarks/>
        [DataMember(Order = 0)]
        public string SubRequestNumber
        {
            get
            {
                return this.subRequestNumberField;
            }
            set
            {
                this.subRequestNumberField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 1)]
        public StatusType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 2)]
        public orgExternalType Originator
        {
            get
            {
                return this.originatorField;
            }
            set
            {
                this.originatorField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 3)]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 4)]
        public string RequestIdRef
        {
            get
            {
                return this.requestIdRefField;
            }
            set
            {
                this.requestIdRefField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 5)]
        public string OriginRequestIdRef
        {
            get
            {
                return this.originRequestIdRefField;
            }
            set
            {
                this.originRequestIdRefField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 6)]
        public string ServiceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 7)]
        public string CaseNumber
        {
            get
            {
                return this.caseNumberField;
            }
            set
            {
                this.caseNumberField = value;
            }
        }
    }

    [DataContract]
    public partial class MessageDataType
    {

        private AppDataType appDataField;

        private AppDocumentType appDocumentField;

        /// <remarks/>
        [DataMember(Order = 0)]
        public AppDataType AppData
        {
            get
            {
                return this.appDataField;
            }
            set
            {
                this.appDataField = value;
            }
        }

        /// <remarks/>
        [DataMember(Order = 1)]
        public AppDocumentType AppDocument
        {
            get
            {
                return this.appDocumentField;
            }
            set
            {
                this.appDocumentField = value;
            }
        }
    }

    /// <remarks/>
    [DataContract]
    public partial class AppDataType
    {

        private System.Xml.XmlElement[] anyField;

        /// <remarks/>
        [DataMember(Order = 0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [DataContract]
    public partial class AppDocumentType
    {

        private string requestCodeField;

        private byte[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [DataMember(Order = 0)]
        public string RequestCode
        {
            get
            {
                return this.requestCodeField;
            }
            set
            {
                this.requestCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryData", typeof(byte[]), DataType = "base64Binary", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("DigestValue", typeof(byte[]), DataType = "base64Binary", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(ReferenceType), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        [DataMember(Order = 1, Name = "BinaryData")]
        public byte[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [System.Xml.Serialization.XmlRootAttribute("Reference", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public partial class ReferenceType
    {

        private Include includeField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2004/08/xop/include", Order = 0)]
        public Include Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smev.gosuslugi.ru/rev120315", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        BinaryData,

        /// <remarks/>
        DigestValue,

        /// <remarks/>
        Reference,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [System.Xml.Serialization.XmlRootAttribute("SubMessages", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public partial class SubMessagesType
    {

        private SubMessageType[] subMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubMessage", Order = 0)]
        public SubMessageType[] SubMessage
        {
            get
            {
                return this.subMessageField;
            }
            set
            {
                this.subMessageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [System.Xml.Serialization.XmlRootAttribute("PacketIds", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public partial class PacketIdsType
    {

        private PacketIdType[] idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id", Order = 0)]
        public PacketIdType[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}
#pragma warning enable