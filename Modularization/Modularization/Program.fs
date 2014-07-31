// define module
// only one module in this file, so it doesn't need the = after it
module Program

// open namespace
open Calculator.Demo

// starting point of application
[<EntryPoint>]
// takes arguments if any
let main args =
    // use add-function from Adder module
    printfn "add 5 and 6 is %d" (Adder.add 5 3)
    // return value
    0