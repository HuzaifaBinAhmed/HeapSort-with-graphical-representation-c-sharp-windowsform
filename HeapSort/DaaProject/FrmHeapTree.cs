using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaaProject
{
    public partial class FrmHeapTree : Form
    {
        private List<Player> players;
        private int[] heapArray;
        private float zoomFactor = 1.0f;
        private Dictionary<int, int> oldHeapPositions = new Dictionary<int, int>();
        private Dictionary<int, Point> nodePositions = new Dictionary<int, Point>();
        private bool isMaxHeap;
        int heapifyCallCount = 0;


        public FrmHeapTree(List<Player> players, bool isMaxHeap = true)
        {
            InitializeComponent();
            this.isMaxHeap = isMaxHeap;
            this.players = players.Select(p => new Player(p.Name, p.Score)).ToList(); 
            BuildAndDisplayHeap();
            RefreshComboboxes();
            MessageBox.Show("Heap Tree took these iterations to complete : " + heapifyCallCount);
            heapifyCallCount = 0;
        }
        private void RefreshComboboxes()
        {
            cmbplayers.Items.Clear();
            cmbscores.Items.Clear();
            foreach (var p in players)
            {
                cmbplayers.Items.Add(p.Name);
                cmbscores.Items.Add(p.Score);
            }
        }
        private void BuildMinHeap(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                MinHeapify(arr, n, i);
            }
        }
        private void MinHeapify(int[] arr, int n, int i)
        {
            heapifyCallCount++;
            int smallest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] < arr[smallest]) smallest = l;
            if (r < n && arr[r] < arr[smallest]) smallest = r;

            if (smallest != i)
            {
                int temp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = temp;
                MinHeapify(arr, n, smallest);
            }
        }
        private void BuildAndDisplayHeap()
        {
            if (players == null || players.Count == 0)
            {
                MessageBox.Show("No players to build heap.");
                return;
            }

            heapArray = players.Select(p => p.Score).ToArray();
            if (isMaxHeap)
                BuildMaxHeap(heapArray);
            else
                BuildMinHeap(heapArray);

            DrawHeapToBitmap();
        }

        private void BuildMaxHeap(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            heapifyCallCount++;
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > arr[largest]) largest = l;
            if (r < n && arr[r] > arr[largest]) largest = r;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                Heapify(arr, n, largest);
            }
        }
        private void FrmHeapTree_Load(object sender, EventArgs e)
        {

        }
        private void DrawHeapToBitmap()
        {
            if (heapArray == null || heapArray.Length == 0)
                return;

            int width = (int)(2000 * zoomFactor);
            int height = (int)(1000 * zoomFactor);
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            nodePositions.Clear();

            int treeHeight = GetTreeHeight(heapArray.Length);
            DrawHeapTree(g, heapArray, 0, width / 2, 40, 0, treeHeight);

            HeapTreeBox.Image = bmp;
            HeapTreeBox.Size = bmp.Size;
            buttonContainer.Dock = DockStyle.Left;
        }
        private int GetTreeHeight(int nodeCount)
        {
            return (int)Math.Ceiling(Math.Log(nodeCount + 1, 2));
        }
        private void DrawHeapTree(Graphics g, int[] heap, int index, int x, int y, int level, int totalHeight)
        {
            if (index >= heap.Length) return;

            int value = heap[index];
            nodePositions[value] = new Point(x, y);

            string playerName = players.FirstOrDefault(p => p.Score == value)?.Name ?? "";

            Brush nodeBrush = Brushes.Blue;
            if (oldHeapPositions.TryGetValue(index, out int oldIndex))
            {
                if (oldIndex > index) nodeBrush = Brushes.Green;
                else if (oldIndex < index) nodeBrush = Brushes.Red;
            }

            int nodeSize = (int)(40 * zoomFactor);
            int fontSize = (int)(this.Font.Size * zoomFactor);

            using (Font zoomFont = new Font(this.Font.FontFamily, fontSize))
            using (Font nameFont = new Font(this.Font.FontFamily, fontSize * 0.9f, FontStyle.Bold))

            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.FillEllipse(nodeBrush, x - nodeSize / 2, y - nodeSize / 2, nodeSize, nodeSize);
                g.DrawEllipse(Pens.Black, x - nodeSize / 2, y - nodeSize / 2, nodeSize, nodeSize);
                g.DrawString(value.ToString(), zoomFont, Brushes.White, new RectangleF(x - nodeSize / 2, y - nodeSize / 2, nodeSize, nodeSize), sf);
                g.DrawString(playerName, nameFont, Brushes.Black, new RectangleF(x - 40, y - nodeSize - 15, 80, 15), sf);
            }

            int verticalSpacing = (int)(90 * zoomFactor);
            int horizontalSpacing = (int)(scrollContainer.Width / Math.Pow(2, level + 2) * zoomFactor);

            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < heap.Length)
            {
                g.DrawLine(Pens.Black, x, y + nodeSize / 2, x - horizontalSpacing, y + verticalSpacing - nodeSize / 2);
                DrawHeapTree(g, heap, left, x - horizontalSpacing, y + verticalSpacing, level + 1, totalHeight);
            }

            if (right < heap.Length)
            {
                g.DrawLine(Pens.Black, x, y + nodeSize / 2, x + horizontalSpacing, y + verticalSpacing - nodeSize / 2);
                DrawHeapTree(g, heap, right, x + horizontalSpacing, y + verticalSpacing, level + 1, totalHeight);
            }
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            zoomFactor += 0.1f;
            DrawHeapToBitmap();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            zoomFactor = Math.Max(0.2f, zoomFactor - 0.1f);
            DrawHeapToBitmap();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbplayers.SelectedItem == null)
            {
                MessageBox.Show("Please select a player to remove.");
                return;
            }

            string playerName = cmbplayers.SelectedItem.ToString();
            var playerToRemove = players.FirstOrDefault(p => p.Name == playerName);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                MessageBox.Show($"{playerName} removed from leaderboard.");

                RefreshComboboxes();
                BuildAndDisplayHeap();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbplayers.SelectedItem == null || cmbscores.Text == "")
            {
                MessageBox.Show("Please select a player and enter a new score.");
                return;
            }

            string playerName = cmbplayers.SelectedItem.ToString();
            if (!int.TryParse(cmbscores.Text, out int newScore))
            {
                MessageBox.Show("Invalid score.");
                return;
            }

            var player = players.FirstOrDefault(p => p.Name == playerName);
            if (player == null) return;

            int oldScore = player.Score;
            player.Score = newScore;

            VisualizeChange(oldScore, newScore);
            BuildAndDisplayHeap();

        }
        private void VisualizeChange(int oldScore, int newScore)
        {
            string movement = newScore > oldScore ? "moved up" :
                              newScore < oldScore ? "moved down" : "unchanged";

            MessageBox.Show($"Score updated: {oldScore} → {newScore} ({movement})", "Heap Update");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            players.Clear();
            heapArray = null;
            oldHeapPositions.Clear();
            nodePositions.Clear();

            cmbplayers.Items.Clear();
            cmbscores.Items.Clear();

            scrollContainer.Invalidate();
        }

        private void cmbplayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPlayerName = cmbplayers.SelectedItem.ToString();
            var selectedPlayer = players.FirstOrDefault(p => p.Name == selectedPlayerName);

            if (selectedPlayer != null)
            {
                cmbscores.Items.Clear();
                cmbscores.Items.Add(selectedPlayer.Score);
                cmbscores.SelectedIndex = 0;
            }
        }

        private void cmbscores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
