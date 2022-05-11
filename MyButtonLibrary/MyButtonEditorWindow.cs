using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyButtonLibrary
{
    public partial class MyButtonEditorWindow : Form
    {
        //public bool IsSavePressed;
        public MyButtonEditorWindow()
        {
            InitializeComponent();
            //IsSavePressed = false;
        }

        public string ButtonCaption
        {
            get { return textButtonCaption.Text; }
            set { textButtonCaption.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IsSavePressed = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //IsSavePressed = false;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
