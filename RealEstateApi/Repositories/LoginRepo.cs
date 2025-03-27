using Dapper;
using Microsoft.AspNetCore.Identity;
using RealEstateApi.Models;
using RealEstateApi.Models.DapperContext;
using RealEstateApi.Tools;
using System.Reflection;

namespace RealEstateApi.Repositories
{
    public class LoginRepo : ILoginRepo
    {
        private readonly Context _context;
        public LoginRepo(Context context)
        {
            _context = context;
        }
        public string GirisYapmaMetodu(GirisssYap p)
        {
            string query = "SELECT * FROM AppUser WHERE UserName = @UserName and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@UserName", p.Username);
            parameters.Add("@password", p.Password);
            using (var connection = _context.CreateConnection())
            {
                connection.ExecuteAsync(query, parameters);
            }
            if (query != null)
            {
                return("aaa");
            }
            else
            {
                return "bbb";
            }
        }
    }
}