namespace FinanceLib.Underlying



type Underlying =
    //| Currency of Currency
    //| Index of Index
    | Token of Token

module Underlying =

    let getCurrency =
        function
        //| Currency c -> c
        //| Index i -> i.Currency
        | Token _ -> USD
