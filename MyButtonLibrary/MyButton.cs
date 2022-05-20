using MyButtonLibrary.Properties;
using System.ComponentModel;

namespace MyButtonLibrary
{
    [Designer("MyButtonLibrary.Design.MyButtonDesigner, MyButtonLibrary.Design")]
    public class MyButton: Button
    {

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.Text = Settings.Default.HelloWorld;
        }
    }
}