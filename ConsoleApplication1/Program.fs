// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open cascalog.hadoop
open cascalog.ops
open cascalog.test
open cascalog
open clojure.core
open jcascalog
open com.twitter.maple.tap


[<EntryPoint>]
let main argv = 
    
    let z = Api.execute((new StdoutTap()), (new Subquery("?person")).predicate(Playground.AGE, "?person", 25))

    printfn "%A" argv
    printfn "Hit any key to exit."
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
