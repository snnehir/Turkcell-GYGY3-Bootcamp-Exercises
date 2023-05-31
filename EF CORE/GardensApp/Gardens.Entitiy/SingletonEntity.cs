namespace Gardens.Entitiy
{
    public class SingletonEntity: IEntity
    {
        private static SingletonEntity instance = null;
        private SingletonEntity()
        {

        }
        public static SingletonEntity CreateInstance()
        {
            if(instance == null)
            {
                instance = new SingletonEntity();
            }
            return instance;
        }
    }
}
