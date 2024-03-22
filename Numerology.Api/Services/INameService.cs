namespace Numerology.Api.Services;

public interface INameService
{
    List<int> GetNameNumbers(string name);
}
