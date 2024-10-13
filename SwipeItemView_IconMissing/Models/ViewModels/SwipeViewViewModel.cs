using CommunityToolkit.Mvvm.ComponentModel;

namespace SwipeItemView_IconMissing.Models.ViewModels;

public partial class SwipeViewViewModel : ObservableObject
{
    [ObservableProperty]
    private SwipeItems _swipeRightItems = [];

    [ObservableProperty]
    private string _swipeViewText = string.Empty;
}