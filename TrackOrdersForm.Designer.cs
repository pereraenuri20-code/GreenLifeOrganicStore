namespace GreenLifeOrganicStore
{
    partial class TrackOrdersForm
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
            this.dgvMyOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyOrders
            // 
            this.dgvMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOrders.Location = new System.Drawing.Point(105, 74);
            this.dgvMyOrders.Name = "dgvMyOrders";
            this.dgvMyOrders.RowHeadersWidth = 62;
            this.dgvMyOrders.RowTemplate.Height = 28;
            this.dgvMyOrders.Size = new System.Drawing.Size(240, 150);
            this.dgvMyOrders.TabIndex = 0;
            this.dgvMyOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyOrders_CellContentClick);
            // 
            // TrackOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMyOrders);
            this.Name = "TrackOrdersForm";
            this.Text = "TrackOrdersForm";
            this.Load += new System.EventHandler(this.TrackOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyOrders;
    }
}