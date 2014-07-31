let add x y = x + y
let multiply x y = x*y
let square x = x * x
let divide x y = x / y

// combining functions
let result = multiply 10 (add 10 (add 5 5))

let add10 = add 10
let multiply10 = multiply 10

// add10 is called with parameter 12 
let result' = 12 |> add10

// add10 is called with parameter 12
// then multiply10 is called with that result as a parameter (22)
let result'' = 12 |> add10 |> multiply10

// COMPOSITION
// parameter goes thru pipeline from left to right
// it can be also right to left <<
// note that parameter p goes like this:
// add10 p -> result of that to parameter to -> multiply10
let add10multiply10 = add10 >> multiply10

// this is same than above (result'')
// parameter 12 moves through pipeline;
// first add10, then its result is passed to multiply10
let result''' = add10multiply10 12