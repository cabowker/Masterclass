using System;
using Autodesk.Revit.UI;

namespace MasterclassRevit.FourthButton
{
    public static class DockablePanelUtils
    {
        public static void RegisterDockablePanel(UIControlledApplication app)
        {
            var viewModel = new DockablePanelViewModel();
            var view = new DockablePanelPage
            {
                DataContext = viewModel
            };

            var data = new DockablePaneProviderData()
            {
                FrameworkElement = view,
                InitialState = new DockablePaneState()
                {
                    DockPosition = DockPosition.Tabbed,
                    TabBehind = DockablePanes.BuiltInDockablePanes.ProjectBrowser
                },
                VisibleByDefault = true
            };

            var panelId = new DockablePaneId(new Guid("7FFE1C83-3779-4451-A396-F177936E3BBD"));
            try
            {
                app.RegisterDockablePane(panelId, "Masterclass", view);
            }
            catch (Exception e)
            {
                //I saw a unicorn and broke this window because someone had the Guid as mine
            }
        }

        public static void ShowDockablePanel(UIApplication app)
        {
            var panelId = new DockablePaneId(new Guid("7FFE1C83-3779-4451-A396-F177936E3BBD"));
            var dockablePanel = app.GetDockablePane(panelId);
            dockablePanel?.Show(); //this is just encase dockablePanel is null it will still show the panel
        }
    }
}