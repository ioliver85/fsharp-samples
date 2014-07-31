
let add x y = x + y

// anonmous function/lambda expression
let add' = fun x y -> x + y

// f is a function
let checkThis item f = 
    if f item then
        printfn "HIT"
    else
        printfn "MISS"

checkThis 5 (fun x -> x > 3)
checkThis 1 (fun x -> x > 3)
checkThis "hi there" (fun x -> x.Length > 5)
