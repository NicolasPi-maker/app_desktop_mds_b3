namespace MAUI_Score
{
    public partial class Player : ContentPage
    {
        int count = 0;

        public Player(int v)
        {
            InitializeComponent();
        }

        public Player(int v, string v1, string v2, object value, float v3, int v4) : this(v)
        {
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
