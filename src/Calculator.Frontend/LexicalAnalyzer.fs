// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Calculator.Frontend

// Converts the source program’s stream of characters into a stream of tokens.
module LexicalAnalyzer =

    let analyze statement =
        statement