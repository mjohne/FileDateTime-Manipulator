using System.ComponentModel;
using FileDateTime_Manipulator.Properties;

namespace FileDateTime_Manipulator
{
	partial class FdtmForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(FdtmForm));
			openFileDialog = new OpenFileDialog();
			toolTip = new ToolTip(components);
			radioButtonNewCreationDateUtc = new RadioButton();
			radioButtonNewCreationDateLocalTime = new RadioButton();
			radioButtonNewLastAccessDateUtc = new RadioButton();
			radioButtonNewLastAccessDateLocalTime = new RadioButton();
			radioButtonNewLastWriteDateUtc = new RadioButton();
			radioButtonNewLastWriteDateLocalTime = new RadioButton();
			dateTimePickerWrited = new DateTimePicker();
			dateTimePickerAccessed = new DateTimePicker();
			dateTimePickerCreated = new DateTimePicker();
			radioButtonLastWriteDateUtc = new RadioButton();
			radioButtonLastWriteDateLocalTime = new RadioButton();
			radioButtonCreationDateUtc = new RadioButton();
			radioButtonCreationDateLocalTime = new RadioButton();
			textBoxLastWriteDate = new TextBox();
			textBoxLastAccessDate = new TextBox();
			textBoxCreationDate = new TextBox();
			radioButtonLastAccessDateUtc = new RadioButton();
			radioButtonLastAccessDateLocalTime = new RadioButton();
			textBoxPath = new TextBox();
			buttonClose = new Button();
			buttonInfo = new Button();
			buttonApply = new Button();
			buttonSelectFile = new Button();
			buttonSelectFolder = new Button();
			statusStrip = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			labelOr = new Label();
			tableLayoutPanelSetDate = new TableLayoutPanel();
			labelNewCreationDate = new Label();
			tableLayoutPanelSetLastWriteDateFormat = new TableLayoutPanel();
			tableLayoutPanelSetLastAccessDateFormat = new TableLayoutPanel();
			labelNewWriteDate = new Label();
			labelNewAccessDate = new Label();
			tableLayoutPanelSetCreationDateFormat = new TableLayoutPanel();
			panelButtons = new Panel();
			tableLayoutPanelGetDate = new TableLayoutPanel();
			tableLayoutPanelGetLastWriteDateFormat = new TableLayoutPanel();
			tableLayoutPanelGetCreationDateFormat = new TableLayoutPanel();
			labelCreationDate = new Label();
			labelLastAccessDate = new Label();
			labelLastWriteDate = new Label();
			tableLayoutPanelGetLastAccessDateFormat = new TableLayoutPanel();
			labelPath = new Label();
			folderBrowserDialog = new FolderBrowserDialog();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			tableLayoutPanelSetDate.SuspendLayout();
			tableLayoutPanelSetLastWriteDateFormat.SuspendLayout();
			tableLayoutPanelSetLastAccessDateFormat.SuspendLayout();
			tableLayoutPanelSetCreationDateFormat.SuspendLayout();
			panelButtons.SuspendLayout();
			tableLayoutPanelGetDate.SuspendLayout();
			tableLayoutPanelGetLastWriteDateFormat.SuspendLayout();
			tableLayoutPanelGetCreationDateFormat.SuspendLayout();
			tableLayoutPanelGetLastAccessDateFormat.SuspendLayout();
			SuspendLayout();
			// 
			// openFileDialog
			// 
			openFileDialog.Filter = "all files|*.*";
			openFileDialog.SupportMultiDottedExtensions = true;
			openFileDialog.Title = "Select file";
			// 
			// radioButtonNewCreationDateUtc
			// 
			radioButtonNewCreationDateUtc.AccessibleDescription = "Convert the creation date preview to the universal time";
			radioButtonNewCreationDateUtc.AccessibleName = "Convert the creation date preview to the universal time";
			radioButtonNewCreationDateUtc.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonNewCreationDateUtc.AutoSize = true;
			radioButtonNewCreationDateUtc.Dock = DockStyle.Fill;
			radioButtonNewCreationDateUtc.Enabled = false;
			radioButtonNewCreationDateUtc.Location = new Point(89, 3);
			radioButtonNewCreationDateUtc.Margin = new Padding(4, 3, 4, 3);
			radioButtonNewCreationDateUtc.Name = "radioButtonNewCreationDateUtc";
			radioButtonNewCreationDateUtc.Size = new Size(79, 21);
			radioButtonNewCreationDateUtc.TabIndex = 1;
			radioButtonNewCreationDateUtc.Text = "UTC";
			toolTip.SetToolTip(radioButtonNewCreationDateUtc, "Convert the creation date preview to the universal time");
			radioButtonNewCreationDateUtc.UseVisualStyleBackColor = true;
			radioButtonNewCreationDateUtc.CheckedChanged += RadioButtonNewCreationDateUtc_CheckedChanged;
			radioButtonNewCreationDateUtc.Enter += SetStatusBar_Enter;
			radioButtonNewCreationDateUtc.Leave += ClearStatusBar_Leave;
			radioButtonNewCreationDateUtc.MouseEnter += SetStatusBar_Enter;
			radioButtonNewCreationDateUtc.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonNewCreationDateLocalTime
			// 
			radioButtonNewCreationDateLocalTime.AccessibleDescription = "Convert the creation date preview to the local time";
			radioButtonNewCreationDateLocalTime.AccessibleName = "Convert the creation date preview to the local time";
			radioButtonNewCreationDateLocalTime.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonNewCreationDateLocalTime.AutoSize = true;
			radioButtonNewCreationDateLocalTime.Checked = true;
			radioButtonNewCreationDateLocalTime.Dock = DockStyle.Fill;
			radioButtonNewCreationDateLocalTime.Enabled = false;
			radioButtonNewCreationDateLocalTime.Location = new Point(4, 3);
			radioButtonNewCreationDateLocalTime.Margin = new Padding(4, 3, 4, 3);
			radioButtonNewCreationDateLocalTime.Name = "radioButtonNewCreationDateLocalTime";
			radioButtonNewCreationDateLocalTime.Size = new Size(77, 21);
			radioButtonNewCreationDateLocalTime.TabIndex = 0;
			radioButtonNewCreationDateLocalTime.TabStop = true;
			radioButtonNewCreationDateLocalTime.Text = "local time";
			toolTip.SetToolTip(radioButtonNewCreationDateLocalTime, "Convert the creation date preview to the local time");
			radioButtonNewCreationDateLocalTime.UseVisualStyleBackColor = true;
			radioButtonNewCreationDateLocalTime.CheckedChanged += RadioButtonNewCreationDateLocalTime_CheckedChanged;
			radioButtonNewCreationDateLocalTime.Enter += SetStatusBar_Enter;
			radioButtonNewCreationDateLocalTime.Leave += ClearStatusBar_Leave;
			radioButtonNewCreationDateLocalTime.MouseEnter += SetStatusBar_Enter;
			radioButtonNewCreationDateLocalTime.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonNewLastAccessDateUtc
			// 
			radioButtonNewLastAccessDateUtc.AccessibleDescription = "Convert the last access date preview to the universal time";
			radioButtonNewLastAccessDateUtc.AccessibleName = "Convert the last access date preview to the universal time";
			radioButtonNewLastAccessDateUtc.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonNewLastAccessDateUtc.AutoSize = true;
			radioButtonNewLastAccessDateUtc.Dock = DockStyle.Fill;
			radioButtonNewLastAccessDateUtc.Enabled = false;
			radioButtonNewLastAccessDateUtc.Location = new Point(89, 3);
			radioButtonNewLastAccessDateUtc.Margin = new Padding(4, 3, 4, 3);
			radioButtonNewLastAccessDateUtc.Name = "radioButtonNewLastAccessDateUtc";
			radioButtonNewLastAccessDateUtc.Size = new Size(79, 21);
			radioButtonNewLastAccessDateUtc.TabIndex = 1;
			radioButtonNewLastAccessDateUtc.Text = "UTC";
			toolTip.SetToolTip(radioButtonNewLastAccessDateUtc, "Convert the last access date preview to the universal time");
			radioButtonNewLastAccessDateUtc.UseVisualStyleBackColor = true;
			radioButtonNewLastAccessDateUtc.CheckedChanged += RadioButtonNewLastAccessDateUtc_CheckedChanged;
			radioButtonNewLastAccessDateUtc.Enter += SetStatusBar_Enter;
			radioButtonNewLastAccessDateUtc.Leave += ClearStatusBar_Leave;
			radioButtonNewLastAccessDateUtc.MouseEnter += SetStatusBar_Enter;
			radioButtonNewLastAccessDateUtc.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonNewLastAccessDateLocalTime
			// 
			radioButtonNewLastAccessDateLocalTime.AccessibleDescription = "Convert the last access date preview to the local time";
			radioButtonNewLastAccessDateLocalTime.AccessibleName = "Convert the last access date preview to the local time";
			radioButtonNewLastAccessDateLocalTime.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonNewLastAccessDateLocalTime.AutoSize = true;
			radioButtonNewLastAccessDateLocalTime.Checked = true;
			radioButtonNewLastAccessDateLocalTime.Dock = DockStyle.Fill;
			radioButtonNewLastAccessDateLocalTime.Enabled = false;
			radioButtonNewLastAccessDateLocalTime.Location = new Point(4, 3);
			radioButtonNewLastAccessDateLocalTime.Margin = new Padding(4, 3, 4, 3);
			radioButtonNewLastAccessDateLocalTime.Name = "radioButtonNewLastAccessDateLocalTime";
			radioButtonNewLastAccessDateLocalTime.Size = new Size(77, 21);
			radioButtonNewLastAccessDateLocalTime.TabIndex = 0;
			radioButtonNewLastAccessDateLocalTime.TabStop = true;
			radioButtonNewLastAccessDateLocalTime.Text = "local time";
			toolTip.SetToolTip(radioButtonNewLastAccessDateLocalTime, "Convert the last access date preview to the local time");
			radioButtonNewLastAccessDateLocalTime.UseVisualStyleBackColor = true;
			radioButtonNewLastAccessDateLocalTime.CheckedChanged += RadioButtonNewLastAccessDateLocalTime_CheckedChanged;
			radioButtonNewLastAccessDateLocalTime.Enter += SetStatusBar_Enter;
			radioButtonNewLastAccessDateLocalTime.Leave += ClearStatusBar_Leave;
			radioButtonNewLastAccessDateLocalTime.MouseEnter += SetStatusBar_Enter;
			radioButtonNewLastAccessDateLocalTime.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonNewLastWriteDateUtc
			// 
			radioButtonNewLastWriteDateUtc.AccessibleDescription = "Convert the last write date preview to the universal time";
			radioButtonNewLastWriteDateUtc.AccessibleName = "Convert the last write date preview to the universal time";
			radioButtonNewLastWriteDateUtc.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonNewLastWriteDateUtc.AutoSize = true;
			radioButtonNewLastWriteDateUtc.Dock = DockStyle.Fill;
			radioButtonNewLastWriteDateUtc.Enabled = false;
			radioButtonNewLastWriteDateUtc.Location = new Point(89, 3);
			radioButtonNewLastWriteDateUtc.Margin = new Padding(4, 3, 4, 3);
			radioButtonNewLastWriteDateUtc.Name = "radioButtonNewLastWriteDateUtc";
			radioButtonNewLastWriteDateUtc.Size = new Size(79, 21);
			radioButtonNewLastWriteDateUtc.TabIndex = 1;
			radioButtonNewLastWriteDateUtc.Text = "UTC";
			toolTip.SetToolTip(radioButtonNewLastWriteDateUtc, "Convert the last write date preview to the universal time");
			radioButtonNewLastWriteDateUtc.UseVisualStyleBackColor = true;
			radioButtonNewLastWriteDateUtc.CheckedChanged += RadioButtonNewLastWriteDateUtc_CheckedChanged;
			radioButtonNewLastWriteDateUtc.Enter += SetStatusBar_Enter;
			radioButtonNewLastWriteDateUtc.Leave += ClearStatusBar_Leave;
			radioButtonNewLastWriteDateUtc.MouseEnter += SetStatusBar_Enter;
			radioButtonNewLastWriteDateUtc.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonNewLastWriteDateLocalTime
			// 
			radioButtonNewLastWriteDateLocalTime.AccessibleDescription = "Convert the last write date preview to the local time";
			radioButtonNewLastWriteDateLocalTime.AccessibleName = "Convert the last write date preview to the local time";
			radioButtonNewLastWriteDateLocalTime.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonNewLastWriteDateLocalTime.AutoSize = true;
			radioButtonNewLastWriteDateLocalTime.Checked = true;
			radioButtonNewLastWriteDateLocalTime.Dock = DockStyle.Fill;
			radioButtonNewLastWriteDateLocalTime.Enabled = false;
			radioButtonNewLastWriteDateLocalTime.Location = new Point(4, 3);
			radioButtonNewLastWriteDateLocalTime.Margin = new Padding(4, 3, 4, 3);
			radioButtonNewLastWriteDateLocalTime.Name = "radioButtonNewLastWriteDateLocalTime";
			radioButtonNewLastWriteDateLocalTime.Size = new Size(77, 21);
			radioButtonNewLastWriteDateLocalTime.TabIndex = 0;
			radioButtonNewLastWriteDateLocalTime.TabStop = true;
			radioButtonNewLastWriteDateLocalTime.Text = "local time";
			toolTip.SetToolTip(radioButtonNewLastWriteDateLocalTime, "Convert the last write date preview to the local time");
			radioButtonNewLastWriteDateLocalTime.UseVisualStyleBackColor = true;
			radioButtonNewLastWriteDateLocalTime.CheckedChanged += RadioButtonNewLastWriteDateLocalTime_CheckedChanged;
			radioButtonNewLastWriteDateLocalTime.Enter += SetStatusBar_Enter;
			radioButtonNewLastWriteDateLocalTime.Leave += ClearStatusBar_Leave;
			radioButtonNewLastWriteDateLocalTime.MouseEnter += SetStatusBar_Enter;
			radioButtonNewLastWriteDateLocalTime.MouseLeave += ClearStatusBar_Leave;
			// 
			// dateTimePickerWrited
			// 
			dateTimePickerWrited.AccessibleDescription = "Set the last write date of the file";
			dateTimePickerWrited.AccessibleName = "Last write date preview of the file";
			dateTimePickerWrited.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dateTimePickerWrited.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			dateTimePickerWrited.Enabled = false;
			dateTimePickerWrited.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePickerWrited.Format = DateTimePickerFormat.Custom;
			dateTimePickerWrited.Location = new Point(408, 18);
			dateTimePickerWrited.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerWrited.Name = "dateTimePickerWrited";
			dateTimePickerWrited.ShowCheckBox = true;
			dateTimePickerWrited.ShowUpDown = true;
			dateTimePickerWrited.Size = new Size(197, 20);
			dateTimePickerWrited.TabIndex = 7;
			toolTip.SetToolTip(dateTimePickerWrited, "Last write date preview of the file");
			dateTimePickerWrited.Enter += SetStatusBar_Enter;
			dateTimePickerWrited.Leave += ClearStatusBar_Leave;
			dateTimePickerWrited.MouseEnter += SetStatusBar_Enter;
			dateTimePickerWrited.MouseLeave += ClearStatusBar_Leave;
			// 
			// dateTimePickerAccessed
			// 
			dateTimePickerAccessed.AccessibleDescription = "Set the last access date of the file";
			dateTimePickerAccessed.AccessibleName = "Last access date preview of the file";
			dateTimePickerAccessed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dateTimePickerAccessed.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			dateTimePickerAccessed.Enabled = false;
			dateTimePickerAccessed.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePickerAccessed.Format = DateTimePickerFormat.Custom;
			dateTimePickerAccessed.Location = new Point(206, 18);
			dateTimePickerAccessed.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerAccessed.Name = "dateTimePickerAccessed";
			dateTimePickerAccessed.ShowCheckBox = true;
			dateTimePickerAccessed.ShowUpDown = true;
			dateTimePickerAccessed.Size = new Size(194, 20);
			dateTimePickerAccessed.TabIndex = 4;
			toolTip.SetToolTip(dateTimePickerAccessed, "Last access date preview of the file");
			dateTimePickerAccessed.Enter += SetStatusBar_Enter;
			dateTimePickerAccessed.Leave += ClearStatusBar_Leave;
			dateTimePickerAccessed.MouseEnter += SetStatusBar_Enter;
			dateTimePickerAccessed.MouseLeave += ClearStatusBar_Leave;
			// 
			// dateTimePickerCreated
			// 
			dateTimePickerCreated.AccessibleDescription = "Set the creation date of the file";
			dateTimePickerCreated.AccessibleName = "Creation date preview of the file";
			dateTimePickerCreated.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dateTimePickerCreated.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			dateTimePickerCreated.Enabled = false;
			dateTimePickerCreated.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePickerCreated.Format = DateTimePickerFormat.Custom;
			dateTimePickerCreated.Location = new Point(4, 18);
			dateTimePickerCreated.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerCreated.Name = "dateTimePickerCreated";
			dateTimePickerCreated.ShowCheckBox = true;
			dateTimePickerCreated.ShowUpDown = true;
			dateTimePickerCreated.Size = new Size(194, 20);
			dateTimePickerCreated.TabIndex = 1;
			toolTip.SetToolTip(dateTimePickerCreated, "Creation date preview of the file");
			dateTimePickerCreated.Enter += SetStatusBar_Enter;
			dateTimePickerCreated.Leave += ClearStatusBar_Leave;
			dateTimePickerCreated.MouseEnter += SetStatusBar_Enter;
			dateTimePickerCreated.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonLastWriteDateUtc
			// 
			radioButtonLastWriteDateUtc.AccessibleDescription = "Convert the last write date to the universal time";
			radioButtonLastWriteDateUtc.AccessibleName = "Convert the last write date to the universal time";
			radioButtonLastWriteDateUtc.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonLastWriteDateUtc.AutoSize = true;
			radioButtonLastWriteDateUtc.Dock = DockStyle.Fill;
			radioButtonLastWriteDateUtc.Enabled = false;
			radioButtonLastWriteDateUtc.Location = new Point(89, 3);
			radioButtonLastWriteDateUtc.Margin = new Padding(4, 3, 4, 3);
			radioButtonLastWriteDateUtc.Name = "radioButtonLastWriteDateUtc";
			radioButtonLastWriteDateUtc.Size = new Size(79, 22);
			radioButtonLastWriteDateUtc.TabIndex = 1;
			radioButtonLastWriteDateUtc.Text = "UTC";
			toolTip.SetToolTip(radioButtonLastWriteDateUtc, "Convert the last write date to the universal time");
			radioButtonLastWriteDateUtc.UseVisualStyleBackColor = true;
			radioButtonLastWriteDateUtc.CheckedChanged += RadioButtonLastWriteDateUtc_CheckedChanged;
			radioButtonLastWriteDateUtc.Enter += SetStatusBar_Enter;
			radioButtonLastWriteDateUtc.Leave += ClearStatusBar_Leave;
			radioButtonLastWriteDateUtc.MouseEnter += SetStatusBar_Enter;
			radioButtonLastWriteDateUtc.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonLastWriteDateLocalTime
			// 
			radioButtonLastWriteDateLocalTime.AccessibleDescription = "Convert the last write date to the local time";
			radioButtonLastWriteDateLocalTime.AccessibleName = "Convert the last write date to the local time";
			radioButtonLastWriteDateLocalTime.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonLastWriteDateLocalTime.AutoSize = true;
			radioButtonLastWriteDateLocalTime.Checked = true;
			radioButtonLastWriteDateLocalTime.Dock = DockStyle.Fill;
			radioButtonLastWriteDateLocalTime.Enabled = false;
			radioButtonLastWriteDateLocalTime.Location = new Point(4, 3);
			radioButtonLastWriteDateLocalTime.Margin = new Padding(4, 3, 4, 3);
			radioButtonLastWriteDateLocalTime.Name = "radioButtonLastWriteDateLocalTime";
			radioButtonLastWriteDateLocalTime.Size = new Size(77, 22);
			radioButtonLastWriteDateLocalTime.TabIndex = 0;
			radioButtonLastWriteDateLocalTime.TabStop = true;
			radioButtonLastWriteDateLocalTime.Text = "local time";
			toolTip.SetToolTip(radioButtonLastWriteDateLocalTime, "Convert the last write date to the local time");
			radioButtonLastWriteDateLocalTime.UseVisualStyleBackColor = true;
			radioButtonLastWriteDateLocalTime.CheckedChanged += RadioButtonLastWriteDateLocalTime_CheckedChanged;
			radioButtonLastWriteDateLocalTime.Enter += SetStatusBar_Enter;
			radioButtonLastWriteDateLocalTime.Leave += ClearStatusBar_Leave;
			radioButtonLastWriteDateLocalTime.MouseEnter += SetStatusBar_Enter;
			radioButtonLastWriteDateLocalTime.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonCreationDateUtc
			// 
			radioButtonCreationDateUtc.AccessibleDescription = "Convert the creation date to the universal time";
			radioButtonCreationDateUtc.AccessibleName = "Convert the creation date to the universal time";
			radioButtonCreationDateUtc.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonCreationDateUtc.AutoSize = true;
			radioButtonCreationDateUtc.Dock = DockStyle.Fill;
			radioButtonCreationDateUtc.Enabled = false;
			radioButtonCreationDateUtc.Location = new Point(89, 3);
			radioButtonCreationDateUtc.Margin = new Padding(4, 3, 4, 3);
			radioButtonCreationDateUtc.Name = "radioButtonCreationDateUtc";
			radioButtonCreationDateUtc.Size = new Size(79, 22);
			radioButtonCreationDateUtc.TabIndex = 1;
			radioButtonCreationDateUtc.Text = "UTC";
			toolTip.SetToolTip(radioButtonCreationDateUtc, "Convert the creation date to the universal time");
			radioButtonCreationDateUtc.UseVisualStyleBackColor = true;
			radioButtonCreationDateUtc.CheckedChanged += RadioButtonCreationDateUtc_CheckedChanged;
			radioButtonCreationDateUtc.Enter += SetStatusBar_Enter;
			radioButtonCreationDateUtc.Leave += ClearStatusBar_Leave;
			radioButtonCreationDateUtc.MouseEnter += SetStatusBar_Enter;
			radioButtonCreationDateUtc.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonCreationDateLocalTime
			// 
			radioButtonCreationDateLocalTime.AccessibleDescription = "Convert the creation date to the local time";
			radioButtonCreationDateLocalTime.AccessibleName = "Convert the creation date to the local time";
			radioButtonCreationDateLocalTime.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonCreationDateLocalTime.AutoSize = true;
			radioButtonCreationDateLocalTime.Checked = true;
			radioButtonCreationDateLocalTime.Dock = DockStyle.Fill;
			radioButtonCreationDateLocalTime.Enabled = false;
			radioButtonCreationDateLocalTime.Location = new Point(4, 3);
			radioButtonCreationDateLocalTime.Margin = new Padding(4, 3, 4, 3);
			radioButtonCreationDateLocalTime.Name = "radioButtonCreationDateLocalTime";
			radioButtonCreationDateLocalTime.Size = new Size(77, 22);
			radioButtonCreationDateLocalTime.TabIndex = 0;
			radioButtonCreationDateLocalTime.TabStop = true;
			radioButtonCreationDateLocalTime.Text = "local time";
			toolTip.SetToolTip(radioButtonCreationDateLocalTime, "Convert the creation date to the local time");
			radioButtonCreationDateLocalTime.UseVisualStyleBackColor = true;
			radioButtonCreationDateLocalTime.CheckedChanged += RadioButtonCreationDateLocalTime_CheckedChanged;
			radioButtonCreationDateLocalTime.Enter += SetStatusBar_Enter;
			radioButtonCreationDateLocalTime.Leave += ClearStatusBar_Leave;
			radioButtonCreationDateLocalTime.MouseEnter += SetStatusBar_Enter;
			radioButtonCreationDateLocalTime.MouseLeave += ClearStatusBar_Leave;
			// 
			// textBoxLastWriteDate
			// 
			textBoxLastWriteDate.AccessibleDescription = "Last write date of the file";
			textBoxLastWriteDate.AccessibleName = "Last write date of the file";
			textBoxLastWriteDate.AccessibleRole = AccessibleRole.Text;
			textBoxLastWriteDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxLastWriteDate.BorderStyle = BorderStyle.FixedSingle;
			textBoxLastWriteDate.Location = new Point(408, 18);
			textBoxLastWriteDate.Margin = new Padding(4, 3, 4, 3);
			textBoxLastWriteDate.Name = "textBoxLastWriteDate";
			textBoxLastWriteDate.PlaceholderText = "last write date here...";
			textBoxLastWriteDate.ReadOnly = true;
			textBoxLastWriteDate.Size = new Size(197, 23);
			textBoxLastWriteDate.TabIndex = 7;
			textBoxLastWriteDate.TextAlign = HorizontalAlignment.Center;
			toolTip.SetToolTip(textBoxLastWriteDate, "Last write date of the file");
			textBoxLastWriteDate.Enter += SetStatusBar_Enter;
			textBoxLastWriteDate.Leave += ClearStatusBar_Leave;
			textBoxLastWriteDate.MouseEnter += SetStatusBar_Enter;
			textBoxLastWriteDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// textBoxLastAccessDate
			// 
			textBoxLastAccessDate.AccessibleDescription = "Last access date of the file";
			textBoxLastAccessDate.AccessibleName = "Last access date of the file";
			textBoxLastAccessDate.AccessibleRole = AccessibleRole.Text;
			textBoxLastAccessDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxLastAccessDate.BorderStyle = BorderStyle.FixedSingle;
			textBoxLastAccessDate.Location = new Point(206, 18);
			textBoxLastAccessDate.Margin = new Padding(4, 3, 4, 3);
			textBoxLastAccessDate.Name = "textBoxLastAccessDate";
			textBoxLastAccessDate.PlaceholderText = "last access date here...";
			textBoxLastAccessDate.ReadOnly = true;
			textBoxLastAccessDate.Size = new Size(194, 23);
			textBoxLastAccessDate.TabIndex = 4;
			textBoxLastAccessDate.TextAlign = HorizontalAlignment.Center;
			toolTip.SetToolTip(textBoxLastAccessDate, "Last access date of the file");
			textBoxLastAccessDate.Enter += SetStatusBar_Enter;
			textBoxLastAccessDate.Leave += ClearStatusBar_Leave;
			textBoxLastAccessDate.MouseEnter += SetStatusBar_Enter;
			textBoxLastAccessDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// textBoxCreationDate
			// 
			textBoxCreationDate.AccessibleDescription = "Creation date of the file";
			textBoxCreationDate.AccessibleName = "Creation date of the file";
			textBoxCreationDate.AccessibleRole = AccessibleRole.Text;
			textBoxCreationDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxCreationDate.BorderStyle = BorderStyle.FixedSingle;
			textBoxCreationDate.Location = new Point(4, 18);
			textBoxCreationDate.Margin = new Padding(4, 3, 4, 3);
			textBoxCreationDate.Name = "textBoxCreationDate";
			textBoxCreationDate.PlaceholderText = "creation date here...";
			textBoxCreationDate.ReadOnly = true;
			textBoxCreationDate.Size = new Size(194, 23);
			textBoxCreationDate.TabIndex = 1;
			textBoxCreationDate.TextAlign = HorizontalAlignment.Center;
			toolTip.SetToolTip(textBoxCreationDate, "Creation date of the file");
			textBoxCreationDate.Enter += SetStatusBar_Enter;
			textBoxCreationDate.Leave += ClearStatusBar_Leave;
			textBoxCreationDate.MouseEnter += SetStatusBar_Enter;
			textBoxCreationDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonLastAccessDateUtc
			// 
			radioButtonLastAccessDateUtc.AccessibleDescription = "Convert the last access date to the universal time";
			radioButtonLastAccessDateUtc.AccessibleName = "Convert the last access date to the universal time";
			radioButtonLastAccessDateUtc.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonLastAccessDateUtc.AutoSize = true;
			radioButtonLastAccessDateUtc.Dock = DockStyle.Fill;
			radioButtonLastAccessDateUtc.Enabled = false;
			radioButtonLastAccessDateUtc.Location = new Point(89, 3);
			radioButtonLastAccessDateUtc.Margin = new Padding(4, 3, 4, 3);
			radioButtonLastAccessDateUtc.Name = "radioButtonLastAccessDateUtc";
			radioButtonLastAccessDateUtc.Size = new Size(79, 22);
			radioButtonLastAccessDateUtc.TabIndex = 1;
			radioButtonLastAccessDateUtc.Text = "UTC";
			toolTip.SetToolTip(radioButtonLastAccessDateUtc, "Convert the last access date to the universal time");
			radioButtonLastAccessDateUtc.UseVisualStyleBackColor = true;
			radioButtonLastAccessDateUtc.CheckedChanged += RadioButtonLastAccessDateUtc_CheckedChanged;
			radioButtonLastAccessDateUtc.Enter += SetStatusBar_Enter;
			radioButtonLastAccessDateUtc.Leave += ClearStatusBar_Leave;
			radioButtonLastAccessDateUtc.MouseEnter += SetStatusBar_Enter;
			radioButtonLastAccessDateUtc.MouseLeave += ClearStatusBar_Leave;
			// 
			// radioButtonLastAccessDateLocalTime
			// 
			radioButtonLastAccessDateLocalTime.AccessibleDescription = "Convert the last access date to the local time";
			radioButtonLastAccessDateLocalTime.AccessibleName = "Convert the last access date to the local time";
			radioButtonLastAccessDateLocalTime.AccessibleRole = AccessibleRole.RadioButton;
			radioButtonLastAccessDateLocalTime.AutoSize = true;
			radioButtonLastAccessDateLocalTime.Checked = true;
			radioButtonLastAccessDateLocalTime.Dock = DockStyle.Fill;
			radioButtonLastAccessDateLocalTime.Enabled = false;
			radioButtonLastAccessDateLocalTime.Location = new Point(4, 3);
			radioButtonLastAccessDateLocalTime.Margin = new Padding(4, 3, 4, 3);
			radioButtonLastAccessDateLocalTime.Name = "radioButtonLastAccessDateLocalTime";
			radioButtonLastAccessDateLocalTime.Size = new Size(77, 22);
			radioButtonLastAccessDateLocalTime.TabIndex = 0;
			radioButtonLastAccessDateLocalTime.TabStop = true;
			radioButtonLastAccessDateLocalTime.Text = "local time";
			toolTip.SetToolTip(radioButtonLastAccessDateLocalTime, "Convert the last access date to the local time");
			radioButtonLastAccessDateLocalTime.UseVisualStyleBackColor = true;
			radioButtonLastAccessDateLocalTime.CheckedChanged += RadioButtonLastAccessDateLocalTime_CheckedChanged;
			radioButtonLastAccessDateLocalTime.Enter += SetStatusBar_Enter;
			radioButtonLastAccessDateLocalTime.Leave += ClearStatusBar_Leave;
			radioButtonLastAccessDateLocalTime.MouseEnter += SetStatusBar_Enter;
			radioButtonLastAccessDateLocalTime.MouseLeave += ClearStatusBar_Leave;
			// 
			// textBoxPath
			// 
			textBoxPath.AccessibleDescription = "Show the full path name";
			textBoxPath.AccessibleName = "Full path name";
			textBoxPath.AccessibleRole = AccessibleRole.Text;
			textBoxPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxPath.BorderStyle = BorderStyle.FixedSingle;
			textBoxPath.Location = new Point(47, 12);
			textBoxPath.Margin = new Padding(4, 3, 4, 3);
			textBoxPath.Name = "textBoxPath";
			textBoxPath.PlaceholderText = "full path here...";
			textBoxPath.ReadOnly = true;
			textBoxPath.Size = new Size(329, 23);
			textBoxPath.TabIndex = 1;
			toolTip.SetToolTip(textBoxPath, "Full path name");
			textBoxPath.Enter += SetStatusBar_Enter;
			textBoxPath.Leave += ClearStatusBar_Leave;
			textBoxPath.MouseEnter += SetStatusBar_Enter;
			textBoxPath.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonClose
			// 
			buttonClose.AccessibleDescription = "Close the application";
			buttonClose.AccessibleName = "Exit Button";
			buttonClose.AccessibleRole = AccessibleRole.PushButton;
			buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonClose.AutoEllipsis = true;
			buttonClose.DialogResult = DialogResult.OK;
			buttonClose.Image = Resources.door_in;
			buttonClose.Location = new Point(541, 14);
			buttonClose.Margin = new Padding(4, 3, 4, 3);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(78, 27);
			buttonClose.TabIndex = 2;
			buttonClose.Text = "&Close";
			buttonClose.TextAlign = ContentAlignment.MiddleRight;
			buttonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonClose, "Close the application");
			buttonClose.UseVisualStyleBackColor = true;
			buttonClose.Click += ButtonClose_Click;
			buttonClose.Enter += SetStatusBar_Enter;
			buttonClose.Leave += ClearStatusBar_Leave;
			buttonClose.MouseEnter += SetStatusBar_Enter;
			buttonClose.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonInfo
			// 
			buttonInfo.AccessibleDescription = "Show some information";
			buttonInfo.AccessibleName = "Info button";
			buttonInfo.AccessibleRole = AccessibleRole.PushButton;
			buttonInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			buttonInfo.AutoEllipsis = true;
			buttonInfo.Image = Resources.information;
			buttonInfo.Location = new Point(13, 14);
			buttonInfo.Margin = new Padding(4, 3, 4, 3);
			buttonInfo.Name = "buttonInfo";
			buttonInfo.Size = new Size(78, 27);
			buttonInfo.TabIndex = 0;
			buttonInfo.Text = "&Info";
			buttonInfo.TextAlign = ContentAlignment.MiddleRight;
			buttonInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonInfo, "Show some information");
			buttonInfo.UseVisualStyleBackColor = true;
			buttonInfo.Click += ButtonInfo_Click;
			buttonInfo.Enter += SetStatusBar_Enter;
			buttonInfo.Leave += ClearStatusBar_Leave;
			buttonInfo.MouseEnter += SetStatusBar_Enter;
			buttonInfo.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonApply
			// 
			buttonApply.AccessibleDescription = "Apply the changes";
			buttonApply.AccessibleName = "Apply button";
			buttonApply.AccessibleRole = AccessibleRole.PushButton;
			buttonApply.Anchor = AnchorStyles.Bottom;
			buttonApply.AutoEllipsis = true;
			buttonApply.Enabled = false;
			buttonApply.Image = Resources.tick_button;
			buttonApply.Location = new Point(279, 14);
			buttonApply.Margin = new Padding(4, 3, 4, 3);
			buttonApply.Name = "buttonApply";
			buttonApply.Size = new Size(78, 27);
			buttonApply.TabIndex = 1;
			buttonApply.Text = "&Apply";
			buttonApply.TextAlign = ContentAlignment.MiddleRight;
			buttonApply.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonApply, "Apply the changes");
			buttonApply.UseVisualStyleBackColor = true;
			buttonApply.Click += ButtonApply_Click;
			buttonApply.Enter += SetStatusBar_Enter;
			buttonApply.Leave += ClearStatusBar_Leave;
			buttonApply.MouseEnter += SetStatusBar_Enter;
			buttonApply.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonSelectFile
			// 
			buttonSelectFile.AccessibleDescription = "Click to selected a file";
			buttonSelectFile.AccessibleName = "Select file";
			buttonSelectFile.AccessibleRole = AccessibleRole.PushButton;
			buttonSelectFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonSelectFile.AutoEllipsis = true;
			buttonSelectFile.Image = Resources.page_white;
			buttonSelectFile.Location = new Point(525, 10);
			buttonSelectFile.Margin = new Padding(4, 3, 4, 3);
			buttonSelectFile.Name = "buttonSelectFile";
			buttonSelectFile.Size = new Size(98, 27);
			buttonSelectFile.TabIndex = 4;
			buttonSelectFile.Text = "&Select file";
			buttonSelectFile.TextAlign = ContentAlignment.MiddleRight;
			buttonSelectFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSelectFile, "Click to selected a file");
			buttonSelectFile.UseVisualStyleBackColor = true;
			buttonSelectFile.Click += ButtonSelectFile_Click;
			buttonSelectFile.Enter += SetStatusBar_Enter;
			buttonSelectFile.Leave += ClearStatusBar_Leave;
			buttonSelectFile.MouseEnter += SetStatusBar_Enter;
			buttonSelectFile.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonSelectFolder
			// 
			buttonSelectFolder.AccessibleDescription = "Click to selected a folder";
			buttonSelectFolder.AccessibleName = "Select folder";
			buttonSelectFolder.AccessibleRole = AccessibleRole.PushButton;
			buttonSelectFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonSelectFolder.AutoEllipsis = true;
			buttonSelectFolder.Image = Resources.folder;
			buttonSelectFolder.Location = new Point(383, 10);
			buttonSelectFolder.Margin = new Padding(4, 3, 4, 3);
			buttonSelectFolder.Name = "buttonSelectFolder";
			buttonSelectFolder.Size = new Size(110, 27);
			buttonSelectFolder.TabIndex = 2;
			buttonSelectFolder.Text = "Select f&older";
			buttonSelectFolder.TextAlign = ContentAlignment.MiddleRight;
			buttonSelectFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSelectFolder, "Click to selected a folder");
			buttonSelectFolder.UseVisualStyleBackColor = true;
			buttonSelectFolder.Click += ButtonSelectFolder_Click;
			buttonSelectFolder.Enter += SetStatusBar_Enter;
			buttonSelectFolder.Leave += ClearStatusBar_Leave;
			buttonSelectFolder.MouseEnter += SetStatusBar_Enter;
			buttonSelectFolder.MouseLeave += ClearStatusBar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Show info texts";
			statusStrip.AccessibleName = "Statusbar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(637, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 0;
			statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabelInformation
			// 
			toolStripStatusLabelInformation.AccessibleDescription = "Just a status bar";
			toolStripStatusLabelInformation.AccessibleName = "status bar";
			toolStripStatusLabelInformation.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			toolStripStatusLabelInformation.Size = new Size(70, 17);
			toolStripStatusLabelInformation.Text = "information";
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Application panel";
			toolStripContainer.AccessibleName = "Application panel";
			toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.ContentPanel.Controls.Add(labelOr);
			toolStripContainer.ContentPanel.Controls.Add(buttonSelectFolder);
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanelSetDate);
			toolStripContainer.ContentPanel.Controls.Add(panelButtons);
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanelGetDate);
			toolStripContainer.ContentPanel.Controls.Add(buttonSelectFile);
			toolStripContainer.ContentPanel.Controls.Add(textBoxPath);
			toolStripContainer.ContentPanel.Controls.Add(labelPath);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(637, 270);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(637, 292);
			toolStripContainer.TabIndex = 0;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// labelOr
			// 
			labelOr.AccessibleDescription = "Select a folder or a file";
			labelOr.AccessibleName = "Folder or file";
			labelOr.AccessibleRole = AccessibleRole.StaticText;
			labelOr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			labelOr.AutoEllipsis = true;
			labelOr.AutoSize = true;
			labelOr.Location = new Point(499, 16);
			labelOr.Margin = new Padding(4, 0, 4, 0);
			labelOr.Name = "labelOr";
			labelOr.Size = new Size(18, 15);
			labelOr.TabIndex = 3;
			labelOr.Text = "or";
			labelOr.Enter += SetStatusBar_Enter;
			labelOr.Leave += ClearStatusBar_Leave;
			labelOr.MouseEnter += SetStatusBar_Enter;
			labelOr.MouseLeave += ClearStatusBar_Leave;
			// 
			// tableLayoutPanelSetDate
			// 
			tableLayoutPanelSetDate.AccessibleDescription = "Panel for the date preview of the file";
			tableLayoutPanelSetDate.AccessibleName = "Date preview panel";
			tableLayoutPanelSetDate.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelSetDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelSetDate.ColumnCount = 3;
			tableLayoutPanelSetDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			tableLayoutPanelSetDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			tableLayoutPanelSetDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			tableLayoutPanelSetDate.Controls.Add(labelNewCreationDate, 0, 0);
			tableLayoutPanelSetDate.Controls.Add(tableLayoutPanelSetLastWriteDateFormat, 2, 2);
			tableLayoutPanelSetDate.Controls.Add(tableLayoutPanelSetLastAccessDateFormat, 1, 2);
			tableLayoutPanelSetDate.Controls.Add(dateTimePickerWrited, 0, 1);
			tableLayoutPanelSetDate.Controls.Add(dateTimePickerAccessed, 0, 1);
			tableLayoutPanelSetDate.Controls.Add(dateTimePickerCreated, 0, 1);
			tableLayoutPanelSetDate.Controls.Add(labelNewWriteDate, 2, 0);
			tableLayoutPanelSetDate.Controls.Add(labelNewAccessDate, 1, 0);
			tableLayoutPanelSetDate.Controls.Add(tableLayoutPanelSetCreationDateFormat, 0, 2);
			tableLayoutPanelSetDate.Location = new Point(14, 129);
			tableLayoutPanelSetDate.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanelSetDate.Name = "tableLayoutPanelSetDate";
			tableLayoutPanelSetDate.RowCount = 3;
			tableLayoutPanelSetDate.RowStyles.Add(new RowStyle());
			tableLayoutPanelSetDate.RowStyles.Add(new RowStyle());
			tableLayoutPanelSetDate.RowStyles.Add(new RowStyle());
			tableLayoutPanelSetDate.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
			tableLayoutPanelSetDate.Size = new Size(609, 77);
			tableLayoutPanelSetDate.TabIndex = 6;
			// 
			// labelNewCreationDate
			// 
			labelNewCreationDate.AccessibleDescription = "Indicate the show the new creation date of the file";
			labelNewCreationDate.AccessibleName = "New creation date";
			labelNewCreationDate.AccessibleRole = AccessibleRole.StaticText;
			labelNewCreationDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelNewCreationDate.AutoEllipsis = true;
			labelNewCreationDate.AutoSize = true;
			labelNewCreationDate.Enabled = false;
			labelNewCreationDate.Location = new Point(4, 0);
			labelNewCreationDate.Margin = new Padding(4, 0, 4, 0);
			labelNewCreationDate.Name = "labelNewCreationDate";
			labelNewCreationDate.Size = new Size(194, 15);
			labelNewCreationDate.TabIndex = 0;
			labelNewCreationDate.Text = "Set new creation date (&4):";
			labelNewCreationDate.TextAlign = ContentAlignment.TopCenter;
			labelNewCreationDate.Enter += SetStatusBar_Enter;
			labelNewCreationDate.Leave += ClearStatusBar_Leave;
			labelNewCreationDate.MouseEnter += SetStatusBar_Enter;
			labelNewCreationDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// tableLayoutPanelSetLastWriteDateFormat
			// 
			tableLayoutPanelSetLastWriteDateFormat.AccessibleDescription = "Panel for the last write date preview format of the file";
			tableLayoutPanelSetLastWriteDateFormat.AccessibleName = "Last write date preview format panel";
			tableLayoutPanelSetLastWriteDateFormat.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelSetLastWriteDateFormat.ColumnCount = 2;
			tableLayoutPanelSetLastWriteDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelSetLastWriteDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelSetLastWriteDateFormat.Controls.Add(radioButtonNewLastWriteDateUtc, 1, 0);
			tableLayoutPanelSetLastWriteDateFormat.Controls.Add(radioButtonNewLastWriteDateLocalTime, 0, 0);
			tableLayoutPanelSetLastWriteDateFormat.Location = new Point(408, 44);
			tableLayoutPanelSetLastWriteDateFormat.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanelSetLastWriteDateFormat.Name = "tableLayoutPanelSetLastWriteDateFormat";
			tableLayoutPanelSetLastWriteDateFormat.RowCount = 1;
			tableLayoutPanelSetLastWriteDateFormat.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelSetLastWriteDateFormat.Size = new Size(172, 27);
			tableLayoutPanelSetLastWriteDateFormat.TabIndex = 8;
			// 
			// tableLayoutPanelSetLastAccessDateFormat
			// 
			tableLayoutPanelSetLastAccessDateFormat.AccessibleDescription = "Panel for the last access date preview format of the file";
			tableLayoutPanelSetLastAccessDateFormat.AccessibleName = "Last access date preview format panel";
			tableLayoutPanelSetLastAccessDateFormat.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelSetLastAccessDateFormat.ColumnCount = 2;
			tableLayoutPanelSetLastAccessDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelSetLastAccessDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelSetLastAccessDateFormat.Controls.Add(radioButtonNewLastAccessDateUtc, 1, 0);
			tableLayoutPanelSetLastAccessDateFormat.Controls.Add(radioButtonNewLastAccessDateLocalTime, 0, 0);
			tableLayoutPanelSetLastAccessDateFormat.Location = new Point(206, 44);
			tableLayoutPanelSetLastAccessDateFormat.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanelSetLastAccessDateFormat.Name = "tableLayoutPanelSetLastAccessDateFormat";
			tableLayoutPanelSetLastAccessDateFormat.RowCount = 1;
			tableLayoutPanelSetLastAccessDateFormat.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelSetLastAccessDateFormat.Size = new Size(172, 27);
			tableLayoutPanelSetLastAccessDateFormat.TabIndex = 5;
			// 
			// labelNewWriteDate
			// 
			labelNewWriteDate.AccessibleDescription = "Indicate the show the new write date of the file";
			labelNewWriteDate.AccessibleName = "New write date";
			labelNewWriteDate.AccessibleRole = AccessibleRole.StaticText;
			labelNewWriteDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelNewWriteDate.AutoEllipsis = true;
			labelNewWriteDate.AutoSize = true;
			labelNewWriteDate.Enabled = false;
			labelNewWriteDate.Location = new Point(408, 0);
			labelNewWriteDate.Margin = new Padding(4, 0, 4, 0);
			labelNewWriteDate.Name = "labelNewWriteDate";
			labelNewWriteDate.Size = new Size(197, 15);
			labelNewWriteDate.TabIndex = 6;
			labelNewWriteDate.Text = "Set new write date (&6):";
			labelNewWriteDate.TextAlign = ContentAlignment.TopCenter;
			labelNewWriteDate.Enter += SetStatusBar_Enter;
			labelNewWriteDate.Leave += ClearStatusBar_Leave;
			labelNewWriteDate.MouseEnter += SetStatusBar_Enter;
			labelNewWriteDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelNewAccessDate
			// 
			labelNewAccessDate.AccessibleDescription = "Indicate the show the news access date of the file";
			labelNewAccessDate.AccessibleName = "New access date";
			labelNewAccessDate.AccessibleRole = AccessibleRole.StaticText;
			labelNewAccessDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelNewAccessDate.AutoEllipsis = true;
			labelNewAccessDate.AutoSize = true;
			labelNewAccessDate.Enabled = false;
			labelNewAccessDate.Location = new Point(206, 0);
			labelNewAccessDate.Margin = new Padding(4, 0, 4, 0);
			labelNewAccessDate.Name = "labelNewAccessDate";
			labelNewAccessDate.Size = new Size(194, 15);
			labelNewAccessDate.TabIndex = 3;
			labelNewAccessDate.Text = "Set new access date (&5):";
			labelNewAccessDate.TextAlign = ContentAlignment.TopCenter;
			labelNewAccessDate.Enter += SetStatusBar_Enter;
			labelNewAccessDate.Leave += ClearStatusBar_Leave;
			labelNewAccessDate.MouseEnter += SetStatusBar_Enter;
			labelNewAccessDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// tableLayoutPanelSetCreationDateFormat
			// 
			tableLayoutPanelSetCreationDateFormat.AccessibleDescription = "Panel for the creation date preview format of the file";
			tableLayoutPanelSetCreationDateFormat.AccessibleName = "Creation date preview format panel";
			tableLayoutPanelSetCreationDateFormat.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelSetCreationDateFormat.ColumnCount = 2;
			tableLayoutPanelSetCreationDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelSetCreationDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelSetCreationDateFormat.Controls.Add(radioButtonNewCreationDateUtc, 1, 0);
			tableLayoutPanelSetCreationDateFormat.Controls.Add(radioButtonNewCreationDateLocalTime, 0, 0);
			tableLayoutPanelSetCreationDateFormat.Location = new Point(4, 44);
			tableLayoutPanelSetCreationDateFormat.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanelSetCreationDateFormat.Name = "tableLayoutPanelSetCreationDateFormat";
			tableLayoutPanelSetCreationDateFormat.RowCount = 1;
			tableLayoutPanelSetCreationDateFormat.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelSetCreationDateFormat.Size = new Size(172, 27);
			tableLayoutPanelSetCreationDateFormat.TabIndex = 2;
			// 
			// panelButtons
			// 
			panelButtons.AccessibleDescription = "Panel for buttons";
			panelButtons.AccessibleName = "Button panel";
			panelButtons.AccessibleRole = AccessibleRole.Pane;
			panelButtons.BackColor = SystemColors.ControlLightLight;
			panelButtons.BorderStyle = BorderStyle.FixedSingle;
			panelButtons.Controls.Add(buttonClose);
			panelButtons.Controls.Add(buttonInfo);
			panelButtons.Controls.Add(buttonApply);
			panelButtons.Dock = DockStyle.Bottom;
			panelButtons.Location = new Point(0, 214);
			panelButtons.Margin = new Padding(4, 3, 4, 3);
			panelButtons.Name = "panelButtons";
			panelButtons.Size = new Size(637, 56);
			panelButtons.TabIndex = 7;
			// 
			// tableLayoutPanelGetDate
			// 
			tableLayoutPanelGetDate.AccessibleDescription = "Panel for the date of the file";
			tableLayoutPanelGetDate.AccessibleName = "Date Panel";
			tableLayoutPanelGetDate.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelGetDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelGetDate.ColumnCount = 3;
			tableLayoutPanelGetDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			tableLayoutPanelGetDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			tableLayoutPanelGetDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			tableLayoutPanelGetDate.Controls.Add(tableLayoutPanelGetLastWriteDateFormat, 2, 2);
			tableLayoutPanelGetDate.Controls.Add(tableLayoutPanelGetCreationDateFormat, 0, 2);
			tableLayoutPanelGetDate.Controls.Add(labelCreationDate, 0, 0);
			tableLayoutPanelGetDate.Controls.Add(labelLastAccessDate, 1, 0);
			tableLayoutPanelGetDate.Controls.Add(textBoxLastWriteDate, 2, 1);
			tableLayoutPanelGetDate.Controls.Add(labelLastWriteDate, 2, 0);
			tableLayoutPanelGetDate.Controls.Add(textBoxLastAccessDate, 1, 1);
			tableLayoutPanelGetDate.Controls.Add(textBoxCreationDate, 0, 1);
			tableLayoutPanelGetDate.Controls.Add(tableLayoutPanelGetLastAccessDateFormat, 1, 2);
			tableLayoutPanelGetDate.Location = new Point(14, 42);
			tableLayoutPanelGetDate.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanelGetDate.Name = "tableLayoutPanelGetDate";
			tableLayoutPanelGetDate.RowCount = 3;
			tableLayoutPanelGetDate.RowStyles.Add(new RowStyle());
			tableLayoutPanelGetDate.RowStyles.Add(new RowStyle());
			tableLayoutPanelGetDate.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
			tableLayoutPanelGetDate.Size = new Size(609, 81);
			tableLayoutPanelGetDate.TabIndex = 5;
			// 
			// tableLayoutPanelGetLastWriteDateFormat
			// 
			tableLayoutPanelGetLastWriteDateFormat.AccessibleDescription = "Panel for the last write date format of the file";
			tableLayoutPanelGetLastWriteDateFormat.AccessibleName = "Last write date format Panel";
			tableLayoutPanelGetLastWriteDateFormat.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelGetLastWriteDateFormat.ColumnCount = 2;
			tableLayoutPanelGetLastWriteDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelGetLastWriteDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelGetLastWriteDateFormat.Controls.Add(radioButtonLastWriteDateUtc, 1, 0);
			tableLayoutPanelGetLastWriteDateFormat.Controls.Add(radioButtonLastWriteDateLocalTime, 0, 0);
			tableLayoutPanelGetLastWriteDateFormat.Location = new Point(408, 47);
			tableLayoutPanelGetLastWriteDateFormat.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanelGetLastWriteDateFormat.Name = "tableLayoutPanelGetLastWriteDateFormat";
			tableLayoutPanelGetLastWriteDateFormat.RowCount = 1;
			tableLayoutPanelGetLastWriteDateFormat.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelGetLastWriteDateFormat.Size = new Size(172, 28);
			tableLayoutPanelGetLastWriteDateFormat.TabIndex = 8;
			// 
			// tableLayoutPanelGetCreationDateFormat
			// 
			tableLayoutPanelGetCreationDateFormat.AccessibleDescription = "Panel for the creation date format of the file";
			tableLayoutPanelGetCreationDateFormat.AccessibleName = "Creation date format panel";
			tableLayoutPanelGetCreationDateFormat.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelGetCreationDateFormat.ColumnCount = 2;
			tableLayoutPanelGetCreationDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelGetCreationDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelGetCreationDateFormat.Controls.Add(radioButtonCreationDateUtc, 1, 0);
			tableLayoutPanelGetCreationDateFormat.Controls.Add(radioButtonCreationDateLocalTime, 0, 0);
			tableLayoutPanelGetCreationDateFormat.Location = new Point(4, 47);
			tableLayoutPanelGetCreationDateFormat.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanelGetCreationDateFormat.Name = "tableLayoutPanelGetCreationDateFormat";
			tableLayoutPanelGetCreationDateFormat.RowCount = 1;
			tableLayoutPanelGetCreationDateFormat.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelGetCreationDateFormat.Size = new Size(172, 28);
			tableLayoutPanelGetCreationDateFormat.TabIndex = 2;
			// 
			// labelCreationDate
			// 
			labelCreationDate.AccessibleDescription = "Indicate the show the creation date of the file";
			labelCreationDate.AccessibleName = "Creation date";
			labelCreationDate.AccessibleRole = AccessibleRole.StaticText;
			labelCreationDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			labelCreationDate.AutoEllipsis = true;
			labelCreationDate.AutoSize = true;
			labelCreationDate.Location = new Point(4, 0);
			labelCreationDate.Margin = new Padding(4, 0, 4, 0);
			labelCreationDate.Name = "labelCreationDate";
			labelCreationDate.Size = new Size(194, 15);
			labelCreationDate.TabIndex = 0;
			labelCreationDate.Text = "Creation date (&1):";
			labelCreationDate.TextAlign = ContentAlignment.TopCenter;
			labelCreationDate.Enter += SetStatusBar_Enter;
			labelCreationDate.Leave += ClearStatusBar_Leave;
			labelCreationDate.MouseEnter += SetStatusBar_Enter;
			labelCreationDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelLastAccessDate
			// 
			labelLastAccessDate.AccessibleDescription = "Indicate the show the last access date of the file";
			labelLastAccessDate.AccessibleName = "Last access date";
			labelLastAccessDate.AccessibleRole = AccessibleRole.StaticText;
			labelLastAccessDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			labelLastAccessDate.AutoEllipsis = true;
			labelLastAccessDate.AutoSize = true;
			labelLastAccessDate.Location = new Point(206, 0);
			labelLastAccessDate.Margin = new Padding(4, 0, 4, 0);
			labelLastAccessDate.Name = "labelLastAccessDate";
			labelLastAccessDate.Size = new Size(194, 15);
			labelLastAccessDate.TabIndex = 3;
			labelLastAccessDate.Text = "Last access date (&2):";
			labelLastAccessDate.TextAlign = ContentAlignment.TopCenter;
			labelLastAccessDate.Enter += SetStatusBar_Enter;
			labelLastAccessDate.Leave += ClearStatusBar_Leave;
			labelLastAccessDate.MouseEnter += SetStatusBar_Enter;
			labelLastAccessDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelLastWriteDate
			// 
			labelLastWriteDate.AccessibleDescription = "Indicate the show the last write date of the file";
			labelLastWriteDate.AccessibleName = "Last write date";
			labelLastWriteDate.AccessibleRole = AccessibleRole.StaticText;
			labelLastWriteDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			labelLastWriteDate.AutoEllipsis = true;
			labelLastWriteDate.AutoSize = true;
			labelLastWriteDate.Location = new Point(408, 0);
			labelLastWriteDate.Margin = new Padding(4, 0, 4, 0);
			labelLastWriteDate.Name = "labelLastWriteDate";
			labelLastWriteDate.Size = new Size(197, 15);
			labelLastWriteDate.TabIndex = 6;
			labelLastWriteDate.Text = "Last write date (&3):";
			labelLastWriteDate.TextAlign = ContentAlignment.TopCenter;
			labelLastWriteDate.Enter += SetStatusBar_Enter;
			labelLastWriteDate.Leave += ClearStatusBar_Leave;
			labelLastWriteDate.MouseEnter += SetStatusBar_Enter;
			labelLastWriteDate.MouseLeave += ClearStatusBar_Leave;
			// 
			// tableLayoutPanelGetLastAccessDateFormat
			// 
			tableLayoutPanelGetLastAccessDateFormat.AccessibleDescription = "Panel for the last access date format of the file";
			tableLayoutPanelGetLastAccessDateFormat.AccessibleName = "Last access date format panel";
			tableLayoutPanelGetLastAccessDateFormat.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanelGetLastAccessDateFormat.ColumnCount = 2;
			tableLayoutPanelGetLastAccessDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelGetLastAccessDateFormat.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelGetLastAccessDateFormat.Controls.Add(radioButtonLastAccessDateUtc, 1, 0);
			tableLayoutPanelGetLastAccessDateFormat.Controls.Add(radioButtonLastAccessDateLocalTime, 0, 0);
			tableLayoutPanelGetLastAccessDateFormat.Location = new Point(206, 47);
			tableLayoutPanelGetLastAccessDateFormat.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanelGetLastAccessDateFormat.Name = "tableLayoutPanelGetLastAccessDateFormat";
			tableLayoutPanelGetLastAccessDateFormat.RowCount = 1;
			tableLayoutPanelGetLastAccessDateFormat.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelGetLastAccessDateFormat.Size = new Size(172, 28);
			tableLayoutPanelGetLastAccessDateFormat.TabIndex = 5;
			// 
			// labelPath
			// 
			labelPath.AccessibleDescription = "Inidicate to show the full path name";
			labelPath.AccessibleName = "Path";
			labelPath.AccessibleRole = AccessibleRole.StaticText;
			labelPath.AutoEllipsis = true;
			labelPath.AutoSize = true;
			labelPath.Location = new Point(10, 16);
			labelPath.Margin = new Padding(4, 0, 4, 0);
			labelPath.Name = "labelPath";
			labelPath.Size = new Size(34, 15);
			labelPath.TabIndex = 0;
			labelPath.Text = "&Path:";
			labelPath.Enter += SetStatusBar_Enter;
			labelPath.Leave += ClearStatusBar_Leave;
			labelPath.MouseEnter += SetStatusBar_Enter;
			labelPath.MouseLeave += ClearStatusBar_Leave;
			// 
			// FdtmForm
			// 
			AccessibleDescription = "Application";
			AccessibleName = "Application";
			AccessibleRole = AccessibleRole.Application;
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(637, 292);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "FdtmForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FileDateTime Manipulator (FDTM)";
			Load += FdtmForm_Load;
			DragDrop += FdtmForm_DragDrop;
			DragOver += FdtmForm_DragOver;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ContentPanel.PerformLayout();
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			tableLayoutPanelSetDate.ResumeLayout(false);
			tableLayoutPanelSetDate.PerformLayout();
			tableLayoutPanelSetLastWriteDateFormat.ResumeLayout(false);
			tableLayoutPanelSetLastWriteDateFormat.PerformLayout();
			tableLayoutPanelSetLastAccessDateFormat.ResumeLayout(false);
			tableLayoutPanelSetLastAccessDateFormat.PerformLayout();
			tableLayoutPanelSetCreationDateFormat.ResumeLayout(false);
			tableLayoutPanelSetCreationDateFormat.PerformLayout();
			panelButtons.ResumeLayout(false);
			tableLayoutPanelGetDate.ResumeLayout(false);
			tableLayoutPanelGetDate.PerformLayout();
			tableLayoutPanelGetLastWriteDateFormat.ResumeLayout(false);
			tableLayoutPanelGetLastWriteDateFormat.PerformLayout();
			tableLayoutPanelGetCreationDateFormat.ResumeLayout(false);
			tableLayoutPanelGetCreationDateFormat.PerformLayout();
			tableLayoutPanelGetLastAccessDateFormat.ResumeLayout(false);
			tableLayoutPanelGetLastAccessDateFormat.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private OpenFileDialog openFileDialog;
		private ToolTip toolTip;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
		private ToolStripContainer toolStripContainer;
		private TableLayoutPanel tableLayoutPanelSetDate;
		private Label labelNewCreationDate;
		private TableLayoutPanel tableLayoutPanelSetLastWriteDateFormat;
		private RadioButton radioButtonNewLastWriteDateUtc;
		private RadioButton radioButtonNewLastWriteDateLocalTime;
		private TableLayoutPanel tableLayoutPanelSetLastAccessDateFormat;
		private RadioButton radioButtonNewLastAccessDateUtc;
		private RadioButton radioButtonNewLastAccessDateLocalTime;
		private DateTimePicker dateTimePickerWrited;
		private DateTimePicker dateTimePickerAccessed;
		private DateTimePicker dateTimePickerCreated;
		private Label labelNewWriteDate;
		private Label labelNewAccessDate;
		private TableLayoutPanel tableLayoutPanelSetCreationDateFormat;
		private RadioButton radioButtonNewCreationDateUtc;
		private RadioButton radioButtonNewCreationDateLocalTime;
		private Panel panelButtons;
		private Button buttonClose;
		private Button buttonInfo;
		private Button buttonApply;
		private TableLayoutPanel tableLayoutPanelGetDate;
		private TableLayoutPanel tableLayoutPanelGetLastWriteDateFormat;
		private RadioButton radioButtonLastWriteDateUtc;
		private RadioButton radioButtonLastWriteDateLocalTime;
		private TableLayoutPanel tableLayoutPanelGetCreationDateFormat;
		private RadioButton radioButtonCreationDateUtc;
		private RadioButton radioButtonCreationDateLocalTime;
		private Label labelCreationDate;
		private Label labelLastAccessDate;
		private TextBox textBoxLastWriteDate;
		private Label labelLastWriteDate;
		private TextBox textBoxLastAccessDate;
		private TextBox textBoxCreationDate;
		private TableLayoutPanel tableLayoutPanelGetLastAccessDateFormat;
		private RadioButton radioButtonLastAccessDateUtc;
		private RadioButton radioButtonLastAccessDateLocalTime;
		private Button buttonSelectFile;
		private TextBox textBoxPath;
		private Label labelPath;
		private Label labelOr;
		private Button buttonSelectFolder;
		private FolderBrowserDialog folderBrowserDialog;
	}
}

