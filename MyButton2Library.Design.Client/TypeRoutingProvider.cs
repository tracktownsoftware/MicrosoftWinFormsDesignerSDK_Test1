using Microsoft.DotNet.DesignTools.Client.TypeRouting;
using System.Collections.Generic;

namespace MyButton2Library.Design.Client
{
    [ExportTypeRoutingDefinitionProvider]
    internal class TypeRoutingProvider : TypeRoutingDefinitionProvider
    {
        public override IEnumerable<TypeRoutingDefinition> GetDefinitions()
        {
            return new[]
            {
                new TypeRoutingDefinition(
                    TypeRoutingKinds.Editor,
                    nameof(MyButton2Editor_ShowNET472Dialog),
                    typeof(MyButton2Editor_ShowNET472Dialog)),
                new TypeRoutingDefinition(
                    TypeRoutingKinds.Editor,
                    nameof(MyButton2Editor_TriggerNET6Dialog),
                    typeof(MyButton2Editor_TriggerNET6Dialog))
            };
        }
    }
}