namespace FinanceLib.Underlying



type TokenCurrency =
    { Base: Currency
      Quote: Token }

    override this.ToString() =
        sprintf "%s/%s" (this.Quote.Symbol.ToString()) (this.Base.ToString())


[<AutoOpen>]
module TokenCurrency =



    type QuoteDelivery = Currency

    let createTokenCurrency (b: Currency) (q: Token) = { Base = b; Quote = q }
