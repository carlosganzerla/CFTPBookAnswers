//1
//STRUCTURE: Classes A, B, C D.
// A inherits from B which inherits from both A and C, which in turn inherit 
//from D. Given any class E that is a superclass of both A and C, we can say
//it is a superclass of D. So D would only implement the necessary methods
// for A and C to work. E would provide additional methods that are neither
//overriden in A or C.

//2
// Assume a 2 category with a, b and a->b. If the limit is the initial object,
//then m = id_a. Therefore for any p' = p . m => p' = p . id = p =>
//all components p' factorize to p, so the equation is always satisfied.
//Now it should be enough to prove the same for q. q' = q . m. But q' = p . f.
//So, we have p . f = q . m. But q = id so p . f = q. Since p = id_a then q = f,
//which confirms that the limit is the initial object.

//3 The initial object is an empty set. The terminal object is the whole
//set that generated such category. 
//The pullback is a set D that contains the most
//elements possible that makes it both a subset of a set A and also a subset 
//of set C. Therefore it is the instersection of A and C
//Similarly, the pushout is the union of sets A and C. It follows the 
//product/sum structure nicely.

//4 Differently from an equalizer, it follows the equations as such:
// q . f = q . g. All other q' would factor to q.

//5 Consider a 3 category: A->B<-C. B is terminal. The pullback is to find
//an the apex of the universal cone conected to the diagram related to this
//category. By the definition of product, the apex of the universal cone is
// a product

//6 Similarly, by the definitions of pushout and coproduct, the apex is a
//coproduct.