using Proptech.Core.Constants;
using Proptech.Core.Enums;
using System.Security.Claims;

namespace Proptech.Core.Extensions
{
    public static class UserClaimsExtension
    {
        public static string GetUserID(this ClaimsPrincipal User)
        {
            return User.Claims.Single(p => p.Type == ProptechClaimTypes.UserID).Value;
        }

        public static List<string> GetAllProjects(this ClaimsPrincipal User)
        {
            return User.Claims.Where(p => p.Type == ProptechClaimTypes.ProjectID).Select(p => p.Value).ToList();
        }

        public static List<string> GetAllOrganizations(this ClaimsPrincipal User)
        {
            return User.Claims.Where(p => p.Type == ProptechClaimTypes.OrganizationID).Select(p => p.Value).ToList();
        }

        public static bool IsGlobalUSer(this ClaimsPrincipal user)
        {
            return user.Claims.Where(p => p.Type == ProptechClaimTypes.Role).Any(p => p.Value == UserRole.GlobalAdministrator.ToString() || p.Value == UserRole.SuperAdmin.ToString());
        }

        public static bool HasOrganizationAccess(this ClaimsPrincipal User, string organizationID)
        {
            return User.GetAllOrganizations().Where(orgID => orgID == organizationID).Any();
        }

        public static bool HasProjectAccess(this ClaimsPrincipal User, string projectID)
        {
            return User.GetAllProjects().Where(orgID => orgID == projectID).Any();
        }

        public static bool HasModuleAccess(this ClaimsPrincipal User, string[] roles)
        {
            return User.Claims.Where(p => p.Type == "Role").Any(p => roles.Contains(p.Value));
        }
    }
}
