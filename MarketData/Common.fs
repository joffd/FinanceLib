namespace FinanceLib.MarketData

open System

[<RequireQualifiedAccess>]
module Common =

    /// From Countinous Rate to DF
    let fromContinousRateToDF (f: DateTime -> DateTime -> float) =
        fun (dateNow: DateTime) (dateLater: DateTime)->
            Math.Exp(-1.0 * dateLater.Subtract(dateNow).TotalDays/365.25 * 
                (f dateNow dateLater))

    /// From DF to Continous Rate.
    /// Exception in case of DF negative
    let fromDFToContinousRate (f: DateTime -> DateTime -> float) =
        fun (dateNow: DateTime) (dateLater: DateTime)->
            -1.0 * Math.Log(f dateNow dateLater) / (dateLater.Subtract(dateNow).TotalDays/365.25)
           

    /// TESTS DVP
    let today = DateTime.Today
    let nextDays =
        [0.0 ..10.0]
        |> List.map (fun i -> today.AddDays(i))

    let rates =
        [0.0 .. 0.001 .. 0.01]
        |> List.map ((+) 0.02)

    let t1 = 
        List.zip nextDays rates
        |> Array.ofList

    let total = [|today , t1|]
    let subf (d: DateTime) (arr: array<DateTime * 'T>) =
        arr 
        |> Array.tryFind (fun (i,_) -> i.Date.CompareTo(d.Date) = 0)
        |> Option.map snd

    let countinious (d1: DateTime) (d2 : DateTime) =
        total
        |> subf d1
        |> Option.bind (subf d2)
        |> Option.defaultValue -1.

    countinious today (today.AddDays(2.))

    let df = 
        fromContinousRateToDF countinious

    df today (today.AddDays(2.))
        
        