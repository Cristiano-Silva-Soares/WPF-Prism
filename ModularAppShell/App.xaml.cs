using System.Windows;
using ModularAppDashboard;
using ModularAppReporting;
using ModularAppShell.Views;

namespace ModularAppShell;

public partial class App : PrismApplication
{
    protected override Window CreateShell()
    {
        return Container.Resolve<MainView>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        // Register shared services here
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<DashboardModule>();
        moduleCatalog.AddModule<ReportingModule>();
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        
        var regionManager = Container.Resolve<IRegionManager>();
        regionManager.RequestNavigate("MainRegion", "DashboardView");
    }
}
