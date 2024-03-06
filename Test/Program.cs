// See https://aka.ms/new-console-template for more information



int[] array = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

//Find the sum of all the integers in the array.

int sum = 0;

foreach (int num in array)
{
    sum += num;
}

Console.WriteLine("The sum of all integers in the array is: " + sum);

//Find the maximum and minimum values in the array

int max = array.Max();
int min = array.Min();

Console.WriteLine("The maximum value in the array is: " + max);
Console.WriteLine("The minimum value in the array is: " + min);

//Count the number of even and odd integers in the array

int evenCount = 0;
int oddCount = 0;

foreach (int number in array)
{
    if (number % 2 == 0)
    {
        evenCount++;
    }
    else
    {
        oddCount++;
    }
}

Console.WriteLine("The number of even integers in the array is: " + evenCount);
Console.WriteLine("The number of odd integers in the array is: " + oddCount);

//Calculate the average of all the integers in the array.

int sum1 = 0;

foreach (int value in array)
{
    sum1 += value;
}

double average = (double)sum1 / array.Length;

Console.WriteLine("The average of all the integers in the array is: " + average);

//Check if a specific integer is present in the array.

int specificInteger = 42;
bool isPresent = false;

foreach (int num2 in array)
{
    if (num2 == specificInteger)
    {
        isPresent = true;
        break;
    }
}

if (isPresent)

{
    Console.WriteLine($"Is {specificInteger} present in the array? {isPresent}");
}
else
{
    Console.WriteLine($"Is {specificInteger} is present in the array? {isPresent}");
}

//Create two dimensional Array.
//Create a program that finds the sum of all elements in a two-dimensional array (matrix).

int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int sum3 = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        sum3 += matrix[row, col];
    }
}


Console.WriteLine("The sum of all elements in the matrix is: " + sum3);








