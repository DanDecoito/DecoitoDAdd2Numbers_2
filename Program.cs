// Daniel Decoito
// 10-20-22
// Mini challenge 2 "Add two number"
// ask the user for two digits as string data, convert it and return the sum of the two numbers. 
// Peer Reviewd by: no review here
Console.Clear();

bool boolOne;
bool boolTwo;
string userInput = "Dan";
bool numCheck = false;
int num1 = 0;
bool numCheck2 = false;
int num2 = 0;
int sum = 0;
string terminateGame = "Dan is cool";


//------------ parse mehtood
static bool ParseBool(string userInput)
{
    bool result = int.TryParse(userInput, out int numOut) ? result = true : result = false;
    return result;
}
while (terminateGame != "")
{
Console.WriteLine("Lets do some Addition");
Console.WriteLine("Enter a number");


while (numCheck == false)
{
    userInput = Console.ReadLine();
    boolOne = ParseBool(userInput);
    if (boolOne == true)
{
  num1 =  int.Parse(userInput);
  numCheck = true;  
}
else
{
    Console.WriteLine("Incorrect input, please enter a number.");
    numCheck =  false;
}   
}


Console.WriteLine("Please enter a second number.");


while (numCheck2 == false)
{
    userInput = Console.ReadLine();
    boolTwo = ParseBool(userInput);
if (boolTwo == true)
{
  num2 =  int.Parse(userInput);
  numCheck2 = true;  
}
else
{
    Console.WriteLine("Incorrect input, please enter a number.");
    numCheck =  false;
}  
}

sum = num1 + num2;
Console.WriteLine($"The sum of {num1} and {num2} is {sum}");

Console.WriteLine("Press any key to play again or press enter to quit game");
terminateGame = Console.ReadLine();
numCheck = false;
numCheck2 = false;
}
