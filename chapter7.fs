module Chapter7
//1
//IDENTITY
// fmap f Nothing = Nothing => fmap _ _ = Nothing
// fmap id Nothing = Nothing = id Nothing => Conforms with identity
//COMPOSITION
// fmap (f o g) _ = Nothing => (fmap f o fmap g) _ = fmap f (fmap g _) =
// = fmap f Nothing = fmap f _ = Nothing => Conforms with composition
// Therefore fmap _ _ = Nothing is a functor along with Nothing

//2 Reader functor Converts any a->b morphism to a (r->a)-(r->b) morphism
//given a type constructor (->) r
// fmap f g = f o g
//IDENTITY
// fmap id g = id o g = g = id g => Conforms to identity
//COMPOSTION
//fmap (f o g) h = (f o g) o h = f o (g o h) =
//fmap f (g o h) = fmap f (fmap g h) = (fmap f o fmap g) h => 
//Conforms to composition

type Reader<'r,'a> = Reader of ('r->'a)

let fmapReader f g = Reader (f << g)

//4
// type List = Nil | Cons a (List a)
// fmap f Nil = Nil
// fmap f (Cons h t) = Cons (f h) (fmap f t)
//IDENTITY
//fmap id Nil = Nil = id Nil -> Base case
// fmap id (Cons h t) = Cons (id h) (fmap id t) = Cons id h (id t) 
//(by induction hypothesis) => fmap id (Cons h t) = Cons h t = id (Cons h t)
// => It conforms to identity
//COMPOSITION
//fmap f o g Nil = Nil = fmap f Nil = fmap f (fmap g Nil) = 
// (fmap f o fmap g) Nil
// fmap f o g (Cons h t) = Cons (f o g h) (fmap f o g t) = 
// Cons (f o g h) ((fmap f o fmap g) t) = Cons (f (g h)) ((fmap f o fmap g) t) =
// fmap f (fmap g (Cons h t)) = (fmap f o fmap g) => It conforms to composition