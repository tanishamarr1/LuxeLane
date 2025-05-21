namespace LuxeLane
{
    partial class FormNotiExample
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
            notificationGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)notificationGrid).BeginInit();
            SuspendLayout();
            // 
            // notificationGrid
            // 
            notificationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notificationGrid.Location = new Point(12, 12);
            notificationGrid.Name = "notificationGrid";
            notificationGrid.Size = new Size(837, 480);
            notificationGrid.TabIndex = 0;
            // 
            // FormNotiExample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 504);
            Controls.Add(notificationGrid);
            Name = "FormNotiExample";
            Text = "FormNotiExample";
            Load += FormNotiExample_Load;
            ((System.ComponentModel.ISupportInitialize)notificationGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView notificationGrid;
    }
}