using System.Text;

public record Authorization {
    public string baseAddress { get; set; }
    
    public string header { get; set; }

    public Authorization() {
        string fileContent = "LeagueClient:9340:58006:5e8et5NMT1jhpoFUJM-Vbw:https";

        string port = fileContent.Split(':')[2];
        string password = fileContent.Split(':')[3];

        this.baseAddress = "https://127.0.0.1:" + port;
        this.header = "Basic " + Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes("riot:" + password));
    }

    public Authorization(string baseAddress, string header) {
        this.baseAddress = baseAddress;
        this.header = header;
    }
}