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
            var rows = flowLayoutPanel.Controls.OfType<RowGenerator>().ToList();
            foreach (RowGenerator row in rows)
            {
                row.Width = flowLayoutPanel.Width - 20;
            }
        }

        public static void UpdateRows(FlowLayoutPanel flowLayoutPanel, bool showActionButtons)
        {
            var rows = flowLayoutPanel.Controls.OfType<RowGenerator>().ToList();
            foreach (RowGenerator row in rows)
            {
                row.Width = flowLayoutPanel.Width - 20;
                if (showActionButtons)
                {
                    row.ShowActionButtons();
                }
                else
                {
                    row.HideActionButtons();
                }
            }
        }
    }
}
