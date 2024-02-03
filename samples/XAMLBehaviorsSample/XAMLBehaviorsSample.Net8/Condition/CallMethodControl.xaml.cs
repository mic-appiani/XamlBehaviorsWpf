using System.ComponentModel;
using System.Windows.Controls;

namespace XAMLBehaviorsSample.Net8.Condition;

public partial class CallMethodControl : UserControl, INotifyPropertyChanged
{
    public int Count { get; set; }

    public CallMethodControl()
    {
        InitializeComponent();
        this.DataContext = this;
        this.Count = 0;
    }

    public void IncrementCount()
    {
        this.Count++;
        this.OnPropertyChanged(nameof(this.Count));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
