namespace FinanceLib.Security


open System
open FinanceLib.Security.Index

[<AutoOpen>]
module SecurityType =
    
    type Security =
        | F of F
