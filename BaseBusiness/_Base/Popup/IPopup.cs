using System;
using System.Windows.Forms;
using System.ComponentModel;
namespace BMS
{
    /// <summary>
    /// Summary description for IFloatingPopup.
    /// </summary>
    public interface IPopup
    {

        event CancelEventHandler PopupHiding;
        event CancelEventHandler PopupShowing;
        event EventHandler PopupHidden;
        event EventHandler PopupShown;
        void Show();
        void Hide();
        void ForceShow();
        System.Windows.Forms.UserControl UserControl
        {
            get;
            set;
        }
        void SetAutoLocation();
        Form PopupForm
        {
            get;
        }
    }
}
