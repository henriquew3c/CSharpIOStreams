using System;
using System.IO;
using System.Text;
using CSharpIOStreams.Models;

namespace CSharpIOStreams
{
    partial class Program
    {

        static void UseInputStream()
        {
            using var inputStream = Console.OpenStandardInput();

            var buffer = new byte[1024];

            while (true)
            {
                var readBytes = inputStream.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes read in console: {readBytes}");
            }
           
        }

        static void UseInputStreamAndStoreFile()
        {
            using var inputStream = Console.OpenStandardInput();
            using var fileStream = new FileStream("inputConsole.txt", FileMode.Create);

            var buffer = new byte[1024];

            while (true)
            {
                Console.WriteLine("Insert input:");

                var readBytes = inputStream.Read(buffer, 0, 1024);

                fileStream.Write(buffer, 0, readBytes);
                fileStream.Flush();

                Console.WriteLine($"Bytes read in console: {readBytes}");
            }
        }

    }
}
