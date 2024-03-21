namespace ShoppingAppSQL.Models;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void ProfileBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignInPage());
    }
}