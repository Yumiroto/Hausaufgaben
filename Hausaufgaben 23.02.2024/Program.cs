using System;

namespace Hausaufgabe_23._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            float[,,] messwerte = new float[12,31,24];
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++) 
                {
                    for(int k = 0; k < 24; k++)
                    {
                        messwerte[i, j, k] = random.Next(1,101);
                    }
                }
            }
            mainmenu();
            Console.WriteLine();
            while (running)
            {

                switch (Console.ReadLine())
                {
                    case "min":
                        float minValue = getMinValue(messwerte);
                        Console.WriteLine(minValue);
                        Console.WriteLine();
                        break;
                        case "max":
                        float maxValue = getMaxValue(messwerte);
                        Console.WriteLine(maxValue);
                        Console.WriteLine();
                        break;
                    case "mid":
                        float midValue = getMidValue(messwerte);
                        Console.WriteLine(midValue);
                        Console.WriteLine();
                        break;
                    case "exit":
                        running = false;
                        break;
                        default:
                        Console.WriteLine("falsche Eingabe");
                        break;

                }

            }


        }
        static void mainmenu()
        {
            Console.WriteLine("Befehle:");
            Console.WriteLine("mid Um den durchschnit aller Werte zu bekommen");
            Console.WriteLine("min um den kleinsten Wert zu bekommen");
            Console.WriteLine("max um den größten Wert zu bekommen");
            Console.WriteLine("exit um das Programm zu schließen");
        }
        static float getMinValue(float[,,] messwerte)
        {
            float minValue = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    for (int k = 0; k < 24; k++)
                    {
                        if(minValue > messwerte[i, j, k])
                        {
                            minValue = messwerte[i, j, k];
                        }
                    }
                }
                
            }
            return minValue;
        }
        static float getMaxValue(float[,,] messwerte)
        {
            float maxValue = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    for (int k = 0; k < 24; k++)
                    {
                        if (maxValue < messwerte[i, j, k])
                        {
                            maxValue = messwerte[i, j, k];
                        }
                    }
                }

            }
            return maxValue;
        }
        static float getMidValue(float[,,] messwerte)
        {
            float midValue = 0;
            int count = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    for (int k = 0; k < 24; k++)
                    {
                        midValue += messwerte[i, j, k];
                        count++;
                    }
                }



            }
            midValue /= count;
            return midValue;
        }
    }  
    
}
