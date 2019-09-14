﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class TabFunctionality : UserControl
    {
        Stack<string> webHistoryB = new Stack<string>();
        Stack<string> webHistoryF = new Stack<string>();

        public TabFunctionality()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textBox1.Text);
                webHistoryB.Push(textBox1.Text);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            webHistoryB.Push(textBox1.Text);
        }
    }
}
