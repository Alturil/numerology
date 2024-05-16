using Numerology.Api.Models;
using Numerology.Api.Repositories;
using System.Text.RegularExpressions;

namespace Numerology.Api.Services;

public class NameService(ILettersNumberRepository lettersNumberRepository, INumberReducerService numberReducerService) : INameService
{
    private readonly ILettersNumberRepository _lettersNumberRepository = lettersNumberRepository;
    private readonly INumberReducerService _numberReducerService = numberReducerService;
    private readonly Regex validCharacters = new(@"[a-z]|ñ|&");

    public NumberValue GetNameReduced(string name)
    {
        return _numberReducerService.GetNumberValue(GetNameAsNumbers(name));
    }

    public int CountCharacters(string name)
    {
        return name.ToLower()
            .Where(character => validCharacters.Matches(character.ToString()).Count > 0)
            .ToList()
            .Count;
    }

    private string GetNameAsNumbers(string name)
    {
        return string.Concat(name.ToLower()
            .Where(character => validCharacters.IsMatch(character.ToString()))
            .Select(character => _lettersNumberRepository.GetNumber(character).ToString()));
    }
}
