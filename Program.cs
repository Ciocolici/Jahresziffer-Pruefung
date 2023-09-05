namespace JahreszifferPruefung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Weil die astronomische Dauer eines Jahres(wenn die Erde die Sonne einmal umrundet
            //hat) etwas länger ist als 365 Tage, wurden Schaltjahre zum Ausgleich eingeführt.

            //Ein Schaltjahr ist ein Jahr, welches eine Jahreszahl hat, die durch 4 teilbar ist.
            //Jahreszahlen, die durch 100 teilbar sind, sind allerdings keine Schaltjahre.Es sei denn, die Jahreszahl ist durch 400 teilbar.

            //Erstellen Programm, welches prüft, ob eine eingegebene Jahresziffer ein Schaltjahr ist
            //oder nicht und anschließend eine entsprechende Antwort ausgibt.



            // Title Jahresziffer Prüfung
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n      _           _                                 _    __    __                   ____           _   _    __                         \r\n     | |   __ _  | |__    _ __    ___   ___   ____ (_)  / _|  / _|   ___   _ __    |  _ \\   _ __  (_) (_)  / _|  _   _   _ __     __ _ \r\n  _  | |  / _` | | '_ \\  | '__|  / _ \\ / __| |_  / | | | |_  | |_   / _ \\ | '__|   | |_) | | '__| | | | | | |_  | | | | | '_ \\   / _` |\r\n | |_| | | (_| | | | | | | |    |  __/ \\__ \\  / /  | | |  _| |  _| |  __/ | |      |  __/  | |    | |_| | |  _| | |_| | | | | | | (_| |\r\n  \\___/   \\__,_| |_| |_| |_|     \\___| |___/ /___| |_| |_|   |_|    \\___| |_|      |_|     |_|     \\__,_| |_|    \\__,_| |_| |_|  \\__, |\r\n                                                                                                                                 |___/ \r\n");

            // Variables
            bool check;
            int jahr;

            // Loop asking for the year, if the user gives something else other than a number it is prompted to answer again
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bitte geben Sie ein Jahr ein.");
                check = int.TryParse(Console.ReadLine(), out jahr);

                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Verwenden Sie bitte nur Ziffern.");
                }
            } while (check == false);

            // Variables: The Variables use the modulus operator ( % ) to check if the variable "jahr" (with the value given by the user) is evenly divisible by 4, 100 and 400 respectively.
            // The result from a modulus operator being the rest after ",", 0 being if there is no rest, also it is evenly divisible
            int jahrTeil4 = jahr % 4;
            int jahrTeil100 = jahr % 100;
            int jahrTeil400 = jahr % 400;

            // if-else checking if the year given by the user is a leap year or not
            // if the year is evenly divisible by 4 and it either: isn't even evenly divisible by 100 or it is evenly divisible by 400, it is a leap year
            // Otherwise it isn't one.
            Console.Clear();
            if(jahrTeil4 == 0 && (jahrTeil100 > 0 || jahrTeil400 == 0)) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{jahr} ist ein Schaltjahr");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{jahr} ist nicht ein Schaltjahr");
            }

        }
    }
}