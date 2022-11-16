namespace GrafikaAlap
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxPoligon = new System.Windows.Forms.CheckBox();
            this.redoBtn = new System.Windows.Forms.Button();
            this.lineColorBtn = new System.Windows.Forms.Button();
            this.canvasBackgroundBtn = new System.Windows.Forms.Button();
            this.savePolygon = new System.Windows.Forms.Button();
            this.polygonDropdown = new System.Windows.Forms.ComboBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.saveAs = new System.Windows.Forms.PictureBox();
            this.polygonState = new System.Windows.Forms.PictureBox();
            this.lineWidth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.canvas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.286344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.71365F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lineWidth);
            this.panel1.Controls.Add(this.saveAs);
            this.panel1.Controls.Add(this.polygonDropdown);
            this.panel1.Controls.Add(this.savePolygon);
            this.panel1.Controls.Add(this.checkBoxPoligon);
            this.panel1.Controls.Add(this.polygonState);
            this.panel1.Controls.Add(this.redoBtn);
            this.panel1.Controls.Add(this.lineColorBtn);
            this.panel1.Controls.Add(this.canvasBackgroundBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 30);
            this.panel1.TabIndex = 1;
            // 
            // checkBoxPoligon
            // 
            this.checkBoxPoligon.AutoSize = true;
            this.checkBoxPoligon.Location = new System.Drawing.Point(534, 8);
            this.checkBoxPoligon.Name = "checkBoxPoligon";
            this.checkBoxPoligon.Size = new System.Drawing.Size(105, 17);
            this.checkBoxPoligon.TabIndex = 4;
            this.checkBoxPoligon.Text = "Összekötött mód";
            this.checkBoxPoligon.UseVisualStyleBackColor = true;
            this.checkBoxPoligon.CheckedChanged += new System.EventHandler(this.checkBoxPoligon_CheckedChanged);
            // 
            // redoBtn
            // 
            this.redoBtn.Location = new System.Drawing.Point(803, 4);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(146, 23);
            this.redoBtn.TabIndex = 2;
            this.redoBtn.TabStop = false;
            this.redoBtn.Text = "Utolsó pont visszavonása";
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // lineColorBtn
            // 
            this.lineColorBtn.Location = new System.Drawing.Point(91, 4);
            this.lineColorBtn.Name = "lineColorBtn";
            this.lineColorBtn.Size = new System.Drawing.Size(75, 23);
            this.lineColorBtn.TabIndex = 1;
            this.lineColorBtn.TabStop = false;
            this.lineColorBtn.Text = "Vonalszín";
            this.lineColorBtn.UseVisualStyleBackColor = true;
            this.lineColorBtn.Click += new System.EventHandler(this.lineColorBtn_Click);
            // 
            // canvasBackgroundBtn
            // 
            this.canvasBackgroundBtn.Location = new System.Drawing.Point(10, 4);
            this.canvasBackgroundBtn.Name = "canvasBackgroundBtn";
            this.canvasBackgroundBtn.Size = new System.Drawing.Size(75, 23);
            this.canvasBackgroundBtn.TabIndex = 0;
            this.canvasBackgroundBtn.TabStop = false;
            this.canvasBackgroundBtn.Text = "Háttérszín";
            this.canvasBackgroundBtn.UseVisualStyleBackColor = true;
            this.canvasBackgroundBtn.Click += new System.EventHandler(this.canvasBackgroundBtn_Click);
            // 
            // savePolygon
            // 
            this.savePolygon.Location = new System.Drawing.Point(661, 4);
            this.savePolygon.Name = "savePolygon";
            this.savePolygon.Size = new System.Drawing.Size(127, 23);
            this.savePolygon.TabIndex = 5;
            this.savePolygon.Text = "Poligon befejezése";
            this.savePolygon.UseVisualStyleBackColor = true;
            this.savePolygon.Click += new System.EventHandler(this.savePolygon_Click);
            // 
            // polygonDropdown
            // 
            this.polygonDropdown.FormattingEnabled = true;
            this.polygonDropdown.Location = new System.Drawing.Point(478, 6);
            this.polygonDropdown.Name = "polygonDropdown";
            this.polygonDropdown.Size = new System.Drawing.Size(50, 21);
            this.polygonDropdown.TabIndex = 6;
            this.polygonDropdown.SelectedIndexChanged += new System.EventHandler(this.polygonDropdown_SelectedIndexChanged);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 36);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1264, 645);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // saveAs
            // 
            this.saveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAs.Image = global::GrafikaAlap.Properties.Resources.saveas;
            this.saveAs.Location = new System.Drawing.Point(1215, 0);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(34, 30);
            this.saveAs.TabIndex = 7;
            this.saveAs.TabStop = false;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // polygonState
            // 
            this.polygonState.BackgroundImage = global::GrafikaAlap.Properties.Resources.polygon;
            this.polygonState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.polygonState.Location = new System.Drawing.Point(440, 0);
            this.polygonState.Name = "polygonState";
            this.polygonState.Size = new System.Drawing.Size(32, 30);
            this.polygonState.TabIndex = 3;
            this.polygonState.TabStop = false;
            this.polygonState.Click += new System.EventHandler(this.polygonState_Click);
            // 
            // lineWidth
            // 
            this.lineWidth.Location = new System.Drawing.Point(289, 0);
            this.lineWidth.Maximum = 12;
            this.lineWidth.Minimum = 1;
            this.lineWidth.Name = "lineWidth";
            this.lineWidth.Size = new System.Drawing.Size(104, 45);
            this.lineWidth.TabIndex = 8;
            this.lineWidth.Value = 1;
            this.lineWidth.Scroll += new System.EventHandler(this.lineWidth_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vonalvastagság:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lineColorBtn;
        private System.Windows.Forms.Button canvasBackgroundBtn;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.PictureBox polygonState;
        private System.Windows.Forms.CheckBox checkBoxPoligon;
        private System.Windows.Forms.Button savePolygon;
        private System.Windows.Forms.ComboBox polygonDropdown;
        private System.Windows.Forms.PictureBox saveAs;
        private System.Windows.Forms.TrackBar lineWidth;
        private System.Windows.Forms.Label label1;
    }
}

