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
            btnDefineStartOrder = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBoxOrder
            // 
            listBoxOrder.FormattingEnabled = true;
            listBoxOrder.Location = new System.Drawing.Point(21, 29);
            listBoxOrder.Name = "listBoxOrder";
            listBoxOrder.Size = new System.Drawing.Size(1170, 932);
            listBoxOrder.TabIndex = 0;
            // 
            // btnDefineStartOrder
            // 
            btnDefineStartOrder.Location = new System.Drawing.Point(21, 987);
            btnDefineStartOrder.Name = "btnDefineStartOrder";
            btnDefineStartOrder.Size = new System.Drawing.Size(359, 71);
            btnDefineStartOrder.TabIndex = 1;
            btnDefineStartOrder.Text = "Mit diesem Ordner anfangen";
            btnDefineStartOrder.UseVisualStyleBackColor = true;
            btnDefineStartOrder.Click += btnDefineStartOrder_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1224, 1094);
            Controls.Add(btnDefineStartOrder);
            Controls.Add(listBoxOrder);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Button btnDefineStartOrder;
    }
}