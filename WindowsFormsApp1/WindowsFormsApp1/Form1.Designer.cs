
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.totalRecsTab = new System.Windows.Forms.DataGridView();
            this.availableRecsTab = new System.Windows.Forms.DataGridView();
            this.currentAllocationTab = new System.Windows.Forms.DataGridView();
            this.maxNeedsTab = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumProcesses = new System.Windows.Forms.TextBox();
            this.txtNumResources = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessNumber = new System.Windows.Forms.TextBox();
            this.txtResourceType = new System.Windows.Forms.TextBox();
            this.txtRequestAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalRecsDataGridView = new System.Windows.Forms.DataGridView();
            this.availablRecsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.totalRecsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableRecsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentAllocationTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNeedsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalRecsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablRecsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalRecsTab
            // 
            this.totalRecsTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalRecsTab.Location = new System.Drawing.Point(110, 220);
            this.totalRecsTab.Name = "totalRecsTab";
            this.totalRecsTab.RowHeadersWidth = 62;
            this.totalRecsTab.RowTemplate.Height = 28;
            this.totalRecsTab.Size = new System.Drawing.Size(240, 150);
            this.totalRecsTab.TabIndex = 0;
            // 
            // availableRecsTab
            // 
            this.availableRecsTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableRecsTab.Location = new System.Drawing.Point(579, 209);
            this.availableRecsTab.Name = "availableRecsTab";
            this.availableRecsTab.RowHeadersWidth = 62;
            this.availableRecsTab.RowTemplate.Height = 28;
            this.availableRecsTab.Size = new System.Drawing.Size(240, 150);
            this.availableRecsTab.TabIndex = 1;
            // 
            // currentAllocationTab
            // 
            this.currentAllocationTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentAllocationTab.Location = new System.Drawing.Point(110, 413);
            this.currentAllocationTab.Name = "currentAllocationTab";
            this.currentAllocationTab.RowHeadersWidth = 62;
            this.currentAllocationTab.RowTemplate.Height = 28;
            this.currentAllocationTab.Size = new System.Drawing.Size(240, 150);
            this.currentAllocationTab.TabIndex = 2;
            // 
            // maxNeedsTab
            // 
            this.maxNeedsTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxNeedsTab.Location = new System.Drawing.Point(579, 413);
            this.maxNeedsTab.Name = "maxNeedsTab";
            this.maxNeedsTab.RowHeadersWidth = 62;
            this.maxNeedsTab.RowTemplate.Height = 28;
            this.maxNeedsTab.Size = new System.Drawing.Size(240, 150);
            this.maxNeedsTab.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 639);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumProcesses
            // 
            this.txtNumProcesses.Location = new System.Drawing.Point(263, 89);
            this.txtNumProcesses.Name = "txtNumProcesses";
            this.txtNumProcesses.Size = new System.Drawing.Size(106, 26);
            this.txtNumProcesses.TabIndex = 5;
            // 
            // txtNumResources
            // 
            this.txtNumResources.Location = new System.Drawing.Point(746, 92);
            this.txtNumResources.Name = "txtNumResources";
            this.txtNumResources.Size = new System.Drawing.Size(93, 26);
            this.txtNumResources.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "enter num of proccess";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "enter num of resources";
            // 
            // txtProcessNumber
            // 
            this.txtProcessNumber.Location = new System.Drawing.Point(988, 159);
            this.txtProcessNumber.Name = "txtProcessNumber";
            this.txtProcessNumber.Size = new System.Drawing.Size(100, 26);
            this.txtProcessNumber.TabIndex = 9;
            // 
            // txtResourceType
            // 
            this.txtResourceType.Location = new System.Drawing.Point(988, 247);
            this.txtResourceType.Name = "txtResourceType";
            this.txtResourceType.Size = new System.Drawing.Size(100, 26);
            this.txtResourceType.TabIndex = 10;
            // 
            // txtRequestAmount
            // 
            this.txtRequestAmount.Location = new System.Drawing.Point(988, 333);
            this.txtRequestAmount.Name = "txtRequestAmount";
            this.txtRequestAmount.Size = new System.Drawing.Size(100, 26);
            this.txtRequestAmount.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "process num ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "resource num";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(869, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "request num";
            // 
            // totalRecsDataGridView
            // 
            this.totalRecsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalRecsDataGridView.Location = new System.Drawing.Point(110, 220);
            this.totalRecsDataGridView.Name = "totalRecsDataGridView";
            this.totalRecsDataGridView.RowHeadersWidth = 62;
            this.totalRecsDataGridView.RowTemplate.Height = 28;
            this.totalRecsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.totalRecsDataGridView.TabIndex = 15;
            // 
            // availablRecsDataGridView
            // 
            this.availablRecsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availablRecsDataGridView.Location = new System.Drawing.Point(579, 209);
            this.availablRecsDataGridView.Name = "availablRecsDataGridView";
            this.availablRecsDataGridView.RowHeadersWidth = 62;
            this.availablRecsDataGridView.RowTemplate.Height = 28;
            this.availablRecsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.availablRecsDataGridView.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 723);
            this.Controls.Add(this.availablRecsDataGridView);
            this.Controls.Add(this.totalRecsDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRequestAmount);
            this.Controls.Add(this.txtResourceType);
            this.Controls.Add(this.txtProcessNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumResources);
            this.Controls.Add(this.txtNumProcesses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxNeedsTab);
            this.Controls.Add(this.currentAllocationTab);
            this.Controls.Add(this.availableRecsTab);
            this.Controls.Add(this.totalRecsTab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.totalRecsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableRecsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentAllocationTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNeedsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalRecsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablRecsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView totalRecsTab;
        private System.Windows.Forms.DataGridView availableRecsTab;
        private System.Windows.Forms.DataGridView currentAllocationTab;
        private System.Windows.Forms.DataGridView maxNeedsTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumProcesses;
        private System.Windows.Forms.TextBox txtNumResources;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessNumber;
        private System.Windows.Forms.TextBox txtResourceType;
        private System.Windows.Forms.TextBox txtRequestAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView totalRecsDataGridView;
        private System.Windows.Forms.DataGridView availablRecsDataGridView;
    }
}

