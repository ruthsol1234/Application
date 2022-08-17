namespace Assignment4_on_GUI
{
    partial class Formforusercontrol
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
            this.customCard1 = new Assignment4_on_GUI.CustomCard();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customCard2 = new Assignment4_on_GUI.CustomCard();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customCard1
            // 
            this.customCard1.Description = "Description";
            this.customCard1.Location = new System.Drawing.Point(3, 3);
            this.customCard1.Name = "customCard1";
            this.customCard1.Price = "200";
            this.customCard1.Size = new System.Drawing.Size(426, 364);
            this.customCard1.TabIndex = 0;
            this.customCard1.Title = "Title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.customCard1);
            this.flowLayoutPanel1.Controls.Add(this.customCard2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1018, 391);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // customCard2
            // 
            this.customCard2.Description = null;
            this.customCard2.Location = new System.Drawing.Point(435, 3);
            this.customCard2.Name = "customCard2";
            this.customCard2.Price = null;
            this.customCard2.Size = new System.Drawing.Size(461, 324);
            this.customCard2.TabIndex = 1;
            this.customCard2.Title = null;
            // 
            // Formforusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Formforusercontrol";
            this.Text = "Formforusercontrol";
            this.Load += new System.EventHandler(this.Formforusercontrol_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomCard customCard1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomCard customCard2;
    }
}