namespace FinanceLib.Security.Crypto

open System
open FinanceLib.Underlying
open FinanceLib.MarketData
open FinanceLib.Security
open FinanceLib.Security.Index
open Microsoft.Extensions.Logging

[<AutoOpen>]
module CCP =

    type CCP(logger: ILogger, token: TokenCurrency, mult: Multiplier) =

        interface ISecurity with
            member _.ILogger = logger
            member _.Underlying = Underlying.TokenCurrency token

            member _.MarketDataRequired = Set.ofList ([])

            member _.Currency = token.Base



        member _.Multiplier = mult
