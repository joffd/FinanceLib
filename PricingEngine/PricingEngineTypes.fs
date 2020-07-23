namespace FinanceLib.PricingEngine

open System
open FinanceLib.Underlying
open FinanceLib.MarketData
open FinanceLib.Security.Index
open FinanceLib.Hol

[<AutoOpen>]
module PricingEngineTypes =

    type ResultType =
        | Fair of Currency option
        | Delta of Currency option
        | Vega of Currency option
        | Theta of Currency option
        | Gamma of Currency option

    type IPricingEngine =
        abstract Name: string
        //abstract Fair: float * Currency
        //abstract Delta: float -> float
        //abstract DeltaLC: float -> float * Currency
    //abstract member SecurityType: SecurityType


    type IPricingF =
        inherit IPricingEngine
        abstract Holding: HoldingF
//abstract Div: Dividends
//abstract IR: InterestRate
//abstract Repo: RepoRate
