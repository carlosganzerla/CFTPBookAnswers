module Chapter15

//1
//They are the inverse if their composition is the identity.
//DRAW DIAGRAM TO SEE PLS
//Forward
// (phi . psi) fa =
//   phi (\h -> fmap h fa) =
//   (\h -> fmap h fa) id =
//   fmap id fa =
//   fa
//Backward
// (psi . phi) alpha =
//   psi (alpha id) =
//   \h -> fmap h (alpha id) =
//   \h -> (alpha h id) = //See explanation below
//   \h -> alpha h =
//   alpha

//Let h: a->x. so C(a,h): C(a,a)->C(a,x). 
//alpha id is Fa. The equivalent to identity function in set C(a,x) is h o id.
//fmap h is Fh. If we pass Fa to Fh we have:
//fmap h fa = alpha h 

//2
//The Yoneda lemma states that there's a 1 to 1 correspondent between 
//transformations from C(a, −) to F and elements of F a. In a category
//with no morphisms other than the identity, all transformations would be from
// C(a,a) to F. Therefore there's a single natural transformation between
// C(a,a) to F for each element of F. Since N morphisms of F are mapped to
//a single element of C(a,a), it indicates that there's a one to one 
//relationship between natural transformations and elements of Fa.

//3
// Convert the ()->x functor to the list functor List x.
// The natural transformations from C(a, -) (in this case () -> x) to F (in this
//case List x) are one-to-one with the elements of F a. So the data type 
//Container (() -> x) -> List x is another representation of List ().
type Container<'x> = Container of ((unit->'x)->List<'x>)
