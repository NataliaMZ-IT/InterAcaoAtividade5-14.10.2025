// Conta Bancária
using Exercicio2;

BankAccount account = new BankAccount();
Console.WriteLine("Insert the name of the holder of the bank account: ");
account.SetHolder(Console.ReadLine()!);

int op;
double value;
do
{
    Console.WriteLine($"\nAccount Holder: {account.GetHolder()}\nCurrent Balance: ${account.GetBalance():F2}");
    Console.WriteLine("Choose an option:\n1 - Deposit\n2 - Withdraw\n3 - Leave");
    op = int.Parse( Console.ReadLine()!);

    switch (op)
    {
        case 1:
            Console.WriteLine("Insert the amount you wish to deposit: ");
            value = double.Parse(Console.ReadLine()!);
            account.DepositBalance(value);
            break;
        case 2:
            Console.WriteLine("Insert the amount you wish to withdraw: ");
            value = double.Parse(Console.ReadLine()!);
            account.WithdrawBalance(value);
            break;
        case 3:
            Console.WriteLine("Signing off... goodbye!");
            break;
        default:
            Console.WriteLine("Invalid option!");
            break;
    }
} while (op != 3);