using System.Collections.Generic;
using System.Linq;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Data;
using Battle4Beers.Models;

namespace Battle4Beers.Client.Models.Actions
{
    public class BeersDatabase : IBeersWriter
    {
        private Battle4BeersDbContext context;
        public BeersDatabase()
        {
            context = new Battle4BeersDbContext();
        }
        public void Save(IEnumerable<Hero> winningTeam, IEnumerable<Hero> losingTeam)
        {

            foreach (var winner in winningTeam)
            {
                this.AddPlayer(winner.Name);
                var winnerInstance = this.FindPlayer(winner.Name);

                foreach (var loser in losingTeam)
                {
                    this.AddPlayer(loser.Name);
                    var loserInstance = this.FindPlayer(loser.Name);
                    var beer = new Beer()
                    {
                        Winner = winnerInstance,
                        Loser = loserInstance
                    };
                    context.Beers.Add(beer);
                    context.SaveChanges();
                }
            }
            context.SaveChanges();


        }

        private void AddPlayer(string name)
        {
            if (!this.PlayerExists(name))
            {
                Player player = new Player()
                {
                    Name = name
                };
                context.Players.Add(player);
                context.SaveChanges();
            }
        }
        private bool PlayerExists(string name)
        {
            return context.Players.Any(p => p.Name == name);
        }

        private Player FindPlayer(string name)
        {
            return context.Players.FirstOrDefault(p => p.Name == name);
        }

        public IEnumerable<Player> GetPlayers()
        {
            return context.Players;
        }

    }
}
