using Numerology.Api.Models;

namespace Numerology.Api.Services;

public class NumberReducerService : INumberReducerService
{
    readonly List<int> irreducibleNumbers = [11, 22, 33];

    public NumberValue GetNumberValue(string number)
    {
        var reducedNumber = SumDigits(number);
        while (reducedNumber >= 10 && !irreducibleNumbers.Any(n => n == reducedNumber))
        {
            reducedNumber = SumDigits(reducedNumber.ToString());
        }

        return new NumberValue
        {
            Sum = SumDigits(number),
            Reduced = reducedNumber
        };
    }

    private int SumDigits(string number)
    {        
        return number.Select(c => (int)char.GetNumericValue(c))
            .ToList()
            .Sum();
    }
}
