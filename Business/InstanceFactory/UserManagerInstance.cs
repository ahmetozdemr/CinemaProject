
using CinemaProject.Business.Concrete;

namespace Business.InstanceFactory
{
    public sealed class UserManagerInstance
    {
        private UserManagerInstance() { }
        private static UserManager instance = null;
        private static readonly object Instancelock = new object();

        public static UserManager Instance
        {
            get
            {
                lock (Instancelock)
                    if (instance == null)
                    {
                        instance = new UserManager(InMemoryUserDalInstance.Instance);
                    }

                return instance;
            }
        }
    }
}
}
