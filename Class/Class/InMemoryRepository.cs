namespace Class;

internal class InMemoryRepository
{
    private List<Barista> _baristas;
    private List<Shift> _shifts;
    private List<Drink> _drinks;
    public InMemoryRepository()
    {
        _baristas = new List<Barista>()
        {
            new Barista { Id = 1, FullName = "Петров П.П.",  Experience = 3, Rating = 4.8 },
            new Barista { Id = 2, FullName = "Павлов В.И.",  Experience = 2, Rating = 3.7 },
            new Barista { Id = 3, FullName = "Иванов И.И.",  Experience = 5, Rating = 1.9 },
            new Barista { Id = 4, FullName = "Сидоров А.Р.",  Experience = 7, Rating = 2.3 },
            new Barista { Id = 5, FullName = "Кузнецов П.Д.",  Experience = 1, Rating = 4.5 },
            new Barista { Id = 6, FullName = "Смирнов Д.В.",  Experience = 2, Rating = 4.1 }
        };
        _shifts = new List<Shift>()
        {
            new Shift { Id = 1, Time = "Утренняя", Date = new DateTime(2025, 9, 1)},
            new Shift { Id = 2, Time = "Дневная", Date = new DateTime(2025, 9, 1)},
            new Shift { Id = 3, Time = "Вечерняя", Date = new DateTime(2025, 9, 1)},
            new Shift { Id = 4, Time = "Утренняя", Date = new DateTime(2025, 9, 2)},
            new Shift { Id = 5, Time = "Дневная", Date = new DateTime(2025, 9, 2)},
            new Shift { Id = 6, Time = "Вечерняя", Date = new DateTime(2025, 9, 2)},
            new Shift { Id = 7, Time = "Утренняя", Date = new DateTime(2025, 9, 3)},
            new Shift { Id = 8, Time = "Дневная", Date = new DateTime(2025, 9, 3)},
            new Shift { Id = 9, Time = "Вечерняя", Date = new DateTime(2025, 9, 3)},
        };
        _drinks = new List<Drink>()
        {
            new Drink {Id = 1, Name = "Латте", ShiftId = 1, BaristaId = 1, Price = 200, Volume = 300},
            new Drink {Id = 2, Name = "Американо", ShiftId = 2, BaristaId = 3, Price = 180, Volume = 300},
            new Drink {Id = 3, Name = "Эспрессо", ShiftId = 2, BaristaId = 3, Price = 190, Volume = 270},
            new Drink {Id = 4, Name = "Раф", ShiftId = 3, BaristaId = 5, Price = 250, Volume = 250},
            new Drink {Id = 5, Name = "Мокко", ShiftId = 3, BaristaId = 5, Price = 200, Volume = 270},
            new Drink {Id = 6, Name = "Капучино", ShiftId = 4, BaristaId = 3, Price = 220, Volume = 250},
            new Drink {Id = 7, Name = "Черный чай", ShiftId = 4, BaristaId = 3, Price = 210, Volume = 300},
            new Drink {Id = 8, Name = "Зеленый чай", ShiftId = 5, BaristaId = 2, Price = 180, Volume = 270},
            new Drink {Id = 9, Name = "Улун", ShiftId = 5, BaristaId = 2, Price = 190, Volume = 300},
            new Drink {Id = 10, Name = "Ромашковый чай", ShiftId = 6, BaristaId = 3, Price = 200, Volume = 300},
            new Drink {Id = 11, Name = "Имбирный чай", ShiftId = 6, BaristaId = 3, Price = 210, Volume = 250},
            new Drink {Id = 12, Name = "Красный чай", ShiftId = 7, BaristaId = 6, Price = 220, Volume = 250},
        };
    }
    public List<Barista> GetBaristas() { return _baristas; }
    public List<Shift> GetShifts() { return _shifts; }
    public List<Drink> GetDrinks() { return _drinks; }
}
