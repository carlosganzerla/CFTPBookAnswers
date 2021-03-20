module Chapter24

type PolyRingF = TermF of int | PolyF of int*int

type Poly = Term of int | Poly of Poly

//1
let rec eval x poly  = 
    let rec loop acc power x  =function
        | head::tail -> 
            let next = acc + head * (x ** power)
            loop next (power + 1.0) x tail
        | [] -> acc
    loop 0.0 0.0 x poly

  
//2 like one but with more work

 
 //3
type MatExpr =
  | RZero
  | ROne
  | RComp11
  | RComp12
  | RComp21
  | RComp22
  | RAdd of MatExpr * MatExpr
  | RMul of MatExpr * MatExpr
  | RNeg of MatExpr


let mNeg  (a,b,c,d) = (-a,-b,-c,-d)

let mAdd (a1,a2,a3,a4) (b1,b2,b3,b4) = (a1 + b1, a2 + b2, a3 + b3, a4 + b4)

let mMult (a1,b1,c1,d1) (a2,b2,c2,d2) = (a1 * a2 + b1 * c2, a1 * b2 + b1 * d2, c1 * a2 + d1 * c2, c1 * b2 + d1 * d2)

let rec evalMat = function
    | RZero -> (0,0,0,0)
    | ROne -> (1,0,0,1)
    | RComp11 -> (1,0,0,0)
    | RComp12 -> (0,1,0,0)
    | RComp21 -> (0,0,1,0)
    | RComp22 -> (0,0,0,1)
    | RAdd (a, b) ->mAdd (evalMat a) (evalMat b)
    | RMul (a, b) -> mMult (evalMat a) (evalMat b)
    | RNeg m -> mNeg (evalMat m)

//4
type StreamF = StreamF of int*list<int>

let coalg (StreamF (n,ns)) = StreamF(n * n , ns)

let toList streamF = 
    let rec loop acc (StreamF (n,ns)) =
        match ns with
        | h::t -> loop (h::acc) (StreamF (n, t))
        | [] -> acc
    loop [] streamF

let ana coalg (head::tail) = coalg (StreamF(head, tail))

let squaresStream = ana coalg [1..100]

let squareList = toList squaresStream

//4 using unfold

let square (current, max) =
    if current <= max then
        Some (current * current, (current + 1, max))
    else 
        None

let squaresFrom1to100 = List.unfold square (1,100)

    
//5
let isNotDivisible bot top = top % bot <> 0

let listSieve = function
 | h::t -> Some(h, List.filter (isNotDivisible h) t)
 | [] -> None


//5
let primes = List.unfold listSieve [2..100]

