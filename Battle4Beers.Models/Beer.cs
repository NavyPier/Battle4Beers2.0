namespace Battle4Beers.Models
{
    public class Beer
    {
        public int Id { get; set; }

        public virtual Player Winner { get; set; }

        public virtual Player Loser { get; set; }

    }
}