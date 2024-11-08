// See https://aka.ms/new-console-template for more information

double result = 0;

Console.WriteLine("ngresa un numero"); int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa otro numero"); int num2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Desea: \nsumar: +\nrestar: -\nmultiplicar: *\ndividir: /"); string op = Console.ReadLine();

switch(op)
{
    case "+":
    result = num1 +num2;
    break;

    case "-":
    result = num1-num2;
    break;

    case "*":
    result = num1*num2;
    break;

    case "/":
    result =(double)num1 / num2;
    break;
}

System.Console.WriteLine($"resultado {result}");
