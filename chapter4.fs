// 1 - 
// identity x = x
// composition - f o g, if g(x) is defined, return f(g(x)), else return nothing

let identity x = Some x

let composePartial f g x = 
    let result = g x
    match result with
    | Some y -> f y
    | None -> None

let safeRec (x : float32) = 
    match x with
    | 0f -> None
    | x -> Some (1f/x)

let safeRoot (x : float32) =
    match x with
    | _ when x < 0f -> None
    | x -> Some (sqrt x)
