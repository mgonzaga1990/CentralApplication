﻿using CentralApplication.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralApplication.Forms
{
    public partial class frmRegistration_AE : Form
    {
        long id;
        User user;

        public frmRegistration_AE(User user,long id)
        {
            InitializeComponent();

            this.id = id;
            this.user = user;
        }

        private void frmRegistration_AE_Load(object sender, EventArgs e)
        {

        }
    }
}