// See https://aka.ms/new-console-template for more information
//Question one, can my computer count to 5?
int scale = 0;

while(scale < 5){
    scale += 1;
    Console.Write(scale + " ");
    
}
Console.WriteLine();
//Question 2, can my Computer go from 100 - 150
int fatScale = 100;
while (fatScale <= 150)
{
    
    Console.Write(fatScale + " ");
    fatScale += 1;
}
Console.WriteLine();
// Question 3, count by 2
int doubleDouble = 0;
while (doubleDouble <= 100)
{
    
    Console.Write(doubleDouble + " ");
    doubleDouble += 2;
}
Console.WriteLine();
// Question 4, count down
int decayingMan = 20;
while (decayingMan >= -20)
{
    Console.Write(decayingMan + " ");
    decayingMan -= 1;
}
Console.WriteLine();
//question 5, time for 3
int tripleWiple = 1;
while (tripleWiple <= 100)
{
    Console.Write(tripleWiple + " ");
    tripleWiple += 3;
}
Console.WriteLine();
//question 6, by the power of 2
int powah = 1;
while (powah <= 1024)
{
    Console.Write(powah + " ");
    powah *= 2;
}
Console.WriteLine();
//Question 7, end it's suffering
string plea = "";
do
{
    Console.WriteLine("Put me out of my misery (yes/no)");
    plea = Console.ReadLine();
} while (plea != "yes");
//Question 8, on or off
bool lightSwitch = false;
int limit = 0;
while (limit <= 10)
{
    Console.WriteLine(lightSwitch);
    if (lightSwitch == false)
    {
        lightSwitch = true;
        limit += 1;
    }
    else
    {
        lightSwitch = false;
        limit += 1;
    }
}
Console.WriteLine();
//Question 9, odd or even
int fourXScale = 1;
bool isEven = false;
while (fourXScale <= 20)
{
    if (isEven)
    {
        Console.Write(fourXScale + " Even ");
        
    }
    else
    {
        Console.Write(fourXScale + " Odd ");
        
    }

    isEven = !isEven;
    fourXScale++;

}
Console.WriteLine();
// question 10, array time
string[] storyTime = new string[] {"once", "upon", "a", "midnight", "dreary"};
int pageNumber = 0;
while (pageNumber < storyTime.Length)
{
    Console.Write(storyTime[pageNumber] + " ");
    pageNumber += 1;
}
Console.WriteLine();
// Bonus Question, Buzz Feed
string bee = "Buzz";
string soda = "Fizz";
int blackNYellow = 1;
while (blackNYellow <= 45)
{
    if (blackNYellow % 3 == 0 && blackNYellow % 5 == 0)
    {
        Console.Write (soda + bee + " ");
        blackNYellow += 1;
    }
    else if (blackNYellow % 3 == 0)
    {
        Console.Write(soda + " ");
        blackNYellow += 1;
    }
    else if (blackNYellow % 5 == 0)
    {
        Console.Write(bee + " ");
        blackNYellow += 1;
    }
    else
    {
        Console.Write(blackNYellow + " ");
        blackNYellow += 1;
    }
}