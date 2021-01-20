module Chapter8

open Chapter5
open Chapter6

//1 Pair a b is a product, just replace Pair for (,), therefore
//bimap f g (Pair a b) = Pair (f a) (g b). Product is functorial
type Pair<'a,'b> = Pair of 'a * 'b

let bimap f g (a,b) = (f a, g b)

let first f = bimap f id
let second g = bimap id g 

let bimap2 f g= (first f) >> (second g)

//2
type Identity<'a> = Identity of 'a
type Const = Const of unit

type Maybe2<'a> = Either<Const, Identity<'a>> 
// => Left of Const | Right of Identity<'a>
let toMaybe maybe2 =
    match maybe2 with
    | Left (Const ()) -> Nothing
    | Right (Identity x) -> Just x

let toMaybe2 maybe =
    match maybe with
    | Just x -> Right (Identity x)
    | Nothing -> Left (Const ())
//They are the inverse because
let toMaybeIdentity x = (toMaybe << toMaybe2) x
//It's the identity. Therefore they are isomorphic.

//3
//It's a bifunctor because sum (coproduct) is functorial and Cons a b is
// a bifunctor
type PreList<'a,'b> = Nil | Cons of 'a * 'b

let bimapPl f g = function
    | Nil -> Nil
    | Cons (a,b) -> Cons (f a, g b)
//It can map any morphism, and respect identity and composition:
//bimapPl id id x= Nil | Cons (a,b) = id x
//bimaPpL f' o f g' o g x = Nil | Cons (f' o f a, g' o g b) = 
//Nil = Cons (f' (f a), g' (g b))
//bimapPl f' g' (bimap f g x) 

//4
type K2<'c,'a,'b> = K2 of 'c
type Fst<'a,'b> = Fst of 'a
type Snd<'a,'b> = Snd of 'b
//This is a const bifunctor:
let bimapK2 _ _ k2 = 
    match k2 with
    | K2 x -> K2 x 
//bimapK2 f g = bimapK2 id id. It's trivial to show that it respects composition.
//They are the same proof:
let bimapFst f _ fst = 
    match fst with
    | Fst x -> Fst (f x)
//Trivial to prove functor laws. They are identity bifunctors to the left 
// and to the right

//5 Either implementation:
let bimapEither f g either = 
    match either with
    | Left x -> Left (f x)
    | Right x -> Right (g x)

//6
// Map<TKey, TElement>
// Mapping the morphisms:
// bimap f g= new map with f applied to all keys and g to all values
//It's a bifunctor
//To become a profunctor it's necessary that
