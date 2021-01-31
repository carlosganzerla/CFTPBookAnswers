module Chapter16
//1
//fromCoY :: (x->a)->x->b ~= a->b
//let fromCoY f x = atob (f x) 
//fromCoY id x = atob x => bijection between functions 

//let fromCoY  (f : 'x->'a) (x : 'x) : 'b = atob (f x)
//2
//let f = id
//fromY f b = f (btoa b)
//fromY f = b -> f (btoa b)
//fromY = btoa
//(fromY f o btoa) = id => b -> f (btoa (btoa b)) =  b -> btoa o btoa b
//Assuming btoa o btoa = id => b->b = id
//(btoa o fromY f) = btoa (b -> f (btoa b)) = btoa (b -> btoa b) b = 
//btoa o btoa = id

//3
// In the single-element category view of monoid, we have a single element and the
// morphisms follow the monoid association rules. We will call this category M. 
// The Yoneda embedding maps the single object a to the functor M(a, -), which 
// is the functor in [M, Set] that maps the single element a to the set M(a,a). 
// The Yoneda embedding maps each morphism in M to the identity natural
// transformation that maps the functor M(a, a) to itself.

//4
// In a preorder category C, if and only if a morphism f: b -> a exists, we
//have exactly one natural transformation between C(a, -) and C(b, -). Since 
//there are no functions that map non-empty sets into the empty set, we see that 
//if C(a, x) is nonempty, then C(b, x) must be nonempty as well.
// Therefore, we have the condition: b <= a, if and only if for all x, 
//a <= x implies b <= x

//5
//[C,D] => Category of all functors from C to D
//Objects in [C,D] are functors. Morphisms are natural transformations.
//[[C,D],Set] => Category of all functors from the functor categroy described
//by all functors from C to D to Set.
//So, by applying the Yoneda embedding:
//[[C,D],Set]([C,D](Fa, -), [C,D](Fb, -)) ~= [C,D](Fb,Fa)
//So we would have
// (Fa -> Fx)->Fb->Fx => NatA -> NatB
//So the embedding maps natural transformations.