using CRUDApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CRUDApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}