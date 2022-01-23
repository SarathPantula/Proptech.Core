namespace Proptech.Core.Helpers
{
    public static class EnumHelper 
    {
        public static IList<int> GetEnumValues<T>() where T : struct, IConvertible
        {
            return Enum.GetValues(typeof(T)).Cast<int>().ToList();
        }
    }
}
