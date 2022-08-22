using System.Linq;

//Calculate the average of numbers in given array
//Empty arrays should return 0

var array = new double[] { 1.0, 2.0, 3.0 };

static double FindAverage(double[] array)
{
    return array.Length == 0 ? 0 : array.Average();
}

Console.WriteLine(FindAverage(array)); 



















