using System.Globalization;



TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

string s = Console.ReadLine();

string result = Result.timeConversion(s);

textWriter.WriteLine(result);

textWriter.Flush();
textWriter.Close();

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var result = Convert.ToDateTime(s);
        string convertTo12Format = result.ToString("hh:mm:ss", CultureInfo.CurrentCulture); // to 12
        string convertTo24Format = result.ToString("HH:mm:ss", CultureInfo.CurrentCulture); // to 24
        return convertTo24Format;
    }

}


