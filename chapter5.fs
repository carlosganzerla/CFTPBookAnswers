module Chapter5
//1
// Say with have object A, B, which both are terminal
// If A is terminal then there's a unique morphism b from B to A
// If B is terminal then there's a unique morphism a from A to B
// Their composition is the identity, hence they are isomorphic
// But there can also be another object C which is also terminal
// Hence C would present another 2 isomorphisms, with objects A and B
// Then the terminal object is unique, up to unique isomorphism

//2
// The product is a smaller object than it's constituents or equal to
// the consituents themselves

//3
// The co-product is a bigger object than it's constituentes or
//equal to the constituents themselves

//4
type Either<'a, 'b> = Left of 'a | Right of 'b
//5
//Injection 1: let i a = a
//Injection 2: let j b = b ? 0 : 1
// We have c, an int, and a, int, and b, a bool
// i a = c, j b = c
//To show Either is better than these injections, we must show that 
// these injections can't find any c' such as:
// I) i' = i << m and i' a = c' for any c' of int
// II) j' = j' << m and j' b = c' for any c' of int
// On I), we have i' x = m x, so if we chose m = i', it satisfies
// On II), we have j' x = (m x) ? 0 : 1, which can yield only c' = 1, or c' = 0
//However, if chose another i, j such as
// let i  = (Left a)
// let j  = (Right b)
//Then we would have i' x = Left (m x), which and can yield any int on Either
//and we would jave j' x = Right (m x), which is same as above,
//Therefore Either is a better candidate

//6 Because they can't project totally on int

//7 They project even less, since i doesn't project on 0, and 1

//8
// type Coproduct = Int of int | Bool of bool
// Acceptable morphisms
// Right int | Left bool