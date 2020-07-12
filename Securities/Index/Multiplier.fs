namespace FinanceLib.Security.Index

[<AutoOpen>]
module Multiplier =
    open System
    open FinanceLib.Underlying.Index

    type Multiplier =
    | Custom of int
    | IndexStandard

    let getMultiplierFromIndex (index: Index) = function
        | Custom i -> i
        | IndexStandard -> index.StandardMultiplier
        
