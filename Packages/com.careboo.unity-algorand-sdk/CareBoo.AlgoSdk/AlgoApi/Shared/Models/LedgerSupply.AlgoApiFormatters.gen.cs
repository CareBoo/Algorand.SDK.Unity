//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{
    
    
    public partial struct LedgerSupply
    {
        
        private static bool @__generated__IsValid = LedgerSupply.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.LedgerSupply), new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.LedgerSupply>().Assign("current_round", null, (AlgoSdk.LedgerSupply x) => x.Round, (ref AlgoSdk.LedgerSupply x, System.UInt64 value) => x.Round = value, false).Assign("online-money", null, (AlgoSdk.LedgerSupply x) => x.OnlineMoney, (ref AlgoSdk.LedgerSupply x, System.UInt64 value) => x.OnlineMoney = value, false).Assign("total-money", null, (AlgoSdk.LedgerSupply x) => x.TotalMoney, (ref AlgoSdk.LedgerSupply x, System.UInt64 value) => x.TotalMoney = value, false));
            AlgoSdk.AlgoApiFormatterLookup.AddFormatter(typeof(AlgoSdk.LedgerSupply[]), AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.LedgerSupply[]>.Instance);
            return true;
        }
    }
}
