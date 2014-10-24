namespace Examples.Classes
 
type Greeter(name : string) = 
  member this.SayHello() = 
      printfn "Hello %s" name
