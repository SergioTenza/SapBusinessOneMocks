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
        [Fact]
        public async Task ShouldFillFormWithRandomData()
        {

            /*
            * What:
            * Where:
            * When:
            */

            //Given
            var formFiller = new Filler<SAPbouiCOM.Form>();
            var formMock = new Mock<SAPbouiCOM.Form>();
            var formClone = formMock.DeepClone();

            //When
            formFiller.Fill((SAPbouiCOM.Form)formMock.Object);
            
            //Then
            Assert.Equal<Mock<SAPbouiCOM.Form>>(formMock, formClone);


        }
    }

}