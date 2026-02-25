using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouhouGameLauncher
{
    public partial class SearchDireForm : Form
    {
        private static List<string> RawSearchDire = new List<string>();
        public SearchDireForm()
        {
            InitializeComponent();
        }

        private void SearchDireForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchDireForm_Shown(object sender, EventArgs e)
        {
            if (SettingControll.SetupCanClose)
            {
                foreach (var Items in SettingControll.Json["SearchDire"])
                {
                    DireListBox.Items.Add(Items);
                    RawSearchDire.Add(Items);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Add Path...";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string AddPath = dialog.SelectedPath;
                DireListBox.Items.Add(AddPath);
                RawSearchDire.Add(AddPath);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DireListBox.SelectedIndex == -1) return;
            RawSearchDire.RemoveAt(DireListBox.SelectedIndex);
            DireListBox.Items.RemoveAt(DireListBox.SelectedIndex);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(string.Join(" , ", RawSearchDire));
            Debug.WriteLine(RawSearchDire.Count);
            if (RawSearchDire.Count != 0)
            {
                SettingControll.Json["SearchDire"] = RawSearchDire;
                SettingControll.SaveJson();
            }
            RawSearchDire.Clear();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            RawSearchDire.Clear();
            this.Close();
        }
    }
}
