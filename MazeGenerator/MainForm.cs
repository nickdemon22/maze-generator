using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGenerator
{
    public partial class MainForm : Form
    {
        private ColorDialog colorDialog;
        private Color mazeColor = Color.Black;

        public MainForm()
        {
            InitializeComponent();


            colorDialog = new ColorDialog();
            colorDialog.Color = mazeColor;

            Random rnd = new Random();
            txtSeed.Text = rnd.Next(10000000, 99999999).ToString();

            btnColorPick.BackColor = mazeColor;
            btnColorPick.ForeColor = Color.White;
        }

        private void ChkUnlimited_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnlimited.Checked)
            {
                numWidth.Maximum = 9999999999999999;
                numHeight.Maximum = 9999999999999999;
                numWidth.Value = 67;
                numHeight.Value = 67;
            }
            else
            {
                numWidth.Maximum = 500;
                numHeight.Maximum = 500;
                numWidth.Value = 67;
                numHeight.Value = 67;
            }
        }

        private void BtnColorPick_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mazeColor = colorDialog.Color;
                btnColorPick.BackColor = mazeColor;
            }
        }

        private void BtnRandomSeed_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txtSeed.Text = rnd.Next(10000000, 99999999).ToString();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            GenerateMaze();
        }

        private void GenerateMaze()
        {
            try
            {
                Cursor = Cursors.WaitCursor;


                int width = (int)numWidth.Value;
                int height = (int)numHeight.Value;

                if (!int.TryParse(txtSeed.Text, out int seed))
                {
                    seed = Math.Abs(txtSeed.Text.GetHashCode());
                }

                string difficulty = cmbDifficulty.SelectedItem.ToString();


                Maze maze = new Maze(width, height, seed, difficulty);

                Bitmap bitmap = DrawMaze(maze);


                if (picMaze.Image != null)
                {
                    picMaze.Image.Dispose();
                }
                picMaze.Image = bitmap;

                this.Text = $"Maze Generator - {width}x{height} | Seed: {seed} | Difficulty: {difficulty}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed generation!: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private Bitmap DrawMaze(Maze maze)
        {
            if (picMaze.Width <= 0 || picMaze.Height <= 0)
                return new Bitmap(1, 1);

            int cellSize = Math.Max(2, Math.Min(
                picMaze.Width / maze.Width,
                picMaze.Height / maze.Height));

            Bitmap bitmap = new Bitmap(maze.Width * cellSize, maze.Height * cellSize);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                for (int x = 0; x < maze.Width; x++)
                {
                    for (int y = 0; y < maze.Height; y++)
                    {
                        Color color;

                        switch (maze.Grid[x, y])
                        {
                            case CellState.Wall:
                                color = mazeColor;
                                break;
                            case CellState.Path:
                                color = Color.White;
                                break;
                            case CellState.Start:
                                color = Color.Green;
                                break;
                            case CellState.Exit:
                                color = Color.Red;
                                break;
                            default:
                                color = Color.White;
                                break;
                        }

                        using (Brush brush = new SolidBrush(color))
                        {
                            g.FillRectangle(brush,
                                x * cellSize,
                                y * cellSize,
                                cellSize,
                                cellSize);
                        }
                    }
                }
            }

            return bitmap;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (picMaze.Image == null)
            {
                MessageBox.Show("Generate maze first!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveDialog.Title = "Save maze to picture";
            saveDialog.FileName = $"solution_{DateTime.Now:yyyyMMdd_HHmmss}";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picMaze.Image.Save(saveDialog.FileName);
                    MessageBox.Show($"Saved to:\n{saveDialog.FileName}", "Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to save!: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (picMaze.Image != null)
            {
                picMaze.Image.Dispose();
            }
            base.OnFormClosing(e);
        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDifficulty_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}