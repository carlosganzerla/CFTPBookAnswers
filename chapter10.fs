module Chapter10
open Chapter6
open Chapter7

type List<'a> = Nil | Cons of 'a * List<'a>

//Alpha
let maybe2List = function
    | Nothing -> Nil
    | Just x -> Cons (x, Nil)


//F
let fmapMaybe f = function
    | Nothing -> Nothing
    | Just x -> Just (f x)


//G
let rec fmapList f = function
    | Nil -> Nil
    | Cons (x, t) -> Cons (f x, fmapList f t)


// G f o alpha A
let leftNaturality f = fmapList f << maybe2List

// alpha B o F f
let rightNaturality f x = maybe2List << fmapMaybe f

//It folows naturality, it's type parametric, and morphisms reach the same
//object

//2
//Only one list. Elements are always the same.

let readerToList1 _ = Nil

let readerToList2 = function
    | Reader f -> Cons (f (), Nil)

//3 

let readerToMaybe1 _ = Nothing

let readerToMaybe2 = function
    | Reader f -> Just (f true)

let readerToMaybe3 = function
    | Reader f -> Just (f false)


//4
// αa:: F a -> F'a
// βa:: G a -> G'a
//(G' . F') f . (β ◦ α)a = (β ◦ α)b . (G . F) f
//(β ◦ α)b . (G . F) f =
//(βF'b . Gαb) . G . F f = // definition of horizontal composition
//βF'b . G  . F' f . αa = // G αb :: G (F b) -> G (F'b)
//(G' . F') f . (β ◦ α)a = // βF'b :: G (F'a) -> G'(F'a)

//5 (B' . A') o (B . A) = (B' o  B) . (A' o A) =>
// (B' . A') o (B . A GFf) = (B' . A') G'F'f  = G''F''f
//(B' o  B) . (A' o A GFf) = (B' o B) . GF''f = G''F''f 

//6
type Op<'a,'r> = Op of ('a->'r) 

let op = Op (fun x -> x > 0)

let f (x : string) = int x

let contramap f = function
    | Op g -> Op (g << f)

let boolToChar = function
    | true -> 'a'
    | _ -> 'b'

//NATURAL TRANSFORMATION TO OP<'a> to Op<char>
let toBoolCharOp = function
    | Op g -> Op (g >> boolToChar)

//PROVING NATURALITY
let left = contramap f (toBoolCharOp op)
let right = toBoolCharOp (contramap f op)

let test (Op l) (Op r) arg = l arg =  r arg

let test0 = test left right "0"
let test1 = test left right "1"
let test2 = test left right "2"