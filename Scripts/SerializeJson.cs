using PasswordManager.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace PasswordManager.Scripts
{
    internal class RowObject
    {
        public byte[] AppNameText { get; set; }
        public byte[] PasswordText { get; set; }

        public RowObject() { }

        public RowObject(byte[] appNameText, byte[] passwordText)
        {
            AppNameText = appNameText;
            PasswordText = passwordText;
        }
    }

    internal static class SerializeJson
    {
        public static List<RowObject> CreateRowObjectsFromFlowLayoutPanel(FlowLayoutPanel targetPanel)
        {
            List<RowObject> rowObjects = new List<RowObject>();

            foreach (RowGenerator rowGenerator in targetPanel.Controls.OfType<RowGenerator>())
            {
                RowObject rowObject = new RowObject
                {
                    AppNameText = rowGenerator.AppNameText,
                    PasswordText = rowGenerator.PasswordText
                };

                rowObjects.Add(rowObject);
            }

            return rowObjects;
        }

        public static void SerializeRowObjectsToJson(FlowLayoutPanel targetPanel, bool overwritePreviousSave)
        {
            string jsonFileSavePath = Settings.Default["JsonFileSavePath"].ToString();

            if (!overwritePreviousSave)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    Filter = "Text files (*.txt)|*.txt",
                    Title = "Save a Text File",
                    RestoreDirectory = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    jsonFileSavePath = saveFileDialog.FileName;
                    try
                    {
                        Settings.Default["JsonFileSavePath"] = Path.GetFullPath(jsonFileSavePath);
                        Settings.Default.Save();
                    }
                    catch (ArgumentException e)
                    {
                        MessageBox.Show(e.Message);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            List<RowObject> rowObjects = CreateRowObjectsFromFlowLayoutPanel(targetPanel);
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(rowObjects, options);

            try
            {
                File.WriteAllText(jsonFileSavePath, jsonString);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static List<RowObject> DeserializeJsonToRowObjects()
        {
            string jsonFileSavePath = Settings.Default["JsonFileSavePath"].ToString();

            if (String.IsNullOrWhiteSpace(jsonFileSavePath))
            {
                return null;
            }

            string jsonString = File.ReadAllText(jsonFileSavePath);

            return JsonSerializer.Deserialize<List<RowObject>>(jsonString);
        }

        public static void CreateRowObjectsFromJson(FlowLayoutPanel targetPanel)
        {
            List<RowObject> rowObjects = DeserializeJsonToRowObjects();

            if (rowObjects == null)
            {
                return;
            }

            foreach (RowObject rowObject in rowObjects)
            {
                RowGenerator rowGenerator = new RowGenerator(targetPanel, rowObject.AppNameText, rowObject.PasswordText);
                rowGenerator.GenerateRow();
            }
        }
    }
}
