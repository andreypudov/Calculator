// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Calculator.Shell

module Program =

    // open Calculator.Backend
    open Calculator.Backend.DefaultBackend
    // open Calculator.Core
    // open Calculator.Frontend
    // open Calculator.Frontend.DefaultFrontend
    open Calculator.Frontend.FParsecFrontend

    [<EntryPoint>]
    let main argv =
        argv
        |> String.concat " "
        |> FParsecFrontend.analyze
        |> DefaultBackend.optimize
        |> printfn "%s"
        0