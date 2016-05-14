namespace IPZ_lex
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
            this.openFile = new System.Windows.Forms.Button();
            this.programBox = new System.Windows.Forms.RichTextBox();
            this.variable = new System.Windows.Forms.RichTextBox();
            this.programOut = new System.Windows.Forms.RichTextBox();
            this.compile = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(12, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(158, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // programBox
            // 
            this.programBox.Location = new System.Drawing.Point(12, 41);
            this.programBox.Name = "programBox";
            this.programBox.Size = new System.Drawing.Size(158, 281);
            this.programBox.TabIndex = 1;
            this.programBox.Text = "";
            this.programBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // variable
            // 
            this.variable.Location = new System.Drawing.Point(190, 41);
            this.variable.Name = "variable";
            this.variable.Size = new System.Drawing.Size(158, 281);
            this.variable.TabIndex = 2;
            this.variable.Text = "";
            this.variable.TextChanged += new System.EventHandler(this.variable_TextChanged);
            // 
            // programOut
            // 
            this.programOut.Location = new System.Drawing.Point(373, 41);
            this.programOut.Name = "programOut";
            this.programOut.Size = new System.Drawing.Size(158, 281);
            this.programOut.TabIndex = 3;
            this.programOut.Text = "";
            this.programOut.TextChanged += new System.EventHandler(this.programOut_TextChanged);
            // 
            // compile
            // 
            this.compile.Location = new System.Drawing.Point(190, 12);
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(158, 23);
            this.compile.TabIndex = 4;
            this.compile.Text = "compile";
            this.compile.UseVisualStyleBackColor = true;
            this.compile.Click += new System.EventHandler(this.compile_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(373, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(158, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 334);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.compile);
            this.Controls.Add(this.programOut);
            this.Controls.Add(this.variable);
            this.Controls.Add(this.programBox);
            this.Controls.Add(this.openFile);
            this.Name = "Form1";
            this.Text = "Lex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.RichTextBox programBox;
        private System.Windows.Forms.RichTextBox variable;
        private System.Windows.Forms.RichTextBox programOut;
        private System.Windows.Forms.Button compile;
        private System.Windows.Forms.Button exitButton;
    }
}

