namespace FinanceLib.MarketData

open System
open FinanceLib.Underlying
open FinanceLib.Underlying.Index

[<AutoOpen>]
module MarketDataTypes =



    type Dividends =
        | DiscountedDivPoints of (DateTime -> DateTime -> float)
        | DivPoints of (DateTime -> DateTime -> float)
        | Yield of (DateTime -> DateTime -> float)

    type InterestRate =
        | DF of (DateTime -> DateTime -> float)
        | ContCompounded of (DateTime -> DateTime -> float)

    type RepoRate = ContCompounded of (DateTime -> DateTime -> float)


    type MarketDataType =
        | Div of Index
        | IR of Currency
        | Repo of Index

    //type Source = Index of Index



    type MarketData =
        | Div of IDividend.IDividend
        | IR of IInterestRate.IInterestRate
        | Repo of IRepoRate.IRepoRate

    type MarketDataEnv = Map<MarketDataType, MarketData>
//abstract member Underlying: Source
//end
