using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Helper
{
    // Singleton class to clear the clipboard periodically.
    // This is to prevent multiple cleaners from running at the same time.
    internal class ClipboardCleaner
    {
        private static ClipboardCleaner instance = null;
        private readonly Timer clipboardTimer;
        private bool isCleaning;

        private ClipboardCleaner()
        {
            clipboardTimer = new Timer();

            // Converts saved value from seconds to milliseconds. Minimum 1 second.
            clipboardTimer.Interval = Math.Max(Constants.AUTO_CLEAR_CLIPBOARD_SECONDS * 1000, 1000);

            clipboardTimer.Tick += ClearKeyboardPeriodically;
            isCleaning = false;
        }

        public static ClipboardCleaner Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClipboardCleaner();
                }
                return instance;
            }
        }

        public void StartClearing()
        {
            if (!isCleaning)
            {
                clipboardTimer.Start();
                isCleaning = true;
            }
        }

        public void StopClearing()
        {
            if (isCleaning)
            {
                clipboardTimer.Stop();
                isCleaning = false;
            }
        }

        public void ClearKeyboardPeriodically(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
