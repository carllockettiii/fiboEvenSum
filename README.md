# Easy Fibonacci Even Numbers Total

By considering the terms in the Fibonacci sequence whose values do not exceed (n), find the sum of the even-valued terms. This a Project Euler Problem.

## Installation

In Microsoft Visual Studio, create a new Console App and then copy and paste the solution into and run. 



## Usage

```C#
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

```

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)
