module Examples.PrimitiveObsession3
 
//define a type alias (erased)
type Username = string
type Password = string
type UserId = int
 
let login (a1 : Username) (a2 : Password) : UserId option =
    failwith "not implemented"

//at runtime
//login : string -> string -> int option
