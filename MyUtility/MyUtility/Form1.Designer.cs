namespace MyUtility
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertData = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.Scount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Lod = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PassGen = new System.Windows.Forms.TabControl();
            this.Count = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.DiaLab = new System.Windows.Forms.Label();
            this.Delenie = new System.Windows.Forms.Button();
            this.Umnozenie = new System.Windows.Forms.Button();
            this.CountLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.RandomPage = new System.Windows.Forms.TabPage();
            this.Copy = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RandTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CountRand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxGen = new System.Windows.Forms.NumericUpDown();
            this.MinGen = new System.Windows.Forms.NumericUpDown();
            this.DiaLB2 = new System.Windows.Forms.Label();
            this.Notepad = new System.Windows.Forms.TabPage();
            this.Notepaad = new System.Windows.Forms.RichTextBox();
            this.PasswordGen = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.NumGen = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.KeyGen = new System.Windows.Forms.Button();
            this.textBoxGen = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.PassGen.SuspendLayout();
            this.Count.SuspendLayout();
            this.RandomPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinGen)).BeginInit();
            this.Notepad.SuspendLayout();
            this.PasswordGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertData,
            this.InsertTime,
            this.Scount,
            this.toolStripMenuItem1,
            this.Save,
            this.Lod});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // InsertData
            // 
            this.InsertData.Name = "InsertData";
            this.InsertData.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.InsertData.Size = new System.Drawing.Size(258, 22);
            this.InsertData.Text = "Вставить дату";
            this.InsertData.Click += new System.EventHandler(this.InsertData_Click);
            // 
            // InsertTime
            // 
            this.InsertTime.Name = "InsertTime";
            this.InsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.InsertTime.Size = new System.Drawing.Size(258, 22);
            this.InsertTime.Text = "Вставить время";
            this.InsertTime.Click += new System.EventHandler(this.InsertTime_Click);
            // 
            // Scount
            // 
            this.Scount.Name = "Scount";
            this.Scount.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.Scount.Size = new System.Drawing.Size(258, 22);
            this.Scount.Text = "Посчитать символы";
            this.Scount.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Scount.Click += new System.EventHandler(this.посчитатьСимволыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(255, 6);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(258, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // Lod
            // 
            this.Lod.Name = "Lod";
            this.Lod.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Lod.Size = new System.Drawing.Size(258, 22);
            this.Lod.Text = "Загрузить";
            this.Lod.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // PassGen
            // 
            this.PassGen.Controls.Add(this.Count);
            this.PassGen.Controls.Add(this.RandomPage);
            this.PassGen.Controls.Add(this.Notepad);
            this.PassGen.Controls.Add(this.PasswordGen);
            this.PassGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassGen.Location = new System.Drawing.Point(0, 24);
            this.PassGen.Multiline = true;
            this.PassGen.Name = "PassGen";
            this.PassGen.SelectedIndex = 0;
            this.PassGen.Size = new System.Drawing.Size(385, 271);
            this.PassGen.TabIndex = 1;
            // 
            // Count
            // 
            this.Count.Controls.Add(this.label4);
            this.Count.Controls.Add(this.DiaLab);
            this.Count.Controls.Add(this.Delenie);
            this.Count.Controls.Add(this.Umnozenie);
            this.Count.Controls.Add(this.CountLB);
            this.Count.Controls.Add(this.button1);
            this.Count.Controls.Add(this.Minus);
            this.Count.Controls.Add(this.plus);
            this.Count.Location = new System.Drawing.Point(4, 22);
            this.Count.Name = "Count";
            this.Count.Padding = new System.Windows.Forms.Padding(3);
            this.Count.Size = new System.Drawing.Size(377, 245);
            this.Count.TabIndex = 0;
            this.Count.Text = "Счетчик";
            this.Count.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(134, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Счетчик";
            // 
            // DiaLab
            // 
            this.DiaLab.AutoSize = true;
            this.DiaLab.Location = new System.Drawing.Point(218, 227);
            this.DiaLab.Name = "DiaLab";
            this.DiaLab.Size = new System.Drawing.Size(128, 13);
            this.DiaLab.TabIndex = 6;
            this.DiaLab.Text = "Диагностический текст";
            // 
            // Delenie
            // 
            this.Delenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delenie.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Delenie.Location = new System.Drawing.Point(82, 111);
            this.Delenie.Name = "Delenie";
            this.Delenie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Delenie.Size = new System.Drawing.Size(29, 28);
            this.Delenie.TabIndex = 5;
            this.Delenie.Text = "-";
            this.Delenie.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Delenie.UseVisualStyleBackColor = true;
            this.Delenie.Click += new System.EventHandler(this.Delenie_Click);
            // 
            // Umnozenie
            // 
            this.Umnozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Umnozenie.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Umnozenie.Location = new System.Drawing.Point(31, 111);
            this.Umnozenie.Name = "Umnozenie";
            this.Umnozenie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Umnozenie.Size = new System.Drawing.Size(29, 28);
            this.Umnozenie.TabIndex = 4;
            this.Umnozenie.Text = "*";
            this.Umnozenie.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Umnozenie.UseVisualStyleBackColor = true;
            this.Umnozenie.Click += new System.EventHandler(this.Umnozenie_Click);
            // 
            // CountLB
            // 
            this.CountLB.AutoSize = true;
            this.CountLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F);
            this.CountLB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CountLB.Location = new System.Drawing.Point(144, 76);
            this.CountLB.Name = "CountLB";
            this.CountLB.Size = new System.Drawing.Size(84, 92);
            this.CountLB.TabIndex = 3;
            this.CountLB.Text = "0";
            this.CountLB.Click += new System.EventHandler(this.Counter_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(31, 179);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сброс";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Minus.Location = new System.Drawing.Point(82, 48);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(29, 30);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.plus.Location = new System.Drawing.Point(31, 48);
            this.plus.Name = "plus";
            this.plus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.plus.Size = new System.Drawing.Size(29, 28);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // RandomPage
            // 
            this.RandomPage.Controls.Add(this.Copy);
            this.RandomPage.Controls.Add(this.Clear);
            this.RandomPage.Controls.Add(this.label5);
            this.RandomPage.Controls.Add(this.RandTextBox);
            this.RandomPage.Controls.Add(this.button2);
            this.RandomPage.Controls.Add(this.CountRand);
            this.RandomPage.Controls.Add(this.label3);
            this.RandomPage.Controls.Add(this.label2);
            this.RandomPage.Controls.Add(this.label1);
            this.RandomPage.Controls.Add(this.MaxGen);
            this.RandomPage.Controls.Add(this.MinGen);
            this.RandomPage.Controls.Add(this.DiaLB2);
            this.RandomPage.Location = new System.Drawing.Point(4, 22);
            this.RandomPage.Name = "RandomPage";
            this.RandomPage.Padding = new System.Windows.Forms.Padding(3);
            this.RandomPage.Size = new System.Drawing.Size(377, 245);
            this.RandomPage.TabIndex = 1;
            this.RandomPage.Text = "Рандомайзер";
            this.RandomPage.UseVisualStyleBackColor = true;
            this.RandomPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(43, 183);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(92, 23);
            this.Copy.TabIndex = 19;
            this.Copy.Text = "Копировать";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(43, 212);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(92, 23);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(181, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Генератор билетов";
            // 
            // RandTextBox
            // 
            this.RandTextBox.Location = new System.Drawing.Point(173, 191);
            this.RandTextBox.Multiline = true;
            this.RandTextBox.Name = "RandTextBox";
            this.RandTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RandTextBox.Size = new System.Drawing.Size(187, 23);
            this.RandTextBox.TabIndex = 16;
            this.RandTextBox.TextChanged += new System.EventHandler(this.RandTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Сгенерировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CountRand
            // 
            this.CountRand.AutoSize = true;
            this.CountRand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CountRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.CountRand.Location = new System.Drawing.Point(196, 58);
            this.CountRand.Name = "CountRand";
            this.CountRand.Size = new System.Drawing.Size(59, 65);
            this.CountRand.TabIndex = 14;
            this.CountRand.Text = "0";
            this.CountRand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountRand.Click += new System.EventHandler(this.CountRand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(51, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Генератор случайных чисел";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "До";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "От";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MaxGen
            // 
            this.MaxGen.Location = new System.Drawing.Point(52, 107);
            this.MaxGen.Maximum = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            this.MaxGen.Minimum = new decimal(new int[] {
            900000,
            0,
            0,
            -2147483648});
            this.MaxGen.Name = "MaxGen";
            this.MaxGen.Size = new System.Drawing.Size(74, 20);
            this.MaxGen.TabIndex = 10;
            this.MaxGen.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.MaxGen.ValueChanged += new System.EventHandler(this.MaxGen_ValueChanged);
            // 
            // MinGen
            // 
            this.MinGen.Location = new System.Drawing.Point(52, 58);
            this.MinGen.Maximum = new decimal(new int[] {
            899999,
            0,
            0,
            0});
            this.MinGen.Minimum = new decimal(new int[] {
            900000,
            0,
            0,
            -2147483648});
            this.MinGen.Name = "MinGen";
            this.MinGen.Size = new System.Drawing.Size(74, 20);
            this.MinGen.TabIndex = 9;
            this.MinGen.ValueChanged += new System.EventHandler(this.MinGen_ValueChanged);
            // 
            // DiaLB2
            // 
            this.DiaLB2.AutoSize = true;
            this.DiaLB2.Location = new System.Drawing.Point(218, 227);
            this.DiaLB2.Name = "DiaLB2";
            this.DiaLB2.Size = new System.Drawing.Size(128, 13);
            this.DiaLB2.TabIndex = 8;
            this.DiaLB2.Text = "Диагностический текст";
            // 
            // Notepad
            // 
            this.Notepad.Controls.Add(this.Notepaad);
            this.Notepad.Location = new System.Drawing.Point(4, 22);
            this.Notepad.Name = "Notepad";
            this.Notepad.Size = new System.Drawing.Size(377, 245);
            this.Notepad.TabIndex = 2;
            this.Notepad.Text = "Блокнот";
            this.Notepad.UseVisualStyleBackColor = true;
            // 
            // Notepaad
            // 
            this.Notepaad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notepaad.Location = new System.Drawing.Point(0, 0);
            this.Notepaad.Name = "Notepaad";
            this.Notepaad.Size = new System.Drawing.Size(377, 245);
            this.Notepaad.TabIndex = 0;
            this.Notepaad.Text = "";
            this.Notepaad.TextChanged += new System.EventHandler(this.Notepaad_TextChanged);
            // 
            // PasswordGen
            // 
            this.PasswordGen.Controls.Add(this.textBoxGen);
            this.PasswordGen.Controls.Add(this.KeyGen);
            this.PasswordGen.Controls.Add(this.label6);
            this.PasswordGen.Controls.Add(this.NumGen);
            this.PasswordGen.Controls.Add(this.checkedListBox1);
            this.PasswordGen.Location = new System.Drawing.Point(4, 22);
            this.PasswordGen.Name = "PasswordGen";
            this.PasswordGen.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordGen.Size = new System.Drawing.Size(377, 245);
            this.PasswordGen.TabIndex = 3;
            this.PasswordGen.Text = "Генератор пароля";
            this.PasswordGen.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы(заглавные)",
            "Спецсимволы: _ ; # @ *"});
            this.checkedListBox1.Location = new System.Drawing.Point(21, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(173, 64);
            this.checkedListBox1.TabIndex = 0;
            // 
            // NumGen
            // 
            this.NumGen.Location = new System.Drawing.Point(128, 113);
            this.NumGen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumGen.Name = "NumGen";
            this.NumGen.Size = new System.Drawing.Size(55, 20);
            this.NumGen.TabIndex = 1;
            this.NumGen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Длина пароля";
            // 
            // KeyGen
            // 
            this.KeyGen.Location = new System.Drawing.Point(21, 144);
            this.KeyGen.Name = "KeyGen";
            this.KeyGen.Size = new System.Drawing.Size(75, 23);
            this.KeyGen.TabIndex = 3;
            this.KeyGen.Text = "Создать пароль";
            this.KeyGen.UseVisualStyleBackColor = true;
            // 
            // textBoxGen
            // 
            this.textBoxGen.Location = new System.Drawing.Point(21, 192);
            this.textBoxGen.Name = "textBoxGen";
            this.textBoxGen.Size = new System.Drawing.Size(319, 20);
            this.textBoxGen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 295);
            this.Controls.Add(this.PassGen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PassGen.ResumeLayout(false);
            this.Count.ResumeLayout(false);
            this.Count.PerformLayout();
            this.RandomPage.ResumeLayout(false);
            this.RandomPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinGen)).EndInit();
            this.Notepad.ResumeLayout(false);
            this.PasswordGen.ResumeLayout(false);
            this.PasswordGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl PassGen;
        private System.Windows.Forms.TabPage Count;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TabPage RandomPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CountLB;
        private System.Windows.Forms.Button Delenie;
        private System.Windows.Forms.Button Umnozenie;
        private System.Windows.Forms.Label DiaLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MaxGen;
        private System.Windows.Forms.NumericUpDown MinGen;
        private System.Windows.Forms.Label DiaLB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CountRand;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox RandTextBox;
        private System.Windows.Forms.TabPage Notepad;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.RichTextBox Notepaad;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertData;
        private System.Windows.Forms.ToolStripMenuItem InsertTime;
        private System.Windows.Forms.ToolStripMenuItem Scount;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Lod;
        private System.Windows.Forms.TabPage PasswordGen;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBoxGen;
        private System.Windows.Forms.Button KeyGen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumGen;
    }
}

