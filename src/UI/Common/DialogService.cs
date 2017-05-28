namespace UI.Common
{
    public class DialogService
    {
        public bool? ShowDialog(ViewModel viewModel)
        {
            CustomWindow window = new CustomWindow(viewModel)
            {
                ShowInTaskbar = false
            };

            return window.ShowDialog();
        }
    }
}