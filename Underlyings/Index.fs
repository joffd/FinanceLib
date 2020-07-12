namespace FinanceLib.Underlying

open System
open FinanceLib.Underlying.Exchange
open FinanceLib.Underlying

[<AutoOpen>]
module Index =

    type IndexName = {
        FullName: string
        BBG: string
        Reuters: string
    }

    type Index = {
        Name: IndexName
        Exchange: Exchange
        Currency: Currency
        Calendar: Set<DateTime>
        StandardMultiplier: int
    }

