namespace FinanceLib.Holding

open System
open FinanceLib.MarketData
open FinanceLib.Underlying
open FinanceLib.Security
open FinanceLib.Security.Index
open FinanceLib.PricingEngine


[<AutoOpen>]
module HoldingF =
    type HoldingF(f: F,
                  marketdataenv: MarketDataEnv,
                  pricingEngineF: IPricingF,
                  ?cur: Currency,
                  ?account: string,
                  ?trader: string) =

        interface IHolding with
            member _.Security = Security.F f
            member _.MarketDataEnv = marketdataenv
            member _.PricingEngine = pricingEngineF :> IPricingEngine

            member _.Currency =
                match cur with
                | None -> (f :> ISecurity).Currency
                | Some c -> c

            member _.Account = account
            member _.Trader = trader
