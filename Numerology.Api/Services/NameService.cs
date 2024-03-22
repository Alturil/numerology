using Numerology.Api.Repositories;
using System.Text.RegularExpressions;

namespace Numerology.Api.Services;

public class NameService : INameService
{
    private readonly ILettersNumberRepository _lettersNumberRepository;
    private readonly Regex validCharacters = new(@"[a-z]|ñ|&");    

    public NameService(ILettersNumberRepository lettersNumberRepository)
    {
        _lettersNumberRepository = lettersNumberRepository;
    }

    public List<int> GetNameNumbers(string name)
    {
        return name
        .Where(character => validCharacters.Matches(character.ToString()).Count > 0)
        .Select(character => _lettersNumberRepository.GetNumber(character))
        .ToList();
    }
}
