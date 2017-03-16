using System;

namespace ListViewApp.All.Models
{
    [Flags]
    public enum PrescriptionStatus
    {
        Canceled = 1,
        Repeatable = 2,
        Finished = 4
    }
}
