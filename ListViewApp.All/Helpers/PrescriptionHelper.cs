using ListViewApp.All.Models;
using System;
using Xamarin.Forms;

namespace ListViewApp.All.Helpers
{
    public static class PrescriptionHelper
    {
        public static string GetPrescriptionStatusIcon(PrescriptionStatus status)
        {
            switch (status)
            {
                case PrescriptionStatus.Finished:
                    return "apply_32.png";
                case PrescriptionStatus.Canceled:
                    return "cancel_32.png";
                case PrescriptionStatus.Repeatable:
                    return "repeat_32.png";
                default:
                    throw new ArgumentException("Unsuported value");
            }
        }

        public static string GetPrescriptionStatusText(PrescriptionStatus status)
        {
            switch (status)
            {
                case PrescriptionStatus.Finished:
                    return "Vydaný";
                case PrescriptionStatus.Canceled:
                    return "Zrušený";
                case PrescriptionStatus.Repeatable:
                    return "Opakovací";
                default:
                    throw new ArgumentException("Unsuported value");
            }
        }

        internal static Color GetPrescriptionStatusBarColor(PrescriptionStatus status)
        {
            if(status.HasFlag(PrescriptionStatus.Finished))
            {
                return Color.FromHex("#CCF2FFF2");
            }
            else if(status.HasFlag(PrescriptionStatus.Canceled))
            {
                return Color.FromHex("#CCFF7F50");
            }
            else
            {
                return Color.FromHex("#CCFFDEAD");
            }
        }
    }
}
