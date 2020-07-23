namespace FinanceLib.Math.Distributions


open System
open MathNet.Numerics

module NormalDistribution =

    let normDistDefault = Distributions.Normal()
    let normDist mean stddev = Distributions.Normal(mean, stddev)

    type NormalDist =
        | Default
        | New of mean: float * stddev: float
        | Existing of Distributions.Normal


    let getNormDist =
        function
        | Default -> normDistDefault
        | New (m, s) -> normDist m s
        | Existing nd -> nd


    let cnd (nd: NormalDist) x =
        (getNormDist nd).CumulativeDistribution x
