using System.ComponentModel;

namespace coursework
{
    partial class CompanyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.Label();
            this.tbBudget = new System.Windows.Forms.Label();
            this.tbEmployersNumber = new System.Windows.Forms.Label();
            this.tbProjectsNumber = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox1.Location = new System.Drawing.Point(345, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 31);
            this.textBox1.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbName.Location = new System.Drawing.Point(137, 99);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 30);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Company Name";
            // 
            // tbBudget
            // 
            this.tbBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbBudget.Location = new System.Drawing.Point(137, 152);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(183, 30);
            this.tbBudget.TabIndex = 5;
            this.tbBudget.Text = "Company Budget";
            // 
            // tbEmployersNumber
            // 
            this.tbEmployersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbEmployersNumber.Location = new System.Drawing.Point(137, 203);
            this.tbEmployersNumber.Name = "tbEmployersNumber";
            this.tbEmployersNumber.Size = new System.Drawing.Size(202, 30);
            this.tbEmployersNumber.TabIndex = 6;
            this.tbEmployersNumber.Text = "Employers Number";
            // 
            // tbProjectsNumber
            // 
            this.tbProjectsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbProjectsNumber.Location = new System.Drawing.Point(137, 251);
            this.tbProjectsNumber.Name = "tbProjectsNumber";
            this.tbProjectsNumber.Size = new System.Drawing.Size(183, 30);
            this.tbProjectsNumber.TabIndex = 7;
            this.tbProjectsNumber.Text = "Projects Number";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btAdd.Location = new System.Drawing.Point(251, 345);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(161, 55);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "ADD";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btCancel.Location = new System.Drawing.Point(418, 345);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(161, 55);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.numericUpDown1.Location = new System.Drawing.Point(345, 152);
            this.numericUpDown1.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(148, 31);
            this.numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.numericUpDown2.Location = new System.Drawing.Point(345, 201);
            this.numericUpDown2.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(148, 31);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.numericUpDown3.Location = new System.Drawing.Point(345, 249);
            this.numericUpDown3.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(148, 31);
            this.numericUpDown3.TabIndex = 12;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbProjectsNumber);
            this.Controls.Add(this.tbEmployersNumber);
            this.Controls.Add(this.tbBudget);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.textBox1);
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancel;

        private System.Windows.Forms.Label tbName;
        private System.Windows.Forms.Label tbBudget;
        private System.Windows.Forms.Label tbEmployersNumber;
        private System.Windows.Forms.Label tbProjectsNumber;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}