namespace WinForm_app7
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
            this.symbol = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.full = new System.Windows.Forms.TextBox();
            this.partial = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // symbol
            // 
            this.symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbol.Location = new System.Drawing.Point(9, 54);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(132, 34);
            this.symbol.TabIndex = 0;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(184, 161);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(132, 55);
            this.del.TabIndex = 6;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // full
            // 
            this.full.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full.Location = new System.Drawing.Point(9, 14);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(457, 34);
            this.full.TabIndex = 7;
            // 
            // partial
            // 
            this.partial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partial.Location = new System.Drawing.Point(9, 94);
            this.partial.Name = "partial";
            this.partial.Size = new System.Drawing.Size(132, 34);
            this.partial.TabIndex = 8;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(334, 385);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(132, 55);
            this.sum.TabIndex = 9;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.elem_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(334, 329);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(132, 55);
            this.sub.TabIndex = 10;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.elem_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(334, 273);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(132, 55);
            this.mult.TabIndex = 11;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.elem_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(334, 217);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(132, 55);
            this.div.TabIndex = 12;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.elem_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(334, 441);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(132, 55);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.elem_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(46, 161);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(132, 55);
            this.c.TabIndex = 14;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(155, 242);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(65, 61);
            this.eight.TabIndex = 15;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.num_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(64, 312);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(65, 61);
            this.four.TabIndex = 16;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.num_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(242, 242);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(65, 61);
            this.nine.TabIndex = 17;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.num_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(155, 312);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(65, 61);
            this.five.TabIndex = 18;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.num_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(64, 242);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(65, 61);
            this.seven.TabIndex = 19;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.num_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(242, 312);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(65, 61);
            this.six.TabIndex = 20;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.num_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(242, 379);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(65, 61);
            this.three.TabIndex = 21;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.num_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(155, 379);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(65, 61);
            this.two.TabIndex = 22;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.num_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(64, 379);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(65, 61);
            this.one.TabIndex = 23;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.num_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(155, 446);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(65, 61);
            this.zero.TabIndex = 24;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.num_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 524);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.five);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.four);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.c);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.partial);
            this.Controls.Add(this.full);
            this.Controls.Add(this.del);
            this.Controls.Add(this.symbol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox symbol;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.TextBox full;
        private System.Windows.Forms.TextBox partial;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button six;
    }
}

