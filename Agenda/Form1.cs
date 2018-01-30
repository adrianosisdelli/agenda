﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Inicial : Form
    {
        private Contador contador = new Contador("Adriano S. Costa");

        public Inicial()
        {
            InitializeComponent();
            this.contador.setMonitor(this.pLabel1);
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            
        }

        private void pButton1_Click(object sender, EventArgs e)
        {
            this.contador.ativar();
        }
    }
}
