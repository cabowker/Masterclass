using System.ComponentModel;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;

namespace MasterclassRevit.SecondButton
{
    public class SpatialElementWrapper : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public ElementId Id { get; set; }
        
        //Use these booleans to delete items from the WPF Form and the InotifyPropertyChanged eventHandler
        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value;  RaisedPropertyChanged(nameof(IsSelected));}
        }

        public SpatialElementWrapper(SpatialElement room)
        {
            Name = room.Name;
            Area = room.Area;
            Id = room.Id;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisedPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}