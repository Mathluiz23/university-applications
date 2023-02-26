namespace university_applications.Test;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

public class UniversityIntegrationTest : IClassFixture<TestingWebAppFactory<Program>>
{
  private readonly HttpClient _httpClient;

  public UniversityIntegrationTest(TestingWebAppFactory<Program> factory) => _httpClient = factory.CreateClient();

  [Theory]
  [InlineData("Brazil", "federal")]
  [InlineData("Brazil", "acre")]

  public async Task ShouldFindAUniversityByCountryAndName(string country, string name)
  {
    var response = await _httpClient.GetAsync($"/university/Country&Name/?name={name}&country={country}");
    response.StatusCode.Should().Be(HttpStatusCode.OK);

    var result = await response.Content.ReadFromJsonAsync<object>();
    result.Should().BeOfType<JsonElement>();
    result?.ToString().Should().Contain(country);
    result?.ToString()!.ToLower().Should().Contain(name);
  }

  [Theory]
  [InlineData("Brazil")]
  [InlineData("Turkey")]
  public async Task ShouldFindAUniversityByCountry(string country)
  {
    var response = await _httpClient.GetAsync($"/university/Country/?country={country}");
    response.StatusCode.Should().Be(HttpStatusCode.OK);

    var result = await response.Content.ReadFromJsonAsync<object>();
    result.Should().BeOfType<JsonElement>();
    result?.ToString().Should().Contain(country);
  }
}