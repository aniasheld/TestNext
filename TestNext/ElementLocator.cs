namespace TestNext
{
    class ElementLocator
    {
        private ElementLocator(LocatorStrategy locator, string identifier)
        {
            Locator = locator;
            Identifier = identifier;
        }
        public LocatorStrategy Locator { get; private set; }
        public string Identifier { get; private set; }

        public static ElementLocator GetLocator (LocatorStrategy locator, string identifier)
        {
            return new ElementLocator(locator, identifier);
        }

        public enum LocatorStrategy { ClassName, CssSelector, Id, LinkText, Name, PartialLinkText, TagName, XPath }
    }
}
