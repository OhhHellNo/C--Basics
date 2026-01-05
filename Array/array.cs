/* an array is a fixed size ordered collection of the same type stored in congtiguious memory location .*/




/* Declaration and initialization */

/* For declaring just write the type and name*/
// int[] numbers;


/* Declaration along with initialization*/
// int[] numbers = new int[5];

/* Declaration along with value*/
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];




/* Accessing Values*/
int first = numbers[0];
int third = numbers[2];


/* Modify elements*/
numbers[1] = 25;


/*Finding the length of the arrray*/
int length = numbers.Length;


// Filtering 

var evens = numbers.Where(x => x % 2 == 0).ToArray;


// Mapping
var squared = numbers.Select(x => x * x).ToArray;



// Aggregation
int sum = numbers.Sum();
double average = numbers.Average();
int max = numbers.Max();
int min = numbers.Min();



//Basic 2d array .


int[,] twodarray =
{
    {11 , 12 , 13 ,14},
    {11 , 12 , 13,14 },
    {11 , 12 , 13,14 }};




//Accessing the value of a 2d array .
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine(twodarray[i, j]);
    }
}