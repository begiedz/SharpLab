/* 
    FizzBuzz challenge
*/
for (int i = 1; i <= 100; i++)
{
    string result =
        (i % 3 == 0 ? "Fizz" : "") +
        (i % 5 == 0 ? "Buzz" : "");

    System.Console.WriteLine(i + (result != string.Empty ? $" - {result}" : null));
}
