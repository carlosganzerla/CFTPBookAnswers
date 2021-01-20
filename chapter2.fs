open System

let memoize f =
    let mutable map = Map.empty
    let memoized x  =
        let result = Map.tryFind x map
        match result with
        | Some previous -> 
            previous
        | None -> 
            let result = f x
            map <- Map.add x result map
            result
    memoized 

let random (seed : int) = (Random seed).Next()

//3 It still works

//4 a is pure, the rest have side effect

//5 Identity and negation

//6
//absurd Void -> 'a
// identity 'a -> 'a
// negation bool -> bool
// true unit->bool, false unit->bool
// ignore 'a->unit

