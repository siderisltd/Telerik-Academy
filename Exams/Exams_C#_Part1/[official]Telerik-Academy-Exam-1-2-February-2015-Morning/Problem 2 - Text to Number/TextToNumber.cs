using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string text = input.ToUpper();
        char currentChar;
        int stupitOrder = 65;
        int result = 0;
        int digit;
        //bool isParsed = false;
        //Console.WriteLine((int)a - stupitOrder);

        for (int i = 0; i < text.Length; i++)
        {
            currentChar = text[i];
            if (int.TryParse(text[i].ToString(),out digit))
            {
                result = result * digit;
            }
            if (text[i] == 'A' || text[i] == 'B' || text[i] == 'C' || text[i] == 'D' || text[i] == 'E' || text[i] == 'F' ||
                text[i] == 'G' || text[i] == 'H' || text[i] == 'I' || text[i] == 'J' || text[i] == 'K' || text[i] == 'L' ||
                text[i] == 'M' || text[i] == 'N' || text[i] == 'O' || text[i] == 'P' || text[i] == 'Q' || text[i] == 'R' ||
                text[i] == 'S' || text[i] == 'T' || text[i] == 'U' || text[i] == 'V' || text[i] == 'W' || text[i] == 'X' ||
                text[i] == 'Y' || text[i] == 'Z')
            {
                result = result + ((int)text[i] - stupitOrder);
            }
            else 
            {
                result = result % m;
            }
            if (text[i] == '@')
            {
                Console.WriteLine(result);
                break;
            }

        }
    }
}