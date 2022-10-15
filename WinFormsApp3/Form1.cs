using System.Runtime.Loader;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void czyPoprawnyIP_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ip01 = int.Parse(ip1.Text);
            int ip02 = int.Parse(ip2.Text);
            int ip03 = int.Parse(ip3.Text);
            int ip04 = int.Parse(ip4.Text);
            int[] tabIP1 = {ip01, ip02, ip03, ip04 };
            klasaIP.Visible = true;
            czyPoprawny.Visible = true;
            typAdresu.Visible = true;

            // Czy ip jest poprawne
            czyPoprawneIP(tabIP1);

            // Jaka klasa
            jakaKlasaIP(tabIP1);

            //Adres hosta czy sieci
            hostCzySiec(tabIP1);

            obliczanieIP(tabIP1);









        }





        private void czyPoprawneIP(int[]tabIP01)
        {
            if (tabIP01[0] <= 255 && tabIP01[1] <= 255 && tabIP01[2] <= 255 && tabIP01[3] <= 255)
            {
                czyPoprawny.Text = "adres ip jest poprawny";
            }
            else
            {
                czyPoprawny.Text = "adres ip jest niepoprawny";
            }
        }

        private void jakaKlasaIP(int[] tabIP01)
        {
            // klasyfikacja klas jest z strony https://soisk.info/index.php/Struktura_i_klasy_adresu_IP

            if (tabIP01[0] >= 1 && tabIP01[0] <= 126)
            {
                klasaIP.Text = "adres ip jest klasy A";

            }
            else if (tabIP01[0] >= 127 && tabIP01[0] <= 191)
            {
                klasaIP.Text = "adres ip jest klasy B";
            }
            else if (tabIP01[0] >= 192 && tabIP01[0] <= 223)
            {
                klasaIP.Text = "adres ip jest klasy C";
            }
            else if (tabIP01[0] >= 224 && tabIP01[0] <= 239)
            {
                klasaIP.Text = "adres ip jest klasy D";
            }
            else if (tabIP01[0] >= 240 && tabIP01[0] <= 255)
            {
                klasaIP.Text = "adres ip jest klasy E";
            }          
            else
            {
                klasaIP.Text = "Adres IP jest niepoprawny";
            }
        }

        private void hostCzySiec(int[] tabIP01)
        {
            if (tabIP01[3] == 0)
            {
                typAdresu.Text = "Podany adres jest adresem sieci";
            }
            else if (tabIP01[3] > 0 && tabIP01[3] <= 255)
            {
                typAdresu.Text = "Podany adres jest adresem hosta";
            }
            // teoretycznie z ko�c�wk� 255 mo�e by� adresem rozg�oszeniowym, ale nie za ka�dym razem musi by� wi�c zostawiam ten przypadek jako adres hosta
            
            else
            {
                typAdresu.Text = "Adres jest niepoprawny";
            }

        }

        private void obliczanieIP(int[] tabIP01)
        {
            string ip01Bin = Convert.ToString(tabIP01[0], 2);
            string ip02Bin = Convert.ToString(tabIP01[1], 2);
            string ip03Bin = Convert.ToString(tabIP01[2], 2);
            string ip04Bin = Convert.ToString(tabIP01[3], 2);
            string maskaBin;
            maskaBin = null;
            // musia�em przypisa� do tego stringa warto�� null, bo inaczej nie dzia�a�o.
            if (int.Parse(maska1.Text) <= 30 && int.Parse(maska1.Text) >= 1)
            {
                string ipBin = "0";
                ipBin = string.Join(ip01Bin, ip02Bin, ip03Bin, ip04Bin);

                for (int i = 0; i <= int.Parse(maska1.Text); i++)
                {
                    if (i > 0)
                    {
                        maskaBin = maskaBin + "1";
                    }
                    else
                    {
                        continue;
                    }


                }
                for (int a = 0; maskaBin.Length < 30; a++)
                {
                    maskaBin = maskaBin + "0";
                }
                test123.Text = maskaBin;
            }
        }














        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void ip1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void czyPoprawny_Click(object sender, EventArgs e)
        {

        }
    }
}