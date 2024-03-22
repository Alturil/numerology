using Numerology.Api.Repositories;
using Numerology.Api.Services;
using Xunit;
using FluentAssertions;

namespace Numerology.UnitTests;

public class NameServiceTests
{
    [Fact]
    public void GetNameNumbers_RejectsNonAlphaCharacters()
    {
        var nameService = new NameService(new LettersNumberRepository());

        var numbers = nameService.GetNameNumbers("1'_!");

        numbers.Should().BeEmpty();
    }
}
