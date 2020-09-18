namespace FinanceLib.Security

open System
open FinanceLib.Tools
open FinanceLib.Underlying
open FinanceLib.MarketData
open Microsoft.Extensions.Logging

[<AutoOpen>]
module ISecurity =



    type ISecurity =
        abstract ILogger: ILogger
        abstract Underlying: Underlying
        abstract MarketDataRequired: Set<MarketDataType>
        abstract Currency: Currency
