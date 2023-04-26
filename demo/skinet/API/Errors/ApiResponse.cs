
namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
        return statusCode switch
        {
                400 => "A bad request, you have made, fucker",
                401 => "Authorized, sike bitch",
                404 => "Resource not found, try again asshole",
                500 => "Errors suck ass, dont make em",
                _ => null
        };
        }
    }
}