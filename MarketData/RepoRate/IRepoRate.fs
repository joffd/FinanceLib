namespace FinanceLib.MarketData

open System
open FinanceLib.Underlying


module IRepoRate =

    type RepoRateFormat = DiscountedFactor of float

    type RepoRateErr = NoData of Underlying

    type IRepoRateIndex =
        inherit IMarketData
        abstract Index: Index
        abstract GetIR: RepoRateFormat -> DateTime -> DateTime -> float
        abstract GetIRResult: RepoRateFormat -> DateTime -> DateTime -> Result<float, RepoRateErr>
