module currying

let add x y = x + y
let sub x y = x - y

let swapargs f x y = f y x 

let inc = add 1
let dec = swapargs sub 1

let searchEven = Seq.filter (fun x -> x % 2 = 0)

[0..1000] |> searchEven |> Seq.length |> printfn "%d"
dec 10 |> printfn "prima di dieci c'e' %d"