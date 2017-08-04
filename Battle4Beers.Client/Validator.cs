using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client
{
    public class Validator
    {
        public void NameValidator(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException(Constants.NameCannotBeNull);
            }
            if (name.Length <= 3 || name.Length > 15)
            {
                throw new ArgumentException(Constants.InvalidPlayerNameSymbolsCount);
            }
        }
    }
}
