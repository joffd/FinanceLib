namespace FinanceLib.Underlying

open System
open FinanceLib.Underlying

type BlockChainTechnology =
    | BTC
    | ETH

type Token = { Name: string; Symbol: string }

module Crypto =

    let BTC = { Name = "Bitcoin"; Symbol = "BTC" }
