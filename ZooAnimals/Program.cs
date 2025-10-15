// Cadastro de animais do zoológico
using ZooAnimals;

Animal[] animals;

Cat RegisterCat() 
{  
    Cat cat = new Cat();
    Console.Write("Insert the cat's name: ");
    cat.SetName(Console.ReadLine()!);
    Console.Write("Insert the cat's age: ");
    cat.SetAge(int.Parse(Console.ReadLine()!));
    return cat; 
}
Dog RegisterDog() 
{  
    Dog dog = new Dog();
    Console.Write("Insert the dog's name: ");
    dog.SetName(Console.ReadLine()!);
    Console.Write("Insert the dog's age: ");
    dog.SetAge(int.Parse(Console.ReadLine()!));
    return dog; 
}
Lion RegisterLion() 
{  
    Lion lion = new Lion();
    Console.Write("Insert the lion's name: ");
    lion.SetName(Console.ReadLine()!);
    Console.Write("Insert the lion's age: ");
    lion.SetAge(int.Parse(Console.ReadLine()!));
    return lion; 
}
Monkey RegisterMonkey() 
{  
    Monkey monkey = new Monkey();
    Console.Write("Insert the monkey's name: ");
    monkey.SetName(Console.ReadLine()!);
    Console.Write("Insert the monkey's age: ");
    monkey.SetAge(int.Parse(Console.ReadLine()!));
    return monkey; 
}

// Main Code
Console.Write("How many animals will you register? ");
int numAnimals = int.Parse(Console.ReadLine()!);
animals = new Animal[numAnimals];

int op;
for (int i = 0; i < numAnimals; i++)
{
    do 
    {
        Console.WriteLine("\nSelect the species of animal:" +
                          "\n1 - Cat\n2 - Dog\n3 - Lion\n4 - Monkey");
        op = int.Parse((Console.ReadLine()!));
        switch (op)
        {
            case 1:
                animals[i] = RegisterCat();
                break;
            case 2:
                animals[i] = RegisterDog();
                break;
            case 3:
                animals[i] = RegisterLion();
                break;
            case 4:
                animals[i] = RegisterMonkey();
                break;
            default:
                Console.WriteLine("Invalid option. Try again.");
                break;
        }
    } while (op < 1 || op > 4);
}

for (int i = 0; i < numAnimals; i++)
{
    Console.WriteLine(animals[i].ToString());
    animals[i].EmitSound();
}