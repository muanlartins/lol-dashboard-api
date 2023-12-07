public record Mastery {
    public string championId { get; set; }
    public int championLevel { get; set; }
    public int championPoints { get; set; }
    public int championPointsSinceLastLevel { get; set; }
    public int championPointsUntilNextLevel { get; set; }
    public bool chestGranted { get; set; }
    public string formattedChampionPoints { get; set; }
    public string formattedMasteryGoal { get; set; }
    public string highestGrade { get; set; }

    public Mastery(string championId, int championLevel, int championPoints, int championPointsSinceLastLevel, int championPointsUntilNextLevel, bool chestGranted, string formattedChampionPoints, string formattedMasteryGoal, string highestGrade) {
        this.championId = championId;
        this.championLevel = championLevel;
        this.championPoints = championPoints;
        this.championPointsSinceLastLevel = championPointsSinceLastLevel;
        this.championPointsUntilNextLevel = championPointsUntilNextLevel;
        this.chestGranted = chestGranted;
        this.formattedChampionPoints = formattedChampionPoints;
        this.formattedMasteryGoal = formattedMasteryGoal;
        this.highestGrade = highestGrade;
    }
};