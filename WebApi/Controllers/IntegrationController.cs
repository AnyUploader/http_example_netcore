using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Test
/// </summary>
[Route("/Test")]
public class TestController : ControllerBase
{
    /// <summary>
    /// This method is used to test HTTP POST with body,content-type: application/json
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost("TestHttpFromBody")]
    public StandardResponse TestHttpFromBody([FromBody] TestInput input)
    {
        return new StandardResponse
        {
            Data = new Dictionary<string, string> { ["testkey"] = "TestHttpFromBody" },
            Success = true,
            Message = "TestHttpFromBody"
        };
    }

    /// <summary>
    ///  This method is used to test HTTP POST with form-data,content-type: multipart/form-data
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost("TestHttpFromForm")]
    public StandardResponse TestHttpFromForm([FromForm] TestInput input)
    {
        return new StandardResponse
        {
            Data = new Dictionary<string, string> { ["testkey"] = "TestHttpFromForm" },
            Success = true,
            Message = "TestHttpFromForm"
        };
    }

    /// <summary>
    ///  This method is used to test HTTP POST with querystring,content-type: application/x-www-form-urlencoded
    /// </summary>
    /// <param name="tags"></param>
    /// <returns></returns>
    [HttpPost("TestHttpFromQuery")]
    public StandardResponse TestHttpFromQuery([FromQuery] string[] tags)
    {
        return new StandardResponse
        {
            Data = new Dictionary<string, string> { ["testkey"] = "TestHttpFromForm" },
            Success = true,
            Message = "TestHttpFromForm"
        };
    }

    /// <summary>
    ///  This method is used to test HTTP GET
    /// </summary>
    /// <param name="tags"></param>
    /// <returns></returns>
    [HttpGet("TestHttpGet")]
    public StandardResponse TestHttpGet([FromQuery] string[] tags)
    {
        return new StandardResponse
        {
            Data = new Dictionary<string, string> { ["testkey"] = "TestHttpGet" },
            Success = true,
            Message = "TestHttpGet"
        };
    }

    public class TestInput
    {
        public string[] Tags { get; set; }
    }

    public class StandardResponse
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Data { get; set; }
        public string Message { get; set; }
    }
}