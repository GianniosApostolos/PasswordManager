using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager.Helper
{
    public static class Constants
    {
        public static int BACKGROUND_PANEL_HEIGHT = 55;
        public static int APP_NAME_WIDTH = 150;
        public static int PASSWORD_WIDTH = 150;

        public static Color FOREGROUND_COLOR_DEFAULT = System.Drawing.Color.FromArgb(255, 255, 255);
        public static Color BACKGROUND_COLOR_DARK_DEFAULT = System.Drawing.Color.FromArgb(30, 30, 30);
        public static Color BACKGROUND_COLOR_LIGHT_DEFAULT = System.Drawing.Color.FromArgb(40, 40, 40);

        public static Color FOREGROUND_COLOR = System.Drawing.Color.FromArgb(255, 255, 255);
        public static Color BACKGROUND_COLOR_DARK = System.Drawing.Color.FromArgb(30, 30, 30);
        public static Color BACKGROUND_COLOR_LIGHT = System.Drawing.Color.FromArgb(255, 255, 255);

        public static bool CONFIRM_MODAL_ON_LOCK;
        public static bool CONFIRM_MODAL_ON_OVERWRITE;
        public static bool SHOW_ONLY_NAMES_ON_SHOW;
        public static bool RANDOM_CHARS_ON_DECRYPT_FAIL;

        public static bool GENERATE_PASSWORD_AND_COPY;
        public static bool AUTO_CLEAR_CLIPBOARD;
        public static int AUTO_CLEAR_CLIPBOARD_SECONDS;

        public static void BindApplicationPropertiesToConstants()
        {
            CONFIRM_MODAL_ON_LOCK = Properties.Settings.Default.ConfirmModalOnLock;
            CONFIRM_MODAL_ON_OVERWRITE = Properties.Settings.Default.ConfirmModalOnOverwrite;
            SHOW_ONLY_NAMES_ON_SHOW = Properties.Settings.Default.ShowOnlyNamesOnShow;
            RANDOM_CHARS_ON_DECRYPT_FAIL = Properties.Settings.Default.ShowRandomCharsOnDecryptFail;
            FOREGROUND_COLOR = Properties.Settings.Default.ForegroundColor;
            BACKGROUND_COLOR_DARK = Properties.Settings.Default.BackgroundColorDark;
            BACKGROUND_COLOR_LIGHT = Properties.Settings.Default.BackgroundColorLight;
            GENERATE_PASSWORD_AND_COPY = Properties.Settings.Default.GenerateAndCopyPassword;
            AUTO_CLEAR_CLIPBOARD = Properties.Settings.Default.AutoClearClipboard;
            AUTO_CLEAR_CLIPBOARD_SECONDS = Properties.Settings.Default.AutoClearClipboardSeconds;
        }

        public static void ApplyColorThemeToFormAndControls(Form selectedForm)
        {
            selectedForm.ForeColor = FOREGROUND_COLOR;
            selectedForm.BackColor = BACKGROUND_COLOR_DARK;

            ApplyColorThemeToControls(selectedForm.Controls);
        }

        private static void ApplyColorThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.ForeColor = FOREGROUND_COLOR;
                control.BackColor = BACKGROUND_COLOR_DARK;

                // Recursively apply colors to child controls
                if (control.Controls.Count > 0)
                {
                    ApplyColorThemeToControls(control.Controls);
                }
            }
        }
    }
}
