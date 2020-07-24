namespace FinanceLib.Holding

open System
open FinanceLib.MarketData
open FinanceLib.Underlying
open FinanceLib.Security
open FinanceLib.PricingEngine


[<AutoOpen>]
module Holding =

    [<AbstractClass>]
    type Holding() =
        abstract Security: ISecurity
        abstract MarketDataEnv: MarketDataEnv
        abstract PricingEngine: IPricingEngine
        abstract Currency: Currency
        abstract Account: string option
        abstract Trader: string option
        member h.GetMarketData(mdt: MarketDataType) = h.MarketDataEnv |> Map.tryFind mdt
