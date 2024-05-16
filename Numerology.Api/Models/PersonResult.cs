namespace Numerology.Api.Models;

public class PersonResult
{
    public NameResult Name { get; set; } = new();
    public DateOfBirthResult DateOfBirth { get; set; } = new();
    public int VibrationNumber { get; set; }
}
