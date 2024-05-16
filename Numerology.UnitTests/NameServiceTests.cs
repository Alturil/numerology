using Numerology.Api.Repositories;
using Numerology.Api.Services;
using Xunit;
using FluentAssertions;
using Numerology.Api.Models;

namespace Numerology.UnitTests;

public class NameServiceTests
{
    private readonly NameService _nameService = new(new LettersNumberRepository(), new NumberReducerService());

    [Fact]
    public void CountCharacters_ReturnsAlphaCharacterCount()
    {
        var numbers = _nameService.CountCharacters("1'_!Kk ñ");
        numbers.Should().Be(3);
    }

    [Fact]
    public void GetNameReduced_GetsNumberValue() // Probably remove
    {
        var reducedName = _nameService.GetNameReduced("Aa Bb Cc"); // 11 22 33
        reducedName.Should().BeEquivalentTo(new NumberValue { Sum = 12, Reduced = 3 });
    }
}
