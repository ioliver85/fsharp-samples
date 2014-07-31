// this file needs to be above Program.fs
// setting up a namespace, since there's multiple modules
namespace Calculator.Demo

// if more than one module, it needs the = after it
module Adder = 
    let square x = x * x

    let add x y = x + y

module Multiplier = 
    let multiply x y = x * y

