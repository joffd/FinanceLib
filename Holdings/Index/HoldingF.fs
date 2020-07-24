﻿namespace FinanceLib.Holding

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

        inherit Holding()
        with
            override h.Security = f :> ISecurity
            override h.MarketDataEnv = marketdataenv
            override h.PricingEngine = pricingEngineF :> IPricingEngine

            override h.Currency =
                match cur with
                | None -> (f :> ISecurity).Currency
                | Some c -> c

            override h.Account = account
            override h.Trader = trader
