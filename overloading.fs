module overloading

open System.Text.RegularExpressions

let string2opt (s:string) = 
    let mutable ret = RegexOptions.ECMAScript
    for c in s do
        match c with
        | 's' -> ret <- ret ||| RegexOptions.Singleline
        | 'm' -> ret <- ret ||| RegexOptions.Multiline
        | 'i' -> ret <- ret ||| RegexOptions.IgnoreCase
        | _ -> ()
    ret

let (^?) a (b, c) = Regex.IsMatch(a, b, string2opt c)
let (^!) a (b, c) = Regex.Match(a, b, string2opt c)

let (!@) (a:Match) = a.Groups.Count - 1
let (^@) (a:Match) (b:int) = a.Groups.[b].Value

let (^~) a (b, c:string, d) = Regex.Replace(a, b, c, string2opt d)

let input = "F# 3.0 is a very cool programming language"

input ^~ ("very", "super", "") |> printfn "%s"

if input ^? (@"F# [\d\.]+", "i") then
    let m = input ^! (@"F# ([\d\.]+)", "")
    printfn "matched %d groups and the f# version is %s" !@m (m^@1)
    
type Point(x:float, y:float) = 
    member this.X = x
    member this.Y = y
    
    static member (+) (p1:Point, p2:Point) = 
        new Point(p1.X + p2.X, p1.Y + p2.Y)
        
let p1, p2 = new Point(0., 1.), new Point(1., 1.)
p1 + p2