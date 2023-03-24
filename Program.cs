Console.WriteLine("Let's get this party started!");

// Deliberately hardcoded password
var password = "pass@word1";
Console.WriteLine("Password is: " + password);

// Something silly
var x = -1;
if (x < 0)
{
  new ArgumentException("x must be nonnegative");
}

const int MAX = 100;
if(MAX == 100)
{
  Console.WriteLine("MAX is exactly 100");
}

// TODO: Create more vulnerabilities to test Sonarcloud such as a weak hashing algorithm