public record Summoner {
    public int accountId { get; set; }
    public string displayName { get; set; }
    public string gameName { get; set; }
    public string internalName { get; set; }
    public bool nameChangeFlag { get; set; }
    public int percentCompleteForNextLevel { get; set; }
    public string privacy { get; set; }
    public int profileIconId { get; set; }
    public string puuid { get; set; }
    public RerollPoint rerollPoints { get; set; }
    public int summonerId { get; set; }
    public int summonerLevel { get; set; }
    public string tagLine { get; set; }
    public bool unnamed { get; set; }
    public int xpSinceLastLevel { get; set; }
    public int xpUntilNextLevel { get; set; }

    public Summoner(
        int accountId, 
        string displayName, 
        string gameName, 
        string internalName, 
        bool nameChangeFlag, 
        int percentCompleteForNextLevel, 
        string privacy, 
        int profileIconId, 
        string puuid, 
        RerollPoint rerollPoints, 
        int summonerId, 
        int summonerLevel, 
        string tagLine, 
        bool unnamed, 
        int xpSinceLastLevel, int xpUntilNextLevel
    ) {
        this.accountId = accountId;
        this.displayName = displayName;
        this.gameName = gameName;
        this.internalName = internalName;
        this.nameChangeFlag = nameChangeFlag;
        this.percentCompleteForNextLevel = percentCompleteForNextLevel;
        this.privacy = privacy;
        this.profileIconId = profileIconId;
        this.puuid = puuid;
        this.rerollPoints = rerollPoints;
        this.summonerId = summonerId;
        this.summonerLevel = summonerLevel;
        this.tagLine = tagLine;
        this.unnamed = unnamed;
        this.xpSinceLastLevel = xpSinceLastLevel;
        this.xpUntilNextLevel = xpUntilNextLevel;
    }
};