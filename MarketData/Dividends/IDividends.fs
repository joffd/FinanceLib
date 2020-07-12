namespace FinanceLib.MarketData

open System
open FinanceLib.Underlying


[<AutoOpen>]
module IDividends =

    //let fromDivPtsToDiscountedDivPts (ir: InterestRate) (divPts: DateTime -> DateTime -> float)
    type DividendFormat =
    //| DivPoints
    | DiscountedDivPoints
    //| Yield

    type DividendErr =
    | NoData of Index * DateTime
    | DiscountRateNegative of Index * DateTime * DateTime


    type IDividendIndex =
        inherit IMarketData
        abstract member Index: Index
        abstract member GetDiv: DividendFormat -> DateTime -> DateTime -> float
        abstract member GetDivResult: DividendFormat -> DateTime -> DateTime -> Result<float,DividendErr>