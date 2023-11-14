namespace MyDataBaseApp
{
    partial class addExerProgramm
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
            this.butReturn = new System.Windows.Forms.Button();
            this.butAddProgramm = new System.Windows.Forms.Button();
            this.days_collection = new System.Windows.Forms.ListBox();
            this.listBoxExercises = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // butReturn
            // 
            this.butReturn.Location = new System.Drawing.Point(172, 231);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(75, 23);
            this.butReturn.TabIndex = 7;
            this.butReturn.Text = "Назад";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // butAddProgramm
            // 
            this.butAddProgramm.Location = new System.Drawing.Point(36, 193);
            this.butAddProgramm.Name = "butAddProgramm";
            this.butAddProgramm.Size = new System.Drawing.Size(211, 23);
            this.butAddProgramm.TabIndex = 6;
            this.butAddProgramm.Text = "Добавить";
            this.butAddProgramm.UseVisualStyleBackColor = true;
            this.butAddProgramm.Click += new System.EventHandler(this.butAddProgramm_Click);
            // 
            // days_collection
            // 
            this.days_collection.FormattingEnabled = true;
            this.days_collection.ItemHeight = 16;
            this.days_collection.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.days_collection.Location = new System.Drawing.Point(36, 101);
            this.days_collection.Name = "days_collection";
            this.days_collection.Size = new System.Drawing.Size(211, 68);
            this.days_collection.TabIndex = 5;
            // 
            // listBoxExercises
            // 
            this.listBoxExercises.FormattingEnabled = true;
            this.listBoxExercises.ItemHeight = 16;
            this.listBoxExercises.Location = new System.Drawing.Point(36, 12);
            this.listBoxExercises.Name = "listBoxExercises";
            this.listBoxExercises.Size = new System.Drawing.Size(211, 68);
            this.listBoxExercises.TabIndex = 4;
            // 
            // addExerProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 303);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.butAddProgramm);
            this.Controls.Add(this.days_collection);
            this.Controls.Add(this.listBoxExercises);
            this.Name = "addExerProgramm";
            this.Text = "addExerProgramm";
            this.Load += new System.EventHandler(this.addExerProgramm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Button butAddProgramm;
        private System.Windows.Forms.ListBox days_collection;
        private System.Windows.Forms.ListBox listBoxExercises;
    }
}