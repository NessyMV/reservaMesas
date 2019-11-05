using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace camion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Salir";
            btn.Location = new Point(1,1);
            btn.BackColor = Color.Aqua;
            btn.Click += new EventHandler(btn_Click);
            Controls.Add(btn);


        }

        void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void asientos1_Load(object sender, EventArgs e)
        {

        }

        private void asientos1_Load_1(object sender, EventArgs e)
        {

        }

        private void asientos1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
