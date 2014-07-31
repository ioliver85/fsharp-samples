open System
open System.Threading

// calculate factorial
// rec = recursive
let rec fact x = 
    if x = 1 then 1
    else x * (fact (x-1))

printfn "%d" (fact 5)

// recursive function calling
// fnA calls fnB and fnB calls fnA
let rec fnA() = fnB()
and fnB() = fnA()

// 'tracitional' C#-stylish way to do a endless loop
let showValues() = 
    let r = Random()
    while true do
        printfn "%d" (r.Next())
        Thread.Sleep(1000)

// functional programming way to do the same
let showValues'() = 
    let r = Random()
    let rec displayLoop() =
        printfn "%d" (r.Next())
        Thread.Sleep(1000)
        displayLoop()
    displayLoop()

//showValues()
showValues'()