module Chapter23

let rec listProd list1 list2 =
    let rec innerLoop acc value  = function
        | head::tail -> innerLoop ((value,head)::acc) value tail
        | [] -> List.rev acc
    let rec loop acc first second = 
        match first with
        | head::tail -> loop (acc @ (innerLoop [] head second)) tail second 
        | [] -> acc 
    loop [] list1 list2 

type Store<'s,'a> = Store of ('s->'a)*'s with
        static member Extract (Store (f,s)) = f s 
        //replace by extend
        static member Duplicate (Store (f,s)) =
            let duplicate f s = Store (f,s) 
            Store (duplicate f,s)

//s should be int*int (an infinite grid)
//a should be boolean, representing live or dead cells

let (-) (x,y) (a,b) = (x-a, y-b)

let roi = listProd [-3..3] [-3..3]

let getNewState (Store (f,s)) = 
    let liveNeighbors = [
            (-1,-1); 
            (-1,0);
            (-1,1);
            (0,-1);
            (0,1);
            (1,-1);
            (1,0);
            (1,1);
    ] |> List.map (f >> ((-) s))  |> List.filter id
    let currentCell = Store.extract store
    liveNeighbors.Length = 3 || (liveNeighbors.Length = 2 && currentCell)
    


let transition (Store (f,s)) =
    


let gameStore = Store

//First define grid function, and a ROI
//Define a print function