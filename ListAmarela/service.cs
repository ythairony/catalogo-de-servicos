class Service {
    private int id;
    private string description;
    private double rating;
    private Category category;

    public Service(int id, string description, double rating, Category category) {
        this.id = id;
        this.description = description;
        this.rating = rating;
        this.category = category;
    }

    public string GetDescription() {
        return description;
        
    }
    public double GetRating() {
        return rating;
    }

    public Category GetCategory() {
        return category;
    }
}