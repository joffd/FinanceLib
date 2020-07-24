namespace FinanceLib.Portfolio

open System
open FinanceLib.Underlying
open FinanceLib.Holding
open FinanceLib.Trade
open FinanceLib.MarketData
open FinanceLib.PricingEngine
open FinanceLib.Security
open FinanceLib.Tools

[<AutoOpen>]
module PortfolioTypes =

    type HoldingTrades = { Holding: Holding; Trades: Trades }
