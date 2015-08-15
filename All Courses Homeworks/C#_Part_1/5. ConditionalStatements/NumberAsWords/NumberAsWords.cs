//Problem 11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.


using System;

class NumberAsWords
{
    public static bool shouldAdd = true;
    public static string result = string.Empty;

    static void Main()
    {
        int numberAsDigit = 12;
        string word = numberAsWord(numberAsDigit);
        Console.WriteLine(word);
    }

    private static string numberAsWord(int number)
    {

        string numberAsString = number.ToString();
        int numberLength = numberAsString.Length;
        //Main logic
        if (numberLength == 3)
        {
            if (shouldAdd)
            {
                int hundreds = ((number / 100) % 10) | 0;
                oneNine(hundreds);
                result += " " + "Hundred" + " ";
                shouldAdd = true;
            }

            var decimals = ((number / 10) % 10) | 0;
            var singles = ((number % 10) | 0);

            if (decimals == 0 && singles == 0)
            {
                shouldAdd = false;
            }
            var numberWithoutHundreds = ((number % 100) | 0);

            if (shouldAdd == true && decimals != 0)
            {
                twentyNinety(numberWithoutHundreds);
            }

            if (shouldAdd == true)
            {
                tenTwenty(numberWithoutHundreds);
            }

            if (shouldAdd == true)
            {
                if (decimals != 0)
                {
                    twentyNinety(decimals);
                }
                result += " ";
                oneNine(singles);
            }
        }
        if (numberLength == 2)
        {

            if (shouldAdd == true)
            {
                tenTwenty(number);
            }

            if (shouldAdd == true)
            {
                twentyNinety(number);
                result += " ";
            }

            if (shouldAdd == true)
            {
                var decimals = ((number / 10) % 10) | 0;
                twentyNinety(decimals);
                result += " ";
                var singles = (number % 10) | 0;
                oneNine(singles);
            }
        }
        if (numberLength == 1)
        {
            oneNine(number);
        }
        //printingResult
        result = result.Trim();
        string[] newresult = result.Split(new char[] { '.', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        result = String.Join(" ", newresult);
        return result;
    }
    private static void oneNine(int digit)
    {
        switch (digit)
        {
            case 1: shouldAdd = false; result += "One"; break;
            case 2: shouldAdd = false; result += "Two"; break;
            case 3: shouldAdd = false; result += "Three"; break;
            case 4: shouldAdd = false; result += "Four"; break;
            case 5: shouldAdd = false; result += "Five"; break;
            case 6: shouldAdd = false; result += "Six"; break;
            case 7: shouldAdd = false; result += "Seven"; break;
            case 8: shouldAdd = false; result += "Eight"; break;
            case 9: shouldAdd = false; result += "Nine"; break;
        }
    }
    private static void tenTwenty(int num)
    {
        switch (num)
        {
            case 10: shouldAdd = false; result += "Ten"; break;
            case 11: shouldAdd = false; result += "Eleven"; break;
            case 12: shouldAdd = false; result += "Twelve"; break;
            case 13: shouldAdd = false; result += "Thirteen"; break;
            case 14: shouldAdd = false; result += "Fourteen"; break;
            case 15: shouldAdd = false; result += "Fifteen"; break;
            case 16: shouldAdd = false; result += "Sixteen"; break;
            case 17: shouldAdd = false; result += "Seventeen"; break;
            case 18: shouldAdd = false; result += "Eighteen"; break;
            case 19: shouldAdd = false; result += "Nineteen"; break;
            case 20: shouldAdd = false; result += "Twelve"; break;
        }
    }
    private static void twentyNinety(int digit)
    {
        switch (digit)
        {

            case 2: shouldAdd = false; result += "Twenty"; break;
            case 3: shouldAdd = false; result += "Thirty"; break;
            case 4: shouldAdd = false; result += "Forty"; break;
            case 5: shouldAdd = false; result += "Fifty"; break;
            case 6: shouldAdd = false; result += "Sixty"; break;
            case 7: shouldAdd = false; result += "Seventy"; break;
            case 8: shouldAdd = false; result += "Eighty"; break;
            case 9: shouldAdd = false; result += "Ninety"; break;

            case 20: shouldAdd = false; result += "Twenty"; break;
            case 30: shouldAdd = false; result += "Thirty"; break;
            case 40: shouldAdd = false; result += "Forty"; break;
            case 50: shouldAdd = false; result += "Fifty"; break;
            case 60: shouldAdd = false; result += "Sixty"; break;
            case 70: shouldAdd = false; result += "Seventy"; break;
            case 80: shouldAdd = false; result += "Eighty"; break;
            case 90: shouldAdd = false; result += "Ninety"; break;
        }
    }
    private static void hundrets(int num)
    {
        switch (num)
        {
            case 100: shouldAdd = false; result += "Twenty"; break;
            case 200: shouldAdd = false; result += "Twenty"; break;
            case 300: shouldAdd = false; result += "Thirty"; break;
            case 400: shouldAdd = false; result += "Forty"; break;
            case 500: shouldAdd = false; result += "Fifty"; break;
            case 600: shouldAdd = false; result += "Sixty"; break;
            case 700: shouldAdd = false; result += "Seventy"; break;
            case 800: shouldAdd = false; result += "Eighty"; break;
            case 900: shouldAdd = false; result += "Ninety"; break;
        }
    }

}



