using System.Windows.Forms;

namespace coursework
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btGenerate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1, this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addCompanyToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.addToolStripMenuItem.Text = "Edit";
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.btAdd, this.btDelete, this.btGenerate});
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addCompanyToolStripMenuItem.Text = "Company";
            // 
            // btAdd
            // 
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 22);
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(121, 22);
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btGenerate
            // 
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(121, 22);
            this.btGenerate.Text = "Generate";
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private System.Windows.Forms.ToolStripMenuItem btGenerate;

        private System.Windows.Forms.ToolStripMenuItem btAdd;

        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}