type Rectangle = 
    { Width: float; Height: float}
// record expression (setting values)
let rect1 = { Width = 5.0; Height = 3.2}
// this works also
let rect2 = { Rectangle.Height = 10.0; Rectangle.Width = 12.3}

type Circle = 
    { mutable Radius: float}
    member x.RadiusSquare with get() = x.Radius * x.Radius
    member x.CalculateArea() = System.Math.PI * x.RadiusSquare

let c1 = {Radius = 3.2}

c1.Radius <- 5.4

// copy and update expression
type Ellipse = 
    { RadiusX: float; RadiusY: float}
    // updates RadiusX
    member x.GrowX dx = { x with RadiusX = x.RadiusX + dx}
    // updates RadiusY
    member x.Growy dy = { x with RadiusY = x.RadiusY + dy}

// function automatically knows the passed type based on the Radius signature
let zeroCircle = function
    | {Radius = 0.0} -> true
    | _ -> false

printfn "%A" (zeroCircle c1)

// function know that passed parameter is typeof Rectangle,
// based on signature
let isSquare = function
    | {Width = w; Height = h} -> w = h





