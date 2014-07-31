module Calculator.Demo.Tests

// xUnit.net -> https://github.com/xunit/xunit
// get xUnit runners too to help running the tests
open Xunit

// unit test
[<Fact>]
let adder_add_5_and_3_should_return_8() =
    Assert.Equal(8, Adder.add 5 3)