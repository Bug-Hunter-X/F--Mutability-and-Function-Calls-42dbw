let add x y = x + y

let z = add 10 20
printf "%d\n" z

let updatedAdd x y = 
    let updatedX = x
    let updatedY = y
    add updatedX updatedY

let x = 30
let y = 40

let z2 = updatedAdd x y
printf "%d\n" z2