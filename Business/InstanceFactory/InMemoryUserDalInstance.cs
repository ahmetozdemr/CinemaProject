using CinemaProject.DataAccess.Concrete.InMemory;

namespace Business.InstanceFactory
{
    public class InMemoryUserDalInstance
    {
        private InMemoryUserDalInstance() { }
        private static InMemoryUserDal instance = null;
        private static readonly object Instancelock = new object();
        public static InMemoryUserDal Instance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new InMemoryUserDal();
                    }

                    return instance;
                }
            }
        }
    }
}
