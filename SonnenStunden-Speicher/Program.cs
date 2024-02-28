namespace Sonnenstunden_Speicher
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool running = true;
            float[] sonnenStunden = new float[7];

            while (running)
            {
                Console.Clear();
                Menu();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        SonnenstundenEingebe(sonnenStunden);
                        break;

                    case "2":
                        Console.Clear();
                        PrintSonnenstunden(sonnenStunden);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Der Druchschnitt berträgt: {CalculateMidValue(sonnenStunden)} Stunden."); 
                        Console.ReadKey();
                        break;

                    case "4":
                         Console.Clear() ;
                        Console.WriteLine($"Der Maximalwert beträgt: {CalculateMaxValue(sonnenStunden)}");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine($"Der Minimalwert beträgt: {CalculateMinValue(sonnenStunden)}");
                        Console.ReadKey();
                        break;
                    case "6":
                        running = false;
                        break;


                }

            }
        }
      

        static void Menu()
        {
            Console.WriteLine("Sonnenstuden der letzten Woche");
            Console.WriteLine("##############################");
            Console.WriteLine("[1] Sonnenstuden eingabe");
            Console.WriteLine("[2] Sonnenstunden ausgabe");
            Console.WriteLine("[3] Durchschnitt berechnen");
            Console.WriteLine("[4] Maximum");
            Console.WriteLine("[5] Mininmum");
            Console.WriteLine("[6] Beenden");
        }

        static float InputToFloat()
        {
            bool convertion = false;
            float result = 0;
            while (!convertion)
            {
                convertion = float.TryParse(Console.ReadLine(), out result);

                if (!convertion)
                {
                    Console.WriteLine("falsche Eingabe bitte versuchen Sie es erneut");
                }
            }
            return result;

        }
        static float[] SonnenstundenEingebe(float[] sonnenStunden)
        {
            bool running = true;
            
            int index = 0;
            while (running)
            {   
                
                Console.WriteLine("Bitte gebe einen Tag ein oder exit um zum Menü zurück zu kommen.");
                string eingabe = Console.ReadLine().ToLower();
                Console.WriteLine("Bitte gebe die Anzahl der Sonnestunden ein.");
                switch (eingabe)
                {
                    case "montag":
                        sonnenStunden[0] = InputToFloat();
                        index = 0;
                        break;
                    case "dienstag":
                        sonnenStunden[1] = InputToFloat();
                        index = 1;
                        break;
                    case "mittwoch":
                        sonnenStunden[2] = InputToFloat();
                        index = 2;
                        break;
                    case "donnerstag":
                        sonnenStunden[3] = InputToFloat();
                        index = 3;
                        break;
                    case "freitag":
                        sonnenStunden[4] = InputToFloat();
                        index = 4;
                        break;
                    case "samstag":
                        sonnenStunden[5] = InputToFloat();
                        index = 5;
                        break;
                    case "sonntag":
                        sonnenStunden[6] = InputToFloat();
                        index = 6;
                        break;
                    case "exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        break;


                }
                Console.WriteLine($"Am {eingabe} wurden {sonnenStunden[index]} Stunden eingetragen.");
                Console.WriteLine();
            }
            return sonnenStunden;
        }
        
        static void PrintSonnenstunden(float[] sonnenStunden)
        {
            
            string[] weekDays = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
            Console.WriteLine();
            for (int i = 0; i< sonnenStunden.Length; i++)
            {
                Console.WriteLine($"{weekDays[i]}: \t{sonnenStunden[i]} Stunden");
            }
            Console.ReadKey();
        }
        
        static float CalculateMidValue(float[] sonnenStunden)
        {
            float midValue = 0f;
            for (int i = 0;i< sonnenStunden.Length;i++)
            {
                midValue += sonnenStunden[i];
            }
            return midValue / sonnenStunden.Length;
        }
        
        static float CalculateMaxValue(float[] sonnenStunden)
        {
            float maxValue = sonnenStunden[0];
            for (int i = 0;i< sonnenStunden.Length ; i++)
            {
                if (maxValue < sonnenStunden[i])
                {
                    maxValue = sonnenStunden[i];
                }
            }
            return maxValue;
        }

        static float CalculateMinValue(float[] sonnenStunden)
        {
            float minValue = sonnenStunden[0];
            for (int i = 0; i < sonnenStunden.Length; i++)
            {
                if (minValue > sonnenStunden[i])
                {
                    minValue = sonnenStunden[i];
                }
            }
            return minValue;
        }


    }
}
