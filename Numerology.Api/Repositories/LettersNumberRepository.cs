using Numerology.Api.Models;

namespace Numerology.Api.Repositories;

public class LettersNumberRepository : ILettersNumberRepository
{
    private readonly List<NumberLetters> _numberLetters =
    [
        new() { Number = 1, Letters = ['a', 'j', 's'] },
        new() { Number = 2, Letters = ['b', 'k', 't'] },
        new() { Number = 3, Letters = ['c', 'l', 'u'] },
        new() { Number = 4, Letters = ['d', 'm', 'v'] },
        new() { Number = 5, Letters = ['e', 'n', 'ñ', 'w'] },
        new() { Number = 6, Letters = ['f', 'o', 'x'] },
        new() { Number = 7, Letters = ['g', 'p', 'y'] },
        new() { Number = 8, Letters = ['h', 'q', 'z'] },
        new() { Number = 9, Letters = ['i', 'r', '&'] }
    ];

    public int GetNumber(char letter)
    {
        return _numberLetters
            .Where(l => l.Letters.Contains(letter))
            .ToList().First()
            .Number;
    }
}
