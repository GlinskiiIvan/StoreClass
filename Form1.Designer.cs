namespace StoreClass
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.label_WorkSchedule = new System.Windows.Forms.Label();
            this.label_AdditionalServices = new System.Windows.Forms.Label();
            this.label_NumberParkingSpaces = new System.Windows.Forms.Label();
            this.label_NumberEmployees = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_WorkSchedule = new System.Windows.Forms.TextBox();
            this.textBox_NumberParkingSpaces = new System.Windows.Forms.TextBox();
            this.textBox_NumberEmployees = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_AdditionalServices = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.textBoxFindAdress = new System.Windows.Forms.TextBox();
            this.label_FIndAdress = new System.Windows.Forms.Label();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(12, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(84, 21);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Название";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Adress.Location = new System.Drawing.Point(12, 44);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(60, 21);
            this.label_Adress.TabIndex = 1;
            this.label_Adress.Text = "Адрес";
            // 
            // label_WorkSchedule
            // 
            this.label_WorkSchedule.AutoSize = true;
            this.label_WorkSchedule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WorkSchedule.Location = new System.Drawing.Point(12, 114);
            this.label_WorkSchedule.Name = "label_WorkSchedule";
            this.label_WorkSchedule.Size = new System.Drawing.Size(133, 21);
            this.label_WorkSchedule.TabIndex = 2;
            this.label_WorkSchedule.Text = "График работы";
            // 
            // label_AdditionalServices
            // 
            this.label_AdditionalServices.AutoSize = true;
            this.label_AdditionalServices.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AdditionalServices.Location = new System.Drawing.Point(12, 219);
            this.label_AdditionalServices.Name = "label_AdditionalServices";
            this.label_AdditionalServices.Size = new System.Drawing.Size(206, 21);
            this.label_AdditionalServices.TabIndex = 6;
            this.label_AdditionalServices.Text = "Дополнительные услуги";
            // 
            // label_NumberParkingSpaces
            // 
            this.label_NumberParkingSpaces.AutoSize = true;
            this.label_NumberParkingSpaces.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberParkingSpaces.Location = new System.Drawing.Point(12, 184);
            this.label_NumberParkingSpaces.Name = "label_NumberParkingSpaces";
            this.label_NumberParkingSpaces.Size = new System.Drawing.Size(259, 21);
            this.label_NumberParkingSpaces.TabIndex = 5;
            this.label_NumberParkingSpaces.Text = "Количество парковочных мест";
            // 
            // label_NumberEmployees
            // 
            this.label_NumberEmployees.AutoSize = true;
            this.label_NumberEmployees.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberEmployees.Location = new System.Drawing.Point(12, 149);
            this.label_NumberEmployees.Name = "label_NumberEmployees";
            this.label_NumberEmployees.Size = new System.Drawing.Size(203, 21);
            this.label_NumberEmployees.TabIndex = 4;
            this.label_NumberEmployees.Text = "Количество работников";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(277, 6);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(207, 29);
            this.textBox_Name.TabIndex = 7;
            // 
            // textBox_WorkSchedule
            // 
            this.textBox_WorkSchedule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_WorkSchedule.Location = new System.Drawing.Point(277, 111);
            this.textBox_WorkSchedule.Name = "textBox_WorkSchedule";
            this.textBox_WorkSchedule.Size = new System.Drawing.Size(207, 29);
            this.textBox_WorkSchedule.TabIndex = 9;
            // 
            // textBox_NumberParkingSpaces
            // 
            this.textBox_NumberParkingSpaces.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberParkingSpaces.Location = new System.Drawing.Point(277, 181);
            this.textBox_NumberParkingSpaces.Name = "textBox_NumberParkingSpaces";
            this.textBox_NumberParkingSpaces.Size = new System.Drawing.Size(207, 29);
            this.textBox_NumberParkingSpaces.TabIndex = 10;
            // 
            // textBox_NumberEmployees
            // 
            this.textBox_NumberEmployees.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberEmployees.Location = new System.Drawing.Point(277, 146);
            this.textBox_NumberEmployees.Name = "textBox_NumberEmployees";
            this.textBox_NumberEmployees.Size = new System.Drawing.Size(207, 29);
            this.textBox_NumberEmployees.TabIndex = 11;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Adress.Location = new System.Drawing.Point(277, 41);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(207, 29);
            this.textBox_Adress.TabIndex = 12;
            // 
            // textBox_AdditionalServices
            // 
            this.textBox_AdditionalServices.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AdditionalServices.Location = new System.Drawing.Point(277, 216);
            this.textBox_AdditionalServices.Name = "textBox_AdditionalServices";
            this.textBox_AdditionalServices.Size = new System.Drawing.Size(207, 29);
            this.textBox_AdditionalServices.TabIndex = 13;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(16, 264);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(468, 38);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Добавить магазин";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Find
            // 
            this.button_Find.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Find.Location = new System.Drawing.Point(700, 40);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(269, 38);
            this.button_Find.TabIndex = 17;
            this.button_Find.Text = "Найти магазин";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // textBoxFindAdress
            // 
            this.textBoxFindAdress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFindAdress.Location = new System.Drawing.Point(762, 6);
            this.textBoxFindAdress.Name = "textBoxFindAdress";
            this.textBoxFindAdress.Size = new System.Drawing.Size(207, 29);
            this.textBoxFindAdress.TabIndex = 16;
            // 
            // label_FIndAdress
            // 
            this.label_FIndAdress.AutoSize = true;
            this.label_FIndAdress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FIndAdress.Location = new System.Drawing.Point(696, 9);
            this.label_FIndAdress.Name = "label_FIndAdress";
            this.label_FIndAdress.Size = new System.Drawing.Size(60, 21);
            this.label_FIndAdress.TabIndex = 15;
            this.label_FIndAdress.Text = "Адрес";
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Answer.Location = new System.Drawing.Point(543, 84);
            this.textBox_Answer.Multiline = true;
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(547, 161);
            this.textBox_Answer.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 315);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.textBoxFindAdress);
            this.Controls.Add(this.label_FIndAdress);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_AdditionalServices);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_NumberEmployees);
            this.Controls.Add(this.textBox_NumberParkingSpaces);
            this.Controls.Add(this.textBox_WorkSchedule);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_AdditionalServices);
            this.Controls.Add(this.label_NumberParkingSpaces);
            this.Controls.Add(this.label_NumberEmployees);
            this.Controls.Add(this.label_WorkSchedule);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label label_WorkSchedule;
        private System.Windows.Forms.Label label_AdditionalServices;
        private System.Windows.Forms.Label label_NumberParkingSpaces;
        private System.Windows.Forms.Label label_NumberEmployees;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_WorkSchedule;
        private System.Windows.Forms.TextBox textBox_NumberParkingSpaces;
        private System.Windows.Forms.TextBox textBox_NumberEmployees;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_AdditionalServices;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.TextBox textBoxFindAdress;
        private System.Windows.Forms.Label label_FIndAdress;
        private System.Windows.Forms.TextBox textBox_Answer;
    }
}

