namespace SkinetAPI.Errors
{
    public class ApiErrorValidationResponse : ApiResponse
    {
        public ApiErrorValidationResponse() : base(400)
        {
        }

        public IEnumerable<string> Errors { get; set; }
    }
}
