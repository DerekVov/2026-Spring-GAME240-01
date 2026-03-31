// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
//My super cool and amazing variables
string wordNumberA,wordNumberB;
double numeroUno, numeroDos, numberChild;
string theOpps = " ";
// even cooler pre-written message
string coolMessage = " and that is how you do math!";
// stupid variables
string[] cutMyself;
string temp1;
// fredrick is here to continue the while loop if the user input is bad
bool fredrick = true;
/*
question 1, what operation do you want
*/
Console.WriteLine("I'm a calculator but you can call me calc (short for calculator)");

while (theOpps.ToLower() != "quit")
{
    fredrick = true;
    
    Console.WriteLine("Give me a math equation, simple");
    theOpps = Console.ReadLine();
    cutMyself = theOpps.Split(' ');
    for (int i = 0; i < cutMyself.Length; i+=2)
    {
        temp1 = cutMyself[i];
        if (Char.IsDigit(temp1, 0) == false)
        {
            Console.WriteLine("im not a dictionary");
            fredrick = false;
        }
        
    }

    if (fredrick == false)
    {
        continue;
    }

wordNumberA = cutMyself[0];
numeroUno = double.Parse(wordNumberA);

wordNumberB = cutMyself[2];
numeroDos = double.Parse(wordNumberB);


    if (cutMyself[1] == "+")
    {
        numberChild = numeroUno + numeroDos;
        Console.WriteLine(wordNumberA + " + " + wordNumberB + " = " + numberChild + coolMessage);
    }
    else if (cutMyself[1] == "-")
    {
        numberChild = numeroUno - numeroDos;
        Console.WriteLine(wordNumberA + " - " + wordNumberB + " = " + numberChild + coolMessage);
    }
    else if (cutMyself[1] == "*")
    {
        numberChild = numeroUno * numeroDos;
        Console.WriteLine(wordNumberA + " * " + wordNumberB + " = " + numberChild + coolMessage);
    }
    else if (cutMyself[1] == "%")
    {
        if (cutMyself[1] == "%" && numeroDos == 0)
        {
            Console.WriteLine("What are you trying to KILL me?!? SCREW YOU!!!");
        }
        else
        {
            numberChild = numeroUno % numeroDos;
            Console.WriteLine(wordNumberA + " % " + wordNumberB + " = " + numberChild + coolMessage);
        }
    }
    else if (cutMyself[1] == "/")
    {
        if (cutMyself[1] == "/" && numeroDos == 0)
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