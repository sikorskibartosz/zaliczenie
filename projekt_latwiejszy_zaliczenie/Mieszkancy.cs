namespace Pesel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę miasta:");
            string city = Console.ReadLine();

            Console.WriteLine("Podaj imię, nazwisko i PESEL mieszkańca:");
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string pesel = Console.ReadLine();

            if (!IsPeselValid(pesel))
            {
                Console.WriteLine("Podany numer PESEL jest nieprawidłowy.");
                return;
            }

            List<Mieszkancy> residents = new List<Mieszkancy>();
            residents.Add(new Mieszkancy(city, name, surname, pesel));

            // Nadpisanie wpisu dla tego samego numeru PESEL, ale innego imienia i nazwiska
            for (int i = 0; i < residents.Count; i++)
            {
                if (residents[i].Pesel == pesel)
                {
                    residents[i] = new Mieszkancy(city, name, surname, pesel);
                }
            }

            // Zapisanie listy mieszkańców do pliku
            using (StreamWriter sw = new StreamWriter("D:/residents.txt"))
            {
                foreach (Mieszkancy resident in residents)
                {
                    sw.WriteLine(resident.ToString());
                }
            }
        }

        public static bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11) return false;

            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += weights[i] * (pesel[i] - '0');
            }
            int controlDigit = 10 - sum % 10;

            return pesel[10] - '0' == controlDigit;
        }
    }

    class Mieszkancy
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }

        public Mieszkancy(string city, string name, string surname, string pesel)
        {
            City = city;
            Name = name;
            Surname = surname;
            Pesel = pesel;
        }

        public override string ToString()
        {
            return $"{City}, {Name} {Surname}, {Pesel}";
        }
    }
}