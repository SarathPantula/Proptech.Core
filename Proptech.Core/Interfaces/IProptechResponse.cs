using Proptech.Core.Models.Response;

namespace Proptech.Core.Interfaces
{
    public interface IProptechResponse
    {
        public List<ErrorMessage> BadRequestResponses { get; set; }
        public List<ErrorMessage> ConflictResponses { get; set; }
        public List<ErrorMessage> UnAuthorizedResponses { get; set; }
        public dynamic OkResponse { get; set; }
        public List<ErrorMessage> PreConditionFailedResponses { get; set; }
        public List<ErrorMessage> ExpectationFailedResponses { get; set; }
        public string SuccessMessage { get; set; }
    }
}
