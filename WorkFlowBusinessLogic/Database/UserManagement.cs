using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WorkFlow.Models;
using WorkFlowBusinessLogic;
using WorkFlowBusinessLogic.Database;

namespace WorkFlow.BusinessLogic
{
    public class UserManagement : DatabaseManagement
    {
        public UserManagement(WorkFlowDbContext db) : base(db) { }

        public List<User> GetAllUsers()
        {
            return this.Db.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return this.Db.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public User GetUserByUsername(string username)
        {
            return this.Db.Users.Where(x => x.Username.Equals(username)).FirstOrDefault();
        }

        public int GetUserIdByUsername(string username)
        {
            return GetUserByUsername(username).Id;
        }

        public void CreateUser(User user)
        {
            this.Db.Users.Add(user);
            Submit();
        }

        public void CreateUser(string login, string password, int companyId)
        {
            var user = new User();
            CreateUser(user);
        }

        public void UpdateUser(User user)
        {
            
        }

        public void UpdateUser(int id, string login, string password, int companyId)
        {
            var user = this.Db.Users.Where(x => x.Id == id).First();

            if (user != null)
            {
                user.Username = login;
                user.PasswordHash = GetHash(password);
                user.CompanyId = companyId;
            }
            else
            {
                CreateUser(login, password, companyId);
            }
        }


        public void Submit()
        {
            this.Db.SaveChanges();
        }

        public ClaimsIdentity GetIdentity(string username, string password)
        {
            User user = this.Db.Users.FirstOrDefault(x => x.Username == username && x.PasswordHash == GetHash(password));
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username)
                };
                var userRolesId = this.Db.UserRoles.Where(x => x.UserId == user.Id).Select(x => x.RoleId);

                foreach (int roleId in userRolesId)
                {
                    var roleName = this.Db.Roles.Where(x => x.Id.Equals(roleId)).FirstOrDefault().Name;
                    claims.Add(new Claim(ClaimTypes.Role, roleName));
                }
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            return null;
        }


        public string GetHash(string password)
        {
            if (password == null)
                return String.Empty;

            ASCIIEncoding oAsciiEncoding = new ASCIIEncoding();
            byte[] tmpSource;
            byte[] tmpHash;
            //Convert to byte array
            tmpSource = oAsciiEncoding.GetBytes(password);

            MD5CryptoServiceProvider oMD5 = new MD5CryptoServiceProvider();
            tmpHash = oMD5.ComputeHash(tmpSource);

            //Convert to hexadecimal			
            StringBuilder sOutput = new StringBuilder(tmpHash.Length);
            for (int i = 0; i < tmpHash.Length; i++)
                sOutput.Append(tmpHash[i].ToString("X2"));

            return sOutput.ToString();
        }
    }
}
