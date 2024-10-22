// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.plusMinus(arr);
class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var numberOfArray = arr.Count();
        var positiveNumsCount = 0m;
        var negativeNumsCount = 0m;
        var zeroNumCount = 0m;
        foreach (int i in arr)
        {
            if (i == 0) zeroNumCount++;

            else if (i > 0) positiveNumsCount++;
            else
                negativeNumsCount++;


        }
        decimal positiveRatio = positiveNumsCount / numberOfArray;
        decimal negativeRatio = negativeNumsCount / numberOfArray;
        decimal zeroRatio = zeroNumCount / numberOfArray;

        Console.WriteLine(positiveRatio.ToString("F6"));
        Console.WriteLine(negativeRatio.ToString("F6"));
        Console.WriteLine(zeroRatio.ToString("F6"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
       
    }
}



