using Zenject;

namespace ExtenjectUtils.Extensions
{
    public static class ExtenjectExtensions
    {
        public static T InjectBy<T>(this T obj,  DiContainer container)
        {
            container.Inject(obj);
            return obj;
        }
    }
}