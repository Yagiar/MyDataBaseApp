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
            this.tbCountPodhod = new System.Windows.Forms.TextBox();
            this.tbCountPovtor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butReturn
            // 
            this.butReturn.Location = new System.Drawing.Point(204, 270);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(75, 23);
            this.butReturn.TabIndex = 7;
            this.butReturn.Text = "Назад";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // butAddProgramm
            // 
            this.butAddProgramm.Location = new System.Drawing.Point(36, 215);
            this.butAddProgramm.Name = "butAddProgramm";
            this.butAddProgramm.Size = new System.Drawing.Size(408, 23);
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
            this.days_collection.Location = new System.Drawing.Point(36, 129);
            this.days_collection.Name = "days_collection";
            this.days_collection.Size = new System.Drawing.Size(211, 68);
            this.days_collection.TabIndex = 5;
            // 
            // listBoxExercises
            // 
            this.listBoxExercises.FormattingEnabled = true;
            this.listBoxExercises.ItemHeight = 16;
            this.listBoxExercises.Location = new System.Drawing.Point(36, 28);
            this.listBoxExercises.Name = "listBoxExercises";
            this.listBoxExercises.Size = new System.Drawing.Size(211, 68);
            this.listBoxExercises.TabIndex = 4;
            // 
            // tbCountPodhod
            // 
            this.tbCountPodhod.Location = new System.Drawing.Point(280, 41);
            this.tbCountPodhod.Name = "tbCountPodhod";
            this.tbCountPodhod.Size = new System.Drawing.Size(164, 22);
            this.tbCountPodhod.TabIndex = 8;
            // 
            // tbCountPovtor
            // 
            this.tbCountPovtor.Location = new System.Drawing.Point(280, 101);
            this.tbCountPovtor.Name = "tbCountPovtor";
            this.tbCountPovtor.Size = new System.Drawing.Size(164, 22);
            this.tbCountPovtor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Список упражнений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дни недели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество подходов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество повторений";
            // 
            // addExerProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCountPovtor);
            this.Controls.Add(this.tbCountPodhod);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.butAddProgramm);
            this.Controls.Add(this.days_collection);
            this.Controls.Add(this.listBoxExercises);
            this.Name = "addExerProgramm";
            this.Text = "addExerProgramm";
            this.Load += new System.EventHandler(this.addExerProgramm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Button butAddProgramm;
        private System.Windows.Forms.ListBox days_collection;
        private System.Windows.Forms.ListBox listBoxExercises;
        private System.Windows.Forms.TextBox tbCountPodhod;
        private System.Windows.Forms.TextBox tbCountPovtor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}