namespace Backup_Programm
{
    partial class Form2
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
            listBoxOrder = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // listBoxOrder
            // 
            listBoxOrder.FormattingEnabled = true;
            listBoxOrder.ItemHeight = 41;
            listBoxOrder.Location = new System.Drawing.Point(27, 37);
            listBoxOrder.Margin = new System.Windows.Forms.Padding(4);
            listBoxOrder.Name = "listBoxOrder";
            listBoxOrder.Size = new System.Drawing.Size(1529, 1193);
            listBoxOrder.TabIndex = 0;
            listBoxOrder.SelectedIndexChanged += listBoxOrder_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1601, 1402);
            Controls.Add(listBoxOrder);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrder;
    }
}