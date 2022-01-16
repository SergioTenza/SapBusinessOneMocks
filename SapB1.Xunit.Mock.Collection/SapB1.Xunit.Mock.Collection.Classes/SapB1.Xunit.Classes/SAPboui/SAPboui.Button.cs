using Moq;
using SapB1.Components.Core;
using Xunit;

namespace SapB1.Xunit.Classes.SAPboui
{
    public partial class SAPboui
    {
        [Fact]
        public void ShouldGetButtonCaptionFromBaseComponentEqualsDependencyButtonCaption()
        {
            //Given
            var sapButton = new Mock<SAPbouiCOM.Button>();
            sapButton.Setup(x => x.Caption).Returns("TEST");

            var baseButton = new GRV_Button(sapButton.Object);
            //When
            var componentCaption = baseButton.Caption;

            //Then
            Assert.True(componentCaption == "TEST");
        }

        [Fact]
        public void ShouldUpdateCaptionOnClickEventOfBaseComponent()
        {
            //Given
            var sapButton = new Mock<SAPbouiCOM.Button>();
            sapButton.SetupAllProperties();
            sapButton.Setup(x => x.Caption).Returns("TEST");

            var baseButton = new GRV_Button(sapButton.Object);
            //When
            baseButton.Click();
            var componentCaption = baseButton.Caption;

            //Then
            Assert.True(componentCaption == "BotonClick");
        }

       
    }
}