using System;

namespace VSoftwareTask
{
    class Program
    {
        static string Encode(string str, int numberOfRails)
        {
            string encodedStr = "";
            char[,] rail = new char[numberOfRails, str.Length];
            bool directionDown = false;
            int row = 0;
            int col = 0;

            for (int i = 0; i < numberOfRails; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    rail[i, j] = '\n';
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if((row == 0) || (row == numberOfRails - 1))
                {
                    directionDown = !directionDown;
                }

                rail[row, col++] = str[i];

                if (directionDown)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            } 

            for (int i = 0; i < numberOfRails; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if(rail[i, j] != '\n')
                    {
                        encodedStr += rail[i, j];
                    }
                }
            }

            return encodedStr;
        }
        static string Decode(string encodedStr, int numberOfRails)
        {
            string decodedStr = "";
            char[,] rail = new char[numberOfRails, encodedStr.Length];
            bool directionDown = false;
            int row = 0;
            int col = 0;

            for (int i = 0; i < numberOfRails; i++)
            {
                for (int j = 0; j < encodedStr.Length; j++)
                {
                    rail[i, j] = ' ';
                }
            }

            for (int i = 0; i < encodedStr.Length; i++)
            {
                if(row == 0)
                {
                    directionDown = true;
                }
                if(row == numberOfRails-1)
                {
                    directionDown = false;
                }

                rail[row, col++] = '#';

                if (directionDown)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            int pointer = 0;

            for (int i = 0; i < numberOfRails; i++)
            {
                for (int j = 0; j < encodedStr.Length; j++)
                {
                    if((rail[i, j] == '#') && (pointer < encodedStr.Length))
                    {
                        rail[i, j] = encodedStr[pointer++];
                    }
                }
            }

            row = 0;
            col = 0;

            for (int i = 0; i < encodedStr.Length; i++)
            {
                if(row == 0)
                {
                    directionDown = true;
                }
                if(row == numberOfRails - 1)
                {
                    directionDown = false;
                }
                if(rail[row, col] != '#')
                {
                    decodedStr += rail[row, col++];
                }
                if (directionDown)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            return decodedStr;
        }
        static void Main(string[] args)
        {
            // TASK 1. Rail Fence Cipher. Encoding and Decoding

            //string encoded = Encode("WEAREDISCOVEREDFLEEATONCE", 3);
            //Console.WriteLine($"Encoded :  {encoded}");
            //Console.WriteLine($"Decoded :  {Decode(encoded, 3)}");



        }
    }
}
