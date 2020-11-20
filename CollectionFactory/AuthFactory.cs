using CollectionAuth;
using CollectionEntities;

namespace CollectionFactory
{
    public class AuthFactory
    {
        public static IAuth GetAuth()
        {
            return new AuthController();
        }
    }
}
