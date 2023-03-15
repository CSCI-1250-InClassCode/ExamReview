/*
Talk about Default Values
*/

//Console.WriteLine("Default Values are as follows: ");

//Console.WriteLine("an int: 0");

//char letter = ' ';

//char letter2 = '\0';

//string name = null;

//name does not have a reference in memory. 

//name -> a memory location to where the letters for name are going to be stored.

//name = "Matt"; //-> this is the point in time that a memory location -> 0x01 thats the location to where M a t t is stored.

//DemonstrateSwitch(3);

int number = 5;


CountDown(1000);
CountDown(5);
CountDown(99);

string value = DemoConcatanaitonVsInterpolation(false, 1231);
System.Console.WriteLine(value);




//Talk about switch statements
static void DemonstrateSwitch(int num)
{

    switch(num)
    {
        case 1:
            System.Console.WriteLine("The number is 1");
            break;
        case 2:
            System.Console.WriteLine("The number is 2");
            break;
        case 3:
        case 4:
            System.Console.WriteLine("The number is 3 or 4");
            break;
        case 5:
            System.Console.WriteLine("The number is 5");
            break;
        default:
            System.Console.WriteLine("The number was not 1 - 5, it was some other value");
            break;


    }//goes here after a break;

}

static void DemonstrateIfStatement(int num)
{
    if(num == 1)
    {
        System.Console.WriteLine("The number is 1");
    }
    else if(num == 2)
    {
        System.Console.WriteLine("The number is 2");
    }
    else if(num == 3 || num == 4)
    {
        System.Console.WriteLine("The number is 3 or 4");
    }
    else if(num == 5)
    {
        System.Console.WriteLine("The number is 5");
    }
    else
    {
        System.Console.WriteLine("The number was not 1 - 5, it was some other value");
    }
    
}

//infinite loops

static void CountDown(int num)
{
    //This will run forever use ctrl-c to break the command prompt.
    
    while(num >= 0)
    {
        System.Console.WriteLine(num);
        num -= 1;
        //count = count - 1;
    }

    System.Console.WriteLine("Blast Off!");
}

//while loop

//String Concatanation vs Interpolation

static string DemoConcatanaitonVsInterpolation(bool choice, int num)
{
    string returnValue;

    if(choice)
    {
          returnValue = "Taking a string" + " to combine the string " + " using the plus symbol. " + num;
    }
    else
    {
         returnValue = $"Taking a string to combine the string using the plus symbol {num}";
    }   

    return returnValue;
}

//literals
