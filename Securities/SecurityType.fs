namespace FinanceLib.Security


open System


[<AutoOpen>]
module SecurityType =
    
    type SecurityTypeAccepted =
        | IndexFuture of Index.F.F
