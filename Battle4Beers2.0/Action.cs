﻿public abstract class Action : IAction
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}
