using System;

    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter amount of money (0.01, 0.05, 0.25, 1, 5, 10, 20, 50, 100, 200, 500, 1000): ");
            string DenominationEntered = Console.ReadLine();

            if (decimal.TryParse(DenominationEntered, out decimal amount))
            {
                string person = DeterminePerson(amount);
                if (person != null)
                {
                    Console.WriteLine($"{person} is found in PHP {amount}.");
                }
                else
                {
                    Console.WriteLine($"No person found in PHP {amount}.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid Denomination: {DenominationEntered}");
            }
        }

        static string DeterminePerson(decimal amount)
        {
            if (amount == 0.01m || amount == 0.05m || amount == 0.25m)
                return "No person";
            else if (amount == 1m)
                return "Jose Rizal";
            else if (amount == 5m)
                return "Emilio Aguinaldo";
            else if (amount == 10m)
                return "Andres Bonifacio & Apolinario Mabini";
            else if (amount == 20m)
                return "Manuel L. Quezon";
            else if (amount == 50m)
                return "Sergio Osmena";
            else if (amount == 100m)
                return "Manuel Roxas";
            else if (amount == 200m)
                return "Diosdado Macapagal";
            else if (amount == 500m)
                return "Benigno Aquino Sr. & Corazon Aquino";
            else if (amount == 1000m)
                return "Jose Abad Santos, Josefa Escoda, & Vicente Lim";
            else
                return "Invalid Denomination";
        }
}
