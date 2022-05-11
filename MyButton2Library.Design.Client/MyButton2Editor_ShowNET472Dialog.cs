using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace MyButton2Library.Design.Client
{
    internal class MyButton2Editor_ShowNET472Dialog : UITypeEditor
    {
        public override object? EditValue(
            ITypeDescriptorContext context,
            IServiceProvider provider,
            object? value)
        {
            if (provider is null)
            {
                return value;
            }
            var editorService = provider.GetRequiredService<IWindowsFormsEditorService>();
            var designerHost = provider.GetRequiredService<IDesignerHost>();

            using (MyButton2EditorDialog_NET472 myButton2DialogWindow = new MyButton2EditorDialog_NET472())
            {
                myButton2DialogWindow.Host = designerHost;

                if (value == null)
                    myButton2DialogWindow.ButtonCaption = "NULL";
                else if (value is string)
                    myButton2DialogWindow.ButtonCaption = (string)value;
                var dialogResult = editorService.ShowDialog(myButton2DialogWindow);
                if (dialogResult == DialogResult.OK)
                    value = myButton2DialogWindow.ButtonCaption;
            }
            return value;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            => UITypeEditorEditStyle.Modal;
    }
}
