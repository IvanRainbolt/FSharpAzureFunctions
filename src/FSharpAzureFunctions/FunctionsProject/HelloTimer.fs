namespace FSharpAzureFunctions

open System
open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging

module HelloTimer =

    [<FunctionName("HelloTimer")>]
    let Run ([<TimerTrigger("*/15 * * * * *")>] myTimer: TimerInfo) (log: ILogger) =
        log.LogInformation(sprintf "F# Timer trigger function HelloTimer executed at: %s" (DateTime.Now.ToString()))