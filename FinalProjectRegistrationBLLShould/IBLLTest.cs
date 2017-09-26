namespace FinalProjectRegistrationBLLShould
{
    public interface IBLLTest
    {
        void GetOne();
        void NotGetOneWithNonExistingId();
        void GetAll();
        void CreateOne();
        void NotCreateOneWithNull();
    }
}