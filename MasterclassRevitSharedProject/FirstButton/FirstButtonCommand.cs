using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using MasterclassRevit.Utilities;
using System;
using System.Reflection;
using System.Windows;

namespace MasterclassRevit.FirstButton
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    class FirstButtonCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                MessageBox.Show("Love you Tasha", "ValorVDC", MessageBoxButton.OK);
                return Result.Succeeded;
            }
            catch (System.Exception)
            {

                return Result.Failed;
            }
            return Result.Succeeded;
        }

        public static void CreateButton(RibbonPanel panel)
        {
            var assembly = Assembly.GetExecutingAssembly();
            panel.AddItem(new PushButtonData(
                MethodBase.GetCurrentMethod().DeclaringType?.Name,
                "First " + Environment.NewLine + "Button", assembly.Location,
                MethodBase.GetCurrentMethod().DeclaringType?.FullName)
            {
                ToolTip = "First Button Command!",
                LargeImage = ImageUtils.LoadImage(assembly, "_32x32.stormTrooper-32.png")
            });
        }
    }
}
