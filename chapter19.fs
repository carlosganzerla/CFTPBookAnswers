module Chapter19
//1
//A free monoid constructed from the singleton set is the unit list
//What needs to be proved is that for every unique morphism from this monoid
//to any other monoid m, there is also a unique function from the singleton
//set to the underlying set of m.
//We know that Mon(Fx, m) ~= Set(x, Um). x = (), so:
//Mon(F (), m) ~= Set((), Um)
//F () does not collapse anything, sice it has possibly only one value. Let's
//call this value M.
//So Mon(M,m) ~= Set((), Um). For any m we pick, there could be as many 
//functions to from the unit set to the underlying set as there are elements
//of m. But each of those functions is mapped to a single monoid m im Mon.