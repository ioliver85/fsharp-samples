
// Calculates the Fibonacci numbers
let rec fibonacci x = 
    match x with
    | x when x <= 0 -> failwith "x must be greater than zero"
    | 1 -> 1
    | 2 -> 1
    // if x > 2, calculates recursively
    | x -> fibonacci(x-1) + fibonacci(x-2)

printfn "Fibonacci 2 = %i" (fibonacci 2)
printfn "Fibonacci 3 = %i" (fibonacci 3)
printfn "Fibonacci 11 = %i" (fibonacci 11)
// throws exception
//printfn "Fibonacci -1 = %i" (fibonacci 0)

// Calculates Lucas numbers
let rec lucas x = 
    match x with
    | x when x <= 0 -> failwith "x must be greater than zero"
    | 1 -> 1
    | 2 -> 3
    | x -> lucas(x-1) + lucas(x-2)

printfn "Lucas 1 = %i" (lucas 1)
printfn "Lucas 2 = %i" (lucas 2)
printfn "Lucas 3 = %i" (lucas 3)
printfn "Lucas 10 = %i" (lucas 10)
// throws exception
//printfn "Lucas -1 = %i" (lucas -1)