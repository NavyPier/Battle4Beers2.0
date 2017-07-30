namespace Battle4Beers.Models
{
    public class SingleScore
    {
        public int Id { get; set; }
        public long Score { get; set; }
        public virtual Player Player { get; set; }
    }
}
