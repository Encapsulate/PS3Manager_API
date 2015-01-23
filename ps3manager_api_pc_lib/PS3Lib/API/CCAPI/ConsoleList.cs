using PS3Lib.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PS3Lib
{
    public class ConsoleList
    {
        public enum Lang
        {
            Null,
            French,
            English
        }

        public class SetLang
        {
            public static Lang defaultLang = Lang.Null;
        }

        private PS3API Api;
        private List<CCAPI.ConsoleInfo> data;

        public ConsoleList(PS3API f)
        {
            Api = f;
            data = Api.CCAPI.GetConsoleList();
        }

        /// <summary>Return the systeme language, if it's others all text will be in english.</summary>
        private Lang getSysLanguage()
        {
            if (SetLang.defaultLang == Lang.Null)
            {
                if (CultureInfo.CurrentCulture.ThreeLetterWindowsLanguageName.StartsWith("FRA"))
                    return Lang.French;
                else return Lang.English;
            }
            else return SetLang.defaultLang;
        }

        private string strTraduction(string keyword)
        {
            if (getSysLanguage() == Lang.French)
            {
                switch (keyword)
                {
                    case "btnConnect": return "Connexion";
                    case "btnRefresh": return "Rafraîchir";
                    case "errorSelect": return "Vous devez d'abord sélectionner une console.";
                    case "errorSelectTitle": return "Sélectionnez une console.";
                    case "selectGrid": return "Sélectionnez une console dans la grille.";
                    case "selectedLbl": return "Sélection :";
                    case "formTitle": return "Choisissez une console...";
                    case "noConsole": return "Aucune console disponible, démarrez CCAPI Manager (v2.5) et ajoutez une nouvelle console.";
                    case "noConsoleTitle": return "Aucune console disponible.";
                }
            }
            else
            {
                switch (keyword)
                {
                    case "btnConnect": return "Connection";
                    case "btnRefresh": return "Refresh";
                    case "errorSelect": return "You need to select a console first.";
                    case "errorSelectTitle": return "Select a console.";
                    case "selectGrid": return "Select a console within this grid.";
                    case "selectedLbl": return "Selected :";
                    case "formTitle": return "Select a console...";
                    case "noConsole": return "None consoles available, run CCAPI Manager (v2.5) and add a new console.";
                    case "noConsoleTitle": return "None console available.";
                }
            }
            return "?";
        }

        public bool Show()
        {
            bool Result = false;
            int tNum = -1;

            // Instance of widgets
            Label lblInfo = new Label();
            Button btnConnect = new Button();
            Button btnRefresh = new Button();
            ListViewGroup listViewGroup = new ListViewGroup("Consoles", HorizontalAlignment.Left);
            ListView listView = new ListView();
            Form formList = new Form();

            // Create our button connect
            btnConnect.Location = new Point(12, 254);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(198, 23);
            btnConnect.TabIndex = 1;
            btnConnect.Text = strTraduction("btnConnect");
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Enabled = false;
            btnConnect.Click += (sender, e) =>
            {
                if (tNum > -1)
                {
                    if (Api.ConnectTarget(data[tNum].Ip))
                    {
                        Api.setTargetName(data[tNum].Name);
                        Result = true;
                    }
                    else Result = false;
                    formList.Close();
                }
                else
                    MessageBox.Show(strTraduction("errorSelect"), strTraduction("errorSelectTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Create our button refresh
            btnRefresh.Location = new Point(216, 254);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 23);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = strTraduction("btnRefresh");
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += (sender, e) =>
            {
                tNum = -1;
                listView.Clear();
                lblInfo.Text = strTraduction("selectGrid");
                btnConnect.Enabled = false;
                data = Api.CCAPI.GetConsoleList();
                int sizeD = data.Count();
                for (int i = 0; i < sizeD; i++)
                {
                    ListViewItem item = new ListViewItem(" " + data[i].Name + " - " + data[i].Ip);
                    item.ImageIndex = 0;
                    listView.Items.Add(item);
                }
            };

            // Create our list view
            listView.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup.Header = "Consoles";
            listViewGroup.Name = "consoleGroup";
            listView.Groups.AddRange(new ListViewGroup[] { listViewGroup });
            listView.HideSelection = false;
            listView.Location = new Point(12, 12);
            listView.MultiSelect = false;
            listView.Name = "ConsoleList";
            listView.ShowGroups = false;
            listView.Size = new Size(290, 215);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.List;
            listView.ItemSelectionChanged += (sender, e) =>
            {
                tNum = e.ItemIndex;
                btnConnect.Enabled = true;
                string Name, Ip = "?";
                if (data[tNum].Name.Length > 18)
                    Name = data[tNum].Name.Substring(0, 17) + "...";
                else Name = data[tNum].Name;
                if (data[tNum].Ip.Length > 16)
                    Ip = data[tNum].Name.Substring(0, 16) + "...";
                else Ip = data[tNum].Ip;
                lblInfo.Text = strTraduction("selectedLbl") + " " + Name + " / " + Ip;
            };

            // Create our label
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 234);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(158, 13);
            lblInfo.TabIndex = 3;
            lblInfo.Text = strTraduction("selectGrid");

            // Create our form
            formList.MinimizeBox = false;
            formList.MaximizeBox = false;
            formList.ClientSize = new Size(314, 285);
            formList.AutoScaleDimensions = new SizeF(6F, 13F);
            formList.AutoScaleMode = AutoScaleMode.Font;
            formList.FormBorderStyle = FormBorderStyle.FixedSingle;
            formList.StartPosition = FormStartPosition.CenterScreen;
            formList.Text = strTraduction("formTitle");
            formList.Controls.Add(listView);
            formList.Controls.Add(lblInfo);
            formList.Controls.Add(btnConnect);
            formList.Controls.Add(btnRefresh);

            // Start to update our list
            ImageList imgL = new ImageList();
            imgL.Images.Add(Resources.ps3);
            listView.SmallImageList = imgL;
            int sizeData = data.Count();

            for (int i = 0; i < sizeData; i++)
            {
                ListViewItem item = new ListViewItem(" " + data[i].Name + " - " + data[i].Ip);
                item.ImageIndex = 0;
                listView.Items.Add(item);
            }

            // If there are more than 0 targets we show the form
            // Else we inform the user to create a console.
            if (sizeData > 0)
                formList.ShowDialog();
            else
            {
                Result = false;
                formList.Close();
                MessageBox.Show(strTraduction("noConsole"), strTraduction("noConsoleTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Result;
        }
    }
   
}
