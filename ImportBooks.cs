
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TipsMaskinen
{
    internal class ImportBooks 
    {
        public string path { get; set; } //path prob
        public List<Bok> böcker = new List<Bok>(); //Lista av böcker
        public ImportBooks() 
        {
                path = @"C:\Users\Ahmad\OneDrive\Desktop\tips_texter.txt";
                FileStream ström = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);// sök texten sen öppna
                if (File.Exists(path))// om den hittats filen
                {
                    StreamReader reader = new StreamReader(ström); // läsar texten
                    string item = null;
                    List<string> itemSaver = new List<string>();// spara inehålet i tillfäligt listan
                    while ((item = reader.ReadLine()) != null) //så längre inte tomt läsa varej line sen spara i item
                    {
                        itemSaver.Add(item); // lägga line info i listan
                    }
                    foreach (var a in itemSaver)// hämta radar från listan sen spar i a varej loop
                    {
                        string[] vektor = a.Split(new string[] { "###" }, StringSplitOptions.None);// ta bort o nödvändiga symboler
                        string titel = vektor[0]; // ta titel från index 0 av array
                        string författare = vektor[1]; // ta författare från index 1 av array
                        string typ = vektor[2]; // ta typ från index 2 av array
                        bool tillgänglig = Convert.ToBoolean(vektor[3]); // ta tillgänglig från index 3 av array sen konverta till bool value
                        Bok bok; // skapa ny objkt
                        switch (typ)
                        {
                            case "Novellsamling":
                                bok = new Novellsamling(titel, författare, tillgänglig); // if fall Novellsamling gör objekt 
                                break;
                            case "Roman":
                                bok = new Roman(titel, författare, tillgänglig); // if fall Roman gör objekt 
                                break;
                            default:
                                bok = new Tidskrift(titel, författare, tillgänglig); //  if fall Tidskrift gör objekt 
                                break;
                    }
                     böcker.Add(bok); //      boken till listan
                     reader.Close();// stäng filen så att path kan användas i ett annat metod
                }
                }
        }
        public Bok SlumpBok()// slump metod
        {
            try
            {
                    Random rnd = new Random(); // skapa objekt från klass Random
                    int antal = böcker.Count(); // hämta antal böcker
                    int slumpatIndex = rnd.Next(0, antal); // slumpa Bok
                    Bok slumpatBok = böcker[slumpatIndex]; // plocka slumpat bok och spara i bok objekt
                    böcker.Remove(slumpatBok);//Gör att samma tips inte kan visas två gånger i rad.
                    return slumpatBok;
            }
            catch (Exception)
            {
                MessageBox.Show("Text fil hitats inte eller tomt försök igen!"); // Felmeddelande 
                Application.Restart();//  starta om appen
                throw;
            }
        }
    }
}
