using Xunit;
using System.Text.Json;
using Moq;
using university_applications.Services;


namespace university_applications.Test;

public class UniversityServiceTest
{

  [Fact]
  public async Task ShouldReturnUniversityByCountryAndName()
  {
    var mockHttpClient = new Mock<HttpClient>();
    var universityService = new UniversityService(mockHttpClient.Object);

    var result = await universityService.FindUniversity("Brazil");

    result.Should().BeOfType<JsonElement>();
  }

  [Fact]
  public async Task ShouldReturnAUniversityByCountry()
  {

    var mockHttpClient = new Mock<HttpClient>();
    var universityService = new UniversityService(mockHttpClient.Object);

    var result = await universityService.FindUniversity("Brazil", "Federal");

    result.Should().BeOfType<JsonElement>();
  }
}

