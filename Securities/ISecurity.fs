namespace FinanceLib.Security

open System
open FinanceLib.Tools
open FinanceLib.Underlying
open FinanceLib.MarketData

[<AutoOpen>]
module ISecurity =
    
    

    type ISecurity =
        abstract member Underlying: Underlying
        abstract member MarketDataRequired: Set<MarketDataNeeded>
        abstract member Currency: Currency
        
       




