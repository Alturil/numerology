using Numerology.Api.Models;

namespace Numerology.Api.Services;

public interface INameService
{
    NumberValue GetNameReduced(string name);
    int CountCharacters(string name);
}
