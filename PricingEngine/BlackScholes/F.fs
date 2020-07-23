namespace FinanceLib.PricingEngine

open System
open FinanceLib.Security
open FinanceLib.Security.Index
open FinanceLib.Underlying
open FinanceLib.MarketData
open FinanceLib.Security
open FinanceLib.Tools

module F =



    let private calcFairValue (discDiv: float) (iryield: float) (repoyield: float) (f: F) (now: DateTime) (spot: float) =

        let timeToExp =
            DateTime.calcYearFracBetween now f.Expiry

        spot
        * discDiv
        * exp ((-iryield + repoyield) * timeToExp)

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
