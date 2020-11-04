using System;
using System.IO;
using System.Text;
using CSharpIOStreams.Models;

namespace CSharpIOStreams
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //uncomment to test

            //DealingDirectlyWithFileStream();
            //UsingStreamReader();
            //ReadFileStreamAndConvertToCurrentAccount();
            //CreateFileWithoutStream();
            //CreateFileWithStream();

            //WriteBinary();
            //ReadBinary();

            //UseInputStream();
            UseInputStreamAndStoreFile();

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
