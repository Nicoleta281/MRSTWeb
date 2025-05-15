using System.Configuration; // pentru ConfigurationManager
using System.Linq;
using eUseControl.BusinesLogic.DBModel.Seed;
using eUseControl.BusinesLogic.Interfaces;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic
{
     public class SessionBL : ISession
     {
          public UserLoginResponse UserLogin(ULoginData data)
          {
               UDTable user;

               using (var db = new UserContext())
               {
                    user = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == data.Password);
               }

               if (user != null)
               {
                    return new UserLoginResponse
                    {
                         Status = true,
                         StatusMsg = "Autentificare reușită!",
                         User = user
                    };
               }

               return new UserLoginResponse
               {
                    Status = false,
                    StatusMsg = "Credentiale invalide!"
               };
          }
     }
}
