namespace FinanceLib.Security.Crypto

open System
open FinanceLib.Underlying
open FinanceLib.MarketData
open FinanceLib.Security
open FinanceLib.Security.Index
open Microsoft.Extensions.Logging

[<AutoOpen>]
module CCF =

    type CCF(logger: ILogger, index: TokenCurrency, expiry: DateTime, expiryType: ExpiryFormula, mult: Multiplier) =

        interface ISecurity with
            member _.ILogger = logger
            member _.Underlying = Underlying.TokenCurrency index

            member _.MarketDataRequired = Set.ofList ([])

            member _.Currency = index.Base

        member _.Expiry = expiry
        member _.ExpiryType = expiryType

        member _.Multiplier = mult

        member x.IsExpired(now: DateTime) = now > x.Expiry

        member x.TimeToExpiry(now: DateTime) =
            x.Expiry.Subtract(now) |> min TimeSpan.Zero
