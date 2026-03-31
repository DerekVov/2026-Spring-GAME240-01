// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
//My super cool and amazing variables
char wordNumberA,wordNumberB;
double numeroUno, numeroDos, numberChild;
string theOpps = " ";
// even cooler pre-written message
string coolMessage = " and that is how you do math!";
/* Computer is here to ask you questions

question 1, what operation do you want
*/
Console.WriteLine("I'm a calculator but you can call me calc (short for calculator)");

while (theOpps.ToLower() != "quit")
{
    Console.WriteLine("Give me a math equation, simple");
    theOpps = Console.ReadLine();
    theOpps.Split("");
    if (theOpps.Length > 3)
    {
        Console.WriteLine("did you type a word in the calculator???");
        continue;
    }

wordNumberA = theOpps[0];
numeroUno = double.Parse(wordNumberA.ToString());

wordNumberB = theOpps[2];
numeroDos = double.Parse(wordNumberB.ToString());


    if (theOpps[1] == '+')
    {
        numberChild = numeroUno + numeroDos;
        Console.WriteLine(wordNumberA + " + " + wordNumberB + " = " + numberChild + coolMessage);
    }
    else if (theOpps[1] == '-')
    {
        numberChild = numeroUno - numeroDos;
        Console.WriteLine(wordNumberA + " - " + wordNumberB + " = " + numberChild + coolMessage);
    }
    else if (theOpps[1] == '*')
    {
        numberChild = numeroUno * numeroDos;
        Console.WriteLine(wordNumberA + " * " + wordNumberB + " = " + numberChild + coolMessage);
    }
    else if (theOpps[1] == '%')
    {
        numberChild = numeroUno % numeroDos;
        Console.WriteLine(wordNumberA + " % " + wordNumberB + " = " + numberChild + coolMessage);
    }
    else if (theOpps[1] == '/')
    {
        if (theOpps[1] == '/' && numeroDos == 0)
        {
            Console.WriteLine("What are you trying to KILL me?!? SCREW YOU!!!");
        }
        else
        {
            numberChild = numeroUno / numeroDos;
            Console.WriteLine(wordNumberA + " / " + wordNumberB + " = " + numberChild + coolMessage);
        }
    
    }
    else
    {
        Console.WriteLine("Can you not read instructions? You a dum dum fr fr");
    }
    Console.WriteLine("lets go again type quit to quit");
}