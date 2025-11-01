namespace WinFormsApp10
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCreate = new MaterialSkin.Controls.MaterialButton();
            btnRead = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            panel4 = new Panel();
            txtSearch = new TextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            panel5 = new Panel();
            dtDatabase = new DataGridView();
            txtInfo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            waifu = new ImageList(components);
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel6 = new Panel();
            panel1 = new Panel();
            rbtnAsc = new MaterialSkin.Controls.MaterialRadioButton();
            rbtnDesc = new MaterialSkin.Controls.MaterialRadioButton();
            lblCount = new MaterialSkin.Controls.MaterialLabel();
            lblRandom = new MaterialSkin.Controls.MaterialLabel();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            lblOptions = new MaterialSkin.Controls.MaterialLabel();
            lblHelp3 = new Label();
            lblHelp4 = new Label();
            lblHelp1 = new Label();
            lblHelp2 = new Label();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.AutoSize = false;
            btnCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreate.Depth = 0;
            btnCreate.HighEmphasis = true;
            btnCreate.Icon = null;
            btnCreate.Location = new Point(57, 132);
            btnCreate.Margin = new Padding(4, 6, 4, 6);
            btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreate.Name = "btnCreate";
            btnCreate.NoAccentTextColor = Color.Empty;
            btnCreate.Size = new Size(217, 35);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreate.UseAccentColor = false;
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            // 
            // btnRead
            // 
            btnRead.AutoSize = false;
            btnRead.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRead.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRead.Depth = 0;
            btnRead.HighEmphasis = true;
            btnRead.Icon = null;
            btnRead.Location = new Point(399, 132);
            btnRead.Margin = new Padding(4, 6, 4, 6);
            btnRead.MouseState = MaterialSkin.MouseState.HOVER;
            btnRead.Name = "btnRead";
            btnRead.NoAccentTextColor = Color.Empty;
            btnRead.Size = new Size(215, 35);
            btnRead.TabIndex = 1;
            btnRead.Text = "Read";
            btnRead.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRead.UseAccentColor = false;
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            btnRead.MouseEnter += btnRead_MouseEnter;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(57, 179);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(217, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += btnUpdate_MouseEnter;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(399, 179);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(217, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Controls.Add(materialLabel2);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(materialLabel3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1264, 50);
            panel4.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(788, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(464, 23);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(732, 16);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(50, 19);
            materialLabel3.TabIndex = 15;
            materialLabel3.Text = "Search";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtDatabase);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(716, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(548, 631);
            panel5.TabIndex = 1;
            // 
            // dtDatabase
            // 
            dtDatabase.AllowUserToAddRows = false;
            dtDatabase.AllowUserToDeleteRows = false;
            dtDatabase.AllowUserToResizeColumns = false;
            dtDatabase.AllowUserToResizeRows = false;
            dtDatabase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtDatabase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtDatabase.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtDatabase.DefaultCellStyle = dataGridViewCellStyle1;
            dtDatabase.Dock = DockStyle.Fill;
            dtDatabase.Location = new Point(0, 0);
            dtDatabase.Name = "dtDatabase";
            dtDatabase.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtDatabase.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtDatabase.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtDatabase.Size = new Size(548, 631);
            dtDatabase.TabIndex = 0;
            // 
            // txtInfo
            // 
            txtInfo.AllowPromptAsInput = true;
            txtInfo.AnimateReadOnly = false;
            txtInfo.AsciiOnly = false;
            txtInfo.BackgroundImageLayout = ImageLayout.None;
            txtInfo.BeepOnError = false;
            txtInfo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtInfo.Depth = 0;
            txtInfo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfo.HelperText = "Enter Information to enter.";
            txtInfo.HidePromptOnLeave = false;
            txtInfo.HideSelection = true;
            txtInfo.InsertKeyMode = InsertKeyMode.Default;
            txtInfo.LeadingIcon = null;
            txtInfo.Location = new Point(57, 75);
            txtInfo.Mask = "";
            txtInfo.MaxLength = 32767;
            txtInfo.MouseState = MaterialSkin.MouseState.OUT;
            txtInfo.Name = "txtInfo";
            txtInfo.PasswordChar = '\0';
            txtInfo.PrefixSuffixText = null;
            txtInfo.PromptChar = '_';
            txtInfo.ReadOnly = false;
            txtInfo.RejectInputOnFirstFailure = false;
            txtInfo.ResetOnPrompt = true;
            txtInfo.ResetOnSpace = true;
            txtInfo.RightToLeft = RightToLeft.No;
            txtInfo.SelectedText = "";
            txtInfo.SelectionLength = 0;
            txtInfo.SelectionStart = 0;
            txtInfo.ShortcutsEnabled = true;
            txtInfo.Size = new Size(604, 48);
            txtInfo.SkipLiterals = true;
            txtInfo.TabIndex = 9;
            txtInfo.TabStop = false;
            txtInfo.TextAlign = HorizontalAlignment.Left;
            txtInfo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtInfo.TrailingIcon = null;
            txtInfo.UseSystemPasswordChar = false;
            txtInfo.ValidatingType = null;
            txtInfo.TextChanged += txtInfo_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(57, 53);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(32, 19);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "Text";
            // 
            // waifu
            // 
            waifu.ColorDepth = ColorDepth.Depth32Bit;
            waifu.ImageStream = (ImageListStreamer)resources.GetObject("waifu.ImageStream");
            waifu.TransparentColor = Color.Transparent;
            waifu.Images.SetKeyName(0, "waifu.png");
            waifu.Images.SetKeyName(1, "waifu worried.png");
            waifu.Images.SetKeyName(2, "waifu question.png");
            waifu.Images.SetKeyName(3, "waifu angry.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.waifu;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(665, 408);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(51, 631);
            panel3.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(rbtnAsc);
            panel6.Controls.Add(rbtnDesc);
            panel6.Controls.Add(lblCount);
            panel6.Controls.Add(lblRandom);
            panel6.Controls.Add(btnClear);
            panel6.Controls.Add(lblOptions);
            panel6.Controls.Add(pictureBox1);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(51, 273);
            panel6.Name = "panel6";
            panel6.Size = new Size(665, 408);
            panel6.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.AccessibleDescription = "Only the cutest there is!";
            panel1.AccessibleName = "";
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(348, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 361);
            panel1.TabIndex = 1;
            panel1.Visible = false;
            // 
            // rbtnAsc
            // 
            rbtnAsc.AutoSize = true;
            rbtnAsc.Depth = 0;
            rbtnAsc.Location = new Point(212, 34);
            rbtnAsc.Margin = new Padding(0);
            rbtnAsc.MouseLocation = new Point(-1, -1);
            rbtnAsc.MouseState = MaterialSkin.MouseState.HOVER;
            rbtnAsc.Name = "rbtnAsc";
            rbtnAsc.Ripple = true;
            rbtnAsc.Size = new Size(109, 37);
            rbtnAsc.TabIndex = 18;
            rbtnAsc.TabStop = true;
            rbtnAsc.Text = "Ascending";
            rbtnAsc.UseVisualStyleBackColor = true;
            rbtnAsc.CheckedChanged += rbtnAsc_CheckedChanged;
            // 
            // rbtnDesc
            // 
            rbtnDesc.AutoSize = true;
            rbtnDesc.Checked = true;
            rbtnDesc.Depth = 0;
            rbtnDesc.Location = new Point(77, 34);
            rbtnDesc.Margin = new Padding(0);
            rbtnDesc.MouseLocation = new Point(-1, -1);
            rbtnDesc.MouseState = MaterialSkin.MouseState.HOVER;
            rbtnDesc.Name = "rbtnDesc";
            rbtnDesc.Ripple = true;
            rbtnDesc.Size = new Size(118, 37);
            rbtnDesc.TabIndex = 17;
            rbtnDesc.TabStop = true;
            rbtnDesc.Text = "Descending";
            rbtnDesc.UseVisualStyleBackColor = true;
            rbtnDesc.CheckedChanged += rbtnDesc_CheckedChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Depth = 0;
            lblCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCount.Location = new Point(7, 76);
            lblCount.MouseState = MaterialSkin.MouseState.HOVER;
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(51, 19);
            lblCount.TabIndex = 16;
            lblCount.Text = "Count: ";
            // 
            // lblRandom
            // 
            lblRandom.BackColor = Color.Plum;
            lblRandom.Depth = 0;
            lblRandom.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRandom.Location = new Point(31, 122);
            lblRandom.MouseState = MaterialSkin.MouseState.HOVER;
            lblRandom.Name = "lblRandom";
            lblRandom.Size = new Size(309, 263);
            lblRandom.TabIndex = 15;
            lblRandom.Visible = false;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(7, 34);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(66, 36);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Depth = 0;
            lblOptions.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblOptions.Location = new Point(6, 9);
            lblOptions.MouseState = MaterialSkin.MouseState.HOVER;
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(132, 19);
            lblOptions.TabIndex = 13;
            lblOptions.Text = "Additional Options";
            // 
            // lblHelp3
            // 
            lblHelp3.AutoSize = true;
            lblHelp3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp3.ForeColor = Color.Blue;
            lblHelp3.Location = new Point(622, 152);
            lblHelp3.Name = "lblHelp3";
            lblHelp3.Size = new Size(32, 15);
            lblHelp3.TabIndex = 15;
            lblHelp3.Text = "Help";
            lblHelp3.Click += lblHelp3_Click;
            // 
            // lblHelp4
            // 
            lblHelp4.AutoSize = true;
            lblHelp4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp4.ForeColor = Color.Blue;
            lblHelp4.Location = new Point(622, 199);
            lblHelp4.Name = "lblHelp4";
            lblHelp4.Size = new Size(32, 15);
            lblHelp4.TabIndex = 16;
            lblHelp4.Text = "Help";
            lblHelp4.Click += lblHelp4_Click;
            // 
            // lblHelp1
            // 
            lblHelp1.AutoSize = true;
            lblHelp1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp1.ForeColor = Color.Blue;
            lblHelp1.Location = new Point(281, 152);
            lblHelp1.Name = "lblHelp1";
            lblHelp1.Size = new Size(32, 15);
            lblHelp1.TabIndex = 17;
            lblHelp1.Text = "Help";
            lblHelp1.Click += lblHelp1_Click;
            // 
            // lblHelp2
            // 
            lblHelp2.AutoSize = true;
            lblHelp2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp2.ForeColor = Color.Blue;
            lblHelp2.Location = new Point(281, 199);
            lblHelp2.Name = "lblHelp2";
            lblHelp2.Size = new Size(32, 15);
            lblHelp2.TabIndex = 18;
            lblHelp2.Text = "Help";
            lblHelp2.Click += lblHelp2_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Gill Sans Ultra Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialLabel2.Location = new Point(12, 9);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(714, 38);
            materialLabel2.TabIndex = 17;
            materialLabel2.Text = "Simple CRUP Database";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(lblHelp2);
            Controls.Add(lblHelp1);
            Controls.Add(lblHelp4);
            Controls.Add(lblHelp3);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(materialLabel1);
            Controls.Add(txtInfo);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnCreate);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCreate;
        private MaterialSkin.Controls.MaterialButton btnRead;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private Panel panel4;
        private Panel panel5;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ImageList waifu;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel6;
        private DataGridView dtDatabase;
        private MaterialSkin.Controls.MaterialLabel lblOptions;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private TextBox txtSearch;
        private Label lblHelp3;
        private Label lblHelp4;
        private Label lblHelp1;
        private Label lblHelp2;
        private MaterialSkin.Controls.MaterialLabel lblRandom;
        private MaterialSkin.Controls.MaterialLabel lblCount;
        private MaterialSkin.Controls.MaterialRadioButton rbtnAsc;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDesc;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
