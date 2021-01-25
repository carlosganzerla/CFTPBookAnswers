module Chapter14

open Chapter6
//1
//Considering the hom-functor C(a,a), applied to an identity morphism of
//object a in C, we would have a hom-set in Set corresponding to all morphisms
//from a to itself. Since such functor would be a reader functor of the form
// a->a, we would have: fmap id h = id . h = h. Since h must be in the form
//C(a,a)->C(a,a), then h is an identity function.

//2
// fmap f (alpha h)
//Let the hom functor be C(12, -)
let alpha h = Just (h 12)
//THE inverse, beta, would be of the type
// Maybe<'a>->int->'a
//But there's not object of 'a if the value of Maybe<'a> is Nothing, so 
//therefore the functor Maybe is not isomorphic to C(a,-), so it is not 
//representable.

//3
//It is representable, because it describes a hom-set.

//4 and also 6
type Stream<'a> = Cons of 'a * Lazy<Stream<'a>>

let rec tabulate f = (Cons (f 0, lazy tabulate (f << (+) 1)))

let rec index (Cons (b, stream)) = function
    | 0 -> b
    | n -> index (stream.Force ()) (n - 1)

let square x =  x * x

let checkSquare x = 
    printf "Evalutaded"
    square x

let memoizedSquares = tabulate checkSquare

//P.S.

//5.
//Consider a stream generated by tabulate.
//We want to prove that, for any f
// (index . tabulate) f = f
//Base case: index Cons(f 0, ...) 0 = f 0
//Hypothesis: index (tablutate f) n = f n
//So, the n + 1 case: index (tabulate f) n + 1 =>
// tabulate f, can be seen as (Cons f0, (Cons, f1, ... (Cons f n, ...))).
//So for n+1, we have: tabulate f = stream
//(Cons f 0, ... (Cons f n, (Cons f n+1, stream[n+1])))
//By the definition of index: index stream n+1 = index stream[n] 1
//But we have also f n = index stream n = index stream[n-1] 0.Therefore,
//for any n, index . (tabulate f) n = f n 


//6
//The functor is a product. It represents pairs of elements in the hom-set.


