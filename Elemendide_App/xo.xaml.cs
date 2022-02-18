using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class xo : ContentPage
    {
        Frame fr;
        Label lbl;
        Image img, omg;

        Grid gr;
        public xo()
        {
            img = new Image { Source = ".jpg" };

            gr = new Grid
            {
                RowDefinitions =
                    {
                        new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition {Height=new GridLength(1,GridUnitType.Star)}
                    },
                ColumnDefinitions =
                    {
                        new ColumnDefinition {Width=new GridLength(1,GridUnitType.Star)},
                        new ColumnDefinition {Width=new GridLength(1,GridUnitType.Star)},
                        new ColumnDefinition {Width=new GridLength(1,GridUnitType.Star)}

                    },
            };
            gr.Children.Add(new BoxView { Color = Color.Black  }, 0, 0);
            gr.Children.Add(new BoxView { Color = Color.Black }, 1, 0);
            gr.Children.Add(new BoxView { Color = Color.Black }, 0, 1);
            gr.Children.Add(new BoxView { Color = Color.Black }, 1, 1);
            gr.Children.Add(new BoxView { Color = Color.Black }, 0, 2);
            gr.Children.Add(new BoxView { Color = Color.Black }, 1, 2);
            gr.Children.Add(new BoxView { Color = Color.Black }, 2, 2);
            gr.Children.Add(new BoxView { Color = Color.Black }, 2, 1);
            gr.Children.Add(new BoxView { Color = Color.Black }, 2, 0);

            fr = new Frame
            {
                Content = gr,
                BorderColor = Color.FromRgb(20, 120, 255),
                CornerRadius = 20,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            StackLayout st = new StackLayout
            {
                Children = { lbl, fr }
            };
            Content = st;
        }
    }
}