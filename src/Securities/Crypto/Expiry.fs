namespace FinanceLib.Security.Index

open System

[<AutoOpen>]
module Expiry =



    type ExpiryFormula =
        | Close
        | Average of (List<TimeSpan> -> float)
        | Point of (TimeSpan -> float)
