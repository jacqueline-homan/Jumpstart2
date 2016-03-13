open System
open System.IO

let printCubes min max =
    let cube n =
        n*n*n
    [|min..max|]
    |> Array.map cube
    |> Array.iter (printfn "%i")
printCubes 0 5

let arr = [|0..5|]
printfn "%A" arr
arr.[3] <- 99
printfn "%A" arr //You can also inspect the array in Fsharpi by typing 'arr;;'

let lis = [0..5]
printfn "%A" lis

let printCubes2 min max =
    let cube n =
        n*n*n
    [min..max]
    |> List.map cube
    |> List.iter (printfn "%i")
printCubes2 0 5

[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

