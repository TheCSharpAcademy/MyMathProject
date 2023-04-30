#region Game
Console.WriteLine(WelcomeMessage());
string WelcomeMessage()
{
    Console.WriteLine("Please type your name");
    string userName = Console.ReadLine();
    Console.Clear();
    
    DateTime gameDate = DateTime.Now;

    return @$"--------------------
Hi {userName.ToUpper()}! 
Today is {gameDate.DayOfWeek}.
Ready to train some math?
--------------------";
}

Console.ReadLine();
Console.Clear();

var gamesHistory = new List<string>();

var isGameOn = true;
do
{
    Console.Clear();

    Console.WriteLine(@"---------------------------------------------
What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
H - View History
Q - Quit the program
---------------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame();
            break;
        case "s":
            SubtractionGame();
            break;
        case "m":
            MultiplicationGame();
            break;
        case "d":
            DivisionGame();
            break;
        case "h":
            PrintHistory();
            break;
        case "q":
            Console.WriteLine("Goodbye");
            isGameOn = false;
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    Console.WriteLine("\nEnter any key to return to menu");
    Console.ReadLine();
} while (isGameOn);

void AdditionGame()
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 3; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine($"Your answer was correct.");
            score++;
        }
        else
        {
            Console.WriteLine($"Your answer was incorrect.");
        }

        if (i == 2) Console.WriteLine($"Game over. Your final score is {score}");
    }

    AddToHistory(score, "Addition");
}

void SubtractionGame()
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 3; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine($"Your answer was correct.");
            score++;
        }
        else
        {
            Console.WriteLine($"Your answer was incorrect.");
        }

        if (i == 2) Console.WriteLine($"Game over. Your final score is {score}");
    }

    AddToHistory(score, "Subtraction");
}

void MultiplicationGame()
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 3; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine($"Your answer was correct.");
            score++;
        }
        else
        {
            Console.WriteLine($"Your answer was incorrect.");
        }

        if (i == 2) Console.WriteLine($"Game over. Your final score is {score}");
    }

    AddToHistory(score, "Multiplication");
}

void DivisionGame()
{
    var score = 0;

    for (int i = 0; i < 3; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine($"Your answer was correct.");
            score++;
        }
        else
        {
            Console.WriteLine($"Your answer was incorrect.");
        }

        if (i == 2) Console.WriteLine($"Game over. Your final score is {score}");
    }

    AddToHistory(score, "Division");
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}

void AddToHistory(int gameScore, string gameType)
{
    gamesHistory.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
}

void PrintHistory()
{
    foreach (var game in gamesHistory)
    {
        Console.WriteLine(game);
    }
}
#endregion

//#region Sandbox
//var index = 1;
//var name = "Pablo";
//var initial = 'P';
//var dateOfBirth = 1982;
//var height = 1.85m;
//var doWeLoveToCode = true;
//var dateTime = DateTime.Now;

//Console.WriteLine(@$"These are the most common data types:
//{index} - Integer, Example: {dateOfBirth}
//{++index} - String, Example: {name}
//{++index} - Character, Example: {initial}
//{++index} - Decimal, Example: {height}
//{++index} - Boolean, Example: {doWeLoveToCode}
//{++index} - DateTime, Example: {dateTime}");

//index = 100;
//name = "Pablo Souza";
//initial = 'S';
//dateOfBirth = 1983;
//height = 1.84m;
//doWeLoveToCode = false;
//dateTime = DateTime.Now.AddDays(1);

//Console.WriteLine(@$"
//These are the most common data types:
//{index} - Integer, Example: {dateOfBirth}
//{++index} - String, Example: {name}
//{++index} - Character, Example: {initial}
//{++index} - Decimal, Example: {height}
//{++index} - Boolean, Example: {doWeLoveToCode}
//{++index} - DateTime, Example: {dateTime}");

//#endregion

