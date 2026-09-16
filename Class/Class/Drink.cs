using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Class;

public class Drink
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название напитка
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Внешний ключ смены
    /// </summary>
    public int ShiftId { get; set; }

    /// <summary>
    /// Внешний ключ бариста
    /// </summary>
    public int BaristaId { get; set; }

    /// <summary>
    /// Цена напитка в рублях
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Объём напитка в миллилитрах
    /// </summary>
    public int Volume { get; set; }

    public string GetInfo()
    {
        return Name + " (" + Price + " руб., " + Volume + " мл)";
    }
}
