namespace FinanceLib.MarketData

open System
open FinanceLib.Underlying


module IRepoRate =
    
    type RepoRateFormat =
    | DiscountedFactor of float

    type RepoRateErr =
    | NoData of Underlying

    type IRepoRateIndex =
        inherit IMarketData
        abstract member Index: Index
        abstract member GetIR: RepoRateFormat -> DateTime -> DateTime -> float
        abstract member GetIRResult:
            RepoRateFormat -> DateTime -> DateTime -> Result<float,RepoRateErr>