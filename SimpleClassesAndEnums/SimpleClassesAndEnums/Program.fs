// enum type
type CarType =
    | Tricar = 0
    | StandardFourWheeler = 1
    | HeavyLoadCarrier = 2
    | ReallyLargeTruck = 3
    | CrazyHugeMonsterTruck = 4
    | WeirdContraption = 5

// class Car
// takes two parameters, color and wheelCount
type Car(color: string, wheelCount: int) =
    // parameter checks
    do 
        if wheelCount < 3 then 
            failwith "Cars need to have at least three wheels"
        if wheelCount > 99 then
            failwith "Come on, that ridiculous"
    
    // value inside class
    let carType = 
        //match wheelcount
        match wheelCount with
        | 3 -> CarType.Tricar
        | 4 -> CarType.StandardFourWheeler
        | 6 -> CarType.HeavyLoadCarrier
        | 8 -> CarType.ReallyLargeTruck
        // temporary value x
        // all odd number of wheels
        | x when x % 2 = 1 -> CarType.WeirdContraption
        // 8+ wheels (even)
        // _ means 'whateva'
        | _ -> CarType.CrazyHugeMonsterTruck

    // mutable value
    let mutable passengerCount = 0

    // secondary constructor
    new() = Car("red", 4)
    
    // class member
    // x is self reference, like self, this
    // this can be also used
    // the color parameter is available automatically
    // %A means any
    member x.Move() = printfn "The %s car (%A) is moving" color carType

    // property
    member x.CarType = carType
    
    // property with getter and setter
    // it is abstract, so that classes derived from Car can modify it
    abstract PassengerCount: int with get, set    
    // initial implementation of abstract property (note no member keyword)
    // v is a temporary value
    // <- sets mutable passengerCount to v
    default x.PassengerCount 
        with get() = passengerCount 
        and set v = passengerCount <- v

// class derived from Car class
type RedSportsCar() = 
    // inherit tells what the base class is and
    // calls base class constructor
    inherit Car("red", 4)

    // override base class property
    override x.PassengerCount
        with set v = 
            if v > 2 then failwith "only two passengers allowed"
                // access base class implementation
                else base.PassengerCount <- v

// instantiate Car
// now new keyword is needed, since class doesn't implement IDisposable
let car = Car()
car.Move()

let yellowCar = Car("yellow", 98)
yellowCar.Move()

printfn "yellowCar has a type %A" yellowCar.CarType

printfn "yellowCar has a %d passengers" yellowCar.PassengerCount
// set mutable value with <-
yellowCar.PassengerCount <- 3
// now yellowCar has a different passengerCount
printfn "yellowCar has a %d passengers" yellowCar.PassengerCount

let sportsCar = RedSportsCar()
sportsCar.PassengerCount <- 2
printfn "sportsCar has %d passengers" sportsCar.PassengerCount

// throws exception
//sportsCar.PassengerCount <- 3

// upcasting to object
let sportsCarObject = sportsCar :> obj

// try to cast object to Car
let sportsCarObjecttBackToCar = sportsCarObject :?> Car