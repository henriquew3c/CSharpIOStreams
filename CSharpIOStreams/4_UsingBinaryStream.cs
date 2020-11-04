using System;
using System.IO;
using System.Text;
using CSharpIOStreams.Models;

namespace CSharpIOStreams
{
    partial class Program
    {
        static void WriteBinary()
        {
            using var fileStream = new FileStream("current_account.txt", FileMode.Create);
            using var writer = new BinaryWriter(fileStream);

            writer.Write(456);                  //agency of current account
            writer.Write(45646546);             //number of current account
            writer.Write(400.50);               //balance of current account
            writer.Write("Honório Henrique");   //Holder of current account
        }

        static void ReadBinary()
        {
            using var fileStream = new FileStream("current_account.txt", FileMode.Open);
            using var reader = new BinaryReader(fileStream);

            var agency = reader.ReadUInt32();
            var number = reader.ReadUInt32();
            var balance = reader.ReadDouble();
            var holder = reader.ReadString();

            Console.WriteLine($"{agency}/{number} {balance} {holder}");

        }
    }
}
