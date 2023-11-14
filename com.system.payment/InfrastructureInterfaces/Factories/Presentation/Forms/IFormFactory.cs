using System.Windows.Forms;
using com.system.payment.PresentationInterfaces;

namespace com.system.payment.InfrastructureInterfaces.Factories.Presentation.Forms
{
    public interface IFormFactory
    {
        IView Create();
    }
}