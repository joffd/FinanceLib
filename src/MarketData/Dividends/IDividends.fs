namespace FinanceLib.MarketData

open System
open FinanceLib.Underlying


[<AutoOpen>]
module IDividend =

    type UnderlyingWithDIv = Index of Index
    //let fromDivPtsToDiscountedDivPts (ir: InterestRate) (divPts: DateTime -> DateTime -> float)
    type DividendFormat =
        //| DivPoints
        | DiscountedDivPoints
    //| Yield

    type DividendErr =
        | NoData of Index * DateTime
        | DiscountRateNegative of Index * DateTime * DateTime


    type IDividend =
        inherit IMarketData
        //abstract Index: Index
        abstract GetDiv: DividendFormat -> DateTime -> DateTime -> float
        abstract GetDivResult: DividendFormat -> DateTime -> DateTime -> Result<float, DividendErr>
