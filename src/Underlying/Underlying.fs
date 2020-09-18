namespace FinanceLib.Underlying



type Underlying =
    //| Currency of Currency
    //| Index of Index
    | TokenCurrency of TokenCurrency

module Underlying =

    let getCurrency =
        function
        //| Currency c -> c
        //| Index i -> i.Currency
        | TokenCurrency t -> t.Base
