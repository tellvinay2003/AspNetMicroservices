// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("hello world");



public class MathFunctions
{


    public static void Main(string[] args)
    {
        string strName = "vinay";
        string result = strName.ChangeFirstLetterCase();
    }




}


public static class StringHelper
{

    public static string ChangeFirstLetterCase(this string inputString)
    {
        if (inputString.Length > 0)
        {
            char[] charArray = inputString.ToCharArray();
            charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
            return new string(charArray);
        }

        return inputString;
    }
}