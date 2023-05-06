using MasteringCollectionView.MAUI.MVVM.ViewModels;
using System.Diagnostics;

namespace MasteringCollectionView.MAUI.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}

	private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
	{
		Debug.Write("--------------------");
		Debug.WriteLine("HorizontalDelta: " + e.HorizontalDelta);
		Debug.WriteLine("VerticalDelta: " + e.VerticalDelta);
		Debug.WriteLine("HorizontalOffset: " + e.HorizontalOffset);
		Debug.WriteLine("VerticalOffset: " + e.VerticalOffset);
		Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
		Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
		Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
		Debug.Write("--------------------");
	}
}