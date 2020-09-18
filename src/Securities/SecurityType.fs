namespace FinanceLib.Security


open System
open FinanceLib.Security.Crypto

[<AutoOpen>]
module SecurityType =

    type Security =
        | CF of CF
        | CP of CP
