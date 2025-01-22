namespace appNetMaui   
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private bool _isHovering = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count += 5 ;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


        private void OnImageTapped(object sender, EventArgs e)
        {
            if (_isHovering)
            {
                MyImage.Source = "jeff_marvel.png"; // Imagen original
            }
            else
            {
                MyImage.Source = "jeff_dolphin.png"; // Imagen de cambio
            }

            _isHovering = !_isHovering; // Cambia el estado
        }
    }

}
