
namespace hulom_prelim
{
    partial class Form1
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
            this.btn_Triangle = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Triangle
            // 
            this.btn_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Triangle.Location = new System.Drawing.Point(12, 48);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.Size = new System.Drawing.Size(102, 35);
            this.btn_Triangle.TabIndex = 0;
            this.btn_Triangle.Text = "Triangle";
            this.btn_Triangle.UseVisualStyleBackColor = true;
            this.btn_Triangle.Click += new System.EventHandler(this.btn_Triangle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(120, 48);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(102, 35);
            this.btn_Rectangle.TabIndex = 1;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_square
            // 
            this.btn_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_square.Location = new System.Drawing.Point(228, 48);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(102, 35);
            this.btn_square.TabIndex = 2;
            this.btn_square.Text = "Square";
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_circle.Location = new System.Drawing.Point(336, 48);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(102, 35);
            this.btn_circle.TabIndex = 3;
            this.btn_circle.Text = "Circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculate each Perimeter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 113);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_circle);
            this.Controls.Add(this.btn_square);
            this.Controls.Add(this.btn_Rectangle);
            this.Controls.Add(this.btn_Triangle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Triangle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Label label1;
    }
}

