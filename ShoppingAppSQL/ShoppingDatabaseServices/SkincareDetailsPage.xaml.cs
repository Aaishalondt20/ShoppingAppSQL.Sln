using ShoppingAppSQL.DataBaseItems;
using ShoppingAppSQL.ShoppingDatabaseServices;

namespace ShoppingAppSQL.Models;

public partial class SkincareDetailsPage : ContentPage
{
    private ShoppingDatabase _database;

    public SkincareDetailsPage()
    {
    }

    //private readonly CartViewModel _viewmodel;
    public SkincareDetailsPage(SkincareItemViewModel item)
    {
        InitializeComponent();
        this.BindingContext = item;
        _database = new ShoppingDatabase();
        //_viewmodel = (CartViewModel)BindingContext;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    /*  private void AddToCartBtn_Clicked(object sender, EventArgs e)
      {

          if (sender is Button button && button.BindingContext is CartItem item)
          {
              _viewmodel.AddItem(item);
          }
      }*/

}