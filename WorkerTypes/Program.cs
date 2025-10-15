// Different types of Worker Classes using the 4 pillars of POO
using WorkerTypes;

WorkerCLT RegisterCLT()
{
    WorkerCLT worker = new WorkerCLT();

    Console.Write("\nInsert the name of the worker: ");
    worker.SetName(Console.ReadLine()!);

    Console.WriteLine("Insert the base wage of the worker: ");
    worker.SetBaseSalary(double.Parse(Console.ReadLine()!));

    Console.WriteLine("Insert the amount of bonus the worker receives: ");
    worker.SetBonus(int.Parse(Console.ReadLine()!));

    return worker;
}

WorkerPJ RegisterPJ()
{
    WorkerPJ worker = new WorkerPJ();

    Console.Write("\nInsert the name of the worker: ");
    worker.SetName(Console.ReadLine()!);

    worker.SetBaseSalary(0);

    Console.WriteLine("Insert the amount of hours the worker works: ");
    worker.SetHours(int.Parse(Console.ReadLine()!));

    Console.WriteLine("Insert the amount the worker receives per hour: ");
    worker.SetHourlyWage(double.Parse(Console.ReadLine()!));

    return worker;
}


Worker[] workers;

Console.Write("Inform the number of workers you want to register: ");
int numWorkers = int.Parse(Console.ReadLine()!);

workers = new Worker[numWorkers];

int op;
for (int i = 0; i < numWorkers; i++)
{
    do {
        Console.WriteLine("\nWhat type of worker do you want to register?" +
                          "\n1 - CLT\n2 - PJ");
        op = int.Parse(Console.ReadLine()!);
        switch (op)
        {
            case 1:
                workers[i] = RegisterCLT();
                break;
            case 2:
                workers[i] = RegisterPJ();
                break;
            default:
                Console.WriteLine("Invalid option! Try again.");
                break;
        }
    } while (op != 1 && op != 2);
}

for (int i = 0; i < numWorkers; i++)
{
    workers[i].ShowInfo();
    Console.WriteLine();
}