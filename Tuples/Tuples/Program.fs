// tuple
let t1 = 12, 5, 7

// decompose
let v1, v2, v3 = t1

// disregarding value with _
let a1, a2, _ = t1

// types can be combined to tuples
let t2 = "hello", true

// helpers, 
// fst = first
// snd = second
printfn "%A" (fst t2)
printfn "%A" (snd t2)

// returns third value
let third t =
    let _, _, returnValue = t
    returnValue

printfn "%A" (third t1)

// tuples support pattern matching
let third' (_, _, r) = r

printfn "%A" (third' t1)
