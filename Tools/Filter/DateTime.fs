namespace FinanceLib.Tools.Filter

open System


[<AutoOpen>]
module FilterDateTime =

    type Request =
        | All
        | TillDateTime of DateTime
        | TillDate of DateTime
        | BetweenTwoDateTime of DateTime * DateTime
        | BetweenTwoDates of DateTime * DateTime
        | SelectedDays of Set<DateTime>


    module Array =
        let filterByRequest (pred: 'T -> DateTime) (req: Request) (arr: array<'T>) =
            match req with
            | All -> arr
            | _ ->
                let f =
                    match req with
                    | All -> fun _ -> true
                    | TillDateTime dt -> fun (x: DateTime) -> x.CompareTo(dt) < 1
                    | TillDate d -> fun (x: DateTime) -> x.Date.CompareTo(d.Date) < 1
                    | BetweenTwoDateTime (dt1, dt2) ->
                        fun (x: DateTime) ->
                            ((min dt1 dt2).CompareTo(x) > -1)
                            && ((max dt1 dt2).CompareTo(x) < 1)
                    | BetweenTwoDates (d1, d2) ->
                        fun (x: DateTime) ->
                            ((min d1 d2).Date.CompareTo(x.Date) > -1)
                            && ((max d1 d2).Date.CompareTo(x.Date) < 1)
                    | SelectedDays set -> fun (x: DateTime) -> set.Contains(x.Date)

                arr |> Array.filter (pred >> f)

    module List =
        let filterByRequest (pred: 'T -> DateTime) (req: Request) (arr: list<'T>) =
            match req with
            | All -> arr
            | _ ->
                let f =
                    match req with
                    | All -> fun _ -> true
                    | TillDateTime dt -> fun (x: DateTime) -> x.CompareTo(dt) < 1
                    | TillDate d -> fun (x: DateTime) -> x.Date.CompareTo(d.Date) < 1
                    | BetweenTwoDateTime (dt1, dt2) ->
                        fun (x: DateTime) ->
                            ((min dt1 dt2).CompareTo(x) > -1)
                            && ((max dt1 dt2).CompareTo(x) < 1)
                    | BetweenTwoDates (d1, d2) ->
                        fun (x: DateTime) ->
                            ((min d1 d2).Date.CompareTo(x.Date) > -1)
                            && ((max d1 d2).Date.CompareTo(x.Date) < 1)
                    | SelectedDays set -> fun (x: DateTime) -> set.Contains(x.Date)

                arr |> List.filter (pred >> f)
