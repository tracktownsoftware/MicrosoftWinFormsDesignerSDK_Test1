using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DotNet.DesignTools.TypeRouting;

namespace MyButtonLibrary.WinForms.Surface.MyButton.TypeRouting
{
    [Shared]
    [ExportTypeRoutingDefinitionProvider]
    internal class MyButtonRoutingDefinitionProvider : TypeRoutingDefinitionProvider
    {
        private readonly TypeRoutingDefinition[] _definitions = new TypeRoutingDefinition[1]
        {
            TypeRoutingDefinitionProvider.RerouteDesigner<MyButtonDesigner>("MyButtonLibrary.WinForms.Surface.MyButton.MyButtonDesigner")
        };

        public override IEnumerable<TypeRoutingDefinition> GetDefinitions()
        {
            return (IEnumerable<TypeRoutingDefinition>)this._definitions;
        }
    }
}
