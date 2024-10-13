using CommunityToolkit.Mvvm.ComponentModel;
using SwipeItemView_IconMissing.Models.ViewModels;
using SwipeItemView_IconMissing.Resources.Fonts;
using System.Collections.ObjectModel;

namespace SwipeItemView_IconMissing;

public partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
    {
        // Populate the SwipeViewViewModel collection with values
        for (int i = 0; i < 10; i++)
        {
            SwipeViewViewModel swipeView = new()
            {
                SwipeRightItems =
                [
                    new SwipeItemView
                    {
                        Padding = new Thickness(24, 0),
                        Content = new Image
                        {
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.Center,
                            Source = new FontImageSource
                            {
                                FontFamily = nameof(MaterialDesignIcons),
                                Color = Colors.White,
                                Glyph = MaterialDesignIcons.TrashCanOutline,
                                Size = 24
                            }
                        },
                        BackgroundColor = Colors.Red,
                    }
                ],
                SwipeViewText = $"Swipe me left or right {i}"
            };
            SwipeViewViewModel.Add(swipeView);
        }
    }

    [ObservableProperty]
    private ObservableCollection<SwipeViewViewModel> _swipeViewViewModel = [];
}