
namespace Sjukhussystem
{
    // Klassen Patient ärver från Person
        public class Patient : Person
        {
            // Privat attribut – bara åtkomligt via metoder
            private string sjukdom;

            // Publika metoder för att läsa och ändra sjukdom
            public string GetSjukdom() => sjukdom;
            public void SetSjukdom(string s) => sjukdom = s;
        }


 }




