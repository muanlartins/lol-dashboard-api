public record Skin {
    public Ownership ownership { get; set; }
    public bool isBase { get; set; }
    public string name { get; set; }
    public string tilePath { get; set; }
    public string tile { get; set; }
    public string splashPath { get; set; }
    public string splash { get; set; }
    public string uncenteredSplashPath { get; set; }
    public string uncenteredSplash { get; set; }
    public string loadScreenPath { get; set; }
    public string loadScreen { get; set; }



    public Skin(
        Ownership ownership, 
        bool isBase, 
        string name, 
        string tilePath, 
        string tile, 
        string splashPath, 
        string splash, 
        string uncenteredSplashPath, 
        string uncenteredSplash,
        string loadScreenPath,
        string loadScreen
    ) {
        this.ownership = ownership;
        this.isBase = isBase;
        this.name = name;
        this.tilePath = tilePath;
        this.tile = tile;
        this.splashPath = splashPath;
        this.splash = splash;
        this.uncenteredSplashPath = uncenteredSplashPath;
        this.uncenteredSplash = uncenteredSplash;
        this.loadScreenPath = loadScreenPath;
        this.loadScreen = loadScreen;
    }
};