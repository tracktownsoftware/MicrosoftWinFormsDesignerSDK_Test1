using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DotNet.DesignTools.TypeRouting;

namespace MyButton2Library.Design.Server
{
    [Shared]
    [ExportTypeRoutingDefinitionProvider]
    internal class MyButton2RoutingDefinitionProvider : TypeRoutingDefinitionProvider
    {
        private readonly TypeRoutingDefinition[] _definitions = new TypeRoutingDefinition[1]
        {
            TypeRoutingDefinitionProvider.RerouteDesigner<MyButton2Designer>("MyButton2Library.Design.MyButton2Designer")
        };

        public override IEnumerable<TypeRoutingDefinition> GetDefinitions()
        {
            return (IEnumerable<TypeRoutingDefinition>)this._definitions;
        }
    }
}
