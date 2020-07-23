namespace FinanceLib.Holding

open System
open FinanceLib.MarketData
open FinanceLib.Underlying
open FinanceLib.Security
open FinanceLib.PricingEngine


[<AutoOpen>]
module IHolding =

    type IHolding =
        abstract Security: Security
        abstract MarketDataEnv: MarketDataEnv
        abstract PricingEngine: IPricingEngine
        abstract Currency: Currency
        abstract Account: string option
        abstract Trader: string option
