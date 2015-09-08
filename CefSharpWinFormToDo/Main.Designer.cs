namespace CefSharpWinFormToDo
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnJQuery = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitTodos = new System.Windows.Forms.SplitContainer();
            this.TodoList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNewTodoTitle = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BrowserConsole = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BrowserAddressLog = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnShowVersionInfo = new System.Windows.Forms.ToolStripButton();
            this.btnHideDevTools = new System.Windows.Forms.ToolStripButton();
            this.btnShowDevTools = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTodos)).BeginInit();
            this.splitTodos.Panel2.SuspendLayout();
            this.splitTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodoList)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowDevTools,
            this.btnHideDevTools,
            this.btnShowVersionInfo,
            this.btnJQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnJQuery
            // 
            this.btnJQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnJQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnJQuery.Image")));
            this.btnJQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJQuery.Name = "btnJQuery";
            this.btnJQuery.Size = new System.Drawing.Size(114, 22);
            this.btnJQuery.Text = "Load jQuery ToDo\'s";
            this.btnJQuery.Click += new System.EventHandler(this.btnJQuery_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBarMessage
            // 
            this.StatusBarMessage.Name = "StatusBarMessage";
            this.StatusBarMessage.Size = new System.Drawing.Size(108, 17);
            this.StatusBarMessage.Text = "Status Bar Message";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitTodos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 614);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitTodos
            // 
            this.splitTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTodos.Location = new System.Drawing.Point(0, 0);
            this.splitTodos.Name = "splitTodos";
            // 
            // splitTodos.Panel2
            // 
            this.splitTodos.Panel2.Controls.Add(this.TodoList);
            this.splitTodos.Panel2.Controls.Add(this.groupBox3);
            this.splitTodos.Size = new System.Drawing.Size(884, 422);
            this.splitTodos.SplitterDistance = 413;
            this.splitTodos.TabIndex = 0;
            // 
            // TodoList
            // 
            this.TodoList.AllowUserToAddRows = false;
            this.TodoList.AllowUserToDeleteRows = false;
            this.TodoList.BackgroundColor = System.Drawing.Color.White;
            this.TodoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodoList.Location = new System.Drawing.Point(0, 52);
            this.TodoList.Name = "TodoList";
            this.TodoList.ReadOnly = true;
            this.TodoList.Size = new System.Drawing.Size(467, 370);
            this.TodoList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNewTodoTitle);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add ToDo Item";
            // 
            // txtNewTodoTitle
            // 
            this.txtNewTodoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNewTodoTitle.Location = new System.Drawing.Point(3, 16);
            this.txtNewTodoTitle.Name = "txtNewTodoTitle";
            this.txtNewTodoTitle.Size = new System.Drawing.Size(461, 20);
            this.txtNewTodoTitle.TabIndex = 0;
            this.txtNewTodoTitle.WordWrap = false;
            this.txtNewTodoTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewTodoTitle_KeyUp);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(884, 188);
            this.splitContainer2.SplitterDistance = 417;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BrowserConsole);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browser Console";
            // 
            // BrowserConsole
            // 
            this.BrowserConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserConsole.Location = new System.Drawing.Point(3, 16);
            this.BrowserConsole.Multiline = true;
            this.BrowserConsole.Name = "BrowserConsole";
            this.BrowserConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BrowserConsole.Size = new System.Drawing.Size(411, 169);
            this.BrowserConsole.TabIndex = 0;
            this.BrowserConsole.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BrowserAddressLog);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browser Address Log";
            // 
            // BrowserAddressLog
            // 
            this.BrowserAddressLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserAddressLog.Location = new System.Drawing.Point(3, 16);
            this.BrowserAddressLog.Multiline = true;
            this.BrowserAddressLog.Name = "BrowserAddressLog";
            this.BrowserAddressLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BrowserAddressLog.Size = new System.Drawing.Size(457, 169);
            this.BrowserAddressLog.TabIndex = 1;
            this.BrowserAddressLog.WordWrap = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnShowVersionInfo
            // 
            this.btnShowVersionInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowVersionInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowVersionInfo.Image")));
            this.btnShowVersionInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowVersionInfo.Name = "btnShowVersionInfo";
            this.btnShowVersionInfo.Size = new System.Drawing.Size(151, 22);
            this.btnShowVersionInfo.Text = "Show Chrome Version Info";
            this.btnShowVersionInfo.Click += new System.EventHandler(this.btnShowVersionInfo_Click);
            // 
            // btnHideDevTools
            // 
            this.btnHideDevTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHideDevTools.Image = ((System.Drawing.Image)(resources.GetObject("btnHideDevTools.Image")));
            this.btnHideDevTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHideDevTools.Name = "btnHideDevTools";
            this.btnHideDevTools.Size = new System.Drawing.Size(90, 22);
            this.btnHideDevTools.Text = "Hide Dev Tools";
            this.btnHideDevTools.Click += new System.EventHandler(this.btnHideDevTools_Click);
            // 
            // btnShowDevTools
            // 
            this.btnShowDevTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowDevTools.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDevTools.Image")));
            this.btnShowDevTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowDevTools.Name = "btnShowDevTools";
            this.btnShowDevTools.Size = new System.Drawing.Size(94, 22);
            this.btnShowDevTools.Text = "Show Dev Tools";
            this.btnShowDevTools.Click += new System.EventHandler(this.btnShowDevTools_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "CefSharp WinForm ToDo Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitTodos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTodos)).EndInit();
            this.splitTodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TodoList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarMessage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BrowserConsole;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox BrowserAddressLog;
        private System.Windows.Forms.SplitContainer splitTodos;
        private System.Windows.Forms.DataGridView TodoList;
        private System.Windows.Forms.ToolStripButton btnJQuery;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNewTodoTitle;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton btnShowDevTools;
        private System.Windows.Forms.ToolStripButton btnHideDevTools;
        private System.Windows.Forms.ToolStripButton btnShowVersionInfo;
    }
}

