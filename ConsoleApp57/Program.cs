class Programm
{
    static int Compare(string str1, string str2)
    {
        int MinLength = Math.Min(str1.Length, str2.Length);
        int b = 3;

        for (int i = 0; i < MinLength; i++)
        {
            if (str1[i] > str2[i])
            {
                b = 1;
                break;
            }
            else if (str1[i] == str2[i])
            {
                b = 0;
            }
            else
            {
                b = -1;
                break;
            }
        }

        bool b1 = b == 0 && str1.Length < str2.Length;
        bool b2 = b == 0 && str2.Length < str1.Length;

        if (b1 == true) b = -1; else if (b2 == true) b = 1;

        return b;
    }

    static void ArrayCompare(string[] strArray)
    {
        string a = "";
        string[] newStrArray = strArray;

        for (int i1 = 0; i1 <= strArray.Length; i1++)
        {
            for (int i = 0; i < newStrArray.Length - 1; i++)
            {
                int b = Compare(newStrArray[i], newStrArray[i + 1]);

                if (b == -1 || b == 0)
                {
                    newStrArray[i] = newStrArray[i];
                    newStrArray[i + 1] = newStrArray[i + 1];
                }

                if (b == 1)
                {
                    a = newStrArray[i];
                    newStrArray[i] = newStrArray[i + 1];
                    newStrArray[i + 1] = a;
                }
            }
        }
        for (int i2 = 0; i2 < newStrArray.Length; i2++)
        {
            Console.WriteLine(newStrArray[i2]);
        }
    }

    static void Main(string[] args)
    {
        string[] strArray = new string[4] { "слон", "слониха", "сон", "решение" };
        ArrayCompare(strArray);
    }
}
