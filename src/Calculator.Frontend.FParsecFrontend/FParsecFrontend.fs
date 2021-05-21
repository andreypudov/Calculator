// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Calculator.Frontend.FParsecFrontend

module FParsecFrontend =

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

    let analyze statement =
        statement
        |> run expr
        |> string