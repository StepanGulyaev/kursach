
namespace ClientWF
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
      this.components = new System.ComponentModel.Container();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.loginTB = new System.Windows.Forms.TextBox();
      this.passwordTB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();

      this.button1.Location = new System.Drawing.Point(703, 386);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(94, 29);
      this.button1.TabIndex = 0;
      this.button1.Text = "Отправить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);

      this.button2.Location = new System.Drawing.Point(250, 91);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(128, 29);
      this.button2.TabIndex = 5;
      this.button2.Text = "Войти";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);

      this.button3.Location = new System.Drawing.Point(256, 33);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(122, 29);
      this.button3.TabIndex = 8;
      this.button3.Text = "Регистрация";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);

      this.listBox1.Font = new System.Drawing.Font("Noto Sans Cond", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(12, 12);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(785, 344);
      this.listBox1.TabIndex = 2;
      this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);

      this.textBox1.Location = new System.Drawing.Point(126, 623);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(163, 27);
      this.textBox1.TabIndex = 3;

      this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.textBox2.Location = new System.Drawing.Point(16, 390);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(668, 25);
      this.textBox2.TabIndex = 4;
      this.textBox2.Text = "Привет!";

      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

      this.loginTB.Location = new System.Drawing.Point(3, 33);
      this.loginTB.Name = "loginTB";
      this.loginTB.Size = new System.Drawing.Size(192, 27);
      this.loginTB.TabIndex = 6;
      this.loginTB.Text = "GulyaevStepan";

      this.passwordTB.Location = new System.Drawing.Point(3, 93);
      this.passwordTB.Name = "passwordTB";
      this.passwordTB.Size = new System.Drawing.Size(192, 27);
      this.passwordTB.TabIndex = 7;
      this.passwordTB.Text = "sus";
 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.loginTB);
      this.panel1.Controls.Add(this.passwordTB);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Location = new System.Drawing.Point(13, 474);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(396, 143);
      this.panel1.TabIndex = 13;

      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 20);
      this.label2.TabIndex = 10;
      this.label2.Text = "Пароль";

      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 20);
      this.label1.TabIndex = 9;
      this.label1.Text = "Логин";

      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 364);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(132, 20);
      this.label3.TabIndex = 14;
      this.label3.Text = "Текст сообщения:";

      this.panel2.Location = new System.Drawing.Point(13, 421);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(127, 41);
      this.panel2.TabIndex = 15;

      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 626);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(108, 20);
      this.label4.TabIndex = 16;
      this.label4.Text = "Вы вошли как:";

      this.panel3.Location = new System.Drawing.Point(424, 474);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(228, 143);
      this.panel3.TabIndex = 18;

      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(809, 658);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Messenger";
      //this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TextBox loginTB;
    private System.Windows.Forms.TextBox passwordTB;
    
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    }
  }

