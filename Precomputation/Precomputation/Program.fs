open System.Collections.Generic

let isInList (list: 'a list) v = 
    let lookupTable = new HashSet<'a>(list)
    printfn "Lookup table created, looking up value"
    lookupTable.Contains v

let list = ["hello"; "there"; "everybody"]

// lookup table gets created now every time
printfn "%b" (isInList list "there")
printfn "%b" (isInList list "boo")

// create function that takes list to be checked as a parameter
let isInListEfficient = isInList list

// lookup table gets still created every time, since code 
// gets executed only when all needed parameters are passed
printfn "%b" (isInListEfficient "there")
printfn "%b" (isInListEfficient "buu")

// function takes list as a parameter, and returns a function
// lookup table gets created only once
let constructLookup (list: 'a list) = 
    let lookupTable = new HashSet<'a>(list)
    printfn "Lookup table created, looking up value"
    fun v ->
        printfn "Performing lookup"
        lookupTable.Contains v

let isInListEfficient' = constructLookup list
printfn "%b" (isInListEfficient' "there")
printfn "%b" (isInListEfficient' "buu")

