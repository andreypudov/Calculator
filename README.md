# Calculator
Command-line arbitrary precision calculator

```fsharp

open FParsec

let str_ws s = pstring s >>. spaces

let opp = OperatorPrecedenceParser<float,unit,unit>()
let expr = opp.ExpressionParser
let term = (pfloat .>> spaces) <|> between (str_ws "(") (str_ws ")") expr
opp.TermParser <- term

type Assoc = Associativity

opp.AddOperator(InfixOperator("+", spaces, 1, Assoc.Left, fun x y -> x + y))
opp.AddOperator(InfixOperator("-", spaces, 1, Assoc.Left, fun x y -> x - y))
opp.AddOperator(InfixOperator("*", spaces, 2, Assoc.Left, fun x y -> x * y))
opp.AddOperator(InfixOperator("/", spaces, 2, Assoc.Left, fun x y -> x / y))
opp.AddOperator(PrefixOperator("+", spaces, 3, true, id ))
opp.AddOperator(PrefixOperator("-", spaces, 3, true, fun x -> -x))

run expr "(3.14 * 2) / 2.718"

```