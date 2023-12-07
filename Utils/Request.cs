using Newtonsoft.Json;

public record Request
{
  public HttpClient client { get; set; }
  public Authorization authorization { get; set; }

  public Request()
  {
    this.client = new HttpClient(
        new HttpClientHandler
        {
          ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => { return true; }
        }
    );
  }
  public async Task<T> JsonRequest<T>(string address, bool auth = false)
  {
    if (auth)
    {
      Authorization authorization = this.authorization;
      string baseAddress = authorization.baseAddress;
      string authorizationHeader = authorization.header;

      var request = new HttpRequestMessage(HttpMethod.Get, baseAddress + address);
      request.Headers.Add("Authorization", authorizationHeader);

      var response = await client.SendAsync(request);
      var result = JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);

      return result;
    }
    else
    {
      var request = new HttpRequestMessage(HttpMethod.Get, address);

      var response = await client.SendAsync(request);
      var result = JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);

      return result;
    }
  }

  public async Task<string> ImageRequest(string address)
  {
    Authorization authorization = this.authorization;
    string baseAddress = authorization.baseAddress;
    string authorizationHeader = authorization.header;

    var request = new HttpRequestMessage(HttpMethod.Get, baseAddress + address);
    request.Headers.Add("Authorization", authorizationHeader);

    var response = await client.SendAsync(request);

    var memoryStream = new MemoryStream();
    var baseLoadScreenStream = response.Content.ReadAsStreamAsync().Result;

    baseLoadScreenStream.CopyTo(memoryStream);
    var result = Convert.ToBase64String(memoryStream.ToArray());

    return "data:image/jpg;base64, " + result;
  }
}