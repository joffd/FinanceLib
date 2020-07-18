namespace FinanceLib.Holding

open System
open FinanceLib.MarketData
open FinanceLib.Underlying
open FinanceLib.Security
open FinanceLib.PricingEngine


[<AutoOpen>]
module IHolding =

    type IHolding =
        abstract member Security: Security
        abstract member MarketDataEnv: MarketDataEnv
        abstract member PricingEngine: IPricingEngine
        abstract member FxPair: FxPair
        abstract member Account: string option
        abstract member Trader: string option