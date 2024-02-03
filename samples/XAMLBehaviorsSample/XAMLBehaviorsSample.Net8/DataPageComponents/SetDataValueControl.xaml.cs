using System.Windows.Controls;

namespace XAMLBehaviorsSample.Net8.DataPageComponents;

public partial class SetDataValueControl : UserControl
{
    public string TextBlockText { get; set; }

    public SetDataValueControl()
    {
        InitializeComponent();
    }
}
