using System.Windows;
using System.Collections.ObjectModel;
// ...

namespace PieBindingToObservableCollection {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class ViewModel {
        public ObservableCollection<Point> PointsCollection { get; private set; }

        public ViewModel() {
            PointsCollection = new ObservableCollection<Point> { new Point(1, 1), new Point(2, 2), new Point(3, 3) };
        }

        public void AddPoint() {
            PointsCollection.Add(new Point(1, 1));
        }
    }
}
