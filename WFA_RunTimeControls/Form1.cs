using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RunTimeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count;
        int count2;
        private void Button1_Click(object sender, EventArgs e) // FlowLayoutPanel içerisinde sırasıyla buton tanımlama işlemi
        {
            count++;
            Button btn = new Button();
            
            btn.Width = 90;
            btn.Height = 20;

            flowLayoutPanel1.Controls.Add(btn);
            btn.Text = count.ToString();
        }

        private void Button2_Click(object sender, EventArgs e) // Formun herhangi bir yerinde sırasıyla buton tanımlama işlemi
        {
            count2++;

            Button btn = new Button();
            Random rnd = new Random();

            btn.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

            int x = rnd.Next(0, this.ClientSize.Width - btn.Width);
            int y = rnd.Next(0, this.ClientSize.Height - btn.Height);
            btn.Left = x;
            btn.Top = y;
            this.Controls.Add(btn);
            btn.Text = count2.ToString();

            btn.Click += Btn_Click; // butona ait click eventini yeni oluşturulan butonlara aktardım.
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button gelenDeger = (Button)sender; //sender objesini cast yaparak button özelliklerini aldım.
            MessageBox.Show(gelenDeger.Text);
        }
    }
}
