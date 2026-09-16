namespace Class;

/// <summary>
/// Смена в кофейне.
/// </summary>
public class Shift
{
    /// <summary>
    /// Первичный ключ.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название смены (например, "Утренняя").
    /// </summary>
    public string Time { get; set; } = string.Empty;

    /// <summary>
    /// Дата смены.
    /// </summary>
    public DateTime Date { get; set; }
    public string GetInfo()
    {
        return Time + " (" + Date.ToString("dd.MM.yyyy") + ")";
    }
}
