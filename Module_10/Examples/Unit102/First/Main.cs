using Module_10.Examples.Unit102.First.Interface;

namespace Module_10.Examples.Unit102.First
{
    internal class Main
    {
        internal static void Run()
        {
            MessageManager messageManager = new();
            ((IWhatsApp)messageManager).SendMessage("Привет");
            ((IViber)messageManager).SendMessage("Картошка");
            ((ITelegram)messageManager).SendMessage("Французкие лапки");
        }
    }
}
