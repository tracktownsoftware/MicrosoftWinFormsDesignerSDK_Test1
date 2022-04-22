using Microsoft.DotNet.DesignTools.Designers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButtonLibrary.WinForms.Surface.MyButton
{
    internal class MyButtonDesigner : ControlDesigner
    {
        private MyButton _workbookView;
        private DesignerActionListCollection _actionLists;
        private IComponentChangeService _componentChangeService;
        private DesignerActionUIService _designerActionUIService;

        public MyButtonDesigner()
        {
        }

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
        }
    }
}
