﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum)
                txtSonuc.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lbSonuc.Text = lbSonuc.Text + "" + txtSonuc.Text + ""+yeniOpt;
            switch(opt)
            {
                case "+":txtSonuc.Text = (sonuc+Double.Parse(txtSonuc.Text)).ToString();break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString(); 
            opt = yeniOpt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lbSonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";

            }
            else if(optDurum)
            {
                txtSonuc.Text = "0";
            }

            if(!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }
    }
}
