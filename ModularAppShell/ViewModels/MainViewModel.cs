namespace ModularAppShell.ViewModels;

public class MainViewModel: BindableBase
{
    public DelegateCommand? NavigateToModuleDashboardCommand { get; }
    public DelegateCommand? NavigateToModuleReportingCommand { get; }


    public MainViewModel(IRegionManager regionManager)
    {
        var regionManagerReceiver = regionManager;
        
        NavigateToModuleDashboardCommand = new DelegateCommand(() =>
        {
            regionManagerReceiver.RequestNavigate("MainRegion", "DashboardView");
        });

        NavigateToModuleReportingCommand = new DelegateCommand(() =>
        {
            regionManagerReceiver.RequestNavigate("MainRegion", "ReportingView");
        });
    }
}