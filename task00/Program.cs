System.Console.WriteLine("Впишите 3 числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max;
if (number1 > number2) {
    max = number1;
    if (number1 > number3) {
        System.Console.WriteLine("Самое большое число: ");
        System.Console.WriteLine(max);
        
    }
}


if (number1 < number2) {
    max = number2;
    if (number2 > number3) {
        System.Console.WriteLine("Самое большое число: ");
        System.Console.WriteLine(max);
        
    }
}

if (number3 > number1) {
    max = number3;
    if (number2 < number3) {
        System.Console.WriteLine("Самое большое число: ");
        System.Console.WriteLine(max);

        
    }
}