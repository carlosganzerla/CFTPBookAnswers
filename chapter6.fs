module Chapter6

open System
open Chapter5

//1
type Maybe<'a> = Nothing | Just of 'a

let maybeToEither = function
    | Just a -> Right a
    | Nothing -> Left ()

let eitherToMaybe = function
    | Right a -> Just a
    | Left () -> Nothing

//2, 3 and 4
type Shape = Circle of float | Rect of float*float | Square of float

let calculate fCircle fRect = function
    | Circle radius -> fCircle radius
    | Rect (a,b) -> fRect a b
    | Square a -> fRect a a

let area = 
    let areaCircle radius = Math.PI * radius ** 2.0
    let areaRect a b = a * b
    calculate areaCircle areaRect

let circ = 
    let circCircle radius = Math.PI * radius * 2.0
    let circRect a b = 2.0 * (a + b)
    calculate circCircle circRect

//5
type SumOfA<'a> = True of 'a | False of 'a

let toSumOfA = function
    | (true, x) -> True x
    | (false, x) -> False x

let toBoolTimesA = function
    | True x -> (true, x)
    | False x -> (false, x)

