namespace LocalDBManager.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.dataGridViewInstances = new System.Windows.Forms.DataGridView();
            this.InstanceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRunning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAutomatic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripInstances = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstances)).BeginInit();
            this.contextMenuStripInstances.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartClick);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StopClick);
            // 
            // dataGridViewInstances
            // 
            resources.ApplyResources(this.dataGridViewInstances, "dataGridViewInstances");
            this.dataGridViewInstances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInstances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstanceName,
            this.IsRunning,
            this.IsAutomatic});
            this.dataGridViewInstances.ContextMenuStrip = this.contextMenuStripInstances;
            this.dataGridViewInstances.Name = "dataGridViewInstances";
            this.dataGridViewInstances.RowTemplate.Height = 37;
            this.dataGridViewInstances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // InstanceName
            // 
            this.InstanceName.DataPropertyName = "Name";
            resources.ApplyResources(this.InstanceName, "InstanceName");
            this.InstanceName.Name = "InstanceName";
            this.InstanceName.ReadOnly = true;
            // 
            // IsRunning
            // 
            this.IsRunning.DataPropertyName = "IsRunning";
            resources.ApplyResources(this.IsRunning, "IsRunning");
            this.IsRunning.Name = "IsRunning";
            this.IsRunning.ReadOnly = true;
            // 
            // IsAutomatic
            // 
            this.IsAutomatic.DataPropertyName = "IsAutomatic";
            resources.ApplyResources(this.IsAutomatic, "IsAutomatic");
            this.IsAutomatic.Name = "IsAutomatic";
            this.IsAutomatic.ReadOnly = true;
            // 
            // contextMenuStripInstances
            // 
            this.contextMenuStripInstances.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStripInstances.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripInstances.Name = "contextMenuStripInstances";
            resources.ApplyResources(this.contextMenuStripInstances, "contextMenuStripInstances");
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartClick);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopClick);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteClick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInstanceToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newInstanceToolStripMenuItem
            // 
            this.newInstanceToolStripMenuItem.Name = "newInstanceToolStripMenuItem";
            resources.ApplyResources(this.newInstanceToolStripMenuItem, "newInstanceToolStripMenuItem");
            this.newInstanceToolStripMenuItem.Click += new System.EventHandler(this.newInstanceToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnStart;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dataGridViewInstances);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstances)).EndInit();
            this.contextMenuStripInstances.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridView dataGridViewInstances;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstanceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRunning;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAutomatic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripInstances;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newInstanceToolStripMenuItem;
    }
}

