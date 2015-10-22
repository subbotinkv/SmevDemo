namespace SmevClient
{
    using System;
    using System.Text;
    using SmevServiceReference;

    class Program
    {
        private static void Main(string[] args)
        {
            using (var client = new SmevDemoServiceClient())
            {
                Request request = GetRequest();

                try
                {
                    client.SampleMethod(ref request.Message, ref request.MessageData);
                }
                catch (Exception e)
                {
                    Console.WriteLine(FormatErrorMessage(e));
                }
            }

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

        /// <summary>
        /// Сформировать тестовый запрос.
        /// </summary>
        /// <returns></returns>
        private static Request GetRequest()
        {
            var request = new Request();

            request.Message = new MessageType();

            request.Message.Sender = new orgExternalType {Code = "CPCL22015", Name = "CryptoProSmevClient"};
            request.Message.Originator = new orgExternalType {Code = "CPCL22015", Name = "CryptoProSmevClient"};
            request.Message.Recipient = new orgExternalType {Code = "CPCL22015", Name = "CryptoProSmevService"};

            request.Message.ServiceCode = "01";
            request.Message.TypeCode = TypeCodeType.OTHR;
            request.Message.Status = StatusType.REQUEST;
            request.Message.Date = DateTime.Now;
            request.Message.ExchangeType = "2";
            request.Message.TestMsg = string.Empty;

            request.Message.RequestIdRef = string.Empty;
            request.Message.OriginRequestIdRef = string.Empty;
            request.Message.ServiceCode = string.Empty;
            request.Message.CaseNumber = string.Empty;
            request.Message.OKTMO = string.Empty;

            var subMsg = new SubMessage();
            subMsg.Originator = new orgExternalType {Code = "CPCL22015", Name = "CryptoProSmevClient"};
            subMsg.Date = DateTime.Now;
            subMsg.CaseNumber = "01";
            subMsg.OriginRequestIdRef = string.Empty;
            subMsg.RequestIdRef = string.Empty;
            subMsg.ServiceCode = "03";
            subMsg.Status = StatusType.PACKET;
            subMsg.SubRequestNumber = "014867";

            request.Message.SubMessages = new[] {subMsg};

            request.MessageData = new MessageDataType();
            request.MessageData.AppData = new AppDataType();

            request.MessageData.AppDocument = new AppDocumentType();
            request.MessageData.AppDocument.RequestCode = "reg_" + Guid.NewGuid().ToString("D");

            byte[] clientDocument = Encoding.UTF8.GetBytes("Test client document");
            request.MessageData.AppDocument.BinaryData = clientDocument;
            return request;
        }

        /// <summary>
        /// Сформировать сообщение об ошибке.
        /// </summary>
        /// <param name="exc">Исключение</param>
        /// <returns>Сообщение об ошибке</returns>
        private static string FormatErrorMessage(Exception exc)
        {
            string errMsg = string.Empty;

            while (exc != null)
            {
                errMsg += string.Format("Error: {0}; Type: {1}\r\n", exc.Message, exc.GetType().Name);
                exc = exc.InnerException;
            }

            return errMsg;
        }
    }
}
