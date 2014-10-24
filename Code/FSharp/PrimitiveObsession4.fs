module Examples.PrimitiveObsession4
 
//define a single case DU (reified)
type Username = Username of string
type Password = Password of string
type UserId = UserId of int
 
let login (a1 : Username) (a2 : Password) : UserId option = 
    failwith "not implemented"

//at runtime
//login : Username -> Password -> UserId option
