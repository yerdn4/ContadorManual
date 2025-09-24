namespace ContadorManual.Gui
{
    public partial class MainPage : ContentPage
    {
        //_conteo lleva el coteo de la aplicacion
        private int _conteo;
        public MainPage()
        {
            InitializeComponent();
            _conteo = 4;
            ConteoLabel.Text= _conteo.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _conteo = 0;
            ConteoLabel.Text = _conteo.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            _conteo++;
            ConteoLabel.Text = _conteo.ToString();
        }
    }
}
