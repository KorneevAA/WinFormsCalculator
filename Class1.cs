using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsCalculator
{
    public static class ControlExtentions
    {
        public static Control? GetLastControl(this Panel control)
        {
            if (control.Controls.Count == 0)
                return null;
            return control.Controls[control.Controls.Count - 1];
        }
    }

}
