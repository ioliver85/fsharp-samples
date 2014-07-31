let add x y = x + y
let multiply x y = x*y
let square x = x * x
let divide x y = x / y

let add' = fun x y -> x + y
// int -> (int -> int)
let add'' x = fun y -> x + y

// 10 is the x parameter in add'' x function
// it returns a new function
// basically it is like:
// let add10'' = fun y -> 10 + y
let add10'' = add'' 10

// 32 is the y parameter in add10'' function
printfn "%d" (add10'' 32)

let multiply'' x = fun y -> x * y
let multiplyBy10'' = multiply'' 10
printfn "%d" (multiplyBy10'' 10)

// simpler way, no differet function declarations needed
let add10 = add 10
printfn "%d" (add10 89)

let multiplyBy10 = multiply 10
printfn "%d" (multiplyBy10 50)