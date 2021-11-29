using System;
using System.IO;


class Program
{

    public static void Main()
    {   
        string path1 = Console.ReadLine();
        string path = Console.ReadLine();
        

       
        string sr = File.ReadAllText(path);
        {
            string sp = File.ReadAllText(path1);
            {
                string[] separators1 = { " ", "\r\n" };
                string[] mass1 = sp.Split(separators1, StringSplitOptions.None);
                float a = float.Parse(mass1[0]);
                float b = float.Parse(mass1[1]);
                float R = float.Parse(mass1[2]);
              
                string[] separators = { " ", "\r\n" };
                string[] mass = sr.Split(separators, StringSplitOptions.None);
               
                int i = 0;

                while (i < mass.Length - 1)
                {
                    string x1 = mass[i];
                    string y1 = mass[i + 1];
                    float x = float.Parse(x1);
                    float y = float.Parse(y1);

                    float R2 = (x - a) * (x - a) + (y - b) * (y - b);
                    float R3 = R * R;

                    if (R2 == R3)
                    {
                        Console.WriteLine("0");
                    }
                    else if (R2 < R3)
                    {
                        Console.WriteLine("1");
                    }
                    else if (R2 > R3)
                    {
                        Console.WriteLine("2");
                    }
                    i = i + 2;
                }

            
             
            }
        }
        
    }
}
