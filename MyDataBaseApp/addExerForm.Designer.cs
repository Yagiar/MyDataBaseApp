namespace MyDataBaseApp
{
    partial class addExerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameExer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameMusGroup = new System.Windows.Forms.TextBox();
            this.but_add_exer = new System.Windows.Forms.Button();
            this.but_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название упражнения";
            // 
            // tbNameExer
            // 
            this.tbNameExer.Location = new System.Drawing.Point(12, 38);
            this.tbNameExer.Name = "tbNameExer";
            this.tbNameExer.Size = new System.Drawing.Size(249, 22);
            this.tbNameExer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Группа мышц";
            // 
            // tbNameMusGroup
            // 
            this.tbNameMusGroup.Location = new System.Drawing.Point(12, 95);
            this.tbNameMusGroup.Name = "tbNameMusGroup";
            this.tbNameMusGroup.Size = new System.Drawing.Size(249, 22);
            this.tbNameMusGroup.TabIndex = 4;
            // 
            // but_add_exer
            // 
            this.but_add_exer.Location = new System.Drawing.Point(12, 138);
            this.but_add_exer.Name = "but_add_exer";
            this.but_add_exer.Size = new System.Drawing.Size(168, 52);
            this.but_add_exer.TabIndex = 9;
            this.but_add_exer.Text = "Добавить упражнение";
            this.but_add_exer.UseVisualStyleBackColor = true;
            this.but_add_exer.Click += new System.EventHandler(this.but_add_exer_Click);
            // 
            // but_return
            // 
            this.but_return.Location = new System.Drawing.Point(215, 138);
            this.but_return.Name = "but_return";
            this.but_return.Size = new System.Drawing.Size(155, 52);
            this.but_return.TabIndex = 10;
            this.but_return.Text = "Вернуться";
            this.but_return.UseVisualStyleBackColor = true;
            this.but_return.Click += new System.EventHandler(this.but_return_Click);
            // 
            // addExerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 223);
            this.Controls.Add(this.but_return);
            this.Controls.Add(this.but_add_exer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameMusGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameExer);
            this.Name = "addExerForm";
            this.Text = "addExerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameExer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameMusGroup;
        private System.Windows.Forms.Button but_add_exer;
        private System.Windows.Forms.Button but_return;
    }
}