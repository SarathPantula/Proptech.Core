namespace Proptech.Core.Models.Response
{
    public class ErrorMessage
    {
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; } = default!;
    }
}
