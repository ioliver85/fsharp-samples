// helper function
let output x = printfn "%A" x

// list comprehension, autofills rest
let ints = [7..13]

output ints

// results to [1;3;5;7;9;11;13;15;17;19]
let oddValues = [1..2..20]

output oddValues

let values step max = [1..step..max]

output (values 2 20)

// sequence
let ints' = seq {7..13}
output ints'

// comp.
output [for x in 7..13 -> x*x]

let yieldValues = 
    seq {
        yield 3;
        yield 42;
        for i in 1..10 do
            yield i
    }

output yieldValues