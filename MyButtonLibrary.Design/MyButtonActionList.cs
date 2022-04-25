using Microsoft.DotNet.DesignTools.Designers.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButtonLibrary.Design
{
    public class MyButtonActionList : DesignerActionList
    {
        private DesignerActionItemCollection _actionItems;
        private MyButtonLibrary.MyButton _myButton;
        private DesignerActionUIService _designerActionUISvc;


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MyButtonActionList(IComponent? component) : base(component)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            if (component != null)
                _myButton = (MyButtonLibrary.MyButton)component;
#pragma warning disable CS8601 // Possible null reference assignment.
            _designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
#pragma warning restore CS8601 // Possible null reference assignment.
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
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

        public void SetBackgroundRed()
        {
            _myButton.BackColor = System.Drawing.Color.Red;
        }

        public void SetBackgroundWhite()
        {
            _myButton.BackColor = System.Drawing.Color.White;
        }

        public void SetBackgroundBlue()
        {

            _myButton.BackColor = System.Drawing.Color.Blue;
        }
    }
}
