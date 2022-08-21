using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Tests.Helper.Token
{
    public static class TestUser
    {
        public static User GetTestUser()
        {
            User user = new()
            {
                Id = 1,
                FirstName = "Oğuzcan",
                LastName = "Genç",
                Email = "oguzcangencc@hotmail.com"
            };
            List<UserOperationClaim> userOperationClaims = new()
            {
                new UserOperationClaim()
                {
                    UserId = 1,
                    OperationClaim = new OperationClaim
                    {
                        Id = 1,
                        Name = "admin"
                    },
                    OperationClaimId = 1
                },
            };
            user.UserOperationClaims = userOperationClaims;

            return user;
        }
    }
}
