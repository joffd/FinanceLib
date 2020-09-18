namespace FinanceLib.Security.Crypto

open System
open FinanceLib.Underlying
open FinanceLib.MarketData
open FinanceLib.Security
open FinanceLib.Security.Index
open Microsoft.Extensions.Logging

[<AutoOpen>]
module CP =

    type CP(logger: ILogger, index: Index, mult: Multiplier) =

        interface ISecurity with
            member _.ILogger = logger
            member _.Underlying = Underlying.Index index

            member _.MarketDataRequired =
                Set.ofList
                    ([ MarketDataType.Div index
                       MarketDataType.IR index.Currency
                       MarketDataType.Repo index ])

            member _.Currency = index.Currency

        member _.Expiry = expiry
        member _.ExpiryType = expiryType

        member _.Multiplier =
            Multiplier.getMultiplierFromIndex index mult

        member x.IsExpired(now: DateTime) = now > x.Expiry

        member x.TimeToExpiry(now: DateTime) =
            x.Expiry.Subtract(now) |> min TimeSpan.Zero
