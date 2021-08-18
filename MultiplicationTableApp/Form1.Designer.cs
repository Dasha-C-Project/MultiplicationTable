
namespace MultiplicationTableApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.startText = new System.Windows.Forms.Label();
            this.successText = new System.Windows.Forms.Label();
            this.startPicture = new System.Windows.Forms.PictureBox();
            this.failText = new System.Windows.Forms.Label();
            this.successPicture = new System.Windows.Forms.PictureBox();
            this.failPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.Label();
            this.firstNumber = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.markText = new System.Windows.Forms.Label();
            this.rightQuantityText = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.startText);
            this.groupBox1.Controls.Add(this.successText);
            this.groupBox1.Controls.Add(this.startPicture);
            this.groupBox1.Controls.Add(this.failText);
            this.groupBox1.Controls.Add(this.successPicture);
            this.groupBox1.Controls.Add(this.failPicture);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(320, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.startButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(145, 348);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 33);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Начать!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startText
            // 
            this.startText.AutoSize = true;
            this.startText.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startText.Location = new System.Drawing.Point(122, 289);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(181, 36);
            this.startText.TabIndex = 4;
            this.startText.Text = "Давай играть!";
            // 
            // successText
            // 
            this.successText.AutoSize = true;
            this.successText.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.successText.Location = new System.Drawing.Point(144, 273);
            this.successText.Name = "successText";
            this.successText.Size = new System.Drawing.Size(137, 72);
            this.successText.TabIndex = 2;
            this.successText.Text = "Молодец! \r\nПравильно!";
            this.successText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.successText.Visible = false;
            // 
            // startPicture
            // 
            this.startPicture.Image = global::MultiplicationTableApp.Properties.Resources.start;
            this.startPicture.Location = new System.Drawing.Point(94, 63);
            this.startPicture.Name = "startPicture";
            this.startPicture.Size = new System.Drawing.Size(227, 232);
            this.startPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPicture.TabIndex = 5;
            this.startPicture.TabStop = false;
            // 
            // failText
            // 
            this.failText.AutoSize = true;
            this.failText.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.failText.Location = new System.Drawing.Point(102, 273);
            this.failText.Name = "failText";
            this.failText.Size = new System.Drawing.Size(219, 36);
            this.failText.TabIndex = 1;
            this.failText.Text = "Попробуй еще раз!";
            this.failText.Visible = false;
            // 
            // successPicture
            // 
            this.successPicture.Image = global::MultiplicationTableApp.Properties.Resources.success;
            this.successPicture.Location = new System.Drawing.Point(108, 53);
            this.successPicture.Name = "successPicture";
            this.successPicture.Size = new System.Drawing.Size(227, 233);
            this.successPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.successPicture.TabIndex = 3;
            this.successPicture.TabStop = false;
            this.successPicture.Visible = false;
            // 
            // failPicture
            // 
            this.failPicture.Image = global::MultiplicationTableApp.Properties.Resources.fail;
            this.failPicture.Location = new System.Drawing.Point(85, 63);
            this.failPicture.Name = "failPicture";
            this.failPicture.Size = new System.Drawing.Size(211, 223);
            this.failPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.failPicture.TabIndex = 0;
            this.failPicture.TabStop = false;
            this.failPicture.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nextButton);
            this.groupBox2.Controls.Add(this.checkButton);
            this.groupBox2.Controls.Add(this.resultBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.secondNumber);
            this.groupBox2.Controls.Add(this.firstNumber);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(320, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(408, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.LightSalmon;
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(182, 167);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(133, 33);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Следующий";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkButton.Enabled = false;
            this.checkButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkButton.Location = new System.Drawing.Point(37, 167);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(136, 33);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(241, 97);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(74, 64);
            this.resultBox.TabIndex = 4;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(191, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 56);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "*";
            // 
            // secondNumber
            // 
            this.secondNumber.AutoSize = true;
            this.secondNumber.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNumber.Location = new System.Drawing.Point(128, 100);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(45, 56);
            this.secondNumber.TabIndex = 1;
            this.secondNumber.Text = "-";
            // 
            // firstNumber
            // 
            this.firstNumber.AutoSize = true;
            this.firstNumber.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNumber.Location = new System.Drawing.Point(31, 100);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(45, 56);
            this.firstNumber.TabIndex = 0;
            this.firstNumber.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.markText);
            this.groupBox3.Controls.Add(this.rightQuantityText);
            this.groupBox3.Controls.Add(this.quantityText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.endButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(320, 220);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Size = new System.Drawing.Size(408, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статистика";
            // 
            // markText
            // 
            this.markText.AutoSize = true;
            this.markText.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markText.Location = new System.Drawing.Point(262, 89);
            this.markText.Name = "markText";
            this.markText.Size = new System.Drawing.Size(22, 26);
            this.markText.TabIndex = 14;
            this.markText.Text = "-";
            // 
            // rightQuantityText
            // 
            this.rightQuantityText.AutoSize = true;
            this.rightQuantityText.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightQuantityText.Location = new System.Drawing.Point(154, 86);
            this.rightQuantityText.Name = "rightQuantityText";
            this.rightQuantityText.Size = new System.Drawing.Size(22, 26);
            this.rightQuantityText.TabIndex = 13;
            this.rightQuantityText.Text = "-";
            // 
            // quantityText
            // 
            this.quantityText.AutoSize = true;
            this.quantityText.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityText.Location = new System.Drawing.Point(55, 86);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(22, 26);
            this.quantityText.TabIndex = 12;
            this.quantityText.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(250, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Оценка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(134, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "К-ство \r\nправильных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(37, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 42);
            this.label6.TabIndex = 9;
            this.label6.Text = "К-ство \r\nответов";
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.Color.LightSalmon;
            this.endButton.Enabled = false;
            this.endButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endButton.Location = new System.Drawing.Point(37, 128);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(136, 33);
            this.endButton.TabIndex = 8;
            this.endButton.Text = "Завершить!";
            this.endButton.UseVisualStyleBackColor = false;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiplicationTableApp.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 409);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренажер таблицы умножения";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox failPicture;
        private System.Windows.Forms.Label failText;
        private System.Windows.Forms.PictureBox successPicture;
        private System.Windows.Forms.Label successText;
        private System.Windows.Forms.PictureBox startPicture;
        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label secondNumber;
        private System.Windows.Forms.Label firstNumber;
        private System.Windows.Forms.Label markText;
        private System.Windows.Forms.Label rightQuantityText;
        private System.Windows.Forms.Label quantityText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button endButton;
    }
}

