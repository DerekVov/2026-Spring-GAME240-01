// I got the funni Array and I want to know who is the greatest and weakest warrior in my array

using System.Runtime.InteropServices;

int[] myGang = new int[9];
//Im not typing each integer individually Im making it random. The random will add a random integer from a range
//change the integer bc the for loop depends on the length of the array
Random tweaker = new Random();
int i;
for (i = 0; i < myGang.Length; i++)
{
    myGang[i] = tweaker.Next(-10,100);
    Console.WriteLine(myGang[i]);
}
//Aight initialization complete, now to find the strongest warrior
int j;
int bigBack = myGang[0];
int twink = myGang[0];
for (j = 0; j < myGang.Length; j++)
{
    
    if (myGang[j] > bigBack)
    {
        bigBack = myGang[j];
    }

    if (myGang[j] < twink)
    {
        twink = myGang[j];
    }
    
}
Console.WriteLine("the biggest boi is: " + bigBack + " the littlelest boi is " + twink);