using Autodesk.Revit.UI;
using MasterclassRevit.FirstButton;
using MasterclassRevit.SecondButton;
using System;
using System.Linq;

namespace MasterclassRevit
{
    public class AppCommand : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            try
            {
                app.CreateRibbonTab("Masterclass");
            }
            catch (Exception)
            {

                //ignored
            }
            var ribbonPanel = app.GetRibbonPanels("Masterclass").FirstOrDefault(x => x.Name == "Masterclass") ?? 
                app.CreateRibbonPanel("Masterclass", "AEC Tech");

            //create buttons
            FirstButtonCommand.CreateButton(ribbonPanel);
            SecondButtonCommand.CreateButton(ribbonPanel);

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication app)
        {
            return Result.Succeeded;
        }

    }
}
