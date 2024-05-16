
using Numerology.Api.Models;

namespace Numerology.Api.Services;

public interface IDateOfBirthService
{
    public NumberValue GetDateOfBirthReduced(int day, int month, int year);
}