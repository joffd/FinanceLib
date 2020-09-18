namespace FinanceLib.Instruments

open System
open FinanceLib.Tools
open FinanceLib.Instruments.Underlying


module ISecurity =
    
    type ISecurity =
        abstract member Underlying: Underlying
        abstract member MarketDataRequired: Set<MarketDataType>
        abstract member Currency: Currency
        abstract member FairValue: DateTime -> float

    type F(index: I, expiry: Expiry) =
        member __.Expiry = expiry
        
        interface ISecurity with

            member __.Underlying = Underlying.Index index
            member __.MarketDataRequired = Set([MarketDataType.Div index; MarketDataType.YC index.Currency])
            member __.Currency = index.Currency
            //member __.FairValue (dt: DateTime) = 1.0


