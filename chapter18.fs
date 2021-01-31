module Chapter18
//1 psi(g) = Ec o Lg

open Chapter5
//2

//3

//4 and 5
//Solution (In this solution, we assume C is Set or Hask) We want to prove that 
//C(Either a b, c) ≅ (C × C)(<a, b>, Δ c). A homset in CxC is 
//(C×C)(<a, b>, Δ c), which consists of pairs of functions a -> c, b -> c and 
//a homset in C is C(Either a b, c), which consists of functions 
//(Either a b -> c). We can define a natural transformation between these two 
//homsets with the factorizer and inversefactorizer functions.
//Factorizer for a coproduct
let factorizer (p,q) = function
    | Left a -> p a
    | Right b -> q b

let inverseFactorizer m = (fun a -> m Left a, fun b -> m Right b)
