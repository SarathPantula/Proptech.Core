using Proptech.Core.Models;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Proptech.Core.Extensions
{
    public static class SMSExtension
    {
        public static MessageResource SendSMS(this SMSMessage smsMessage)
        {
            TwilioClient.Init(smsMessage.AccountSID, smsMessage.AuthToken);

            var message = MessageResource.Create(
                body: smsMessage.Message,
                from: smsMessage.From,
                to: smsMessage.To
            );

            return message;
        }
    }
}
