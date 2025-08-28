// // Run firsst C# program
// Console.WriteLine("Hello, World!");

// // Declare variable.
// //The first line declares a variable, aFriend, and assigns it a value, "Bill". The second line prints the name.
// string aFriend = "Bill";
// Console.WriteLine(aFriend);
// // Store another value in the variable
// aFriend = "Maria";
// Console.WriteLine(aFriend);
// // String interpolation - $"This is call String intrapolation, joining Strings value in curly braces"
// Console.WriteLine($"Hello {aFriend}");

// // Workin with String
// string firstFriend = "Maria";
// string secondFriend = "Sage";
// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
// // Print variable property - Lenght
// Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
// Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


// // Variable property - Trim
// string greeting = "      Hello World!       ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");

// // Variable property - Replace method takes two arguement
// string sayHello = "Hello World!";
// Console.WriteLine(sayHello);
// sayHello = sayHello.Replace("Hello", "Greetings");
// Console.WriteLine(sayHello);

// // Variable property - ToUpper and ToLower methods
// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());

// // The other part of a search and replace operation is to find text in a string. 
// //You can use the Contains method for searching. 
// //It tells you if a string contains a substring inside it. 
// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.Contains("goodbye"));
// Console.WriteLine(songLyrics.Contains("greetings"));
// //It tells you if a string StartsWith/Endswith a substring inside it. 
// Console.WriteLine(songLyrics.StartsWith("you"));
// Console.WriteLine(songLyrics.StartsWith("goodbye"));
// Console.WriteLine(songLyrics.EndsWith("hello"));
// Console.WriteLine(songLyrics.EndsWith("goodbye"));


// // Working with numbers Aug 28, 2025

// int year = 0;
// Console.WriteLine($"The year is {year}");
// year = 2024;
// Console.WriteLine($"The year is {year}");



// Använd Console.WriteLine för att fråga efter användarens ålder.




/* // Att läsa in data från en användare.
Console.WriteLine("Type your age and press Enter: ");

// Att konvertera en string till en int.
string arg = Console.ReadLine();
int age;
if (int.TryParse(arg, out age))
{
    Console.WriteLine($"You are {age} years old.");
    // Att skapa en bool-variabel baserat på ett villkor.
    bool isOldEnough = age >= 18;
    // Att använda en if-sats för att presentera olika meddelanden.
    if (isOldEnough)
    {
        Console.WriteLine("Du kan komma in på krogen.");
    }
    else
    {
        Console.WriteLine("Du är tyvärr för ung!");
    }
}
 */


int age;
while (true)
{
    Console.Write("Type your age(Must be Number) and press Enter: ");
    string? arg = Console.ReadLine();

    if (int.TryParse(arg, out age))
    {
        break; // avsluta loopen om inmatningen var korrekt
    }
    else
    {
        Console.WriteLine("Ogiltig inmatning! Försök igen.");
    }
}

Console.WriteLine($"You are {age} years old.");
if (age >= 18)
{
    Console.WriteLine("Du kan komma in på krogen.");
}
else
{
    Console.WriteLine("Du är tyvärr för ung!");
}
