// square is a function's name
// first x is a function parameter
// return value: x * x
let square x = x * x

// multi-line function
let add x y =
    let result = 
        x + y
    result

// function call
let add5and3 = add 5 3

// similar to c#'s add(square(12), 7)
let result = add (square 12) 7

// function call
printfn "add 1 and 2 is %d" (add 1 2)