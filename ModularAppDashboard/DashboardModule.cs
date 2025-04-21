using ModularAppDashboard.Views;

namespace ModularAppDashboard;

public class DashboardModule : IModule
{
    public void OnInitialized(IContainerProvider containerProvider)
    {
        // Optional logic after module loads
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<DashboardView>("DashboardView");
    }
}