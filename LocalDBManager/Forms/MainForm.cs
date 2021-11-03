namespace LocalDBManager.Forms
{
    using MartinCostello.SqlLocalDb;
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        readonly IInstancesManager _sqlInstancesManager;
        readonly NewInstanceForm _newInstanceForm;

        public MainForm(
            IInstancesManager instancesManager,
            NewInstanceForm newInstanceForm)
        {
            _sqlInstancesManager = instancesManager;
            _newInstanceForm = newInstanceForm;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshInstances();
        }

        private void StartClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow instanceInfoRow in dataGridViewInstances.SelectedRows)
            {
                _sqlInstancesManager.Start((ISqlLocalDbInstanceInfo) instanceInfoRow.DataBoundItem);
            }
            RefreshInstances();
        }

        private void StopClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow instanceInfoRow in dataGridViewInstances.SelectedRows)
            {
                _sqlInstancesManager.Stop((ISqlLocalDbInstanceInfo)instanceInfoRow.DataBoundItem);
            }
            RefreshInstances();
        }

        private void RefreshInstances()
        {
            dataGridViewInstances.DataSource = _sqlInstancesManager.GetInstances();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow instanceInfoRow in dataGridViewInstances.SelectedRows)
            {
                var cancel = false;
                var instance = (ISqlLocalDbInstanceInfo)instanceInfoRow.DataBoundItem;
                switch (MessageBox.Show($"Do you want to delete the instance '{instance.Name}'?", "SQL LocalDB Manager", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                       _sqlInstancesManager.Delete(instance, true);
                        break;
                    case DialogResult.No:
                        continue;
                    case DialogResult.Cancel:
                        cancel = true;
                        break;
                }

                if (cancel) break;
            }
            RefreshInstances();
        }

        private void newInstanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_newInstanceForm.ShowDialog() == DialogResult.OK)
            {
                RefreshInstances();
            }
        }
    }
}
