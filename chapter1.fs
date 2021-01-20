let identity x = x

let compose f g x = g (f x)

let add5 = (+) 5

let testIdentity () =
    let result = compose add5 identity 3
    match result with
    | 8 -> printfn "ok"
    | _ -> failwith "fodeu"

//4 WWW is a category, with itself as a single element, and links are morphisms 
//from WWW to itself. Pages are different views of WWW.

//5 - It's not a category because you can't add yourself as friend, altough you 
//can compose friendships.

//6 - When there is an arrow from each node to itself, and when there's a 
//composition arrow between nodes that linked indirectly