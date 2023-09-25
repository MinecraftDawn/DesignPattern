namespace DesignPattern.Singleton
{
    class SingletonGreed
    {
        private static SingletonGreed instance = new SingletonGreed();

        private SingletonGreed()
        {
            Console.WriteLine("SingletonGreed");
        }

        public static SingletonGreed getInstance()
        {
            return instance;
        }
    }

    class SingletonLazy
    {
        private static SingletonLazy instance = null;

        private SingletonLazy()
        {
            Console.WriteLine("SingletonLazy");
        }

        public static SingletonLazy getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonLazy();
            }

            return instance;
        }
    }

    class SignletonLazySafe
    {
        private static SignletonLazySafe instance = null;
        private static readonly object instanceLock = new object();

        private SignletonLazySafe()
        {
            Console.WriteLine("SignletonLazySafe");
        }

        public static SignletonLazySafe getInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SignletonLazySafe();
                    }
                }
            }
            return instance;

        }
    }
}
