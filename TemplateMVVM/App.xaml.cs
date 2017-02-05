using System.Windows;
using TemplateMVVM.ViewModels;
using UseAbilities.MVVM.Managers;

namespace TemplateMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            AdvancedViewManager.Instance.RegisterRelation<MainViewModel, Views.MainView>();
            AdvancedViewManager.Instance.ResolveAndShow<MainViewModel>();
        }
    }
}
