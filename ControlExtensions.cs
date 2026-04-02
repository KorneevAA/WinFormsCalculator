using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsCalculator
{
    public static class ControlExtensions
    {
        public static Control? GetLastControl(this Control control)
        {
            if (control.Controls.Count == 0)
                return null;
            return control.Controls[control.Controls.Count - 1];
        }
    }
}
