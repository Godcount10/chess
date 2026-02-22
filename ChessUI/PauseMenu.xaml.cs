using System.Windows.Controls;

namespace ChessUI
{
    /// <summary>
    /// PauseMenu.xaml 的交互逻辑
    /// </summary>
    public partial class PauseMenu : UserControl
    {
        public event Action<Option> OptionSelected;
        public PauseMenu()
        {
            InitializeComponent();
        }

        private void Restart_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Restart);
        }

        private void Continue_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Continue);
        }
    }
}
