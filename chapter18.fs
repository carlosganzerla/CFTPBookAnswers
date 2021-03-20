module Chapter18
//1 
//C(La, b) ~= D(a,Rb)
//We must find a morphis that maps a lifted g to a morphism La->b
//Let g: a -> Rb
//Then Lg: La->LRb
//Then Lg belongs to C(La, L o R b)
//So we need to map L o R b, to La.
//But the epsilon component maps L o R b to b.
//So the component psi must be: psi = eb o Lg

open Chapter5
//2
//C(Ld, c) = D(d, Rc)
//Let d = Rc
//C(LRc, c) = D(Rc, Rc) = C(L o R c, c) = C(L o R c, Ic) = counit

//3
//Just prove that the existence of n and e implies in the existance of psi,
//that is:
//psi: D(d, Rc) -> C(Ld, c)
//g: d -> Rc
// => Lg = Ld -> LRc
//We know that for any morphism g belonging to D(d,Rc):
// psi = e o L g => (C(Ld, LRc)->C(Ld, c))->(D(d,Rc)->C(Ld,LRc)).

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

//6
let productToFunction pairFn = fun z -> fun a ->  pairFn (z,a) 

let functionToProduct fn = fun (z,a) -> fn z a


Option.bind()
