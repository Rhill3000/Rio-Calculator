// See https://aka.ms/new-console-template for more information

bool continuing = true;


int number1;
int number2;


while (continuing) {
Console.WriteLine("Welcome to the Calculator");

Console.WriteLine("Enter a number");

 
number1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter your second digit!");
number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please choose an operator *, +, -, / or type x to exit");

switch (Console.ReadLine())
{ 
    case "*":
    Console.WriteLine("The total is " + (number1 * number2));
    break;

    case "+" :
    Console.WriteLine("The total is " + (number1 + number2));
    break;

    case "-" :
    Console.WriteLine("The total is " + (number1 - number2));
    break;

    case "/" :
    Console.WriteLine("The total is " + (number1 / number2));
    break;

    default :
    Console.WriteLine("That key is not a valid option");
    break;
         
    case "x" :   
         Console.WriteLine("You have exited the calculator");
         return;



}
}



