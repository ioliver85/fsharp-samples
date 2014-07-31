// enums need values
// case identifers need a value assigned
// otherwise type doesn't get compiled as a .net Enum type
type MyEnum =
    | First = 0
    | Second = 0

type Product = 
    | OwnProduct of string
    | SupplierReference of int

let product1 = OwnProduct("beer")
let product2 = SupplierReference(33)
// this works also
let product3 = Product.OwnProduct("bread")

// alias
type Count = int

type StockBooking = 
    | Incoming of Product * Count
    | Outgoing of Product * Count

let bookings =
    [
        Incoming(OwnProduct("Rubber Chicken"), 50);
        Incoming(SupplierReference(123), 60);
        Outgoing(OwnProduct("Pulley"), 70);
        Outgoing(SupplierReference(456), 80);
    ]

// type augmentation
// existing types can also be extended
type System.Int32 with
    member x.IsZero = x = 0

let i = 5
printfn "%A" i.IsZero

let booking = Incoming(SupplierReference(63), 20)

type StockBooking with
    member x.IsIncomingBooking() =
        match x with
        | Incoming(_,_) -> true
        | _ -> false

printfn "%A" (booking.IsIncomingBooking())

// empty
type 'a List = E | L of 'a * 'a List

let ints = L(10, L(12, L(15, E)))

printfn "%A" ints