// See https://aka.ms/new-console-template for more information
// Variables outside any scope so they can be called at any time
string honoredOne = "";
string[] cleave = {};
string[] fishCalc = {};
int fishBarrel = 0;
int typeFish = 0;
//Try catch number 1
while (true)
{
    // Getting the special
    Console.WriteLine("Yo ho ho, what will the patron be requesting tonight?");
    honoredOne = Console.ReadLine();
    try
    {
        // Makes sure the file exists and can be read through
        StreamReader cool = new StreamReader(honoredOne);
        string item;
        // getting what is in the file and splitting it (We only want the last index)
        item = cool.ReadLine();
        cleave = item.Split(" ");
        // end file and loop
        cool.Close();
        break;

    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Yarrr! That file be lost to the seven seas!");
    }
    catch (IOException)
    {
        Console.WriteLine("Yarrr! something be wrong");
    }
}

// we will be using the last index in a conditional later
//Getting the log Try-Catch number 2
while (true)
{
    Console.WriteLine("Arrrr, me crew all have short term memory loss from the overconsumption of rum! \nWhat was the log our crew captured?");
    honoredOne = Console.ReadLine();
    try
    {
        StreamReader cooler = new StreamReader(honoredOne);
        string wood;
        // While loop to go through entire file
        while (true)
        {
            //Take in value before checking if null is better cus otherwise checking file will iterate through it
            wood = cooler.ReadLine();
            if (wood == null)
            {
                break;
            }
            fishCalc = wood.Split(" ");
            // Total fish added
            fishBarrel += int.Parse(fishCalc[0]);
            // Check if the fish is part of the special
            if (fishCalc[1] == cleave[3])
            {
                typeFish += int.Parse(fishCalc[0]);
            }
        }

        cooler.Close();
        break;
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Yarrr! That file be lost to the seven seas!");
    }
    catch (IOException)
    {
        Console.WriteLine("Yarrr! something be wrong");
    }
}
// Last try catch
while (true)
{
    try
    {
        Console.WriteLine("AY MATEY, and where would the menu be stored today?");
        honoredOne = Console.ReadLine();
        using (StreamWriter orderUp = new StreamWriter(honoredOne))
        {
            orderUp.WriteLine("Ay... Today's catch of the day is " + cleave[3]);
            orderUp.WriteLine("In ye logs we estimated a catch of: " + typeFish + " " + cleave[3]);
            orderUp.WriteLine("But in total we pirates caught: " + fishBarrel + " fish!");
            orderUp.Close();
            break;
        }


    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Where Be that menu?");
    }
    catch (IOException)
    {
        Console.WriteLine("YO HO OH NO!");
    }
    
}

