namespace WindowsFormsApp1
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
            this.flowLayoutPanelPartners = new System.Windows.Forms.Panel();
            this.rating = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.flowLayoutPanelPartners.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPartners
            // 
            this.flowLayoutPanelPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.flowLayoutPanelPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelPartners.Controls.Add(this.rating);
            this.flowLayoutPanelPartners.Controls.Add(this.phone);
            this.flowLayoutPanelPartners.Controls.Add(this.name);
            this.flowLayoutPanelPartners.Controls.Add(this.percent);
            this.flowLayoutPanelPartners.Controls.Add(this.type);
            this.flowLayoutPanelPartners.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelPartners.Name = "flowLayoutPanelPartners";
            this.flowLayoutPanelPartners.Size = new System.Drawing.Size(858, 145);
            this.flowLayoutPanelPartners.TabIndex = 0;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rating.Location = new System.Drawing.Point(17, 101);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(116, 28);
            this.rating.TabIndex = 0;
            this.rating.Text = "Рейтинг: 10";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(17, 73);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(147, 28);
            this.phone.TabIndex = 0;
            this.phone.Text = "+79512155511";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(17, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 28);
            this.name.TabIndex = 0;
            this.name.Text = "Директор";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent.Location = new System.Drawing.Point(768, 17);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(50, 28);
            this.percent.TabIndex = 0;
            this.percent.Text = "10%";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(17, 17);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(291, 28);
            this.type.TabIndex = 0;
            this.type.Text = "Тип | Наименование партнера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.flowLayoutPanelPartners);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Партнеры";
            this.flowLayoutPanelPartners.ResumeLayout(false);
            this.flowLayoutPanelPartners.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel flowLayoutPanelPartners;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label percent;
    }
}

