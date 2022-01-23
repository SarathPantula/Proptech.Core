using Proptech.Core.Interfaces;

namespace Proptech.Core.Models
{
    public class MDCResponse : IMDCResponse
    {
        public MDCResponse()
        {
            BadRequestResponses = new List<ErrorMessage>();
            UnAuthorizedResponses = new List<ErrorMessage>();
            ConflictResponses = new List<ErrorMessage>();
            PreConditionFailedResponses = new List<ErrorMessage>();
            ExpectationFailedResponses = new List<ErrorMessage>();
        }
        public dynamic OkResponse { get; set; } = default!;
        public List<ErrorMessage> BadRequestResponses { get; set; }
        public List<ErrorMessage> UnAuthorizedResponses { get; set; }
        public List<ErrorMessage> ConflictResponses { get; set; }
        public List<ErrorMessage> PreConditionFailedResponses { get; set; }
        public List<ErrorMessage> ExpectationFailedResponses { get; set; }
        public string SuccessMessage { get; set; } = default!;
    }
}
