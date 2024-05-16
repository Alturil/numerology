namespace Numerology.Api.Models;

public class NameResult
{
    public string Name { get; set; } = string.Empty;
    public NumberValue NumberValue { get; set; } = new();
    public int YearsInLifeCycle { get; set; }
}
