using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelRezarvasyon
{
    public partial class Rezarvasyon : Form
    {
        decimal fiyat;

        public Rezarvasyon()
        {
            InitializeComponent();
        }

        private void Rezarvasyon_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Odeme O1 = new Odeme();
            O1.label1.Text = label1.Text;
            O1.label2.Text = label2.Text;
            O1.label3.Text = label3.Text;
            O1.label4.Text = label4.Text;
            O1.label5.Text = label5.Text;
            O1.label6.Text = label6.Text;

            O1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "1+1 City View";
            fiyat = 0;
            fiyat = 300;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "1+1 Sea View";
            fiyat = 0;
            fiyat = 350;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "2+1 City View";
            fiyat = 0;
            fiyat = 450;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "2+1 Sea View";
            fiyat = 0;
            fiyat = 500;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = "3+1 Suit";
            fiyat = 0;
            fiyat = 700;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "4+1 Penthouse";
            fiyat = 0;
            fiyat = 950;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void button8_Click(object sender, EventArgs e)
        {


            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label6.Text = (fiyat * 1).ToString();
                    break;
                case 1:
                    label6.Text = (fiyat * 2).ToString();
                    break;
                case 2:
                    label6.Text = (fiyat * 3).ToString();
                    break;
                case 3:
                    label6.Text = (fiyat * 4).ToString();
                    break;
                case 4:
                    label6.Text = (fiyat * 5).ToString();
                    break;
                case 5:
                    label6.Text = (fiyat * 6).ToString();
                    break;
                case 6:
                    label6.Text = (fiyat * 7).ToString();
                    break;
                case 7:
                    label6.Text = (fiyat * 8).ToString();
                    break;
                case 8:
                    label6.Text = (fiyat * 9).ToString();
                    break;
                case 9:
                    label6.Text = (fiyat * 10).ToString();
                    break;
                case 10:
                    label6.Text = (fiyat * 11).ToString();
                    break;
                case 11:
                    label6.Text = (fiyat * 12).ToString();
                    break;
                case 12:
                    label6.Text = (fiyat * 13).ToString();
                    break;
                case 13:
                    label6.Text = (fiyat * 14).ToString();
                    break;
                case 14:
                    label6.Text = (fiyat * 15).ToString();
                    break;
                case 15:
                    label6.Text = (fiyat * 16).ToString();
                    break;
                case 16:
                    label6.Text = (fiyat * 17).ToString();
                    break;
                case 17:
                    label6.Text = (fiyat * 18).ToString();
                    break;
                case 18:
                    label6.Text = (fiyat * 19).ToString();
                    break;
                case 19:
                    label6.Text = (fiyat * 20).ToString();
                    break;
                case 20:
                    label6.Text = (fiyat * 21).ToString();
                    break;
                case 21:
                    label6.Text = (fiyat * 22).ToString();
                    break;
                case 22:
                    label6.Text = (fiyat * 23).ToString();
                    break;
                case 23:
                    label6.Text = (fiyat * 24).ToString();
                    break;
                case 24:
                    label6.Text = (fiyat * 25).ToString();
                    break;
                case 25:
                    label6.Text = (fiyat * 26).ToString();
                    break;
                case 26:
                    label6.Text = (fiyat * 27).ToString();
                    break;
                case 27:
                    label6.Text = (fiyat * 28).ToString();
                    break;
                case 28:
                    label6.Text = (fiyat * 29).ToString();
                    break;
                case 29:
                    label6.Text = (fiyat * 30).ToString();
                    break;

                default:

                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
