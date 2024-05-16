using FluentAssertions;
using Numerology.Api.Models;
using Numerology.Api.Services;
using Xunit;

namespace Numerology.UnitTests;

public class NumberReducerTests
{
    private INumberReducerService _reducerService = new NumberReducerService();

    [Theory]
    [InlineData("65", 11, 11 )]
    [InlineData("994", 22, 22)]
    [InlineData("9996", 33, 33)]
    [InlineData("99999992", 65, 11)]
    public void NumberReducer_ReducesAnyNumberBut_11_22_33(string number, int sum, int reduced)
    {
        var reducedName = _reducerService.GetNumberValue(number);
        reducedName.Should().BeEquivalentTo(new NumberValue { Sum = sum, Reduced = reduced });
    }
}
