namespace FinanceLib.Tools

open System

module DateTime =

    [<Literal>]
    let DaysPerYear = 365.26575

    let SecondsPerYear = DaysPerYear * 24. * 3600.

    let calcSecondsBetween (now: DateTime) (future: DateTime) = (future - now).TotalSeconds

    let calcYearFracBetween (now: DateTime) (future: DateTime) =
        (calcSecondsBetween now future) / SecondsPerYear
