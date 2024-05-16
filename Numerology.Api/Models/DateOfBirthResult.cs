namespace Numerology.Api.Models;

public class DateOfBirthResult
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public NumberValue NumberValue { get; set; } = new();
}
