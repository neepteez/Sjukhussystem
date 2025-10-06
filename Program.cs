namespace Sjukhussystem
{  
        class Program
        {
            static void Main(string[] args)
            {
                // Skapar ett objekt av klassen Läkare
                Läkare läkare = new Läkare();
                läkare.SetNamn("Dr. Andersson");      // Sätter namn
                läkare.SetÅlder(45);                  // Sätter ålder
                läkare.SetSpecialitet("Kirurgi");     // Sätter specialitet

                // Skapar ett objekt av klassen Patient
                Patient patient = new Patient();
                patient.SetNamn("Lisa Nilsson");              // Sätter namn
                patient.SetÅlder(32);                         // Sätter ålder
                patient.SetSjukdom("Blindtarmsinflammation"); // Sätter sjukdom

                //  Skriver ut information om läkaren och patienten i konsolen
                Console.WriteLine($"Läkare: {läkare.GetNamn()}, {läkare.GetÅlder()} år, Specialitet: {läkare.GetSpecialitet()}");
                Console.WriteLine($"Patient: {patient.GetNamn()}, {patient.GetÅlder()} år, Sjukdom: {patient.GetSjukdom()}");

                // Väntar på att användaren trycker på en tangent innan programmet stängs
                Console.ReadKey();
            }
        }
    }









