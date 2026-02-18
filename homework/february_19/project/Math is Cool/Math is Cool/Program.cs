// See https://aka.ms/new-console-template for more information
//My super cool and amazing variables
string wordNumberA,wordNumberB;
double numeroUno, numeroDos, numberChild;
string theOpps;
// even cooler pre-written message
string coolMessage = " and that is how you do math!";
/* Computer is here to ask you questions

question 1, what operation do you want
*/
Console.WriteLine("I'm a calculator but you can call me calc (short for calculator)");
Console.WriteLine("What is the operation we will be using today (addition, subtraction, multiplication, division) ");
theOpps = Console.ReadLine();

Console.WriteLine("What is your first number");
wordNumberA = Console.ReadLine();
numeroUno = double.Parse(wordNumberA);

Console.WriteLine("What is your second number");
wordNumberB = Console.ReadLine();
numeroDos = double.Parse(wordNumberB);

if (theOpps == "addition" || theOpps == "Addition")
{
    numberChild = numeroUno + numeroDos;
    Console.WriteLine(wordNumberA + " + " + wordNumberB + " = "  + numberChild + coolMessage);
}
else if (theOpps == "subtraction" || theOpps == "Subtraction")
{
    numberChild = numeroUno - numeroDos;
    Console.WriteLine(wordNumberA + " - " + wordNumberB + " = "  + numberChild + coolMessage);
}
else if (theOpps == "multiplication" || theOpps == "Multiplication")
{
    numberChild = numeroUno * numeroDos;
    Console.WriteLine(wordNumberA + " * " + wordNumberB + " = "  + numberChild + coolMessage);
}
else if (theOpps == "division" || theOpps == "Division")
{
    if (theOpps == "division" && numeroDos == 0)
    {
        Console.WriteLine("What are you trying to KILL me?!? SCREW YOU!!!");
    }
    else
    {
        numberChild = numeroUno / numeroDos;
        Console.WriteLine(wordNumberA + " / " + wordNumberB + " = "  + numberChild + coolMessage);
    }
}
else
{
    Console.WriteLine("Can you not read instructions? I said addition, subtraction, multiplecation, or division!");
}
