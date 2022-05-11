using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MyButton2Library.Design.Client
{
    public partial class MyButton2EditorDialog_NET472 : Form
    {
        public bool IsSavePressed;
        public IDesignerHost? Host { get; set; }

        public MyButton2EditorDialog_NET472()
        {
            InitializeComponent();
            IsSavePressed = false;
        }

        public string ButtonCaption
        {
            get 
            { 
                return textButtonCaption.Text; 
            }
            set 
            {
                textButtonCaption.Text = value; 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ButtonCaption = "Hello World2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsSavePressed = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsSavePressed = false;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textButtonCaption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
