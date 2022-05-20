using Microsoft.DotNet.DesignTools.Designers.Actions;
using Microsoft.DotNet.DesignTools.Designers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButtonLibrary.Design
{
    internal class MyButtonActionList : DesignerActionList
    {
        private readonly ComponentDesigner _designer;

        public MyButtonActionList(MyButtonDesigner designer) : base(designer.Component)
        {
            _designer = designer;
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionMethodItem(
                this,
                "EditMyButtonCaption",
                "Edit MyButton caption (NET6 dialog)...",
                "",
                "",
                true));
            items.Add(new DesignerActionMethodItem(
                this,
                "ApplicationSettingsBug",
                "Reading application settings fails in NET6 WinForms designer...",
                "",
                "",
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
            items.Add(new DesignerActionMethodItem(
                this,
                "EditButtonText",
                "Edit Button Text",
                "",
                "",
                true));
            return items;
        }


        public MyButton MyButton
        {
            get { return (MyButtonLibrary.MyButton)Component!; }
        }

        public void EditMyButtonCaption()
        {
            using (MyButtonEditorDialog dlg = new MyButtonEditorDialog())
            {
                dlg.ButtonCaption = MyButton.Text;
                var dialogResult = dlg.ShowDialog(MyButton);
                if (dialogResult == DialogResult.OK)
                    MyButton.Text = dlg.ButtonCaption;
            }
        }

        public void ApplicationSettingsBug()
        {
            using (MyButtonEditorDialog dlg = new MyButtonEditorDialog())
            {
                dlg.ButtonCaption = MyButton.Text;
                dlg.ApplicationSettingsTest();
                var dialogResult = dlg.ShowDialog(MyButton);
                if (dialogResult == DialogResult.OK)
                    MyButton.Text = dlg.ButtonCaption;
            }
        }

        public void SetBackgroundRed()
        {
            MyButton.BackColor = System.Drawing.Color.Red;
        }

        public void SetBackgroundWhite()
        {
            MyButton.BackColor = System.Drawing.Color.White;
        }

        public void SetBackgroundBlue()
        {

            MyButton.BackColor = System.Drawing.Color.Blue;
        }
    }
}
