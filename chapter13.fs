//1
//Consider the monoid with underlying set {a,b,e}
//We know that: h (a * b) = ha * hb.
//If homomorphism is isomorphic, then we have a g:
// g (ha * hb) = a * b
// If h doesn't preserve the unit, then:
// h e = x, where is not the unit element of the target monoid.
// So, h (a * e) = ha * he = ha * x
//If we apply g to this homomorphism:
// g (ha * x) = gha * gx = a * gx
//But x is not the unit in the target monoid. So a * gx != a, but h and g are
//isomorphic, therefore gx must be equal to e. Conversely, if y is not the
//unit element in the target monoid set, and e' is the unit element in this set,
//we have: a' * hy != a'. By the same reasoning, hy = hge' = e'. Since h and g
//describe an isomorphism, this is always true, and by the same token:
// gx = ghe = e. So the conclusion is that an isomorphism between monoids that
//preserve the product structure must also preserve the unit element.

//2
//[] -> 1
//[1, 2, 3, 4] -> 24
//There are infinite lists, since this can happen
// [12] = [12 ,1] = [1 ,12] = [1, 1, 1, 12].
//If we consider unique integers without 1:
// [12] = [2 ,6] = [3, 4] = [4, 3] = [6, 2]
//We could also make make another homomorphism, that will map the list
// to sum instead of multiplication. Then the image of [] would be 0
// [1, 2, 3, 4] would have the image 10. The binary operation respects
// the law of associativity.

//3
//Consider the element a of set A,
//then all elements would be a:
//[a], [a, a], [a, a, ..., a]
//The unit type also has a single element on it's set: ().
//If we had a product like () * int, we could convert it to a list of a
//for any integer value that corresponde to the list's length:
// (5, ()) = [a, a, a, a, a], (1, ()) = [a], (0, ()) = [].
//Therefore the monoid is isomorphic to a product unit * int.