using ModularAppReporting.Views;

namespace ModularAppReporting;

public class ReportingModule: IModule
{
    public void OnInitialized(IContainerProvider containerProvider)
    {
        // Optional logic after module loads
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<ReportingView>("ReportingView");
    }
}