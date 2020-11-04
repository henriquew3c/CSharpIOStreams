using System;
using System.IO;
using CSharpIOStreams.Models;

namespace CSharpIOStreams
{
    partial class Program
    {
        private static void UsingStreamReader()
        {
            using var fileStream = new FileStream("accounts.txt", FileMode.Open);
            using var reader = new StreamReader(fileStream);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }

        private static CurrentAccount ConvertStringLineToCurrentAccount(string line)
        {
            var lineSplit = line.Split(",");

            var client = new Client
            {
                Name = lineSplit[3]
            };

            var number = int.Parse(lineSplit[0]);
            var agency = int.Parse(lineSplit[1]);
            var balance = double.Parse(lineSplit[2].Replace('.', ','));

            var currentAccount = new CurrentAccount(number, agency)
            {
                Holder = client
            };

            currentAccount.Deposit(balance);

            return currentAccount;

        }

        private static void ReadFileStreamAndConvertToCurrentAccount()
        {
            using var fileStream = new FileStream("accounts.txt", FileMode.Open);
            using var reader = new StreamReader(fileStream);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var currentAccount = ConvertStringLineToCurrentAccount(line);

                var msg =
                    $"Holder: {currentAccount.Holder.Name}, Number: {currentAccount.Number}, Agency: {currentAccount.Agency}, Balance: {currentAccount.Balance}";
                Console.WriteLine(msg);
            }
        }
    }

}
