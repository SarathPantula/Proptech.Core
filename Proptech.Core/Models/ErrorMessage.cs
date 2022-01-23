namespace Proptech.Core.Models
{
    public class ErrorMessage
    {
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; } = default!;
    }
}
