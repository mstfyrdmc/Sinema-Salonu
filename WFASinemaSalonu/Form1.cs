using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASinemaSalonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYap_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < 6; x++) // yukarıdan aşağıya sıralanması
            {

                for (int y = 0; y < 13; y++) // yan yana sıralanması
                {

                    //koltuk resminin oluşturulması ve standart özellikleri
                    PictureBox pbKoltuk = new PictureBox();
                    pbKoltuk.Image = Properties.Resources.koltuk;
                    pbKoltuk.SizeMode = PictureBoxSizeMode.Zoom;
                    pbKoltuk.Width = pbKoltuk.Height = 70;
                    pbKoltuk.BackColor = Color.Indigo;
                    pbKoltuk.Margin = new Padding(5, 5, 20, 5);                  

                    // arada koridor olmayan koltukların yaklaştırılması
                    if (y == 0)
                    {
                        pbKoltuk.Margin = new Padding(20, 5, 20, 5);
                    }
                    else if (y == 1 || y == 3 || y == 8 || y == 10)
                    {
                        pbKoltuk.Margin = new Padding(5, 5, 5, 5);
                    }

                    switch (x) //sıra başı ve sonunda koltuk olmayan yerler için
                    {
                        case 0:
                            if (y == 0 || y == 1 || y == 11 || y == 12)
                            {
                                pbKoltuk.BackColor = Color.Transparent;
                                pbKoltuk.Image = null;                               
                            }
                            break;

                        case 2:
                            if (y == 0 || y == 1 || y == 11 || y == 12)
                            {
                                pbKoltuk.BackColor = Color.Transparent;
                                pbKoltuk.Image = null;
                            }
                            break;
                            
                        case 4:
                            if (y == 0 || y == 1 || y == 11 || y == 12)
                            {
                                pbKoltuk.BackColor = Color.Transparent;
                                pbKoltuk.Image = null;
                            }
                            break;
                            
                    }

                    flpSalon.Controls.Add(pbKoltuk);
                }



            }

        }

        private void flpSalon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
