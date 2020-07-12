namespace FinanceLib.Trade

open System
open FinanceLib.Tools.Filter

[<AutoOpen>]
module Trades =

    


    type Trades = {
        Trades: array<Trade>
    } with
       
        member x.UnitQty =
            x.Trades
            |> Array.fold (fun acc t -> acc + t.UnitQty) 0.

        member x.calcPnL (currVal: float) =
            x.Trades
            |> (Trade.calcPnL currVal)

        member x.filterByRequest (req: Request) =
            x.Trades
            |> Array.filterByRequest (fun t -> t.DateTime) req
            |> fun x -> { Trades = x}

        member x.filterCalcPnL (req: Request) (currVal: float) =
            x.Trades
            |> Array.filterByRequest (fun t -> t.DateTime) req
            |> (Trade.calcPnL currVal)