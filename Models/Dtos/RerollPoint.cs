public record RerollPoint {
    public int currentPoints { get; set; }
    public int maxRolls { get; set; }
    public int numberOfRolls { get; set; }
    public int pointsCostToRoll { get; set; }
    public int PointsToReroll { get; set; }

    public RerollPoint(int currentPoints, int maxRolls, int numberOfRolls, int pointsCostToRoll, int PointsToReroll) {
        this.currentPoints = currentPoints;
        this.maxRolls = maxRolls;
        this.numberOfRolls = numberOfRolls;
        this.pointsCostToRoll = pointsCostToRoll;
        this.PointsToReroll = PointsToReroll;
    }
};