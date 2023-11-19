namespace MyDataBaseApp
{
    partial class planForm
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
            this.panelProducts = new System.Windows.Forms.Panel();
            this.panelExercise = new System.Windows.Forms.Panel();
            this.labelBZU = new System.Windows.Forms.Label();
            this.butReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelProducts
            // 
            this.panelProducts.Location = new System.Drawing.Point(12, 77);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(488, 361);
            this.panelProducts.TabIndex = 0;
            // 
            // panelExercise
            // 
            this.panelExercise.Location = new System.Drawing.Point(506, 77);
            this.panelExercise.Name = "panelExercise";
            this.panelExercise.Size = new System.Drawing.Size(642, 361);
            this.panelExercise.TabIndex = 1;
            // 
            // labelBZU
            // 
            this.labelBZU.AutoSize = true;
            this.labelBZU.Location = new System.Drawing.Point(12, 47);
            this.labelBZU.Name = "labelBZU";
            this.labelBZU.Size = new System.Drawing.Size(44, 16);
            this.labelBZU.TabIndex = 2;
            this.labelBZU.Text = "label1";
            // 
            // butReturn
            // 
            this.butReturn.Location = new System.Drawing.Point(12, 472);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(131, 41);
            this.butReturn.TabIndex = 3;
            this.butReturn.Text = "Назад";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // planForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 525);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.labelBZU);
            this.Controls.Add(this.panelExercise);
            this.Controls.Add(this.panelProducts);
            this.Name = "planForm";
            this.Text = "План питания";
            this.Load += new System.EventHandler(this.planForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelExercise;
        private System.Windows.Forms.Label labelBZU;
        private System.Windows.Forms.Button butReturn;
    }
}