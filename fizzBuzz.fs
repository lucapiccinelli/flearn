module fizzBuzz

let (|Mul3|_|) i = if i % 3 = 0 then Some Mul3 else None    
let (|Mul5|_|) i = if i % 5 = 0 then Some Mul5 else None
    
let fizzBuzzF i =
  match i with
  | Mul3 & Mul5 -> printf "FizzBuzz, " 
  | Mul3 -> printf "Fizz, "
  | Mul5 -> printf "Buzz, "
  | _ -> printf "%d, " i
 
[0..100] |> List.iter fizzBuzzF 