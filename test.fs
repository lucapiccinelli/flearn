module banana

let hello x = printfn "hello %s" x


let add x y = 
    x + y

let x = add 3.0 5.2

let toHackerTalk (phr:string) = 
    phr.Replace('t', '7').Replace('o', '0')
    
let quad x = 
    let doub x = 
        x * 2
    doub(doub x)
    

let lucaTest test x= 
    test x
    
let isMe x = 
    if x = "Luca" then
        "It is Luca"
    else
        "It's someone else"

printfn "%s" (lucaTest isMe "Luca")        
printfn "%b" (lucaTest (fun x -> x < 2) 1)