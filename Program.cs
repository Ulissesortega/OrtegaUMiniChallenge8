//name: Ulises Ortega
//Date: 09.17.22
//Program Name: Guess It
//The program provides the user with a menu of 3 options to play in different ranges, the user should select 1, 2 =, or 3, otherwise
//the program will enforce the user to a valid choice, once a valid choice has been made
//you will have to guess the number between the selected range.
//The program will validate the input to make sure that is a number and if is not a number and it will prompt and error message and ask for a valid number
//once the number has been guessed the program is completed
//after completed, It will ask the user to run the program again Yes or No with data validatation for Yes and No only.
//

Console.Clear();
string userChoice = "";

do{
Console.Clear();
Console.WriteLine("Let's Play Guess It, Please choose 1 of the options below: ");
Console.WriteLine("---------------------------");
Console.WriteLine("1 - Easy = 1 to 10");
Console.WriteLine("---------------------------");
Console.WriteLine("2 - Medium = 1 to 50");
Console.WriteLine("---------------------------");
Console.WriteLine("3 - Hard = 1 to 100");
Console.WriteLine("---------------------------");


int option ;
bool isNumber = false;


isNumber = Int32.TryParse(Console.ReadLine(), out option);

while (option != 1 &&  option != 2 && option !=3)
{
    Console.WriteLine("Please enter 1, 2, or 3");
    isNumber = Int32.TryParse(Console.ReadLine(), out option);    
}

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------//
 
if (option == 1){
 
Random random = new Random();
int min = 1;
int max = 10;
int guess;
int number;
int guesses;
bool checkNum1;

 
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
   
    while(guess != number)
    {
        do{
        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        checkNum1 = Int32.TryParse(Console.ReadLine(), out guess);
            if (checkNum1 == false)
                {
                    Console.WriteLine("that is not a number, please enter a number between 1 and 10");
                }
        }while(checkNum1 == false);

        if(guess > number)
        {
        Console.WriteLine(guess + " is too high!");
        }else if(guess < number)
        {
          Console.WriteLine(guess + " is to low!");
        }
    guesses++;
    }
    Console.WriteLine("");  
    Console.WriteLine("You Got It!");
    Console.WriteLine("");  
    Console.WriteLine("-----------------------------");
    Console.WriteLine("The number was: " + number);
    Console.WriteLine("-----------------------------");
    Console.WriteLine("You Win!");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Guesses: " + guesses);
    Console.WriteLine("-----------------------------");
}  
//---------------------------------------------------------------------------------------------------------------------------------------------------------------//
 
 
else if(option ==2){
   
Random random = new Random();
int min = 1;
int max = 50;
int guess;
int number;
int guesses;
bool checkNum1;
 
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
   
    while(guess != number)
    {
        do{
        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        checkNum1 = Int32.TryParse(Console.ReadLine(), out guess);
            if (checkNum1 == false)
                {
                    Console.WriteLine("that is not a number, please enter a number between 1 and 50");
                }
        }while(checkNum1 == false);

        if(guess > number)
        {
        Console.WriteLine(guess + " is too high!");
        }else if(guess < number)
        {
          Console.WriteLine(guess + " is to low!");
        }
    guesses++;
    }
    Console.WriteLine("");  
    Console.WriteLine("You Got It!");
    Console.WriteLine("");  
    Console.WriteLine("-----------------------------");
    Console.WriteLine("The number was: " + number);
    Console.WriteLine("-----------------------------");
    Console.WriteLine("You Win!");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Guesses: " + guesses);
    Console.WriteLine("-----------------------------");
}
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------//
 
else if (option ==3)
{
Random random = new Random();
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
bool checkNum1;
 
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
   
    while(guess != number)
    {
     do{
        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        checkNum1 = Int32.TryParse(Console.ReadLine(), out guess);
            if (checkNum1 == false)
                {
                    Console.WriteLine("that is not a number, please enter a number between 1 and 100");
                }
        }while(checkNum1 == false);   
        if(guess > number)

        {
        Console.WriteLine(guess + " is too high!");
        }else if(guess < number)
        {
          Console.WriteLine(guess + " is to low!");
        }
    guesses++;
    }
    Console.WriteLine("");  
    Console.WriteLine("You Got It!");
    Console.WriteLine("");  
    Console.WriteLine("-----------------------------");
    Console.WriteLine("The number was: " + number);
    Console.WriteLine("-----------------------------");
    Console.WriteLine("You Win!");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Guesses: " + guesses);
    Console.WriteLine("-----------------------------");
}


do
{
   Console.WriteLine("Do you want to Run the program again, Yes or No?");
   userChoice = Console.ReadLine().ToUpper();
   if(userChoice != "Yes" && userChoice != "NO")
   {
       Console.WriteLine("Invalid Choice, Please type Yes or No");
   }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");