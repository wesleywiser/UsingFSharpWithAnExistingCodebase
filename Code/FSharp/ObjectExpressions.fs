module Examples.ObjectExpressions

let makeDisposable text =
    { new System.IDisposable with
        member this.Dispose() = printfn "%s" text 
    }
