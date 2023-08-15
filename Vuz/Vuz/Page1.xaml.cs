using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Vuz.Constants;


namespace Vuz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            Pin pinTokyo = new Pin
            {
                Type = PinType.Place,
                Label = "Krivoy Rog",
                Address = "Sumida-ku, Tokyo, Japan",
                Position = new Position(47.904553d, 33.401160d),
                Rotation = 33.3f,  // Corrected property name
                Tag = "KNU",
            };
            map.Pins.Add(pinTokyo);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pinTokyo.Position, Distance.FromMeters(5000)));



        }
    }
}