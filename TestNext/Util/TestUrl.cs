using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNext.Util
{
    static class TestUrl
    {
        private static TestContext Context { get; set; }

        public static string StartUrl => Context.Properties["startUrl"].ToString();
        public static string GoogleUrl => Context.Properties["google"].ToString();
        public static string CapSogUrl => Context.Properties["capsog"].ToString();


        public static void Init(TestContext context)
        {
            Context = context;
        }
    }
}
