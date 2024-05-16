using Numerology.Api.Models;

namespace Numerology.Api.Services;

public interface INumberReducerService
{
    NumberValue GetNumberValue(string number);
}