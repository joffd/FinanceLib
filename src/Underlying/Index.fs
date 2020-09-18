namespace FinanceLib.Underlying

open System




type IndexName =
    { FullName: string
      BBG: string
      Reuters: string }

type Index =
    { Name: IndexName
      Exchange: Exchange
      Currency: Currency
      Calendar: Set<DateTime>
      StandardMultiplier: float }

//module Index =
//    let a = 1
