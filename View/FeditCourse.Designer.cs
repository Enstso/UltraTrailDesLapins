namespace Utdl.View {
    partial class FeditCourse {
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
            this.btnValider = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(109, 71);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(73, 26);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 9);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "id :";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(7, 41);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(53, 13);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "distance :";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(65, 7);
            this.tbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(56, 20);
            this.tbId.TabIndex = 4;
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(65, 38);
            this.tbDistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(56, 20);
            this.tbDistance.TabIndex = 5;
            // 
            // FeditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 119);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnValider);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FeditCourse";
            this.Text = "edit course";
            this.Load += new System.EventHandler(this.FeditCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDistance;
    }
}