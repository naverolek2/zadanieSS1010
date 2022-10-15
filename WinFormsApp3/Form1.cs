using Microsoft.VisualBasic.Devices;
using System.Net;
using System.Runtime.Loader;
using System.Windows.Forms.VisualStyles;


// https://github.com/lduchosal/ipnetwork
// Jak nie dzia³a to zainstalowaæ nuget " IPNetwork2"
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
            pierwHost.Visible = true;   
            ostatHost.Visible = true;   

            // Czy ip jest poprawne
            czyPoprawneIP(tabIP1);

            // Jaka klasa
            jakaKlasaIP(tabIP1);

            //Adres hosta czy sieci czy mo¿e rozg³oszeniowy czy te¿ nie znajduje siê w puli adresów
            hostCzySiec(tabIP1);

            // Obliczanie pierwszego i ostatniego hosta
            obliczanieIP(tabIP1);
            obliczanieIP2(tabIP1);








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
            string ip01 = tabIP01[0].ToString();
            string ip02 = tabIP01[1].ToString();
            string ip03 = tabIP01[2].ToString();
            string ip04 = tabIP01[3].ToString();
            string ob = $"{ip01}.{ip02}.{ip03}.{ip04}/{maska1.Text}";
            string ob2 = $"{ip01}.{ip02}.{ip03}.{ip04}";
            IPNetwork ipObliczanie = IPNetwork.Parse(ob);          
            IPAddress network = ipObliczanie.Network;
            if (ob2 == network.ToString())
            {
                typAdresu.Text = "Podany adres jest adresem sieci";
            }
            else 
            {
                typAdresu.Text = "Podany adres jest adresem hosta";
            }
            
        }

        private void obliczanieIP(int[] tabIP01)
        {
            string ip01 = tabIP01[0].ToString();
            string ip02 = tabIP01[1].ToString();
            string ip03 = tabIP01[2].ToString();
            string ip04 = tabIP01[3].ToString();
            string ob = $"{ip01}.{ip02}.{ip03}.{ip04}/{maska1.Text}";
            IPNetwork ipObliczanie = IPNetwork.Parse(ob);
            // musia³em przypisaæ do tego stringa wartoœæ null, bo inaczej nie dzia³a³o.

            IPAddress firstUsable = ipObliczanie.FirstUsable;
            pierwHost.Text = $"Pierwszy adres hosta to: {firstUsable.ToString()}";
        }


        private void obliczanieIP2(int[] tabIP01)
        {
            string ip01 = tabIP01[0].ToString();
            string ip02 = tabIP01[1].ToString();
            string ip03 = tabIP01[2].ToString();
            string ip04 = tabIP01[3].ToString();
            string ob = $"{ip01}.{ip02}.{ip03}.{ip04}/{maska1.Text}";
            IPNetwork ipObliczanie = IPNetwork.Parse(ob);
            // musia³em przypisaæ do tego stringa wartoœæ null, bo inaczej nie dzia³a³o.

            IPAddress lastUsable = ipObliczanie.LastUsable;
            ostatHost.Text = $"Ostatni adres hosta to:{lastUsable.ToString()}";
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