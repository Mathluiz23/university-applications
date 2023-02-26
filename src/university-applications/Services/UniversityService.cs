namespace university_applications.Services
{
  public class UniversityService : IUniversityService
  {
    private readonly HttpClient _httpClient;

    private readonly string _remoteServiceBaseUrl = "http://universities.hipolabs.com";

    public UniversityService(HttpClient client)
    {
      _httpClient = client;
      _httpClient.BaseAddress = new Uri(_remoteServiceBaseUrl);
    }

    public async Task<object> FindUniversity(string name, string country)
    {
      var response = await _httpClient.GetAsync($"/search?{name}&{country}");

      response.EnsureSuccessStatusCode();

      var result = await response.Content.ReadFromJsonAsync<object>();

      return result;
    }

    public async Task<object> FindUniversity(string country)
    {
      var response = await _httpClient.GetAsync($"/search?{country}");

      response.EnsureSuccessStatusCode();

      var result = await response.Content.ReadFromJsonAsync<object>();

      return result;
    }
  }
}
