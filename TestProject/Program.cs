﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/*
for (int i = 0; i < 10; i += 1)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
*/
/*
string[] names = {"Alex", "Eddie", "David", "Michael"};

for(int i = names.Length - 1; i >= 0; i--)
{
    //Console.WriteLine(names[i]);
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
    Console.WriteLine(names[i]);
}
*/

/*
foreach (var name in names)
{
    Console.WriteLine(name);
}
*/
/*
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
    if (i % 3 == 0)
    {
        Console.WriteLine( i + "Fizz");
        if (i % 5 == 0)
        {
            Console.WriteLine(i + "Buzz");
            if(i % 3 == 0 || i % 5 == 0)
            {
                 Console.WriteLine(i + "Fizz Buzz");
            }
        }
    }

}*/

/*
Random random = new Random();
int current = random.Next(1, 11);

do{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/

/*
Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

/*
Random random = new Random();
int heroe = 10;
int monstruo = 10;
int ataque = random.Next(1, 11);

while (heroe > 0 && monstruo > 0)
{


    ataque = random.Next(1, 11);
    monstruo -= ataque;
    Console.WriteLine($"Monster was damaged and lost {ataque} health and now has {monstruo} health");
    // Console.WriteLine(heroe);
     if (monstruo <= 0)
 {
     Console.WriteLine("Heroe wins");
     break;
 }
    ataque = random.Next(1, 11);
    heroe -= ataque;
    Console.WriteLine($"Heroe was damaged and lost {ataque} health and now has {heroe} health");

    if (heroe <= 0)
    {
        Console.WriteLine("Monstruo wins");
        break;
    }
*/

/*
string? readResult;
Console.WriteLine("Enter a string: ");

do{
    readResult = Console.ReadLine();
} while (readResult == null);
*/   
/*   
string? readResult;
bool validEntry = false;


Console.WriteLine("Enter a string containing at least three character: ");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again");
        }
    }
} while (validEntry == false);
   
*/
/*
int numericValue = 0;
bool validNumber = false;
string? readResult;
readResult = Console.ReadLine();

validNumber = int.TryParse(readResult, out numericValue);
Console.WriteLine(validNumber);
*/   

string? readResult;
int numero = 0;
bool validEntry = false;
bool validateNumber = false;
// validateNumber = int.TryParse(readResult, out numero);
Console.WriteLine("Ingrese un valor entre 5 y 10");

do
{
    readResult = Console.ReadLine();
    validateNumber = int.TryParse(readResult, out numero);
    if (validateNumber)
    {
        if (numero > 4 && numero < 11)
        {
            validEntry = true;
            Console.WriteLine($"////////////////Your input value {numero} has been accepted.!!!!!!!!");
        } 
        else
        {
            Console.WriteLine("Debe ingresar un valor entre 5 y 10...");
        }
    }
    else
    {
        Console.WriteLine("Ingrese un numero...");
    }

} while (validEntry == false);



