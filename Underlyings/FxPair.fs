namespace FinanceLib.Underlying

open FinanceLib.Underlying

[<AutoOpen>]
module FxPair =

    type FxPair =
        { Base: Currency
          Quote: Currency
          Deliverable: bool }
        member this.Bloomberg =
            sprintf "%s%s" (this.Base.ToString()) (this.Quote.ToString())

        member this.Reuters =
            sprintf "%s%s" (this.Quote.ToString()) (this.Base.ToString())

        override this.ToString() =
            sprintf "%s/%s" (this.Base.ToString()) (this.Quote.ToString())


    type QuoteDelivery = Currency * bool

    let createFxPair (del: bool) (b: Currency) (q: Currency) =
        { Base = b
          Quote = q
          Deliverable = del }
