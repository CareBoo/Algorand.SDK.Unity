//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk.Experimental.Abi
{
    
    
    public partial struct Interface
    {
        
        private static bool @__generated__IsValid = Interface.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Experimental.Abi.Interface>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Experimental.Abi.Interface>(false).Assign("name", (AlgoSdk.Experimental.Abi.Interface x) => x.Name, (ref AlgoSdk.Experimental.Abi.Interface x, System.String value) => x.Name = value, AlgoSdk.StringComparer.Instance).Assign("desc", (AlgoSdk.Experimental.Abi.Interface x) => x.Description, (ref AlgoSdk.Experimental.Abi.Interface x, System.String value) => x.Description = value, AlgoSdk.StringComparer.Instance).Assign("methods", (AlgoSdk.Experimental.Abi.Interface x) => x.Methods, (ref AlgoSdk.Experimental.Abi.Interface x, AlgoSdk.Experimental.Abi.Method[] value) => x.Methods = value, AlgoSdk.ArrayComparer<AlgoSdk.Experimental.Abi.Method>.Instance));
            return true;
        }
    }
}
