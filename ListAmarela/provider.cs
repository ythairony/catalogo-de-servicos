class Provider{
    private int id;
    private string first_name;
    private string second_name;
    private string nickname;
    private string contact;
    private string sex;
    private string neighborhood;

    public Provider(int id, string first_name, string second_name, string nickname, string contact, string sex, string neighborhood )
    {
        this.id = id;
        this.first_name = first_name;
        this.second_name = second_name;
        this.nickname = nickname;
        this.contact = contact;
        this.sex = sex;
        this.neighborhood = neighborhood;
    }
    public string GetFirst_name() { return this.first_name; }
    public string GetSecond_name() { return this.second_name; }
    public string GetNickname() { return this.nickname; }
    public string GetContact() { return this.contact; }
    public string GetSex() { return this.sex; }
    public string GetNeighborhood() { return this.neighborhood; }

    //ToString

    public override string ToString() { return $">>> {nickname} <<<\nComplete Name: {first_name} {second_name}\nContact: {contact}\nSex: {sex}\nNeighborhood: {neighborhood} "; }
}