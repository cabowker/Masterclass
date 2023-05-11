using System;
using System.Reflection;
using Autodesk.Internal.Windows;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using MasterclassRevit.Utilities;

namespace MasterclassRevit.FourthButton
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    [Journaling(JournalingMode.NoCommandData)]
    public class FourthButtonCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                var app = commandData.Application;
                DockablePanelUtils.ShowDockablePanel(app);
                return Result.Succeeded;
            }
            catch (Exception)
            {
                return Result.Failed;
            }
        }

        public static void CreateButton(RibbonPanel panel)
        {
            var assembly = Assembly.GetExecutingAssembly();
            panel.AddItem(
                new PushButtonData(
                    MethodBase.GetCurrentMethod()?.DeclaringType?.Name,
                    "Fourth" + Environment.NewLine + "Button",
                    assembly.Location,
                    MethodBase.GetCurrentMethod()?.DeclaringType?.FullName)
            {
                ToolTip = "Fourth Button ToolTip.",
                LargeImage = ImageUtils.LoadImage(assembly, "_32x32.fourthButton.png")
            });
        }
    }
}