// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Calculator.Frontend

// Turns the token sequence into an abstract syntax tree.
module SyntaxAnalyzer =

    let analyze statement =
        statement