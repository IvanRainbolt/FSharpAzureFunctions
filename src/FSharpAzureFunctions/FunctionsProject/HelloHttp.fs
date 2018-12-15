namespace FSharpAzureFunctions

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc

module HelloHttp =
    [<FunctionName("HelloHttp")>]
    let run
        ([<HttpTrigger(Extensions.Http.AuthorizationLevel.Anonymous, "get", Route = "hellohttp")>]
        req: HttpRequest) =
            ContentResult(Content = "Hello Http", ContentType = "text/html")

    [<FunctionName("HelloHttp2")>]
    let run2
        ([<HttpTrigger(Extensions.Http.AuthorizationLevel.Anonymous, "get", Route = "hellohttp2")>]
        req: HttpRequest) =
            ContentResult(Content = "Hello Http 2", ContentType = "text/html")
