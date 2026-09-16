namespace Class;

internal class CsvRepository
{
    private string _basePath;
    public CsvRepository(string basePath) { _basePath = basePath; }

    public List<Drink> GetDrinks()
    {
        List<Drink> result = new List<Drink>();
        string[] lines = File.ReadAllLines(Path.Combine(_basePath, "drinks.csv"));
        if (lines.Length < 2) return result;
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(';');
            if (parts.Length < 6) continue;
            Drink b = new Drink();
            b.Id = int.Parse(parts[0]);
            b.Name = parts[1];
            b.ShiftId = int.Parse(parts[2]);
            b.BaristaId = int.Parse(parts[3]);
            b.Price = decimal.Parse(parts[4]);
            b.Volume = int.Parse(parts[5]);
            result.Add(b);
        }
        return result;
    }
    public List<Barista> GetBaristas()
    {
        List<Barista> result = new List<Barista>();
        string[] lines = File.ReadAllLines(Path.Combine(_basePath, "baristas.csv"));
        if (lines.Length < 2) return result;
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(';');
            if (parts.Length < 4) continue;
            Barista b = new Barista();
            b.Id = int.Parse(parts[0]);
            b.FullName = parts[1];
            b.Experience = int.Parse(parts[2]);
            b.Rating = double.Parse(parts[3]);
            result.Add(b);
        }
        return result;
    }
    public List<Shift> GetShifts()
    {
        List<Shift> result = new List<Shift>();
        string[] lines = File.ReadAllLines(Path.Combine(_basePath, "shifts.csv"));
        if (lines.Length < 2) return result;
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(';');
            if (parts.Length < 3) continue;
            Shift b = new Shift();
            b.Id = int.Parse(parts[0]);
            b.Time = parts[1];
            b.Date = DateTime.Parse(parts[2]);
            result.Add(b);
        }
        return result;
    }
}