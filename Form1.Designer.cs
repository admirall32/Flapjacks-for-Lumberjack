
namespace Flapjacks_for_Lumberjack
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
            this.label1 = new System.Windows.Forms.Label();
            this.LumberjackNameTextBox = new System.Windows.Forms.TextBox();
            this.AddLumberjackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.addFlapjacksButton = new System.Windows.Forms.Button();
            this.listLamberjacks = new System.Windows.Forms.TextBox();
            this.nextLumberjackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // LumberjackNameTextBox
            // 
            this.LumberjackNameTextBox.Location = new System.Drawing.Point(109, 7);
            this.LumberjackNameTextBox.Name = "LumberjackNameTextBox";
            this.LumberjackNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.LumberjackNameTextBox.TabIndex = 1;
            // 
            // AddLumberjackButton
            // 
            this.AddLumberjackButton.Location = new System.Drawing.Point(93, 33);
            this.AddLumberjackButton.Name = "AddLumberjackButton";
            this.AddLumberjackButton.Size = new System.Drawing.Size(131, 23);
            this.AddLumberjackButton.TabIndex = 2;
            this.AddLumberjackButton.Text = "Add lumberjack";
            this.AddLumberjackButton.UseVisualStyleBackColor = true;
            this.AddLumberjackButton.Click += new System.EventHandler(this.AddLumberjackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breakfast line";
            // 
            // Line
            // 
            this.Line.FormattingEnabled = true;
            this.Line.Location = new System.Drawing.Point(12, 70);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(120, 316);
            this.Line.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextLumberjackButton);
            this.groupBox1.Controls.Add(this.listLamberjacks);
            this.groupBox1.Controls.Add(this.addFlapjacksButton);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Location = new System.Drawing.Point(138, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 316);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a lamberjack";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(6, 19);
            this.howMany.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.howMany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(93, 20);
            this.howMany.TabIndex = 0;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Checked = true;
            this.crispy.Location = new System.Drawing.Point(6, 45);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(53, 17);
            this.crispy.TabIndex = 1;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(6, 74);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(55, 17);
            this.soggy.TabIndex = 2;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(6, 103);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(67, 17);
            this.browned.TabIndex = 3;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(6, 132);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(62, 17);
            this.banana.TabIndex = 4;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // addFlapjacksButton
            // 
            this.addFlapjacksButton.Location = new System.Drawing.Point(6, 155);
            this.addFlapjacksButton.Name = "addFlapjacksButton";
            this.addFlapjacksButton.Size = new System.Drawing.Size(147, 23);
            this.addFlapjacksButton.TabIndex = 5;
            this.addFlapjacksButton.Text = "Add flapjacks";
            this.addFlapjacksButton.UseVisualStyleBackColor = true;
            this.addFlapjacksButton.Click += new System.EventHandler(this.addFlapjacksButton_Click);
            // 
            // listLamberjacks
            // 
            this.listLamberjacks.Location = new System.Drawing.Point(6, 184);
            this.listLamberjacks.Multiline = true;
            this.listLamberjacks.Name = "listLamberjacks";
            this.listLamberjacks.ReadOnly = true;
            this.listLamberjacks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listLamberjacks.Size = new System.Drawing.Size(147, 97);
            this.listLamberjacks.TabIndex = 6;
            // 
            // nextLumberjackButton
            // 
            this.nextLumberjackButton.Location = new System.Drawing.Point(6, 287);
            this.nextLumberjackButton.Name = "nextLumberjackButton";
            this.nextLumberjackButton.Size = new System.Drawing.Size(147, 23);
            this.nextLumberjackButton.TabIndex = 7;
            this.nextLumberjackButton.Text = "Next lumberjack";
            this.nextLumberjackButton.UseVisualStyleBackColor = true;
            this.nextLumberjackButton.Click += new System.EventHandler(this.nextLumberjackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddLumberjackButton);
            this.Controls.Add(this.LumberjackNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Hungry Lumberjacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LumberjackNameTextBox;
        private System.Windows.Forms.Button AddLumberjackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Line;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextLumberjackButton;
        private System.Windows.Forms.TextBox listLamberjacks;
        private System.Windows.Forms.Button addFlapjacksButton;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.NumericUpDown howMany;
    }
}

