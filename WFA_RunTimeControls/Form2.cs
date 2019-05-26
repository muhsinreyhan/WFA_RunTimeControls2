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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sutunSayisi = 10;
            int satirSayisi = 5;

            for (int i =0 ; i < sutunSayisi; i++)
            {
                for(int j = 0; j < satirSayisi; j++)
                {
                    Button btn = new Button();
                    btn.Text = string.Format("{0}x{1}", i + 1, j + 2);
                    btn.Width = 90;
                    btn.Height = 23;
                    btn.Top = j * btn.Height;
                    btn.Left = i * btn.Width;
                    this.Controls.Add(btn);
                }
            }
            button1.Visible = false;
            this.AutoSize = true;
        }
    }
}
