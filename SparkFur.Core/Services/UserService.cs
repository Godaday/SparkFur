using SparkFur.Core.Interfaces;
using SparkFur.Infrastructure.Interfaces;
using SparkFur.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Core.Services
{
    public class UserService:BaseService<User>,IUserService
    {

        public UserService(IUserRepository  userRepository, IUnitOfWork unitOfWork) : base(userRepository, unitOfWork)
        {
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
           var result=  await  base._repository.GetAsync(x => x.Username == username);
            return result.FirstOrDefault();
        }
    }
}
