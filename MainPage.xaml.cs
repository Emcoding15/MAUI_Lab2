namespace MAUIApp22;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnExpectationClicked(object sender, EventArgs e)
    {
        ExpectationImgBtn.Source = "app21.png";
        ExpectationLabel.Text = "Reality";
    }

    private void OnExpectationClicked2(object sender, EventArgs e)
    {
        ExpectationImgBtn2.Source = "app21.png";
        ExpectationLabel2.Text = "Reality";
    }
}
