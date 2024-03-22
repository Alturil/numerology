namespace Numerology.Api.Models;

public record NumberLetters
{
    public int Number { get; set; }
    public List<char> Letters { get; set; } = new();
}
