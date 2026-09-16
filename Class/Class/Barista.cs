using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Class;

public class Barista
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    public int Id { get; set;}
    /// <summary>
    /// Фио баристы
    /// </summary>
    public string FullName { get; set; }
    /// <summary>
    /// Сколько работает
    /// </summary>
    public int Experience { get; set; }
    /// <summary>
    /// Рейтинг баристы
    /// </summary>
    public double Rating { get; set; }

    public string GetInfo()
    {
        return FullName + " (" + Experience + " года, рейтинг " + Rating + ")";
    }
}
