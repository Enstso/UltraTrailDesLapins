namespace Utdl.View {
    partial class FeditLapin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblSurnom = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDossard = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbSurnom = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbDossard = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(86, 11);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(56, 20);
            this.tbId.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 12);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "id :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(98, 160);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(73, 26);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblSurnom
            // 
            this.lblSurnom.AutoSize = true;
            this.lblSurnom.Location = new System.Drawing.Point(14, 42);
            this.lblSurnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurnom.Name = "lblSurnom";
            this.lblSurnom.Size = new System.Drawing.Size(47, 13);
            this.lblSurnom.TabIndex = 8;
            this.lblSurnom.Text = "surnom :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(14, 71);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 13);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "age :";
            // 
            // lblDossard
            // 
            this.lblDossard.AutoSize = true;
            this.lblDossard.Location = new System.Drawing.Point(14, 100);
            this.lblDossard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDossard.Name = "lblDossard";
            this.lblDossard.Size = new System.Drawing.Size(50, 13);
            this.lblDossard.TabIndex = 10;
            this.lblDossard.Text = "dossard :";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(14, 128);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(49, 13);
            this.lblPosition.TabIndex = 11;
            this.lblPosition.Text = "position :";
            // 
            // tbSurnom
            // 
            this.tbSurnom.Location = new System.Drawing.Point(86, 40);
            this.tbSurnom.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurnom.Name = "tbSurnom";
            this.tbSurnom.Size = new System.Drawing.Size(56, 20);
            this.tbSurnom.TabIndex = 12;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(86, 69);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(56, 20);
            this.tbAge.TabIndex = 13;
            // 
            // tbDossard
            // 
            this.tbDossard.Location = new System.Drawing.Point(86, 99);
            this.tbDossard.Margin = new System.Windows.Forms.Padding(2);
            this.tbDossard.Name = "tbDossard";
            this.tbDossard.ReadOnly = true;
            this.tbDossard.Size = new System.Drawing.Size(56, 20);
            this.tbDossard.TabIndex = 14;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(86, 128);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.ReadOnly = true;
            this.tbPosition.Size = new System.Drawing.Size(56, 20);
            this.tbPosition.TabIndex = 15;
            // 
            // FeditLapin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 233);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbDossard);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbSurnom);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDossard);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSurnom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnValider);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FeditLapin";
            this.Text = "FeditLapin";
            this.Load += new System.EventHandler(this.FeditLapin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblSurnom;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDossard;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbSurnom;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbDossard;
        private System.Windows.Forms.TextBox tbPosition;
    }
}