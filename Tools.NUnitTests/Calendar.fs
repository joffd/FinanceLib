module Tools.NUnitTests

open System
open NUnit.Framework

open FinanceLib.Tools



[<Test>]
let compareDateTo_1 () =
    let d1 = DateTime(2020,1,2)
    let d2 = DateTime(2020,1,1)
    let d3 = DateTime(2020,1,3)
    let d4 = DateTime(2020,1,2)

    let res = d1.CompareTo(d2)
    let actual = compateDateTo d1 d2
    Assert.AreEqual(res, actual)

[<Test>]
let compareDateTo_2 () =
    let d1 = DateTime(2020,1,2)
    let d3 = DateTime(2020,1,3)

    let res = d1.CompareTo(d3)
    let actual = compateDateTo d1 d3
    Assert.AreEqual(res, actual)

[<Test>]
let compareDateTo_3 () =
    let d1 = DateTime(2020,1,2)
    let d4 = DateTime(2020,1,2)

    let res = d1.CompareTo(d4)
    let actual = compateDateTo d1 d4
    Assert.AreEqual(res, actual)


[<Test>]
let businessDaysBetween_1 () =
    let calendar : Date.Calendar = {
        WeekendDays = stdWeekendSet
        Holidays = Set.empty
    }

    let stardD = DateTime(2020,2,2)
    let endD = DateTime(2020,2,25)
    let actual =
        businessDaysBetween calendar stardD endD
        |> List.distinct
        |> List.length
    let res = 17
    Assert.AreEqual(res, actual)


