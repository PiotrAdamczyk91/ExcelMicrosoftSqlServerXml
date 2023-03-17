namespace ExcelMicrosoftSqlServerXml
{
    partial class Start
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SerwerTextBox = new TextBox();
            LoginTextBox = new TextBox();
            HasloTextBox = new TextBox();
            Polacz = new Button();
            label5 = new Label();
            StatusPolaczenia = new Label();
            Rozlacz = new Button();
            TworzenieBazyDanych = new Button();
            TworzenieTabeli = new Button();
            label6 = new Label();
            PobierzDane = new Button();
            textSciezka = new TextBox();
            ResoultGrid = new DataGridView();
            label7 = new Label();
            cbo = new ComboBox();
            Import = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Imie = new ComboBox();
            Nazwisko = new ComboBox();
            label12 = new Label();
            KodPracownika = new ComboBox();
            label13 = new Label();
            Dzial = new ComboBox();
            label14 = new Label();
            Stanowisko = new ComboBox();
            Export = new Button();
            ((System.ComponentModel.ISupportInitialize)ResoultGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(348, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 0;
            label1.Text = "Ustawienia SQL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Serwer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Hasło";
            // 
            // SerwerTextBox
            // 
            SerwerTextBox.Location = new Point(72, 49);
            SerwerTextBox.Name = "SerwerTextBox";
            SerwerTextBox.Size = new Size(571, 23);
            SerwerTextBox.TabIndex = 4;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(72, 78);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(571, 23);
            LoginTextBox.TabIndex = 5;
            // 
            // HasloTextBox
            // 
            HasloTextBox.Location = new Point(72, 107);
            HasloTextBox.Name = "HasloTextBox";
            HasloTextBox.Size = new Size(571, 23);
            HasloTextBox.TabIndex = 6;
            // 
            // Polacz
            // 
            Polacz.Location = new Point(665, 49);
            Polacz.Name = "Polacz";
            Polacz.Size = new Size(83, 37);
            Polacz.TabIndex = 7;
            Polacz.Text = "Połącz";
            Polacz.UseVisualStyleBackColor = true;
            Polacz.Click += Polacz_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 142);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 8;
            label5.Text = "Status połączenia:";
            // 
            // StatusPolaczenia
            // 
            StatusPolaczenia.AutoSize = true;
            StatusPolaczenia.Location = new Point(129, 142);
            StatusPolaczenia.Name = "StatusPolaczenia";
            StatusPolaczenia.Size = new Size(66, 15);
            StatusPolaczenia.TabIndex = 9;
            StatusPolaczenia.Text = "Rozłączony";
            // 
            // Rozlacz
            // 
            Rozlacz.Location = new Point(665, 99);
            Rozlacz.Name = "Rozlacz";
            Rozlacz.Size = new Size(83, 37);
            Rozlacz.TabIndex = 10;
            Rozlacz.Text = "Rozłącz";
            Rozlacz.UseVisualStyleBackColor = true;
            Rozlacz.Click += Rozlacz_Click;
            // 
            // TworzenieBazyDanych
            // 
            TworzenieBazyDanych.Location = new Point(781, 49);
            TworzenieBazyDanych.Name = "TworzenieBazyDanych";
            TworzenieBazyDanych.Size = new Size(145, 37);
            TworzenieBazyDanych.TabIndex = 11;
            TworzenieBazyDanych.Text = "Tworzenie Bazy Danych";
            TworzenieBazyDanych.UseVisualStyleBackColor = true;
            TworzenieBazyDanych.Click += TworzenieBazyDanych_Click;
            // 
            // TworzenieTabeli
            // 
            TworzenieTabeli.Location = new Point(781, 99);
            TworzenieTabeli.Name = "TworzenieTabeli";
            TworzenieTabeli.Size = new Size(145, 37);
            TworzenieTabeli.TabIndex = 12;
            TworzenieTabeli.Text = "Tworzenie Tabeli";
            TworzenieTabeli.UseVisualStyleBackColor = true;
            TworzenieTabeli.Click += TworzenieTabeli_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(803, 534);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 13;
            label6.Text = "Piotr Adamczyk";
            // 
            // PobierzDane
            // 
            PobierzDane.Location = new Point(12, 213);
            PobierzDane.Name = "PobierzDane";
            PobierzDane.Size = new Size(115, 23);
            PobierzDane.TabIndex = 14;
            PobierzDane.Text = "Pobierz Dane";
            PobierzDane.UseVisualStyleBackColor = true;
            PobierzDane.Click += PobierzDane_Click;
            // 
            // textSciezka
            // 
            textSciezka.Location = new Point(137, 213);
            textSciezka.Name = "textSciezka";
            textSciezka.ReadOnly = true;
            textSciezka.Size = new Size(611, 23);
            textSciezka.TabIndex = 15;
            // 
            // ResoultGrid
            // 
            ResoultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResoultGrid.Location = new Point(12, 256);
            ResoultGrid.Name = "ResoultGrid";
            ResoultGrid.RowTemplate.Height = 25;
            ResoultGrid.Size = new Size(914, 71);
            ResoultGrid.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(754, 217);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 17;
            label7.Text = "Arkusz:";
            // 
            // cbo
            // 
            cbo.FormattingEnabled = true;
            cbo.Location = new Point(805, 213);
            cbo.Name = "cbo";
            cbo.Size = new Size(121, 23);
            cbo.TabIndex = 18;
            cbo.SelectedIndexChanged += cbo_SelectedIndexChanged;
            // 
            // Import
            // 
            Import.Location = new Point(597, 375);
            Import.Name = "Import";
            Import.Size = new Size(301, 23);
            Import.TabIndex = 19;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = true;
            Import.Click += Import_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(348, 162);
            label8.Name = "label8";
            label8.Size = new Size(162, 32);
            label8.TabIndex = 20;
            label8.Text = "Import z pliku";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(348, 440);
            label9.Name = "label9";
            label9.Size = new Size(186, 32);
            label9.TabIndex = 21;
            label9.Text = "Eksport do pliku";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 343);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 22;
            label10.Text = "Imię:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(292, 343);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 23;
            label11.Text = "Nazwisko:";
            // 
            // Imie
            // 
            Imie.FormattingEnabled = true;
            Imie.Location = new Point(62, 340);
            Imie.Name = "Imie";
            Imie.Size = new Size(200, 23);
            Imie.TabIndex = 24;
            Imie.Text = "                 Wybierz kolumnę";
            // 
            // Nazwisko
            // 
            Nazwisko.FormattingEnabled = true;
            Nazwisko.Location = new Point(368, 340);
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Size = new Size(200, 23);
            Nazwisko.TabIndex = 25;
            Nazwisko.Text = "                 Wybierz kolumnę";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(597, 343);
            label12.Name = "label12";
            label12.Size = new Size(95, 15);
            label12.TabIndex = 26;
            label12.Text = "Kod pracownika:";
            // 
            // KodPracownika
            // 
            KodPracownika.FormattingEnabled = true;
            KodPracownika.Location = new Point(698, 340);
            KodPracownika.Name = "KodPracownika";
            KodPracownika.Size = new Size(200, 23);
            KodPracownika.TabIndex = 27;
            KodPracownika.Text = "                 Wybierz kolumnę";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 379);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 28;
            label13.Text = "Dział:";
            // 
            // Dzial
            // 
            Dzial.FormattingEnabled = true;
            Dzial.Location = new Point(62, 376);
            Dzial.Name = "Dzial";
            Dzial.Size = new Size(200, 23);
            Dzial.TabIndex = 29;
            Dzial.Text = "                 Wybierz kolumnę";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(292, 379);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 30;
            label14.Text = "Stanowisko:";
            // 
            // Stanowisko
            // 
            Stanowisko.FormattingEnabled = true;
            Stanowisko.Location = new Point(368, 376);
            Stanowisko.Name = "Stanowisko";
            Stanowisko.Size = new Size(200, 23);
            Stanowisko.TabIndex = 31;
            Stanowisko.Text = "                 Wybierz kolumnę";
            // 
            // Export
            // 
            Export.Location = new Point(292, 488);
            Export.Name = "Export";
            Export.Size = new Size(301, 23);
            Export.TabIndex = 32;
            Export.Text = "Export";
            Export.UseVisualStyleBackColor = true;
            Export.Click += Export_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 565);
            Controls.Add(Export);
            Controls.Add(Stanowisko);
            Controls.Add(label14);
            Controls.Add(Dzial);
            Controls.Add(label13);
            Controls.Add(KodPracownika);
            Controls.Add(label12);
            Controls.Add(Nazwisko);
            Controls.Add(Imie);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Import);
            Controls.Add(cbo);
            Controls.Add(label7);
            Controls.Add(ResoultGrid);
            Controls.Add(textSciezka);
            Controls.Add(PobierzDane);
            Controls.Add(label6);
            Controls.Add(TworzenieTabeli);
            Controls.Add(TworzenieBazyDanych);
            Controls.Add(Rozlacz);
            Controls.Add(StatusPolaczenia);
            Controls.Add(label5);
            Controls.Add(Polacz);
            Controls.Add(HasloTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(SerwerTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Start";
            Text = "Excel_MicrosoftSqlServer_Xml";
            ((System.ComponentModel.ISupportInitialize)ResoultGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SerwerTextBox;
        private TextBox LoginTextBox;
        private TextBox HasloTextBox;
        private Button Polacz;
        private Label label5;
        private Label StatusPolaczenia;
        private Button Rozlacz;
        private Button TworzenieBazyDanych;
        private Button TworzenieTabeli;
        private Label label6;
        private Button PobierzDane;
        private TextBox textSciezka;
        private DataGridView ResoultGrid;
        private Label label7;
        private ComboBox cbo;
        private Button Import;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox Imie;
        private ComboBox Nazwisko;
        private Label label12;
        private ComboBox KodPracownika;
        private Label label13;
        private ComboBox Dzial;
        private Label label14;
        private ComboBox Stanowisko;
        private Button Export;
    }
}