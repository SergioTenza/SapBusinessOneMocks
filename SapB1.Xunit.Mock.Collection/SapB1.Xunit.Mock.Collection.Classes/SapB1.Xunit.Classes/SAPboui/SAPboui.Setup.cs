using Force.DeepCloner;
using Moq;
using System.Threading.Tasks;
using Tynamix.ObjectFiller;
using Xunit;

namespace SapB1.Xunit.Classes.SAPboui
{
    public partial class SAPboui
    {
        private readonly Mock applicationMock;
        private readonly Mock companyMock;
        private readonly Mock formMock;
        public SAPboui()
        {
            applicationMock = new Mock<SAPbouiCOM.Application>();
            companyMock = new Mock<SAPbobsCOM.Company>();
            formMock = new Mock<SAPbouiCOM.Form>();
            
        }
    }

}