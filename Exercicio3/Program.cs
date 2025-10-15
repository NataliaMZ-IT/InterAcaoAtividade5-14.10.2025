// Sistema de Veículos
using Exercicio3;

string InsertManu()
{
    Console.WriteLine("Insert the name of the Manufacturer: ");
    return Console.ReadLine()!;
}

string InsertModel()
{
    Console.WriteLine("Insert the name of the Model: ");
    return Console.ReadLine()!;
}

int InsertYear()
{
    Console.WriteLine("Insert the year of the vehicle: ");
    return int.Parse(Console.ReadLine()!);
}

Vehicle[] vehicles;

Console.WriteLine("Insert the number of vehicles you want to register: ");
int numVehicles = int.Parse(Console.ReadLine()!);
vehicles = new Vehicle[numVehicles];

int op, aux;
double aux2;
for (int i = 0; i < numVehicles; i++)
{
    Console.WriteLine("\nChoose the type of vehicle:\n1 - Motorcycle\n2 - Car\n3 - Truck");
    op = int.Parse(Console.ReadLine()!);

    do
    {
        switch (op)
        {
            case 1:
                Console.Write("How many seats does your motorcycle have? ");
                aux = int.Parse(Console.ReadLine()!);
                vehicles[i] = new Motorcycle(InsertManu(), InsertModel(), InsertYear(), aux);
                break;
            case 2:
                Console.Write("How many doors does your car have? ");
                aux = int.Parse(Console.ReadLine()!);
                vehicles[i] = new Car(InsertManu(), InsertModel(), InsertYear(), aux);
                break;
            case 3:
                Console.Write("How much weight (kg) can your truck hold? ");
                aux2 = double.Parse(Console.ReadLine()!);
                vehicles[i] = new Truck(InsertManu(), InsertModel(), InsertYear(), aux2);
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    } while (op < 1 || op > 3);
}
for (int i = 0; i < numVehicles; i++)
{
    Console.WriteLine();
    vehicles[i].ShowInfo();
}