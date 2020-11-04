using System;
using System.IO;
using System.Text;
using CSharpIOStreams.Models;

namespace CSharpIOStreams
{
    partial class Program
    {
        static void CreateFileWithoutStream()
        {
            using var fileStream = new FileStream("exported_accounts.txt", FileMode.Create);

            const string accountsString = "456,78945,4785.50,Gustavo Santos";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(accountsString);
            
            fileStream.Write(bytes);
        }

        static void CreateFileWithStream()
        {
            using var fileStream = new FileStream("exported_accounts.txt", FileMode.Create);
            using var writer = new StreamWriter(fileStream, Encoding.UTF8);

            const string accountsString = "456,78945,4785.50,Gustavo Santos";
            writer.Write(accountsString);
        }
    }
}
