using System.Reflection;

namespace Odry.CoindarAPI.Demo
{
    public sealed partial class MainWindow
    {
        private CoindarClient CoindarClient { get; set; }

        public MainWindow()
        {
            // Set icon from the assembly
            Icon = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location).ToImageSource();
            
            InitializeComponent();

            CoindarClient = new CoindarClient();
            LoadEventsListAsync();
        }

        private async void LoadEventsListAsync()
        {
            var events = await CoindarClient.Events.MonthEventsAsync(2017, 11);
            DataGrid1.Items.Clear();

            foreach (var ev in events) {
                DataGrid1.Items.Add(ev);
            }

            DataGrid1.Items.Refresh();
        }
    }
}
