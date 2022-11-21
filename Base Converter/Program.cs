using System;
using System.Collections.Generic;

Console.WriteLine("Please enter number");
string enteredText = Console.ReadLine();
int number;
bool isParsable = int.TryParse(enteredText, out number);

if (!isParsable)
{
    Console.WriteLine("Wrong Format!");
    return;
}

Console.WriteLine("Please enter new base number between 2-20");
enteredText = Console.ReadLine();
int newBase;
isParsable = int.TryParse(enteredText, out newBase);


if (!isParsable || newBase < 2 || newBase > 20)
{
    Console.WriteLine("Wrong Format! Use number between 2-20!");
    return;
}

List<int> list = new List<int>();
do {
    int remains = number % newBase;
    list.Add(remains);
    number = number / newBase;
} while (number > 0);

Console.WriteLine("Your number in new base is -");
for (int i = list.Count - 1; i >= 0; i--)
{
    if (list[i] <= 9)
        Console.Write(list[i]);
    if (list[i] == 10)
        Console.Write("A");
    if (list[i] == 11)
        Console.Write("B");
    if (list[i] == 12)
        Console.Write("C");
    if (list[i] == 13)
        Console.Write("D");
    if (list[i] == 14)
        Console.Write("E");
    if (list[i] == 15)
        Console.Write("F");
    if (list[i] == 16)
        Console.Write("G");
    if (list[i] == 17)
        Console.Write("H");
    if (list[i] == 18)
        Console.Write("I");
    if (list[i] == 19)
        Console.Write("J");
    if (list[i] == 20)
        Console.Write("K");
}