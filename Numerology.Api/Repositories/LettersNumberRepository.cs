using Numerology.Api.Models;

namespace Numerology.Api.Repositories;

public class LettersNumberRepository : ILettersNumberRepository
{
    private readonly List<NumberLetters> _numberLetters = new()
    {
        new() { Number = 1, Letters = new() { 'a', 'j', 's' } },
        new() { Number = 2, Letters = new() { 'b', 'k', 't' } },
        new() { Number = 3, Letters = new() { 'c', 'l', 'u' } },
        new() { Number = 4, Letters = new() { 'd', 'm', 'v' } },
        new() { Number = 5, Letters = new() { 'e', 'n', 'ñ', 'w' } },
        new() { Number = 6, Letters = new() { 'f', 'o', 'x' } },
        new() { Number = 7, Letters = new() { 'g', 'p', 'y' } },
        new() { Number = 8, Letters = new() { 'h', 'q', 'z' } },
        new() { Number = 9, Letters = new() { 'i', 'r', '&' } }
    };

    public int GetNumber(char letter)
    {
        return _numberLetters
            .Where(l => l.Letters.Contains(letter))
            .ToList().First()
            .Number;
    }
}
