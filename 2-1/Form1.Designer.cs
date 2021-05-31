
namespace _2_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.delButt = new System.Windows.Forms.Button();
            this.editButt = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            this.rentButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adress = new System.Windows.Forms.Label();
            this.rented = new System.Windows.Forms.Label();
            this.rentFrom = new System.Windows.Forms.Label();
            this.rentTo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 38;
            this.listBox1.Location = new System.Drawing.Point(83, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(850, 802);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // delButt
            // 
            this.delButt.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delButt.Location = new System.Drawing.Point(94, 1099);
            this.delButt.Name = "delButt";
            this.delButt.Size = new System.Drawing.Size(197, 61);
            this.delButt.TabIndex = 2;
            this.delButt.Text = "Удалить";
            this.delButt.UseVisualStyleBackColor = true;
            this.delButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // editButt
            // 
            this.editButt.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButt.Location = new System.Drawing.Point(94, 1000);
            this.editButt.Name = "editButt";
            this.editButt.Size = new System.Drawing.Size(197, 61);
            this.editButt.TabIndex = 3;
            this.editButt.Text = "Изменить";
            this.editButt.UseVisualStyleBackColor = true;
            this.editButt.Click += new System.EventHandler(this.editButt_Click);
            // 
            // addButt
            // 
            this.addButt.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButt.Location = new System.Drawing.Point(94, 905);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(197, 61);
            this.addButt.TabIndex = 4;
            this.addButt.Text = "Добавить";
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // rentButt
            // 
            this.rentButt.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentButt.Location = new System.Drawing.Point(690, 905);
            this.rentButt.Name = "rentButt";
            this.rentButt.Size = new System.Drawing.Size(243, 61);
            this.rentButt.TabIndex = 5;
            this.rentButt.Text = "Арендовать";
            this.rentButt.UseVisualStyleBackColor = true;
            this.rentButt.Click += new System.EventHandler(this.rentButt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(690, 1000);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.adress.Location = new System.Drawing.Point(1102, 177);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(0, 46);
            this.adress.TabIndex = 7;
            // 
            // rented
            // 
            this.rented.AutoSize = true;
            this.rented.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rented.Location = new System.Drawing.Point(1102, 299);
            this.rented.Name = "rented";
            this.rented.Size = new System.Drawing.Size(0, 46);
            this.rented.TabIndex = 8;
            // 
            // rentFrom
            // 
            this.rentFrom.AutoSize = true;
            this.rentFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rentFrom.Location = new System.Drawing.Point(1102, 417);
            this.rentFrom.Name = "rentFrom";
            this.rentFrom.Size = new System.Drawing.Size(0, 46);
            this.rentFrom.TabIndex = 9;
            // 
            // rentTo
            // 
            this.rentTo.AutoSize = true;
            this.rentTo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rentTo.Location = new System.Drawing.Point(1105, 523);
            this.rentTo.Name = "rentTo";
            this.rentTo.Size = new System.Drawing.Size(0, 46);
            this.rentTo.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1782, 784);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(14, 9);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(690, 1099);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 61);
            this.button3.TabIndex = 12;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 1230);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rentTo);
            this.Controls.Add(this.rentFrom);
            this.Controls.Add(this.rented);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rentButt);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.editButt);
            this.Controls.Add(this.delButt);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button delButt;
        private System.Windows.Forms.Button editButt;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button rentButt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label rented;
        private System.Windows.Forms.Label rentFrom;
        private System.Windows.Forms.Label rentTo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

