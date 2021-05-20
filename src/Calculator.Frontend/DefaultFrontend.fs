// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Calculator.Frontend

module DefaultFrontend =
    
    open LexicalAnalyzer
    open SemanticAnalyzer
    open SyntaxAnalyzer

    let analyze statement =
        statement
            |> LexicalAnalyzer.analyze
            |> SyntaxAnalyzer.analyze
            |> SemanticAnalyzer.analyze