namespace Battle4Beers.Client
{
    public class ActionManager
    {
        public void DoAction(string action)
        {
            if(action == "NEW GAME")
            {
                DrawMenu.NewGameMenu();
            }
        }
    }
}
