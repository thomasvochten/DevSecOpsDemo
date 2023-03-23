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

// TODO: Use an older nuget dependency to test Dependabot
// TODO: Create more vulnerabilities to test Sonarcloud such as a weak hashing algorithm