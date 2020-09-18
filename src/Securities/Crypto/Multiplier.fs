namespace FinanceLib.Security.Index

[<AutoOpen>]
module Multiplier =
    open System
    open FinanceLib.Underlying

    type Multiplier =
        | Custom of float
        | IndexStandard

    let getMultiplierFromIndex (index: Index) =
        function
        | Custom i -> i
        | IndexStandard -> index.StandardMultiplier
