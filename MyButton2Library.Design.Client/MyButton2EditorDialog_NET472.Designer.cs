namespace MyButton2Library.Design.Client
{
    partial class MyButton2EditorDialog_NET472
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyButton2EditorDialog_NET472));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textButtonCaption = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(920, 219);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edit MyButton2 caption:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textButtonCaption
            // 
            this.textButtonCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButtonCaption.ForeColor = System.Drawing.Color.Black;
            this.textButtonCaption.Location = new System.Drawing.Point(38, 318);
            this.textButtonCaption.Multiline = true;
            this.textButtonCaption.Name = "textButtonCaption";
            this.textButtonCaption.Size = new System.Drawing.Size(908, 120);
            this.textButtonCaption.TabIndex = 2;
            this.textButtonCaption.TextChanged += new System.EventHandler(this.textButtonCaption_TextChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(224, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(498, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyButton2EditorDialog_NET472
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 579);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textButtonCaption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyButton2EditorDialog_NET472";
            this.Text = "MyButton2EditorDialog_NET472";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textButtonCaption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}