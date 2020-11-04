using System;
using System.IO;
using System.Text;

namespace CSharpIOStreams
{
    partial class Program
    {
        static void DealingDirectlyWithFileStream()
        {
            using var fileStream = new FileStream("accounts.txt", FileMode.Open);

            var buffer = new byte[1024];

            fileStream.Read(buffer, 0, 1024);

            var sizeBytesRead = -1;

            while (sizeBytesRead != 0)
            {
                sizeBytesRead = fileStream.Read(buffer, 0, 1024);
                WriteBuffer(buffer, sizeBytesRead);
            }
        }

        private static void WriteBuffer(byte[] buffer, int sizeBytesRead)
        {
            //Get default encoding into operational system
            var utf8 = Encoding.Default;

            var text = utf8.GetString(buffer, 0, sizeBytesRead);
            Console.Write(text);
        }
    }

}
