using MyButtonLibrary;
using System.ComponentModel;
using Microsoft.DotNet.DesignTools.Designers.Actions;

namespace MyButtonLibrary.WinForms.Surface.MyButton
{
    public class MyButtonActionList : DesignerActionList
    {
        private DesignerActionItemCollection _actionItems;
        private string _productName;
        private MyButtonLibrary.MyButton _myButton;
        private DesignerActionUIService _designerActionUISvc;

        public MyButtonActionList(IComponent? component) : base(component)
        {
            if (component != null)
            {
                _productName = component.GetType().Name;
                _myButton = (MyButtonLibrary.MyButton)component;
            }
            _designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }


        public virtual string ProductName => _productName;

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