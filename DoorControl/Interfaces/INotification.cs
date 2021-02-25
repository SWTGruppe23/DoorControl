using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControl.Interfaces
{
    interface INotification
    {
        void NotifyEntryGranted(int id);
        void NotifyEntryDenied(int id);
    }
}
