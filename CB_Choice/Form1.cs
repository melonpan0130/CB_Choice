﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        // default is private
        string[] SList = new string[]
        {
            "Icecream", "Chicken", "Kimchi", "cookie"
        };
        string OrgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }

            this.OrgStr = lblResult.Text;

            if(this.cbList.Items.Count > 0) // 값이 있을 때
                this.cbList.SelectedIndex = 0; // 첫번째 값 기본 설정

        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.cbList.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            // processing enter key
            if(e.KeyChar == (char)13)
            {
                CheckInput();
                e.Handled = true; // 소리 막아줌
            }
        }

        private void CheckInput()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("Please select something", "information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.txtList.Focus();
            }
        }
    }
}
