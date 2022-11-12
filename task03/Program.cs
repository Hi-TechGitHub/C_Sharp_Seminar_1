System.Console.WriteLine("Впишите число.");
int number1 = Convert.ToInt32(Console.ReadLine());
int start = 0;
while (start < number1) {
    start += 2;
    System.Console.WriteLine(start);
}