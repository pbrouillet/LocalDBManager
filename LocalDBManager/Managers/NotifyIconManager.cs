namespace LocalDBManager
{
    using LocalDBManager.Properties;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public class NotifyIconManager : IDisposable
	{
		NotifyIcon _notifyIcon;
        readonly IInstancesManager _instancesManager;

        public NotifyIconManager(IInstancesManager instancesManager)
		{
			var contextMenuContext = new NotifyIconContextMenu();
            _instancesManager = instancesManager;

            _notifyIcon = new NotifyIcon();
			_notifyIcon.ContextMenuStrip = contextMenuContext.ContextMenuStrip;
			_notifyIcon.Icon = Resources.microsoft_sql_server;
			_notifyIcon.Visible = true;

            _notifyIcon.DoubleClick += DoubleClick;

            var items = _notifyIcon.ContextMenuStrip.Items;
            items["showToolStripMenuItem"].Click += ShowClick;
            items["exitToolStripMenuItem"].Click += ExitClick;

            BindInstancesToContextMenus();
		}

        private void BindInstancesToContextMenus()
        {
            var items = _notifyIcon.ContextMenuStrip.Items;

            var startToolStripMenuItem = items["startToolStripMenuItem"] as ToolStripDropDownItem;
            var restartToolStripMenuItem = items["restartToolStripMenuItem"] as ToolStripDropDownItem;
            var stopToolStripMenuItem = items["stopToolStripMenuItem"] as ToolStripDropDownItem;

            startToolStripMenuItem.DropDownItemClicked += (object sender, ToolStripItemClickedEventArgs e) =>
            {
                string? tag = e.ClickedItem.Tag as string;
                if (!string.IsNullOrWhiteSpace(tag))
                {
                    _instancesManager.Start(tag);
                }
                else
                {
                    foreach (var instance in _instancesManager.GetInstances().Where(instance => !instance.IsRunning))
                    {
                        _instancesManager.Start(instance);
                    }
                }
                
                BindInstancesToContextMenus();
            };

            restartToolStripMenuItem.DropDownItemClicked += (object sender, ToolStripItemClickedEventArgs e) =>
            {
                string? tag = e.ClickedItem.Tag as string;
                if (!string.IsNullOrWhiteSpace(tag))
                {
                    _instancesManager.Restart(tag);
                }
                else
                {
                    foreach (var instance in _instancesManager.GetInstances().Where(instance => instance.IsRunning))
                    {
                        _instancesManager.Restart(instance);
                    }
                }

                BindInstancesToContextMenus();
            };

            stopToolStripMenuItem.DropDownItemClicked += (object sender, ToolStripItemClickedEventArgs e) =>
            {
                string? tag = e.ClickedItem.Tag as string;
                if (!string.IsNullOrWhiteSpace(tag))
                {
                    _instancesManager.Stop(tag);
                }
                else
                {
                    foreach (var instance in _instancesManager.GetInstances().Where(instance => instance.IsRunning))
                    {
                        _instancesManager.Stop(instance);
                    }
                }

                BindInstancesToContextMenus();
            };

            BindInstancesToContextMenu("start", startToolStripMenuItem, true);
            BindInstancesToContextMenu("restart", restartToolStripMenuItem, false);
            BindInstancesToContextMenu("stop", stopToolStripMenuItem, false);
        }

        private void BindInstancesToContextMenu(string prefix, ToolStripDropDownItem toolStripMenuItem, bool enabledIfStopped)
        {
            while (toolStripMenuItem.DropDownItems.Count > 2)
            {
                toolStripMenuItem.DropDownItems.RemoveAt(2);
            }

            var instanceMenuItems = _instancesManager.GetInstances().Select(instance => new ToolStripMenuItem
            {
                Name = prefix + instance.Name,
                Text = instance.Name,
                Tag = instance.Name,
                Enabled = instance.IsRunning ^ enabledIfStopped
            });
            
            toolStripMenuItem.DropDownItems.AddRange(instanceMenuItems.ToArray());
        }

        private void ShowClick(object? sender, EventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
        }

        private void ExitClick(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoubleClick(object? sender, EventArgs e)
        {
            var mainForm = Application.OpenForms["MainForm"];

            mainForm.Show();
            mainForm.Focus();
        }

        public void Dispose()
        {
			_notifyIcon.Visible = false;
			_notifyIcon.Dispose();
        }
    }
}