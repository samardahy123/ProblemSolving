// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

Result.miniMaxSum(arr);

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
   
    
    public static void miniMaxSum(List<long> arr)
    {
        long sumMax = 0;
        long sumMin = 0;

        var orderedArray= arr.OrderBy(c => c);


        foreach (var item in orderedArray) {

          var sum=orderedArray.Sum(c => c)-item;
          
            if(sum>sumMax) 
                sumMax = sum;
            else sumMin = sum;

          
        }

        Console.WriteLine(sumMin + " " + sumMax);

    }

}

class Solution
{
    public static void Main(string[] args)
    {

       
    }
}
