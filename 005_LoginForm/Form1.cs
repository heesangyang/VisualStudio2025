﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_LoginForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "1234" && txtPW.Text == "5678")
            {
                txtL.Text = "로그인 성공";
            }
            else
            {
                txtL.Text = "로그인 실패";
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
