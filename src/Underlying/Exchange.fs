namespace FinanceLib.Underlying

open System



[<CustomEquality; CustomComparison>]
type Exchange =
    { Name: string
      TimeZone: TimeZoneInfo }
    override this.Equals(obj) =
        match obj with
        | :? Exchange as ex ->
            (ex.Name = this.Name
             && ex.TimeZone.Id = this.TimeZone.Id)
        | _ -> false

    override this.GetHashCode() = this.GetHashCode()

    interface System.IComparable with
        member this.CompareTo obj =
            match obj with
            | :? Exchange -> 0
            | _ -> -1
