using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrafikaDLL;

namespace GrafikaAlap
{
    public partial class Form1 : Form
    {
        Graphics g;
        int dist = ExtensionPointF.DIST;

        List<Pen> linePens = new List<Pen>();
        Pen linePen = new Pen(Color.Black,4);

        List<List<PointF>> polygonObjects = new List<List<PointF>>();
        List<PointF> selectedPolygonPoints = new List<PointF>();
        int selectedPolygonIndex = 0;
        int grabbedIndex = -1;
        bool drawingState = false;
        bool movingState = false;

        public Form1()
        {
            InitializeComponent();
            linePens.Add(new Pen(Color.Black, 4));
            polygonObjects.Add(selectedPolygonPoints);
            polygonDropdown.DataSource = GetPolygonObjectIndexes();
        }

        List<int> GetPolygonObjectIndexes()
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < polygonObjects.Count; i++)
            {
                indexes.Add(i);
            }
            return indexes;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            // jobbra - le
            g = e.Graphics;
            drawPolygon(g);
            drawPolygonPoint(g);
        }

        private void drawPolygon(Graphics polygon)
        {

            for (int i = 0; i < polygonObjects.Count; i++)
            {
                for (int j = 0; j < polygonObjects[i].Count - 1; j++)
                {
                    g.DrawLine(linePens[i], polygonObjects[i][j], polygonObjects[i][j + 1]);
                }

                if (checkBoxPoligon.Checked && polygonObjects[i].Count >= 3)
                {
                    g.DrawLine(linePens[i], polygonObjects[i][0], polygonObjects[i][polygonObjects[i].Count - 1]);
                }
            }
            

        }

        private void drawPolygonPoint(Graphics polygon)
        {
            for (int i = 0; i < polygonObjects.Count; i++)
            {
                for (int j = 0; j < polygonObjects[i].Count; j++)
                {
                    g.DrawEllipse(Pens.Black, polygonObjects[i][j].X - dist, polygonObjects[i][j].Y - dist,
                          2 * dist, 2 * dist);
                }
            }
            
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawingState)
            {
                polygonObjects[selectedPolygonIndex].Add(new PointF(e.X, e.Y));
            }
            else if (movingState)
            {
                foreach (PointF point in polygonObjects[selectedPolygonIndex])
                {
                    if (point.IsGrabbed(new PointF(e.X,e.Y)))
                    {
                        grabbedIndex = polygonObjects[selectedPolygonIndex].IndexOf(point);
                    }
                }
            }
            canvas.Invalidate();
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouseup");
            grabbedIndex = -1;
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (grabbedIndex != -1)
            {
                polygonObjects[selectedPolygonIndex][grabbedIndex] = new PointF(e.X, e.Y);
                canvas.Invalidate();
            }
        }

        private void polygonState_Click(object sender, EventArgs e)
        {
            drawingState = !drawingState;
            if (drawingState)
            {
                polygonState.BackColor = Color.LightGray;
                movingState = false;
            }
            else
            {
                polygonState.BackColor = Color.White;
                movingState = true;
            }
        }

        #region User eksönök
        // background color picker
        #endregion

        private void lineColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                linePens[selectedPolygonIndex].Color = MyDialog.Color;

            lineColorBtn.TabStop = false;
            canvas.Invalidate();
        }

        private void canvasBackgroundBtn_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.BackColor = MyDialog.Color;
                Console.WriteLine(MyDialog.Color);
            }

            canvasBackgroundBtn.TabStop = false;
            canvas.Focus();
            canvas.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                if (polygonObjects[selectedPolygonIndex].Count > 0) polygonObjects[selectedPolygonIndex].RemoveAt(selectedPolygonPoints.Count - 1);
                canvas.Invalidate();
            }
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            if (polygonObjects[selectedPolygonIndex].Count > 0) polygonObjects[selectedPolygonIndex].RemoveAt(polygonObjects[selectedPolygonIndex].Count - 1);
            canvas.Invalidate();
        }

        private void checkBoxPoligon_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void savePolygon_Click(object sender, EventArgs e)
        {
            if(polygonObjects[selectedPolygonIndex].Count < 3)
            {
                MessageBox.Show("Csak olyan poligont tudsz menteni amely legalább 3 pöttyből áll.");
                return;
            }
     

           
            polygonObjects.Add(new List<PointF>());
            linePens.Add(new Pen(Color.Black, 3));
            selectedPolygonIndex = polygonObjects.Count - 1;
            polygonDropdown.DataSource = GetPolygonObjectIndexes();
            polygonDropdown.SelectedIndex = polygonObjects.Count - 1;

            canvas.Invalidate();
        }

        private void polygonDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            selectedPolygonIndex = (int)cmb.SelectedValue;
            Console.WriteLine(selectedPolygonIndex);
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap targetBitmap = new Bitmap(canvas.ClientSize.Width,
                    canvas.ClientSize.Height);
                    canvas.DrawToBitmap(targetBitmap, canvas.ClientRectangle);
                    targetBitmap.Save(saveFileDialog.FileName);
                }
            }
        }

        private void lineWidth_Scroll(object sender, EventArgs e)
        {
            linePens[selectedPolygonIndex].Width = int.Parse(lineWidth.Value.ToString());
            canvas.Invalidate();
        }
    }
}
