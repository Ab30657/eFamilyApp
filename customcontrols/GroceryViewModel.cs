using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Family.customcontrols
{
    class GroceryViewModel
    {
        ResourceDictionary dict = Application.LoadComponent(new Uri("Family;component/resources/images.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;

        public ObservableCollection<GetFileDetails> getFileDetails
        {
            get
            {

                return new ObservableCollection<GetFileDetails>
                {
                    new GetFileDetails(){ FileThumb=(BitmapImage)dict["milk"], FileName="Milk", Quantity=2, Unit="litres"},
                    new GetFileDetails(){FileThumb=(BitmapImage)dict["eggs"], FileName="Eggs", Quantity=10, Unit="eggs"},
                    new GetFileDetails(){FileThumb=(BitmapImage)dict["notebook"], FileName="Notebook", Quantity=4, Unit="copies"},
                    new GetFileDetails(){FileThumb=(BitmapImage)dict["ketchup"], FileName="Ketchup", Quantity=2, Unit="bottles"},
                    new GetFileDetails(){FileThumb=(BitmapImage)dict["cabbage"], FileName="Cabbage", Quantity=3, Unit="kgs"},
                    new GetFileDetails(){FileThumb=(BitmapImage)dict["chips"], FileName="Potato Chips", Quantity=4, Unit="packets"}
                };
            }
        }
    }

    class GetFileDetails
    {
        public BitmapImage FileThumb { get; set; }

        public string FileName { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }

    }
}
