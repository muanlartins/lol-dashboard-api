public record Champions
{
  public Dictionary<string, string> keys { get; set; }

  public Champions(Dictionary<string, string> keys)
  {
    this.keys = keys;
  }
};