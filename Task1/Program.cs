﻿//Task 1 with string
void Task1()
{   
    Console.WriteLine("Enter three  digits number");
    string numbers = Console.ReadLine();
    Console.WriteLine(numbers[1]);

}
//Task1 with int

void Task2()
{
    Console.WriteLine("Enter three  digits number");
    int numbers = int.Parse(Console.ReadLine());
    Console.WriteLine((numbers/10)%10);
}

//Task 2
void Task3()
{
    Console.WriteLine("Enter three digits number");
    int numbers = int.Parse(Console.ReadLine());
    string numberstext = Convert.ToString(numbers);
    if (numberstext.Length > 2)
    {
        Console.WriteLine("Third number is " + numberstext[2]);
    }
    else {
        Console.WriteLine("Theres no third number");
    }
}

//Task3
void Task4()
{
    Console.WriteLine("Enter day number");
    int daynumber = Convert.ToInt32(Console.ReadLine());

    if (daynumber==6 || daynumber ==7){
        Console.WriteLine("Its weekend");
    }
    else if (daynumber<1 || daynumber>=8){
        Console.WriteLine("Enter correct day");
    }
    else{
        Console.WriteLine("Its workday");
    }
}
