using Microsoft.DotNet.DesignTools.Designers.Actions;
using Microsoft.DotNet.DesignTools.Designers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButton2Library.Design.Server
{
    internal class MyButton2ActionList : DesignerActionList
    {
        private readonly ComponentDesigner _designer;

        public MyButton2ActionList(MyButton2Designer designer) : base(designer.Component)
        {
            _designer = designer;
        }

        public MyButton2Library.MyButton2 MyButton2
        {
            get { return (MyButton2Library.MyButton2)Component!; }
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionMethodItem(
                this,
                "InvokeMyButton2DialogNET6",
                "Edit MyButton2 caption (NET6 dialog)...",
                true));
            items.Add(new DesignerActionMethodItem(
                this,
                "InvokeMyButton2DialogNET472",
                "Edit MyButton2 caption (NET472 dialog)...",
                true));
            items.Add(new DesignerActionMethodItem(
                this,
                "SetBackgroundRed",
                "Red Background",
                "BackgroundColor",
                "",
                true));
            items.Add(new DesignerActionMethodItem(
                this,
                "SetBackgroundWhite",
                "White Background",
                "BackgroundColor",
                "",
                true));
            items.Add(new DesignerActionMethodItem(
                this,
                "SetBackgroundBlue",
                "Blue Background",
                "BackgroundColor",
                "",
                true));
            return items;
        }

        public void InvokeMyButton2DialogNET472()
        {
            _designer.InvokePropertyEditor("Text");
        }

        public void InvokeMyButton2DialogNET6()
        {
            _designer.InvokePropertyEditor("TextTrigger");
        }

        public void SetBackgroundRed()
        {
            MyButton2.BackColor = System.Drawing.Color.Red;
        }

        public void SetBackgroundWhite()
        {
            MyButton2.BackColor = System.Drawing.Color.White;
        }

        public void SetBackgroundBlue()
        {

            MyButton2.BackColor = System.Drawing.Color.Blue;
        }

    }
}
