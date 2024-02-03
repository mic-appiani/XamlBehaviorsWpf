using System.Windows;
using System.Windows.Controls;

namespace XAMLBehaviorsSample.Net8
{
    public partial class DataPage : UserControl
    {
        private DataStateControl _dataStateControl;
        private SetDataValueControl _setDataValueControl;

        public DataPage()
        {
            this.InitializeComponent();
            this._dataStateControl = new DataStateControl();
            this._setDataValueControl = new SetDataValueControl();
        }

        private void DataStateBehavior_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this._dataStateControl);
        }

        private void SetDataStoreValueAction_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this._setDataValueControl);
        }
    }
}
