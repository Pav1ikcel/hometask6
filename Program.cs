/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

int count = 0;

Console.Write("Enter a list of numbers separated by a comma: ");
string input = Console.ReadLine();

// Split the input string into an array of strings
string[] numbers = input.Split(',');

foreach (string number in numbers) {
    // Convert the string to an integer
    int num = int.Parse(number);


    if (num > 0) {
        count++;
    }
}
Console.WriteLine("The number of numbers greater than 0 is: " + count);
*/

/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;


class MainClass {
    public static void Main (string[] args) {
        double k1, b1, k2, b2;


        Console.WriteLine("Enter the value of k1:");
        k1 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter the value of b1:");
        b1 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter the value of k2:");
        k2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter the value of b2:");
        b2 = Convert.ToDouble(Console.ReadLine());


        if (k1 == k2) {
            Console.WriteLine("The lines are parallel, they will never intersect");
        } else {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine("The intersection point of the two lines is at the following coordinates: ({0}, {1})", x, y);
        }
    }
}

*/