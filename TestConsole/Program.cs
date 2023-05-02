using PayPointTestTask;
using System;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            // generating new address and key           
            var addressAndKey = AddressGenerator.GenerateAddressAndKey();
            Console.WriteLine("New address: " + addressAndKey);            
            // getting TRX balance
            var balance = BalanceGetter.GetBalance("TNPns1Wa3NZYozYKTJvsEshk6FS4opWgnf");
            Console.WriteLine(balance);            
        }
    }
}
