
module Trade.NUnitTests

open System
open FinanceLib.Trade

open NUnit.Framework

let dt = DateTime(2020,1,1)
let broker = "broker"

let sign i =
    if (i % 2 = 0) then 1. else -1.

let trades1 =
    Array.init 3 (fun i -> (float (i+1)) * sign (i+1), (float (i+1)) + 1.)
    |> Array.map 
        (fun (qty, p) -> {
            DateTime = dt.AddDays(p)
            Qty = qty
            Multiplier = 10.
            Price = p
            Commission = 0.1 * abs(qty * 10.)
            Broker = broker
        })
        
       


[<Test>]
let SingleTradeUnitQty () =
    let trade1 = {
        DateTime = dt
        Qty = 5.
        Multiplier = 10.
        Price = 1.
        Commission = 0.1
        Broker = broker
    }

    let act = trade1.UnitQty
    let exp = 50.
    
    Assert.AreEqual(exp, act)

[<Test>]
let TradesCalcUnitQty1 () =
    let act = Trade.calcUnitQty trades1
    let exp = -20.

    Assert.AreEqual(exp, act)

[<Test>]
let TradesCalcUnitQty2 () =
    let act = {Trades = trades1}.UnitQty
    let exp = -20.

    Assert.AreEqual(exp, act)

[<Test>]
let TradesCalcPnl1 () =
    let act = Trade.calcPnL 3.5 trades1
    let exp = 4.

    Assert.AreEqual(exp, act)

[<Test>]
let TradesCalcPnl2 () =
    let act = {Trades = trades1}.calcPnL 3.5
    let exp = 4.

    Assert.AreEqual(exp, act)


