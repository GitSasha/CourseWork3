
namespace PIZZAZZ.Dishes
{
    public abstract class BaseDish
    {
        protected string Description = "";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();
    }
}
