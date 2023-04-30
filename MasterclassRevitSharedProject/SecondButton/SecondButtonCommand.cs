using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using MasterclassRevit.Utilities;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Interop;


namespace MasterclassRevit.SecondButton
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    [Journaling(JournalingMode.NoCommandData)]
    public class SecondButtonCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                var uiApp = commandData.Application;
                var model = new SecondButtonModel(uiApp);
                var viewmodel = new SecondButtonViewModel(model);
                var view = new SecondButtonView();
                view.DataContext = viewmodel;
                
                //To keep the Revit windows from orphan or left behind when Revit is shutdown
                var unused = new WindowInteropHelper(view) 
                    { Owner = Process.GetCurrentProcess().MainWindowHandle };
                //you could do it like on Line 27
                // unused.Owner = Process.GetCurrentProcess().MainWindowHandle;
                
                view.ShowDialog();
                return Result.Succeeded;
            }
            catch (System.Exception)
            {

                return Result.Failed;
            }
        }
        public static void CreateButton(RibbonPanel panel)
        {
            var assembly = Assembly.GetExecutingAssembly();
            panel.AddItem(new PushButtonData(
                MethodBase.GetCurrentMethod().DeclaringType?.Name,
                "Second " + Environment.NewLine + "Button", assembly.Location,
                MethodBase.GetCurrentMethod().DeclaringType?.FullName)
            {
                ToolTip = "Second Button Command!",
                LargeImage = ImageUtils.LoadImage(assembly, "_32x32.stormTrooper-32.png")
            });
        }
    }
}
