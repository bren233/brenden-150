class player
{
    private string initals { get; set; }
    private int score { get; set; }
    public string Initals { get; set; }
    public int Score { get; set; }

    public player(string initals, int score)
    {
        this.Initals = initals;
        this.Score = score;
    }


    static void Main()
    {
        player bill = new player("B", 300);
        Console.WriteLine($"player {bill.Initals} score {bill.Score}");
    }
}
