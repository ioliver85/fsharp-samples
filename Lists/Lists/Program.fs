// empty list
let empty = []

let intList = [12;44;3;65]

printfn "%A" intList

// add item to list 
// :: prepend as a first item
let addItem listOfXs x = x :: listOfXs
// short way
printfn "%A" (1234 :: intList)

let newIntList = addItem intList 1234
printfn "%A" newIntList

// append a list after another list
let appendedIntList = intList @ [999]

printfn "%A" appendedIntList

// list methods
printfn "head %A" intList.Head // first item
printfn "tail %A" intList.Tail // ALL the rest of items as list
printfn "head and tail %A" intList.Tail.Head // first item of tail

// loop list
for i in intList do
    printfn "%A" i

let rec listLength (l: 'a list) =
    if l.IsEmpty then 0
        else 1 + (listLength l.Tail)

printfn "length of list: %d" (listLength intList)

let rec listLength' l = 
    match l with
    | [] -> 0
    | _ :: xs -> 1 + (listLength' xs)

printfn "length of list %d" (listLength' intList)

// x::xs head and tail
let rec takeFromList n l = 
    match n, l with
    | 0, _ -> []
    | _, [] -> []
    |_, (x :: xs) -> x :: (takeFromList (n - 1) xs)

printfn "%A" (takeFromList 2 intList)