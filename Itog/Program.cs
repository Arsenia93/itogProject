using System;
using System.Collections.Generic;
string[] massive = { "Life", "is", "just", "a", "joke" };
int i = 0;
int size = 0;

while (massive.Length > i)
{
   if (massive[i].Length < 4 && massive[i].Length > 0)    
        size++;
        Console.Write("{0} ", massive[i]);
        i++;
}
Console.WriteLine();
string[] massive2 = new string[size];
i = 0;
int j = 0;
while (massive.Length > i)
{
    if (massive[i].Length < 4 && massive[i].Length > 0)    
    {
        massive2[j] = massive[i];
        Console.Write("{0} ", massive2[j]);
        j++;
    }
    i++;
}

