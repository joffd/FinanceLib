namespace FinanceLib.Security

open System
open FinanceLib.Tools
open FinanceLib.Underlying
open FinanceLib.MarketData

[<AutoOpen>]
module ISecurity =



    type ISecurity =
        abstract Underlying: Underlying
        abstract MarketDataRequired: Set<MarketDataNeeded>
        abstract Currency: Currency
