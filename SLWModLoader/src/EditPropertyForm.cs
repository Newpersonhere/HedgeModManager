﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLWModLoader
{
    public partial class EditPropertyForm : Form
    {
        public EditPropertyForm(string name, string value, string type, string group, ListViewGroupCollection groups)
        {
            InitializeComponent();
            Text = $"Edit \"{name}\" Property";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}