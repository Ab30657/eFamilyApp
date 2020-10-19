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
                    new GetFileDetails(){ FileThumb=(BitmapImage)dict["milk"], FileName="Milk", Quantity=2, Unit="litres"}
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
