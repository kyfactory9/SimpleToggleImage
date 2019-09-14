using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ImageToggleControl.xaml
    /// </summary>
    public partial class ImageToggleControl : UserControl
    {
        public static DependencyProperty ImageToggleProperty = DependencyProperty.Register("ImageToggle", typeof(bool), typeof(ImageToggleControl), new PropertyMetadata(false));

        public bool ImageToggle
        {
            get { return (bool)GetValue(ImageToggleProperty); }
            set { SetValue(ImageToggleProperty, value); }
        }

        public ImageToggleControl()
        {
            InitializeComponent();

            this.DataContext = this;
        }
    }
}
