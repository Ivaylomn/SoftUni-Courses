using System.Security.Claims;

namespace HouseRentingSystem.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
