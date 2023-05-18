
using CinemaProject.Business.Concrete;

namespace Business.InstanceFactory
{
    public sealed class UserManagerInstance
    {
        private UserManagerInstance() {}
        private static UserManager instance=null;

        public static UserManager Instance
        {
            get
            {
                if (instance==null)
                {
                    instance=new UserManager(InMemoryUserDalInstance.Instance);
                }
                return instance;
            }
        }
    }
}
