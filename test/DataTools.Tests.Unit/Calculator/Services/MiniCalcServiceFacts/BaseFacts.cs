using CarpeDiem.DataTools.Calculator.Services;

namespace CarpeDiem.DataTools.Calculator.Services;

public partial class MiniCalcServiceFacts
{
    public abstract class BaseFacts
    {
        protected readonly IMiniCalcService service;

        protected BaseFacts()
        {
            service = new MiniCalcService();
        }
    }
}