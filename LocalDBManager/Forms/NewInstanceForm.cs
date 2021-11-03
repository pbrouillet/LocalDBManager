namespace LocalDBManager.Forms
{
    using System;
    using System.Windows.Forms;

    public partial class NewInstanceForm : Form
    {
        readonly IInstancesManager _instancesManager;

        public NewInstanceForm(IInstancesManager instancesManager)
        {
            _instancesManager = instancesManager;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                _instancesManager.New(txtInstanceName.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtInstanceName_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
