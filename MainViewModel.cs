using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AttachedProperties;

internal class MainViewModel : INotifyPropertyChanged
{
    #region Button "bindingAPButton" 
    private string? _bindingString = "Bound Value";

    public string? BindingString
    {
        get { return _bindingString; }
        set 
        { 
            _bindingString = value; 
            OnPropertyChanged(); 
        }
    }
    #endregion

    #region Button "APChangedButton"
    private string? _boundStringChangedByEvent = "This string is not yet bound";

    public string? BoundStringChangedByEvent
    {
        get { return _boundStringChangedByEvent; }
        set { _boundStringChangedByEvent = value; OnPropertyChanged(); }
    }
    #endregion


    #region Stuff for INotifyPropertyChanged
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
}
