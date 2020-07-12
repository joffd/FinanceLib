namespace FinanceLib.Holding

open System
open FinanceLib.MarketData
open FinanceLib.Underlying
open FinanceLib.Security
open FinanceLib.Security.Index
open FinanceLib.PricingEngine


[<AutoOpen>]
module HoldingF =
    type HoldingF(f: F, marketdataenv: MarketDataEnv, pricingEngineF: IPricingF, qd: QuoteDelivery, 
        ?account: string, ?trader: string) =
        
        interface IHolding with
            member _.Security = f :> ISecurity
            member _.MarketDataEnv = marketdataenv
            member _.PricingEngine = pricingEngineF :> IPricingEngine
            member _.FxPair = 
                FxPair.createFxPair (fst qd) (getCurrency (f :> ISecurity).Underlying) (snd qd)
            member _.Account = account
            member _.Trader = trader


        