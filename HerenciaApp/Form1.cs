﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Animal animal = new Animal("Animal Genérico", 5);
                MessageBox.Show($"Nombre: {animal.Nombre}\nEdad: {animal.Edad}\nSonido: {animal.EmitirSonido()}");
            }

            private void btnPerro_Click(object sender, EventArgs e)
            {
                Perro perro = new Perro("Bobby", 3);
                MessageBox.Show($"Nombre: {perro.Nombre}\nEdad: {perro.Edad}\nSonido: {perro.EmitirSonido()}");
            }
        }
    }

