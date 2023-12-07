public record Champion {
    public Ownership ownership { get; set; }
    public Skin[] skins { get; set; }
    public string name { get; set; }
    public string baseLoadScreenPath { get; set; }
    public string baseLoadScreen { get; set; }
    public string title { get; set; }

    public Champion(Ownership ownership, Skin[] skins, string name, string baseLoadScreenPath, string baseLoadScreen, string title)
    {
        this.ownership = ownership;
        this.skins = skins;
        this.name = name;
        this.baseLoadScreenPath = baseLoadScreenPath;
        this.baseLoadScreen = baseLoadScreen;
        this.title = title;
    }
};