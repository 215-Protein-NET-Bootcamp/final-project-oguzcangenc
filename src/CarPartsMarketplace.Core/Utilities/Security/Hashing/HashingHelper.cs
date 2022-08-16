using System.Security.Cryptography;
using System.Text;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using Microsoft.Extensions.Options;

namespace CarPartsMarketplace.Core.Utilities.Security.Hashing
{
    public static class HashingHelper
    {
        private static readonly IOptions<TokenOptions> _tokenOptions;

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (var i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        [Obsolete("Obsolete")]
        public static void MD5Hash(string text, out string mailMd5, IOptions<TokenOptions> _tokenOptions)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var securityKey = _tokenOptions.Value.SecurityKey;
            
            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text + securityKey));

            //get hash result after compute it  
            byte[]? result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            if (result != null)
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits  
                    //for each byte  
                    strBuilder.Append(result[i].ToString("x2"));
                }

            mailMd5 = strBuilder.ToString();
        }
    }
}