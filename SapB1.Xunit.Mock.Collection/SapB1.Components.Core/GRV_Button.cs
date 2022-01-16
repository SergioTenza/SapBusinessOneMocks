namespace SapB1.Components.Core
{
    public class GRV_Button
    {
        public Action<object, SAPbouiCOM.SBOItemEventArg> ClickBefore;
        public Action<object, SAPbouiCOM.SBOItemEventArg> ClickAfter;
        public Action Click;
        public string Caption
        {
            get => this.button.Caption;
            set
            {
                this.button.Caption = value;
            }
        }

        private readonly SAPbouiCOM.Button button;

        public GRV_Button(SAPbouiCOM.Button button)
        {
            this.button = button;
           
            this.button.ClickAfter += Button_ClickAfter;
            this.button.ClickBefore += Button_ClickBefore;
            ClickBefore = GRV_Button_ClickBefore;
            ClickAfter = GRV_Button_ClickAfter;
            Click = GRV_Button_Click;
        }


        private void GRV_Button_Click()
        {           
            //this.button.Item.Click();
            this.Caption = "BotonClick";
        }
        private void GRV_Button_ClickBefore(object? sender, SAPbouiCOM.SBOItemEventArg e)
        {
            throw new NotImplementedException();
        }
        private void GRV_Button_ClickAfter(object? sender, SAPbouiCOM.SBOItemEventArg e)
        {
            throw new NotImplementedException();
        }
        private void Button_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            
            ClickBefore(sboObject, pVal);
        }
        private void Button_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            
            ClickAfter(sboObject, pVal);
        }

        

        
    }
}
