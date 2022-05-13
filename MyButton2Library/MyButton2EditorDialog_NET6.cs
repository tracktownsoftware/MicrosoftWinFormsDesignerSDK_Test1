using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyButton2Library
{
    public partial class MyButton2EditorDialog_NET6 : Form
    {
        public MyButton2EditorDialog_NET6()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.Load += MyButton2EditorDialog_NET6_Load;
        }

        public string ButtonCaption
        {
            get { return textButtonCaption.Text; }
            set { textButtonCaption.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyButton2EditorDialog_NET6_Load(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
    }
}
