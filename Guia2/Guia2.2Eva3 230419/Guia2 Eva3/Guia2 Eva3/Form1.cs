﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_Eva3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { // Carga la imagen dentro del cuadro Picture box.
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                // Muestra el nombre del archivo en el titulo de forma


                this.Text = string.Concat("Visor de Imagenes(" + openFileDialog1.FileName + ")");

            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("Cal");


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplorer", "http:// www.utec.edu.sv ");


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("C: \\");
            



        }


    }
}
