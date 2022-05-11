using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace MyButton2Library.Design.Client
{
    internal class MyButton2Editor_TriggerNET6Dialog : UITypeEditor
    {
        public override object? EditValue(
            ITypeDescriptorContext context,
            IServiceProvider provider,
            object? value)
        {
            value = "TriggerNET6Dialog";
            return value;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            => UITypeEditorEditStyle.None;
    }
}
