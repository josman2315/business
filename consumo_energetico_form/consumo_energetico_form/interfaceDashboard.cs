﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consumo_energetico_form
{
    public partial class interfaceDashboard : Form
    {
        public interfaceDashboard()
        {
            InitializeComponent();
        }

        private void interfaz_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            formLogin loginForm = new formLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
