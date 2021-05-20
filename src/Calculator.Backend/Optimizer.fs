// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Calculator.Backend

module Optimizer =

    open System

    // Define a function to construct a message to print
    let from whom =
        sprintf "from %s" whom

    let main argv =
        let message = from "F#" // Call the function
        printfn "Hello world %s" message
        0 // return an integer exit code