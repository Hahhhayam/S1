namespace Core
{
    public static class GLOBALS
    {
        public readonly static string DATAPATHA = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"data\");
    }
}
