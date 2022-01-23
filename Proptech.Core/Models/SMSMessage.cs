namespace Proptech.Core.Models
{
    public class SMSMessage
    {
        public string To { get; set; } = default!;
        public string From { get; set; } = default!;
        public string Message { get; set; } = default!;
        public string AccountSID { get; set; } = default!;
        public string AuthToken { get; set; } = default!;
    }
}
