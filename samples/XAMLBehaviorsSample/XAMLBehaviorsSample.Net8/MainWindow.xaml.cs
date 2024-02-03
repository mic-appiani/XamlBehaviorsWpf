using System.Windows;

namespace XAMLBehaviorsSample.Net8;

public partial class MainWindow : Window
{
    private AnimationPage animationPage;
    private ConditionPage conditionPage;
    private DataPage dataPage;

    public MainWindow()
    {
        InitializeComponent();
        this.animationPage = new AnimationPage();
        this.conditionPage = new ConditionPage();
        this.dataPage = new DataPage();
        this.MainContent.Children.Add(this.animationPage);
    }

    private void AnimationButton_Click(object sender, RoutedEventArgs e)
    {
        this.MainContent.Children.Clear();
        this.MainContent.Children.Add(this.animationPage);
    }

    private void ConditionalButton_Click(object sender, RoutedEventArgs e)
    {
        this.MainContent.Children.Clear();
        this.MainContent.Children.Add(this.conditionPage);
    }

    private void DataBehaviorButton_Click(object sender, RoutedEventArgs e)
    {
        this.MainContent.Children.Clear();
        this.MainContent.Children.Add(this.dataPage);
    }
}
