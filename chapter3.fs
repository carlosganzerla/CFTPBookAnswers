//1
//NODE A, 1 MORPHISM A->A (identity)
//NODE A, 2 MORPHISMS A->A, (edge and identity)
//NODE A,B A->A, A->B, B->B
//NODE A, identity and 26 other morphisms

//2
// A =C B, B =C C => A =C C,  A =C B, B =C A => A = B, => It is a partial order
// T1 := T2 T1 is assignable from T2
// T1 sub T2, T1 sub T2, T2 sub T3, => T1 sub T3, 
//T1 sub T2, T2 sub T1 => T2 = T1 => It is a partial order 

//3
// AND operation is associative (A & B) & C = A & (B & C), 
//and the identity element is TRUE
// OR operation is associative, and the identity element is TRUE

//4 
// Neutral element TRUE
// Morphism = and a b (bool-bool->bool)
// Identity identity b = b
// and a o and b c = (a & (b & c)) = a & b c = and a & b c

//
// Neutral element 0
// Append add m n = (m + n) % 3
// Compostion add x o add y n = (x + (y + n)) % 3 = add x+y n = (x + y + n) % 3
// Identity: identity x = x
//Identity compostion 