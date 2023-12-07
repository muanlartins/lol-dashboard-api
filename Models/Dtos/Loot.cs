public record Loot {
    public string displayCategories { get; set; }
    public int storeItemId { get; set; }
    public string parentItemStatus { get; set; }
    public string itemDesc { get; set; }

    public Loot(string displayCategories, int storeItemId, string parentItemStatus, string itemDesc) {
        this.displayCategories = displayCategories;
        this.storeItemId =  storeItemId;
        this.parentItemStatus =  parentItemStatus;
        this.itemDesc =  itemDesc;
    }
};