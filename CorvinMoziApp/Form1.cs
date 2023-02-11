using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace CorvinMoziApp
{
    public partial class Form1 : Form
    {
        Mozi kell = new Mozi(new List<Terem>());
        string keput = @"..//../Kepek/";
        int oldalszama = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void kepekbetoltese(PictureBox pictureBox, int i, int j)
        {
            string kep = @"";
            if (kell.terem[oldalszama].Ulesek[i,j] == 1)
            {
                kep = keput + "felnott" + ".png";
            }
            else if (kell.terem[oldalszama].Ulesek[i, j] == 2)
            {
                kep = keput + "gyerek" + ".png";
            }
            else { kep = keput + "ures" + ".png"; }
                
            pictureBox.ImageLocation = kep;
                    
        }
        private void valtas()
        {
         
            panel.Controls.Clear();
            int picturesize = 40;
            pictureBox1.ImageLocation = keput + kell.terem[oldalszama].Nev.Split(' ')[0] + ".jpg";
    
            for (int i = 0; i < kell.terem[oldalszama].Sorok; i++)
            {
                for (int j = 0; j < kell.terem[oldalszama].Szekek; j++)
                {
                    PictureBox picturebox = new PictureBox();

                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturebox.SetBounds(j * picturesize, i * picturesize, picturesize, picturesize);
                    picturebox.Name = $"{i};{j}";
                    kepekbetoltese(picturebox,i,j);
                    picturebox.Click += (o, ev) => {
                        PictureBox picture = (PictureBox)o;
                        int[] ules = Array.ConvertAll(picture.Name.Split(';'), int.Parse);
                        
                        int koordinata_i = ules[0];
                        int koordinata_j = ules[1];
                        if (kell.terem[oldalszama].Ulesek[koordinata_i, koordinata_j] + 1 > 3)
                        {
                            kell.terem[oldalszama].Ulesek[koordinata_i, koordinata_j] = 0;
                        }
                        else
                        {
                            kell.terem[oldalszama].Ulesek[koordinata_i, koordinata_j] += 1;
                        }kepekbetoltese(picturebox, ules[0], ules[1]);
                    };
                    panel.Controls.Add(picturebox);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string lines = File.ReadAllText(@"..//../CorvinMozi.csv");
            string[] lines1 = Regex.Split(lines, Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < lines1.Length ; i++)
            {
                
                string[] cod = Regex.Split(lines1[i], Environment.NewLine);
                string[] asd = cod[1].Split(';');
                int[,] ulesek = new int[Convert.ToInt32(asd[0]), Convert.ToInt32(asd[1])];
                for (int j = 2; j < cod.Length; j++)
                {
                    try
                    {
                    string[] szet = cod[j].Split(';');
                    int ertek = 0;
                    if (szet[2] == "F")
                    {

                        ertek = 1;
                    }
                    else { ertek = 2; }
                    ulesek[Convert.ToInt32(szet[0]) - 1, Convert.ToInt32(szet[1]) - 1] = ertek;

                    }
                    catch (Exception)
                    {

                        continue;
                    }
                   
                }
                kell.terem.Add(new Terem(cod[0], Convert.ToInt32(asd[0]), Convert.ToInt32(asd[1]), ulesek));
            }
            valtas();
        }
            private void nyilak()
            {
                if (oldalszama > 0)
                {
                    ballnyil.ImageLocation = keput + @"balnyil.jpg";
                }
                else
                {
                    jobbnyil.ImageLocation = @"";
                }
                if (oldalszama < 5)
                {
                    jobbnyil.ImageLocation = keput + @"jobbnyil.jpg";
                }
                else
                {
                    jobbnyil.ImageLocation = @"";
                }
            }

        private void ballnyil_Click(object sender, EventArgs e)
        {
            if (oldalszama + 1 < 6)
            {
                oldalszama++;
            }
            valtas();
            nyilak();
        }

        private void jobbnyil_Click(object sender, EventArgs e)
        {
            if (oldalszama - 1 > -1)
            {
                oldalszama--;
            }
            valtas();
            nyilak();
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            string[] datum = Regex.Split(DateTime.Now.ToString(), ". ");
            File.Move(@"..//../CorvinMozi.csv", $"..//../CorvinMozi_{datum[0]}{datum[1]}{datum[2]}{datum[3].Replace(":", "")}.csv");
            string filesave = "";
            int count= 0; 
            foreach (Terem lp in kell.terem)
            {
                count++;
                filesave += $"{lp.Nev}{Environment.NewLine}{lp.Sorok};{lp.Szekek}{Environment.NewLine}";
                for (int x = 0; x < lp.Ulesek.GetLength(0); x++)
                {
                    for (int y = 0; y < lp.Ulesek.GetLength(1); y++)
                    {
                        string f = "";
                        if (lp.Ulesek[x, y] == 1)
                        {
                            f = "F";
                        }
                        else if (lp.Ulesek[x, y] == 2)
                        {
                            f = "D";
                        }
                        if (f != "")
                        {
                            
                            filesave += $"{x + 1};{y + 1};{f}{Environment.NewLine}";
                        }
                        
                    }
                    
                }
                if (count != 6)
                {
                    filesave += Environment.NewLine;
                }
                
            }
            File.WriteAllText(@"..//../CorvinMozi.csv", filesave);
        }
    }
}
