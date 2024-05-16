using Numerology.Api.Models;

namespace Numerology.Api.Services;

public class PersonService(INameService nameService, IDateOfBirthService dateOfBirthService) : IPersonService
{
    private readonly INameService _nameService = nameService;
    private readonly IDateOfBirthService _dateOfBirthService = dateOfBirthService;

    public PersonResult GetPersonResult(string name, int day, int month, int year)
    {
        var nameReducedNumber = _nameService.GetNameReduced(name);
        var dateOfBirthReducedNumber = _dateOfBirthService.GetDateOfBirthReduced(day, month, year);

        return new PersonResult
        {
            Name = new()
            {
                Name = name,
                NumberValue = nameReducedNumber,
                YearsInLifeCycle = _nameService.CountCharacters(name)
            },
            DateOfBirth = new()
            {
                Day = day,
                Month = month,
                Year = year,
                NumberValue = dateOfBirthReducedNumber
            },
            VibrationNumber = nameReducedNumber.Reduced + dateOfBirthReducedNumber.Reduced
        };
    }
}
