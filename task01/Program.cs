System.Console.WriteLine("Впишите 2 числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
if (number1 > number2) {
    max = number1;
}
else {
    max = number2;
}
Console.WriteLine("Самое большое число это: " + max);