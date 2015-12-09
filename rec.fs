module MyRec

type Book = 
  { Name: string;
    AuthorName: string;
    Rating: int option;
    ISBN: string }
    
type VHS =
  { Name: string;
    AuthorName: string;
    Rating: string; // Videos use a different rating system.
    ISBN: string }
    

let bananaBook = 
    { Name = "Banana book";
      AuthorName = "Bla";
      Book.Rating = None;
      ISBN = "1234343" }

let pearBook = 
    { bananaBook with Book.Rating = Some 3 }

let print (book: Book) = 
    match book.Rating with
    | Some rating ->
      printfn "I give %s %A stars out of 5" book.Name rating
    | None -> printfn "I give %s no rating" book.Name
    
type MushroomColor = 
| Red
| Green 
| Blue   
 
type PowerUp = 
| FireFlower
| MushRoom of MushroomColor
| Star of int
    
let handlePowerUp powerUp = 
    match powerUp with 
    | FireFlower -> printfn "FireFlower"
    | MushRoom color -> match color with
                        | Red -> printfn "Red"
                        | Green -> printfn "Green"
                        | Blue -> printfn "Blue"
    | Star duration -> printfn "duration %d" duration 

MushRoom Green |> handlePowerUp