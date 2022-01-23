namespace Proptech.Core.Helpers
{
    public static class OTPHelper
    {
        public static string GenerateRandomOTP()
        {
            int iOTPLength = 6;
            string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string sOTP = String.Empty;

            Random rand = new ();

            for (int i = 0; i < iOTPLength; i++)
            {
                var sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];
                sOTP += sTempChars;
            }
            return sOTP;
        }
    }
}
