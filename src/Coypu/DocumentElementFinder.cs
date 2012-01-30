namespace Coypu
{
    internal class DocumentElementFinder : ElementFinder
    {
        public DocumentElementFinder(Driver driver) : base(driver, null,null)
        {
        }

        internal override Element Find()
        {
            return Driver.DocumentElement;
        }
    }
}