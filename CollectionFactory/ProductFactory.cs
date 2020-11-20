using CollectionAssortiment;
using CollectionEntities;

namespace CollectionFactory
{
    public class ProductFactory
    {
        public static IProduct GetAssortiment()
        {
            return new ProductController();
        }
    }
}
