# PayPointTestTask
# TRON Address and Balance

This C# project includes two classes for generating a TRON address and checking the balance of an address in the Nile test network.

## Requirements

- .NET 5.0
- RestSharp and Newtonsoft.Json NuGet packages

## Address Generator

The AddressGenerator class provides a method GenerateAddressAndKey() that returns a randomly generated TRON address and private key.

### Example usage:

csharp
var addressAndKey = AddressGenerator.GenerateAddressAndKey();
string address = addressAndKey.Item1;
string privateKey = addressAndKey.Item2;

## Balance Getter

The BalanceGetter class provides a method GetBalance() that returns the balance of an address in Nile test network.

### Example usage:

csharp
string address = "TJRab7v4o9L4mJ39ZUDxu7gV5famuE5eTW";
string balance = BalanceGetter.GetBalance(address);
Console.WriteLine($"The balance of address {address} is {balance} TRX.");

## Note
- The Nile test network was used for testing the project.
