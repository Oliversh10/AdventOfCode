using Microsoft.VisualBasic;
using System.Collections.Generic;

string valg;
string file = @"C:\Users\olive\OneDrive\Skrivebord\Coding\Advent\day1input.txt";


if (File.Exists(file))
{
    // læser al teksten i en string
    string str = File.ReadAllText(file);
    // læser linjerne i et array
    string[] strArr = File.ReadAllLines(file);

    int maxcalorier = 0;
    int elfbære = 0;

    foreach (string c in strArr)
    {
        if (String.IsNullOrEmpty(c))
        {
            if (elfbære >= maxcalorier)
            {
                maxcalorier = elfbære;
            }
            elfbære = 0;

        }
        else
        {
            int sInt = int.Parse(c);
            elfbære += sInt;
        }

    }


    // udskriver både hvad der står i dokumentet og hvad gennemsnittet er
    Console.WriteLine("Maximum calories carried by one elf: " + maxcalorier);


    int[] top3elf = { 0, 0, 0 };
    
    elfbære = 0;

    foreach (string s in strArr)
    {
        if (String.IsNullOrEmpty(s))
        {
            if (elfbære >= top3elf[0])
            {
                top3elf[2] = top3elf[1];
                top3elf[1] = top3elf[0];
                top3elf[0] = elfbære;
            }
            else if (elfbære >= top3elf[1])
            {
                top3elf[2] = top3elf[1];
                top3elf[1] = elfbære;
            }
            else if (elfbære >= top3elf[2])
            {
                top3elf[2] = elfbære;
            }
            elfbære = 0;

        }
        else
        {
            int sInt = int.Parse(s);
            elfbære += sInt;
        }
    }

    Console.WriteLine("Top1: " + top3elf[0]);
    Console.WriteLine("Top2: " + top3elf[1]);
    Console.WriteLine("Top3: " + top3elf[2]);
    Console.WriteLine("Top3 together: " + top3elf.Sum());

    Console.ReadLine();
}

