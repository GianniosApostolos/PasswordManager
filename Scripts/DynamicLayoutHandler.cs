using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Scripts
{
    internal static class DynamicLayoutHandler
    {
        public static void ResizeRows(FlowLayoutPanel flowLayoutPanel)
        {
            foreach (RowGenerator row in flowLayoutPanel.Controls.OfType<RowGenerator>())
            {
                row.Width = flowLayoutPanel.Width - 20;
            }
        }
    }
}
