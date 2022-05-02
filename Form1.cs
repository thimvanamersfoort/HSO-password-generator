using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using Xceed.Words.NET;
//using PdfSharp;
//using PdfSharp.Drawing;
//using PdfSharp.Pdf;

namespace passwordGeneratorHertzinger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_SelectedLength.Text = "Geselecteerde lengte: " + trb_WachtwoordLengte.Value.ToString();
        }

        #region variables

        public char[] kleineLetters =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'h', 'j', 'k', 'm', 'n', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };
        public char[] hoofdLetters =
        {
            'A', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        public char[] nummers =
        {
            '2', '3', '4', '5', '6', '7', '8'
        };
        public char[] specialeTekens =
        {
            '!', '?', '{', '}', '[', ']', '<', '>', '/', '\\', '&', '#', '@', '*', '(', ')'
        };
        public List<string> GeneratedPasswords = new List<string>();

        #endregion

        private void btn_Genereer_Click(object sender, EventArgs e)
        {
            List<char> Tekens = new List<char>();
            tb_Output.Text = "";

            if(cb_KleineLetters.Checked == true)
            {
                foreach(char item in kleineLetters)
                {
                    Tekens.Add(item);
                }
            }
            if(cb_Hoofdletters.Checked == true)
            {
                foreach(char item in hoofdLetters)
                {
                    Tekens.Add(item);
                }
            }
            if(cb_Cijfers.Checked == true)
            {
                foreach(char item in nummers)
                {
                    Tekens.Add(item);
                }
            }
            if(cb_SpecialeTekens.Checked == true)
            {
                foreach(char item in specialeTekens)
                {
                    Tekens.Add(item);
                }
            }

            if(cb_SpecialeTekens.Checked == false 
                && cb_Cijfers.Checked == false 
                && cb_Hoofdletters.Checked == false 
                && cb_KleineLetters.Checked == false)
            {
                MessageBox.Show("Selecteer alsjeblieft een van de 4 tekensoorten!", "Alert:");
                Tekens.Clear();
            }

            if(Tekens.Count > 0)
            {
                Generate(Tekens);
            }
        }
        private void Generate(List<char> Tekens)
        {
            int wachtwoordLengte = trb_WachtwoordLengte.Value;
            int hoeveelheidWachtwoorden = Convert.ToInt32(nud_HoeveelheidWachtwoorden.Value);

            List<string> Wachtwoorden = new List<string>();
            var random = new Random();

            for(int i = 1; i <= hoeveelheidWachtwoorden; i++)
            {
                StringBuilder wachtwoord = new StringBuilder();
                
                for(int k = 1; k <= wachtwoordLengte; k++)
                {
                    List<char> tempTekens = Tekens;
                    int index = random.Next(tempTekens.Count);
                    char character = tempTekens[index];

                    wachtwoord.Append(character);
                }

                int voortgang = i / hoeveelheidWachtwoorden * 100;
                decimal value2 = Convert.ToDecimal(voortgang);
                ProgressBar.Value = Convert.ToInt32(Math.Ceiling(value2));

                Wachtwoorden.Add(wachtwoord.ToString());
                tb_Output.Text += wachtwoord + "\r\n";
            }

            GeneratedPasswords = Wachtwoorden;
        }
        private void btn_Exporteer_Click(object sender, EventArgs e)
        {
            if(tb_Output.Text == "")
            {
                MessageBox.Show("Kan geen data opslaan omdat er geen wachtwoorden gegenereerd zijn!", "Error:");
            }
            else
            {
                var sfd = new SaveFileDialog();
                sfd.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
                sfd.AddExtension = false;
                sfd.OverwritePrompt = true;
                sfd.Filter = "Excel file| *.xlsx |Word file | *.docx";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(Path.GetFullPath(sfd.FileName));

                    if(extension == ".xlsx")
                    {
                        var workbook = new XLWorkbook();
                        workbook.AddWorksheet("Passwords");
                        var ws = workbook.Worksheet("Passwords");

                        int row = 6;

                        ws.Cell("A" + 1).Value = "Powered by HSO Hertzinger password generator:";
                        ws.Cell("A" + 2).Value = "";
                        ws.Cell("A" + 3).Value = "";
                        ws.Cell("A" + 4).Value = "";
                        ws.Cell("A" + 5).Value = "";

                        foreach (string item in GeneratedPasswords)
                        {
                            ws.Cell("A" + row.ToString()).Value = item.ToString();
                            row++;
                        }

                        string filename = Path.GetFileNameWithoutExtension(sfd.FileName) + extension;

                        string filename1 = Path.ChangeExtension(sfd.FileName, null);

                        workbook.SaveAs(filename1 + ".xlsx");
                        MessageBox.Show("File " + filename +" successfully saved.", "Notification:");

                        if(cb_OpenFile.Checked == true)
                        {
                            Process.Start(sfd.FileName);
                        }
                    }
                    else if(extension == ".docx")
                    {
                        string filename = sfd.FileName;

                        var doc = DocX.Create(filename);
                        doc.InsertParagraph("Powered by HSO Hertzinger password generator:");
                        doc.InsertParagraph("");
                        doc.InsertParagraph("");
                        doc.InsertParagraph("");
                        doc.InsertParagraph("");

                        foreach (string item in GeneratedPasswords)
                        {
                            doc.InsertParagraph(item);
                        }
                        doc.Save();

                        MessageBox.Show("File " + Path.GetFileNameWithoutExtension(sfd.FileName) + extension + " successfully saved.", "Notification:");
                        if (cb_OpenFile.Checked == true)
                        {
                            Process.Start(sfd.FileName);
                        }
                    }
                    #region pdf
                    /*else if(extension == ".pdf")
                    {
                        string filename = sfd.FileName;
                        PdfDocument pdf = new PdfDocument();

                        pdf.Info.Title = "Powered by HSO Hertzinger password generator";

                        PdfPage pdfPage = pdf.AddPage();
                        XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                        XFont font = new XFont("Arial", 12, XFontStyle.Regular);

                        foreach(string item in GeneratedPasswords)
                        {
                            graph.DrawString(item, font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
                        }
                        
                        pdf.Save(filename);
                    }*/
                    #endregion
                    else
                    {
                        MessageBox.Show("Deze bestandsextentie wordt niet ondersteund: \r\n\r\n" + extension, "Error:");
                    }
                }
            }
            
        }

        private void pb_Logo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.hertzinger.com/");
        }
        private void trb_WachtwoordLengte_Scroll(object sender, EventArgs e)
        {
            lbl_SelectedLength.Text = "Geselecteerde lengte: " + trb_WachtwoordLengte.Value.ToString();
        }
        private void btn_Empty_Click(object sender, EventArgs e)
        {
            tb_Output.Text = "";
            ProgressBar.Value = 0;
        }
    }
}
