# F# Mutability and Function Calls

This example demonstrates a potential issue in F# related to mutability and how changes to mutable variables after a function call might not produce expected results when the function uses the initial values.

## Bug Description
The `add` function calculates the sum of `x` and `y`. The values of `x` and `y` are then modified, and the `add` function is called again.  One might expect the second call to `add` to reflect the updated values, but due to how the initial values are captured at the time of function call and not live bound, it does not. 

## How to Reproduce
1. Compile and run the code in `bug.fs`.
2. Observe the output. The output shows that the initial values of `x` and `y` (10 and 20) are used in both calculations, not the updated values (30 and 40).

## Solution
The `bugSolution.fs` file provides a solution that uses a function to return the sum of updated values.