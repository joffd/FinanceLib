namespace FinanceLib.Underlying


open FinanceLib.Underlying

[<AutoOpen>]
module UnderlyingTypes =

    type Underlying =
        | Currency of Currency
        | Index of Index

    let getCurrency = function
        | Currency c -> c
        | Index i -> i.Currency
