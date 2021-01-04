using CollectionEntities;
using CollectionFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionLogic.Entities;

namespace CollectionLogic
{
    public class User
    {
        private readonly IUser _UserDal = UserFactory.GetUser();

        public List<UserEntitiy> ReadAll()
        {
            List<UserEntitiy> users = new List<UserEntitiy>();

            foreach (UserDTO user in _UserDal.Read())
            {
                users.Add(new UserEntitiy().UserDTOToUser(user));
            }
            return users;
        }


    }
}
