namespace MauiAppActionSheetIssue
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            await Shell.Current.DisplayActionSheet("Title of action sheet", "Cancel is not short", "Delete is also very long...", ["A very long item to select from the action sheet"]);
            
        }
    }

}
