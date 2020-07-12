namespace FinanceLib.MarketData

open System
open FinanceLib.Underlying


module IInterestRate =
    
    type InterestRateFormat =
    | DiscountedFactor of float

    type InterestRateErr =
    | NoData of Underlying

    type IInterestRateIndex =
        inherit IMarketData
        abstract member Index: Index
        abstract member GetIR: InterestRateFormat -> DateTime -> DateTime -> float
        abstract member GetIRResult:
            InterestRateFormat -> DateTime -> DateTime -> Result<float,DividendErr>