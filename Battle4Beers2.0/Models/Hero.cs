using System;
using System.Collections.Generic;

public abstract class Hero : IHero
{
    private string name;
    private int health;
    private List<Action> actions;

    public Hero(string name, int health)
    {
        this.Name = name;
        this.Health = health;
        this.actions = new List<Action>();
    }

    public int Health
    {
        get { return this.health; }
        protected set { this.health = value; }
    }

    public string Name
    {
        get { return this.name; }
        protected set
        {
            if(value.Length < 3 || value.Length > 15)
            {
                throw new ArgumentException(@"- A player's name must be longer than 3 symbols!!!
- A player's name must be shorter than 16 symbols!!!");
            }

            this.name = value;
        }
    }

    public List<Action> Actions
    {
        get
        {
            return this.actions;
        }
    }
}
