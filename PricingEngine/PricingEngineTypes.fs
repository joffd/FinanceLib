namespace FinanceLib.PricingEngine

open System
open FinanceLib.Underlying
open FinanceLib.MarketData
open FinanceLib.Security.Index

[<AutoOpen>]
module PricingEngineTypes =

    type ResultType =
        | Fair of Currency option
        | Delta of Currency option
        | Vega of Currency option
        | Theta of Currency option
        | Gamma of Currency option

    type IPricingEngine =
        abstract member Name: string
        abstract member Fair: float * Currency
        abstract member Delta: float -> float
        abstract member DeltaLC: float -> float * Currency
        //abstract member SecurityType: SecurityType

    
    type IPricingF =
        inherit IPricingEngine
        abstract member F: F 
        abstract member Div: Dividends
        abstract member IR: InterestRate
        abstract member Repo: RepoRate
        
