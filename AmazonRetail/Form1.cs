using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonRetail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            Form2 myForm = new Form2();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.contenedor.Controls.Add(myForm);
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            Form3 myForm = new Form3();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.contenedor.Controls.Add(myForm);
            myForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
