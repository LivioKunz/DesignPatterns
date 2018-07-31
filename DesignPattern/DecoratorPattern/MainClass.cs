namespace DecoratorPattern
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Merchant merchant = new Merchant();
            merchant.Say();


            CoughDecorator merchantWithCough = new CoughDecorator(merchant);
            merchantWithCough.Say();

            SnifflesDecorator merchantWithSniffles = new SnifflesDecorator(merchant);
            merchantWithSniffles.Say();

            SnifflesDecorator merchantWithEverything = new SnifflesDecorator(merchantWithCough);
            merchantWithEverything.Say();
        }
    }
}