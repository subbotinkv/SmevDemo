namespace Client
{
    using System;
    using System.Text;

    using SmevServiceReference;

    class Program
    {
        static void Main(string[] args)
        {
            GetDataFromService();
        }

        private static async void GetDataFromService()
        {
            try
            {
                using (var client = new SmevServiceDemoClient("SmevServiceDemo"))
                {
                    Console.WriteLine("Send request...");

                    Response result = await client.TestMethodAsync(CreateRequest());

                    Console.WriteLine("Service response: {0}", result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(FormatErrorMessage(ex));
            }

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

        private static Request CreateRequest()
        {
            // Message.
            var message = new MessageType
            {
                Sender = new orgExternalType {Code = "CPCL22015", Name = "CryptoProSmevClient"},
                Originator = new orgExternalType {Code = "CPCL22015", Name = "CryptoProSmevClient"},
                Recipient = new orgExternalType {Code = "CPCL22015", Name = "CryptoProSmevService"},
                ServiceCode = "01",
                TypeCode = TypeCodeType.OTHR,
                Status = StatusType.REQUEST,
                Date = DateTime.Now,
                ExchangeType = "2",
                TestMsg = string.Empty,
                RequestIdRef = string.Empty,
                OriginRequestIdRef = string.Empty,
                CaseNumber = string.Empty,
                OKTMO = string.Empty
            };

            // Submessages.
            message.SubMessages = new[]
            {
                new SubMessage
                {
                    Originator = new orgExternalType {Code = "CPCL22015", Name = "CryptoProSmevClient"},
                    Date = DateTime.Now,
                    CaseNumber = "01",
                    OriginRequestIdRef = string.Empty,
                    RequestIdRef = string.Empty,
                    ServiceCode = "03",
                    Status = StatusType.PACKET,
                    SubRequestNumber = "014867"
                }
            };

            // Data.
            var data = new MessageDataType
            {
                AppData = new AppDataType(),
                AppDocument = new AppDocumentType {RequestCode = $"reg_{Guid.NewGuid().ToString("D")}", BinaryData = Encoding.UTF8.GetBytes("Test client document")}
            };

            return new Request {Message = message, MessageData = data};
        }

        private static string FormatErrorMessage(Exception ex)
        {
            string errMsg = string.Empty;

            while (ex != null)
            {
                errMsg += $"Error: {ex.Message}; Type: {ex.GetType().Name}\r\n";
                ex = ex.InnerException;
            }

            return errMsg;
        }
    }
}
