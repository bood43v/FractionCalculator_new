/// Обыкновенные дроби и операции над ними
/// Файл формы
/// @author Будаев Г.Б.
using classFraction;

namespace FractionCalculator
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.button_add = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_compare = new System.Windows.Forms.Button();
            this.textBox_num_res = new System.Windows.Forms.TextBox();
            this.textBox_denom_res = new System.Windows.Forms.TextBox();
            this.richTextBox_report = new System.Windows.Forms.RichTextBox();
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.textBox_denom1 = new System.Windows.Forms.TextBox();
            this.textBox_num2 = new System.Windows.Forms.TextBox();
            this.textBox_denom2 = new System.Windows.Forms.TextBox();
            this.button_convertDouble = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guide_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(315, 35);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(126, 43);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sub.Location = new System.Drawing.Point(315, 92);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(126, 43);
            this.button_sub.TabIndex = 2;
            this.button_sub.Text = "˗";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_mult
            // 
            this.button_mult.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mult.Location = new System.Drawing.Point(447, 35);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(126, 43);
            this.button_mult.TabIndex = 3;
            this.button_mult.Text = "✱";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_div.Location = new System.Drawing.Point(447, 92);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(126, 43);
            this.button_div.TabIndex = 4;
            this.button_div.Text = "÷";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_compare
            // 
            this.button_compare.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_compare.Location = new System.Drawing.Point(315, 150);
            this.button_compare.Name = "button_compare";
            this.button_compare.Size = new System.Drawing.Size(258, 43);
            this.button_compare.TabIndex = 5;
            this.button_compare.Text = "Сравнить";
            this.button_compare.UseVisualStyleBackColor = true;
            this.button_compare.Click += new System.EventHandler(this.button_compare_Click);
            // 
            // textBox_num_res
            // 
            this.textBox_num_res.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_num_res.Font = new System.Drawing.Font("Inter Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_num_res.Location = new System.Drawing.Point(600, 37);
            this.textBox_num_res.Multiline = true;
            this.textBox_num_res.Name = "textBox_num_res";
            this.textBox_num_res.ReadOnly = true;
            this.textBox_num_res.Size = new System.Drawing.Size(113, 41);
            this.textBox_num_res.TabIndex = 11;
            this.textBox_num_res.TabStop = false;
            this.textBox_num_res.Text = "23";
            this.textBox_num_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_denom_res
            // 
            this.textBox_denom_res.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_denom_res.Font = new System.Drawing.Font("Inter Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_denom_res.Location = new System.Drawing.Point(600, 93);
            this.textBox_denom_res.Multiline = true;
            this.textBox_denom_res.Name = "textBox_denom_res";
            this.textBox_denom_res.ReadOnly = true;
            this.textBox_denom_res.Size = new System.Drawing.Size(113, 42);
            this.textBox_denom_res.TabIndex = 12;
            this.textBox_denom_res.TabStop = false;
            this.textBox_denom_res.Text = "20";
            this.textBox_denom_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox_report
            // 
            this.richTextBox_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBox_report.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_report.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_report.Location = new System.Drawing.Point(34, 219);
            this.richTextBox_report.Name = "richTextBox_report";
            this.richTextBox_report.ReadOnly = true;
            this.richTextBox_report.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_report.Size = new System.Drawing.Size(679, 168);
            this.richTextBox_report.TabIndex = 0;
            this.richTextBox_report.Text = "";
            // 
            // textBox_num1
            // 
            this.textBox_num1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_num1.Font = new System.Drawing.Font("Inter Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_num1.Location = new System.Drawing.Point(34, 37);
            this.textBox_num1.Multiline = true;
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(113, 41);
            this.textBox_num1.TabIndex = 7;
            this.textBox_num1.Text = "2";
            this.textBox_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_denom1
            // 
            this.textBox_denom1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_denom1.Font = new System.Drawing.Font("Inter Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_denom1.Location = new System.Drawing.Point(34, 93);
            this.textBox_denom1.Multiline = true;
            this.textBox_denom1.Name = "textBox_denom1";
            this.textBox_denom1.Size = new System.Drawing.Size(113, 42);
            this.textBox_denom1.TabIndex = 8;
            this.textBox_denom1.Text = "5";
            this.textBox_denom1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_num2
            // 
            this.textBox_num2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_num2.Font = new System.Drawing.Font("Inter Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_num2.Location = new System.Drawing.Point(173, 36);
            this.textBox_num2.Multiline = true;
            this.textBox_num2.Name = "textBox_num2";
            this.textBox_num2.Size = new System.Drawing.Size(113, 42);
            this.textBox_num2.TabIndex = 9;
            this.textBox_num2.Text = "3";
            this.textBox_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_denom2
            // 
            this.textBox_denom2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_denom2.Font = new System.Drawing.Font("Inter Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_denom2.Location = new System.Drawing.Point(173, 93);
            this.textBox_denom2.Multiline = true;
            this.textBox_denom2.Name = "textBox_denom2";
            this.textBox_denom2.Size = new System.Drawing.Size(113, 42);
            this.textBox_denom2.TabIndex = 10;
            this.textBox_denom2.Text = "4";
            this.textBox_denom2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_convertDouble
            // 
            this.button_convertDouble.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_convertDouble.Location = new System.Drawing.Point(600, 150);
            this.button_convertDouble.Name = "button_convertDouble";
            this.button_convertDouble.Size = new System.Drawing.Size(113, 43);
            this.button_convertDouble.TabIndex = 6;
            this.button_convertDouble.Text = "123.45";
            this.button_convertDouble.UseVisualStyleBackColor = true;
            this.button_convertDouble.Click += new System.EventHandler(this.button_convertDouble_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // help_ToolStripMenuItem
            // 
            this.help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guide_ToolStripMenuItem,
            this.about_ToolStripMenuItem1});
            this.help_ToolStripMenuItem.Name = "help_ToolStripMenuItem";
            this.help_ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.help_ToolStripMenuItem.Text = "Справка";
            // 
            // guide_ToolStripMenuItem
            // 
            this.guide_ToolStripMenuItem.Name = "guide_ToolStripMenuItem";
            this.guide_ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.guide_ToolStripMenuItem.Text = "Инструкция";
            this.guide_ToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // about_ToolStripMenuItem1
            // 
            this.about_ToolStripMenuItem1.Name = "about_ToolStripMenuItem1";
            this.about_ToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.about_ToolStripMenuItem1.Text = "Об авторе";
            this.about_ToolStripMenuItem1.Click += new System.EventHandler(this.обАвтореToolStripMenuItem1_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::FractionCalculator.Properties.Resources.background_fraction;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(744, 421);
            this.Controls.Add(this.button_convertDouble);
            this.Controls.Add(this.textBox_denom2);
            this.Controls.Add(this.textBox_num2);
            this.Controls.Add(this.textBox_denom1);
            this.Controls.Add(this.textBox_num1);
            this.Controls.Add(this.richTextBox_report);
            this.Controls.Add(this.textBox_denom_res);
            this.Controls.Add(this.textBox_num_res);
            this.Controls.Add(this.button_compare);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(760, 700);
            this.MinimumSize = new System.Drawing.Size(760, 460);
            this.Name = "Form_main";
            this.Text = "Операции с дробями";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_compare;
        private System.Windows.Forms.TextBox textBox_num_res;
        private System.Windows.Forms.TextBox textBox_denom_res;
        private System.Windows.Forms.RichTextBox richTextBox_report;
        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.TextBox textBox_denom1;
        private System.Windows.Forms.TextBox textBox_num2;
        private System.Windows.Forms.TextBox textBox_denom2;

        private System.Windows.Forms.Button button_convertDouble;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guide_ToolStripMenuItem;
    }
}

