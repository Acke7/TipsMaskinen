using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipsMaskinen
{
    public partial class Form1 : Form
    {
        string Titel;
        string Författare;
        string Type;
        bool tillgänglig ;
        ImportBooks importBooks = new ImportBooks(); //skapa obj från ImportBooks och hämta text fil till listan
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            Bok slumptBok = importBooks.SlumpBok(); // hämta slumpat bok
                string text = slumptBok.ToString(); // gör den string
            textBox1.Text = text; // visa boken i box
           
        }
        private void TitelBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void FörfattareBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void romanTypecCheck_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        private void NovellsamlingCheck_CheckedChanged(object sender, EventArgs e)
        {
        
        }
        private void TidskriftCheck_CheckedChanged(object sender, EventArgs e)
        {
         
        }
        private void Addbok_Click(object sender, EventArgs e) // lägg ny bok
        {
            if (NovellsamlingCheck.Checked)
            {
                TidskriftCheck.Enabled = false;
                romanTypecCheck.Enabled = false;
                Type = "Novellsamling";
                
            }
            if (TidskriftCheck.Checked)
            {
                NovellsamlingCheck.Enabled = false;
                romanTypecCheck.Enabled=false;
                Type = "Tidskrift";
              
            }
            if (romanTypecCheck.Checked)
            {
                NovellsamlingCheck.Enabled = false;
                TidskriftCheck.Enabled = false;
                Type = "Roman";
                
            }
            Titel = TitelBox.Text;
            Författare = FörfattareBox.Text;
            tillgänglig = true;
            Bok bok;
            switch (Type)
            {
                case "Novellsamling":
                    bok = new Novellsamling(Titel, Författare, tillgänglig); // if fall Novellsamling gör objekt 
                    break;
                case "Roman":
                    bok = new Roman(Titel, Författare, tillgänglig); // if fall Roman gör objekt 
                    break;
                default:
                    bok = new Tidskrift(Titel, Författare, tillgänglig); //  if fall Tidskrift gör objekt 
                    break;
            }
            // Append text to an existing file till path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, importBooks.path), true))
            {
                outputFile.WriteLine(bok.titel.ToString() + "###" + bok.författare.ToString() + "###" + bok.typ.ToString() + "###" + bok.tillgänglig);
            }
            MessageBox.Show("Lagrats");
            Application.Restart(); // starta om appen
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
