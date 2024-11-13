/*This Program genrate password.*/

// Make a const of all the posable combnation of password.
const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
const string Digits = "0123456789";
const string SpecialCharacters = "!@#$%^&*()_-+={}[]:;|<>,.?/ ` ~";
const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialCharacters;

//Ask the User for input and also make it where it require the input to be an int.
Console.WriteLine("\nPlease Enter a pasword amount you want: ");
#pragma warning disable CS8604 // Possible null reference argument.
int PasswordAmount = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
Console.WriteLine("Please Enter a password length you want: ");
#pragma warning disable CS8604 // Possible null reference argument.
int PasswordLength = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

// Make where it will be randmize for to help with the complcatedness.
Random rnd = new Random();

// Covert all of this in the array.
string[] AllPasswords =
    Enumerable.Repeat(0, PasswordAmount).Select(i => string.Concat(Enumerable.Repeat(0, PasswordLength).Select(j => AllChars[rnd.Next(AllChars.Length)]))).ToArray();

// Go to each posable combnation in the array.
foreach (var p in AllPasswords)
{
    Console.WriteLine(p);
}

