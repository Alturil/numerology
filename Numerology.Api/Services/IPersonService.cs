using Numerology.Api.Models;

namespace Numerology.Api.Services
{
    public interface IPersonService
    {
        PersonResult GetPersonResult(string name, int day, int month, int year);
    }
}