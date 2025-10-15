// Sistema de Pagamentos
using Exercicio1;

PaymentBoleto PayByBoleto(double val, string date)
{
    PaymentBoleto aux = new PaymentBoleto();
    aux.SetValue(val);
    aux.SetDueDate(date);
    aux.SetPaidDate();
    return aux;
}

PaymentCreditCard PayByCredit(double val, string date)
{
    PaymentCreditCard aux = new PaymentCreditCard();
    aux.SetValue(val);
    aux.SetDueDate(date);
    Console.WriteLine("How many parcels will you pay with?");
    aux.SetParcels(int.Parse(Console.ReadLine()!));
    return aux;
}

Payment[] payment;

Console.Write("Inform the number of payments you want to register: ");
int numPayments = int.Parse(Console.ReadLine()!);

payment = new Payment[numPayments];

for (int i = 0; i < numPayments; i++)
{
    Console.WriteLine("\nInsert value of the payment: ");
    double value = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Insert the due date: (dd/mm/yyyy)");
    string date = Console.ReadLine()!;

    int op;
    do
    {
        Console.WriteLine("Choose your form of payment:\n1 - Boleto\n2 - Credit Card");
        op = int.Parse(Console.ReadLine()!);

        switch (op)
        {
            case 1:
                payment[i] = PayByBoleto(value, date);
                break;
            case 2:
                payment[i] = PayByCredit(value, date);
                break;
            default:
                Console.WriteLine("");
                break;
        }
    } while (op != 1 && op != 2);
}

for (int i = 0; i < numPayments; i++)
{
    payment[i].ProcessPayment();
}
