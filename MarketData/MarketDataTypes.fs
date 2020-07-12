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

    type RepoRate =
    | ContCompounded of (DateTime -> DateTime -> float)

    type MarketData =
    | Div of Dividends
    | IR of InterestRate
    | Repo of RepoRate

    type MarketDataNeeded =
    | Div of Index
    | IR of Currency
    | Repo of Index

    type Source =
    | Index of Index
    
        

    type MarketDataEnv = Set<MarketDataNeeded>

    type IMarketData = interface end
        //abstract member Underlying: Source
        //end
    

    

