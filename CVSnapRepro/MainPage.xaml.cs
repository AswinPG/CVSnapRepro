namespace CVSnapRepro
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            List<int> list = new List<int>();   
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            MainCV.ItemsSource = list;
        }
    }

}
