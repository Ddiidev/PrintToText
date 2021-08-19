namespace PrintToText
{
	partial class frm
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pic = new System.Windows.Forms.PictureBox();
			this.t = new System.Windows.Forms.Timer(this.components);
			this.customPanel1 = new PrintToText.CustomPanel();
			this.lb = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			this.customPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pic
			// 
			this.pic.BackColor = System.Drawing.Color.Transparent;
			this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
			this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pic.Location = new System.Drawing.Point(0, 0);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(597, 402);
			this.pic.TabIndex = 0;
			this.pic.TabStop = false;
			this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
			this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
			this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
			// 
			// t
			// 
			this.t.Interval = 300;
			this.t.Tick += new System.EventHandler(this.t_Tick);
			// 
			// customPanel1
			// 
			this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.customPanel1.BackColorTransparent = System.Drawing.Color.Black;
			this.customPanel1.Controls.Add(this.lb);
			this.customPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.customPanel1.Location = new System.Drawing.Point(0, 0);
			this.customPanel1.Name = "customPanel1";
			this.customPanel1.Size = new System.Drawing.Size(597, 60);
			this.customPanel1.TabIndex = 1;
			this.customPanel1.TransparencyKey = 100;
			this.customPanel1.Visible = false;
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.Transparent;
			this.lb.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb.ForeColor = System.Drawing.Color.White;
			this.lb.Location = new System.Drawing.Point(0, 0);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(597, 35);
			this.lb.TabIndex = 1;
			this.lb.Text = "ENG";
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(597, 402);
			this.Controls.Add(this.customPanel1);
			this.Controls.Add(this.pic);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PrintToText";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			this.customPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pic;
		private CustomPanel customPanel1;
		private System.Windows.Forms.Label lb;
		public System.Windows.Forms.Timer t;
	}
}

