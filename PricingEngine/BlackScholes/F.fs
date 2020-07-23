namespace FinanceLib.PricingEngine

open System
open FinanceLib.Security
open FinanceLib.Security.Index
open FinanceLib.Underlying
open FinanceLib.MarketData
open FinanceLib.Security
open FinanceLib.Tools

module F =


    let calcFairValue (f: F) = 1.


    type BlackScholesF(f: F, div: Dividends, ir: InterestRate, repo: RepoRate) =
        let fair = calcFairValue f

        interface IPricingF with
            member _.Name = "Black Scholes - Listed Future"
            member _.F = f
            member _.Div = div
            member _.IR = ir
            member _.Repo = repo
            member _.Fair = fair, (f :> ISecurity).Currency
            member _.Delta(qty) = if qty >= 0. then 1. else 0.
            member _.DeltaLC qty = fair, (f :> ISecurity).Currency
//member __.SecurityType = SecurityType.F
