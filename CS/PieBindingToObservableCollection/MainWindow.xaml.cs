using System.Windows;
using System.Collections.ObjectModel;
// ...

namespace PieBindingToObservableCollection {
    public partial class MainWindow : Window {
        public static readonly DependencyProperty PointsCollectionProperty = DependencyProperty.Register("PointsCollection",
            typeof(PointsCollection), typeof(MainWindow), new PropertyMetadata());

        public PointsCollection PointsCollection {
            get { return (PointsCollection)GetValue(PointsCollectionProperty); }
            set { SetValue(PointsCollectionProperty, value); }
        }

        public MainWindow() {
            InitializeComponent();
            PointsCollection = new PointsCollection();
            PointsCollection.Add(new Point(1, 1));
            PointsCollection.Add(new Point(2, 2));
            PointsCollection.Add(new Point(3, 3));
        }
        void Button_Click(object sender, RoutedEventArgs e) {
            PointsCollection.Add(new Point(1, 1));
        }
    }

    public class PointsCollection : ObservableCollection<Point> {
    }
}
