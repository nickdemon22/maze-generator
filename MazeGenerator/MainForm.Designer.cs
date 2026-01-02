namespace MazeGenerator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelControls = new Panel();
            btnSave = new Button();
            btnGenerate = new Button();
            btnRandomSeed = new Button();
            txtSeed = new TextBox();
            lblSeed = new Label();
            btnColorPick = new Button();
            lblColor = new Label();
            cmbDifficulty = new ComboBox();
            lblDifficulty = new Label();
            numHeight = new NumericUpDown();
            lblHeight = new Label();
            numWidth = new NumericUpDown();
            lblWidth = new Label();
            chkUnlimited = new CheckBox();
            picMaze = new PictureBox();
            panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaze).BeginInit();
            SuspendLayout();
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.WhiteSmoke;
            panelControls.Controls.Add(btnSave);
            panelControls.Controls.Add(btnGenerate);
            panelControls.Controls.Add(btnRandomSeed);
            panelControls.Controls.Add(txtSeed);
            panelControls.Controls.Add(lblSeed);
            panelControls.Controls.Add(btnColorPick);
            panelControls.Controls.Add(lblColor);
            panelControls.Controls.Add(cmbDifficulty);
            panelControls.Controls.Add(lblDifficulty);
            panelControls.Controls.Add(numHeight);
            panelControls.Controls.Add(lblHeight);
            panelControls.Controls.Add(numWidth);
            panelControls.Controls.Add(lblWidth);
            panelControls.Controls.Add(chkUnlimited);
            panelControls.Dock = DockStyle.Left;
            panelControls.Location = new Point(0, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(250, 561);
            panelControls.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(232, 33);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save as picture";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Gray;
            btnGenerate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(12, 292);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(232, 40);
            btnGenerate.TabIndex = 12;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // btnRandomSeed
            // 
            btnRandomSeed.Location = new Point(156, 241);
            btnRandomSeed.Name = "btnRandomSeed";
            btnRandomSeed.Size = new Size(88, 23);
            btnRandomSeed.TabIndex = 11;
            btnRandomSeed.Text = "Random";
            btnRandomSeed.UseVisualStyleBackColor = true;
            btnRandomSeed.Click += BtnRandomSeed_Click;
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(12, 242);
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(138, 23);
            txtSeed.TabIndex = 10;
            txtSeed.Text = "12345678";
            // 
            // lblSeed
            // 
            lblSeed.AutoSize = true;
            lblSeed.Location = new Point(12, 221);
            lblSeed.Name = "lblSeed";
            lblSeed.Size = new Size(35, 15);
            lblSeed.TabIndex = 9;
            lblSeed.Text = "Seed:";
            // 
            // btnColorPick
            // 
            btnColorPick.Location = new Point(12, 97);
            btnColorPick.Name = "btnColorPick";
            btnColorPick.Size = new Size(220, 25);
            btnColorPick.TabIndex = 8;
            btnColorPick.Text = "Pick";
            btnColorPick.UseVisualStyleBackColor = true;
            btnColorPick.Click += BtnColorPick_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(12, 79);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(39, 15);
            lblColor.TabIndex = 7;
            lblColor.Text = "Color:";
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.AutoCompleteCustomSource.AddRange(new string[] { "Easy", "Normal", "Insane" });
            cmbDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Normal", "Insane" });
            cmbDifficulty.Location = new Point(12, 43);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(220, 23);
            cmbDifficulty.TabIndex = 6;
            cmbDifficulty.SelectedIndexChanged += cmbDifficulty_SelectedIndexChanged;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(12, 25);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(58, 15);
            lblDifficulty.TabIndex = 5;
            lblDifficulty.Text = "Difficulty:";
            lblDifficulty.Click += lblDifficulty_Click;
            // 
            // numHeight
            // 
            numHeight.Location = new Point(12, 151);
            numHeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numHeight.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(80, 23);
            numHeight.TabIndex = 4;
            numHeight.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(12, 133);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(46, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height:";
            // 
            // numWidth
            // 
            numWidth.Location = new Point(98, 151);
            numWidth.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numWidth.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(80, 23);
            numWidth.TabIndex = 2;
            numWidth.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(98, 133);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(42, 15);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width:";
            // 
            // chkUnlimited
            // 
            chkUnlimited.AutoSize = true;
            chkUnlimited.Location = new Point(12, 180);
            chkUnlimited.Name = "chkUnlimited";
            chkUnlimited.Size = new Size(161, 19);
            chkUnlimited.TabIndex = 0;
            chkUnlimited.Text = "Unlimited (Experemental)";
            chkUnlimited.UseVisualStyleBackColor = true;
            chkUnlimited.CheckedChanged += ChkUnlimited_CheckedChanged;
            // 
            // picMaze
            // 
            picMaze.BackColor = Color.White;
            picMaze.BorderStyle = BorderStyle.FixedSingle;
            picMaze.Dock = DockStyle.Fill;
            picMaze.Location = new Point(250, 0);
            picMaze.Name = "picMaze";
            picMaze.Size = new Size(634, 561);
            picMaze.TabIndex = 1;
            picMaze.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(picMaze);
            Controls.Add(panelControls);
            MinimumSize = new Size(700, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maze Generator";
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaze).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panelControls;
        private CheckBox chkUnlimited;
        private Label lblWidth;
        private NumericUpDown numWidth;
        private Label lblHeight;
        private NumericUpDown numHeight;
        private Label lblDifficulty;
        private ComboBox cmbDifficulty;
        private Label lblColor;
        private Button btnColorPick;
        private Label lblSeed;
        private TextBox txtSeed;
        private Button btnRandomSeed;
        private Button btnGenerate;
        private Button btnSave;
        private PictureBox picMaze;
    }
}