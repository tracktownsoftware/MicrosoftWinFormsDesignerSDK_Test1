using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;

namespace MyButton2Library
{
    [Designer("MyButton2Library.Design.Server.MyButton2Designer, MyButton2Library.Design.Server")]
    public class MyButton2 : Button
    {
        [Editor("MyButton2Editor_ShowNET472Dialog", typeof(UITypeEditor))]
        public override string Text 
        {
            get 
            { 
                return base.Text; 
            }
            set 
            {

                base.Text = value; 
            } 
        }


        [Editor("MyButton2Editor_TriggerNET6Dialog", typeof(UITypeEditor))]
        public string TextTrigger
        {
            get 
            { 
                return base.Text; 
            }
            set 
            {
                if (value == "TriggerNET6Dialog")
                {
                    using (MyButton2EditorDialog_NET6 dlg = new MyButton2EditorDialog_NET6())
                    {
                        dlg.ButtonCaption = base.Text;
                        var dialogResult = dlg.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                            base.Text = dlg.ButtonCaption;
                    }
                }
                else
                    base.Text = value;
            }
        }

    }
}
