using CinemaProject.DataAccess.Concrete.InMemory;

namespace Business.InstanceFactory
{
    public class InMemoryUserDalInstance
    {
        private InMemoryUserDalInstance() { }
        private static InMemoryUserDal instance = null;
        public static InMemoryUserDal Instance
        {
            get
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
