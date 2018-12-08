﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompletaNome.Forms
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
            linkLabel1.Links.Add(0, 6, "https://github.com/Josue10599/ProjetoPNE");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
