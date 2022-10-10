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
            klasaIP.Visible = true;
            czyPoprawny.Visible = true;
            typAdresu.Visible = true;

            // Czy poprawny
            if (ip01 <= 255 && ip02 <= 255 && ip03 <= 255 && ip04 <= 255)
            {            
                czyPoprawny.Text = "adres ip jest poprawny";
            }
            else
            {               
                czyPoprawny.Text = "adres ip jest niepoprawny";
            }

            // Jaka klasa
            if (ip01 >= 0 && ip01 <= 127)
            {
                klasaIP.Text = "adres ip jest klasy A";
                
            }
           else if(ip01 >= 128 && ip01 <= 191)
            {
                klasaIP.Text = "adres ip jest klasy B";
            }
            else if (ip01 >= 192 && ip01 <= 223)
            {
                klasaIP.Text = "adres ip jest klasy C";
            }
            else if (ip01 >= 224 && ip01 <= 239)
            {
                klasaIP.Text = "adres ip jest klasy D";
            }
            else if (ip01 >= 240 && ip01 <= 247)
            {
                klasaIP.Text = "adres ip jest klasy E";
            }
            else if (ip01 >= 248 && ip01 <= 255)
            {
                klasaIP.Text = "adres ip jest klasy F";
            }
           else
            {
                klasaIP.Text = "Adres jest niepoprawny";
            }

            // Czy adres sieci czy hosta
            if (ip04 == 0)
            {
                typAdresu.Text = "Podany adres jest adresem sieci";
            }
            else if (ip04 > 0 && ip04 <= 255)
            {
                typAdresu.Text = "Podany adres jest adresem hosta";
            }
            else
            {
                typAdresu.Text = "Adres jest niepoprawny";
            }

            // do obliczania pierwszego/ostatniego hosta.
            string ip01Bin = Convert.ToString(ip01, 2);
            string ip02Bin = Convert.ToString(ip02, 2);
            string ip03Bin = Convert.ToString(ip03, 2);
            string ip04Bin = Convert.ToString(ip04, 2);
            string maskaBin = "0"; 
            if (int.Parse(maska1.Text) <= 30 && int.Parse(maska1.Text) >= 1) {
                string ipBin = "0";
                ipBin = string.Join(ip01Bin, ip02Bin, ip03Bin, ip04Bin);
                
                for (int i = 0; i <= int.Parse(maska1.Text); i++)
                {
                    if(maskaBin == "0")
                    {
                        maskaBin = "2";
                    }
                    else if(maskaBin == "2")
                    {
                        maskaBin = "1";
                    }
                    else
                    {
                        maskaBin = maskaBin + "1";
                    }
                  
                    
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