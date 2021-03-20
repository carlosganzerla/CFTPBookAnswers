module Chapter25

//1 It maps homomorphisms;
// f: a->b
// It can be seen that: Tf o ua = ub o T(Tf)
// So the action on morphisms for F:
//Ff: (Ta, ua) -> (T (fa), Tf o ua)


//2
// The unit (eta) is duplicate:
//eta: I->Fw o Uw
//I maps to (Wa, da)
// Fw maps a to (Wa, da)
//Uw maps (Wa, da) to Wa
//So we have:
// (Wa, da) -> (W(Wa), dWa)

// The counit (epsilon) is extract:
//epsilon: Uw o Fw -> I 
// Fw maps a to (Wa, da). Uw maps (Wa, da) to Wa.
// So we have: Wa -> a. Which corresponds to extract

//Draw it to make it easier

//3
//It's already done unit is duplicate (co-join), counit is extract (co-return)