module overloading

open System.Text.RegularExpressions

let (^?) a b = Regex.IsMatch(a, b)
let (^!) a b = Regex.Match(a, b)

let (!@) (a:Match) = a.Groups.Count - 1
let (^@) (a:Match) (b:int) = a.Groups.[b].Value

let myInput = "F# 3.0 is a very cool programming language"

let match input = 
    if input ^? @"F# [\d\.]+" then
        let m = input ^! @"F# [\d\.]+"
        printfn "matched %d groups and the f# version is %s" !@m (m ^@ 1)    
        
match myInput