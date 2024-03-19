using System.Data;

int firstNumber = 1;
int secondNumber = 1;
int result;
int additionalVariable;
Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
for (int i = 1; i < 45; i++)
{
    result = firstNumber + secondNumber;
    additionalVariable = secondNumber;
    secondNumber = result;
    firstNumber = additionalVariable;
    Console.WriteLine(result);
}
