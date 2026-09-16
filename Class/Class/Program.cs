using System.Xml.Linq;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирай загрузка 1 из InMemoryRepository или 2 из CsvRepository");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine($"Не ну ты тупой, тебе сказали выбири 1 или 2, а ты написал {input}.Выздоравливай, но боюсь тупость не лечится");
                return;
            }
            List<Drink> drinks = null;
            List<Barista> baristas = null;
            List<Shift> shifts = null;
            switch (choice)
            {
                case 1:
                    {
                        InMemoryRepository repository = new InMemoryRepository();
                        drinks = repository.GetDrinks();
                        baristas = repository.GetBaristas();
                        shifts = repository.GetShifts();
                        break;
                    }
                case 2:
                    {
                        CsvRepository repository = new CsvRepository("data");
                        drinks = repository.GetDrinks();
                        baristas = repository.GetBaristas();
                        shifts = repository.GetShifts();
                        break;
                    }
            }
            Barista barista = FindBarista(drinks, baristas, "Латте");
            Console.WriteLine(barista.GetInfo());
            Shift shift = FindShift(drinks, shifts, "Латте");
            Console.WriteLine(shift.GetInfo());
            Console.WriteLine(GetTotalVolume(drinks));
        }
        /// <summary>
        /// Ищет первого баристу по названию напитка
        /// </summary>
        /// <param name="drinks">Полученный лист напитков</param>
        /// <param name="baristas">Полученный лист барист</param>
        /// <param name="drinkName">Имя напитка</param>
        /// <returns></returns>
        static Barista? FindBarista(List<Drink> drinks, List<Barista> baristas, string drinkName)
        {
            if (drinkName == null) return null;
            for (int i = 0; i < drinks.Count; i++)
            {
                if (drinks[i].Name == drinkName)
                {
                    for (int j = 0; j < baristas.Count; j++)
                    {
                        if (baristas[j].Id == drinks[i].BaristaId) return baristas[j];
                    }
                    return null;
                }
            }
            return null;
        }
        /// <summary>
        /// Ищет первую смену по названию напитка
        /// </summary>
        /// <param name="drinks">Полученный лист напитков</param>
        /// <param name="shifts">Полученный лист смен</param>
        /// <param name="drinkName">Имя напитка</param>
        /// <returns></returns>
        static Shift? FindShift(List<Drink> drinks, List<Shift> shifts, string drinkName)
        {
            if (drinkName == null) return null;
            for (int i = 0; i < drinks.Count; i++)
            {
                if (drinks[i].Name == drinkName)
                {
                    for (int j = 0; j < shifts.Count; j++)
                    {
                        if (shifts[j].Id == drinks[i].ShiftId) return shifts[j];
                    }
                    return null;
                }
            }
            return null;
        }
        static int GetTotalVolume(List<Drink> drinks)
        {
            int totalVolume = 0;
            for (int i = 0; i < drinks.Count; i++)
            {
                totalVolume += drinks[i].Volume;
            }
            return totalVolume;
        }
    }
}
