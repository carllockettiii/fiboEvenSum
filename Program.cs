// See https://aka.ms/new-console-template for more information
static int FiboEvenSum(int number)
{
    int x = 0;
    int numberOne = 0;
    int numberTwo = 1;
    int counter = 0;
    int tempNumber = 0;

    while (x < number)
    {
        tempNumber = numberTwo + numberOne;
        numberOne = numberTwo;
        numberTwo = tempNumber;
        x = tempNumber;

        if ((x % 2) == 0)
        {
            counter += x;
        }
    }
    return counter;
}

int fib = 100000;
int result = FiboEvenSum(fib);
Console.WriteLine("Fibonacci even number of " + fib + " is " + result);
