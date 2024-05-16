using Numerology.Api.Models;

namespace Numerology.Api.Services;

public class DateOfBirthService(INumberReducerService numberReducerService) : IDateOfBirthService
{
    private readonly INumberReducerService _numberReducerService = numberReducerService;

    public NumberValue GetDateOfBirthReduced(int day, int month, int year)
    {
        return _numberReducerService.GetNumberValue($"{day}{month}{year}");
    }
}
