namespace FinanceLib.Trade

open System

[<AutoOpen>]
module Trade =

    type Trade = {
        DateTime: DateTime
        Qty: float
        Multiplier: float
        Price: float
        Commission: float // total commission for the trade
        Broker: string
    } with
        
        member x.UnitQty =
            x.Multiplier * x.Qty

        member x.pnl (currVal: float) =
            x.UnitQty * (currVal - x.Price) - x.Commission

        static member calcQty (trades: array<Trade>) =
            trades
            |> Array.fold (fun acc t -> acc + t.Qty) 0.

        static member calcUnitQty (trades: array<Trade>) =
            trades
            |> Array.fold (fun acc t -> acc + t.UnitQty) 0.

        static member calcPnL (currVal: float) (trades: array<Trade>) =
            trades
            |> Array.fold (fun acc t -> acc + t.UnitQty * (currVal - t.Price) - t.Commission) 0.

        
        
            




