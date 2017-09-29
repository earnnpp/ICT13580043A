using Xamarin.Forms;

namespace ICT13580043A
{
    public partial class ICT13580043APage : ContentPage
    {
        public ICT13580043APage()
        {
            InitializeComponent();

            okButton.Clicked +=OkButton_Clicked;

            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;
        }

        void OkButton_Clicked(object sender, System.EventArgs e)
      
        {
            firstNamelable.Text = firstNameEntry.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valuelable.Text = value.ToString();
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
			int value = (int)e.NewValue;
            valuelable.Text = value.ToString();
        
        
        
        }
    }
}
