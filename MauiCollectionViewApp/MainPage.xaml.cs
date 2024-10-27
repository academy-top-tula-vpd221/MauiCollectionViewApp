using System.Windows.Input;

namespace MauiCollectionViewApp
{
    public partial class MainPage : ContentPage
    {

        List<Flight> flights;
        public ICommand SelectCommand { set; get; }
        public MainPage()
        {
            InitializeComponent();

            flights = new()
            {
                new(){ Name = "ASD-123", ToCity = "Moscow", Date = new DateOnly(2024, 11, 5), Time = new TimeOnly(12, 45)},
                new(){ Name = "NMS-234", ToCity = "Kazan", Date = new DateOnly(2024, 12, 20), Time = new TimeOnly(21, 10)},
                new(){ Name = "GGH-008", ToCity = "Inrkutsk", Date = new DateOnly(2024, 11, 19), Time = new TimeOnly(16, 30)},
                new(){ Name = "SER-897", ToCity = "Novosobirsk", Date = new DateOnly(2025, 1, 9), Time = new TimeOnly(19, 20)},
            };

            colView.ItemsSource = flights;

            SelectCommand = new Command<List<object>>(fs =>
            {
                string result = "Selected: ";
                foreach (var o in fs)
                    if(o is Flight f)
                        result += " " + f.Name;
                listLabel.Text = result;
            });

            BindingContext = this;
        }

        private void colView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(sender is CollectionView cw)
            {
                string result = "Selected: ";
                foreach (var o in cw.SelectedItems)
                    if (o is Flight f)
                        result += " " + f.Name;
                listLabel.Text = result;
            }
        }
    }

}
