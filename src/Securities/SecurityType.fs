namespace FinanceLib.Security


open System
open FinanceLib.Security.Crypto

[<AutoOpen>]
module SecurityType =

    type Security =
        | CCF of CCF
        | CCP of CCP
