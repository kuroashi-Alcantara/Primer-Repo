// See https://aka.ms/new-console-template for more information

double result = 0;
string prove;
int num1 = 0;
int num2 = 0;

try
{
Console.WriteLine("ingresa un numero");
prove = Console.ReadLine();
if (prove != null)
{
        num1 = int.Parse(prove);
}

Console.WriteLine("Ingresa otro numero");
prove = Console.ReadLine();
if (prove != null)
{    
    num2 = int.Parse(prove);
}


System.Console.WriteLine("Desea: \nsumar: +\nrestar: -\nmultiplicar: *\ndividir: /");

string op = Console.ReadLine();

switch (op)
{
    case "+":
        result = num1 + num2;
        break;

    case "-":
        result = num1 - num2;
        break;

    case "*":
        result = num1 * num2;
        break;

    case "/":
        result = (double)num1 / num2;
        break;
}

System.Console.WriteLine($"resultado {result}");

}
catch(Exception ex)
{
    System.Console.WriteLine(ex.Message);
}