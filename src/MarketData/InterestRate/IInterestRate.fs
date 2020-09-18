namespace FinanceLib.MarketData

open System
open FinanceLib.Underlying


module IInterestRate =

    type InterestRateFormat = DiscountedFactor of float

    type InterestRateErr = NoData of Underlying

    type IInterestRate =
        inherit IMarketData

        abstract GetIR: InterestRateFormat -> DateTime -> DateTime -> float
        abstract GetIRResult: InterestRateFormat -> DateTime -> DateTime -> Result<float, DividendErr>
