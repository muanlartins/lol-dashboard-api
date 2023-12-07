public record Ownership {
    public bool owned { get; set; }

    public Ownership(bool owned) {
        this.owned = owned;
    }
};