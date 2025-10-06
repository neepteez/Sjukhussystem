

namespace Sjukhussystem
{
    // Klassen Läkare ärver från Person
    
        public class Läkare : Person
        {
            // Privat attribut för läkarens specialitet
            private string specialitet;

            // Publika metoder för att hämta och ändra specialitet
            public string GetSpecialitet() => specialitet;
            public void SetSpecialitet(string s) => specialitet = s;
        }

}


