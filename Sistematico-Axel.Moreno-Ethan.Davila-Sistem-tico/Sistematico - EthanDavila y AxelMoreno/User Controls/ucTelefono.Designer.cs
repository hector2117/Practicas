
namespace Sistematico___EthanDavila_y_AxelMoreno.User_Controls
{
    partial class ucTelefono
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
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.LblNoExistencias = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblMarcaModelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LkLblNombre = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PBImage
            // 
            this.PBImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBImage.Location = new System.Drawing.Point(3, 18);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(402, 127);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBImage.TabIndex = 0;
            this.PBImage.TabStop = false;
            // 
            // LblNoExistencias
            // 
            this.LblNoExistencias.AutoSize = true;
            this.LblNoExistencias.Location = new System.Drawing.Point(15, 251);
            this.LblNoExistencias.Name = "LblNoExistencias";
            this.LblNoExistencias.Size = new System.Drawing.Size(64, 13);
            this.LblNoExistencias.TabIndex = 3;
            this.LblNoExistencias.Text = "Disponibles:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(15, 278);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(131, 13);
            this.LblDescripcion.TabIndex = 6;
            this.LblDescripcion.Text = "Descripción del Teléfono: ";
            // 
            // LblMarcaModelo
            // 
            this.LblMarcaModelo.AutoSize = true;
            this.LblMarcaModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarcaModelo.Location = new System.Drawing.Point(17, 199);
            this.LblMarcaModelo.Name = "LblMarcaModelo";
            this.LblMarcaModelo.Size = new System.Drawing.Size(0, 16);
            this.LblMarcaModelo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descripción: ";
            // 
            // LkLblNombre
            // 
            this.LkLblNombre.AutoSize = true;
            this.LkLblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLblNombre.LinkColor = System.Drawing.Color.Black;
            this.LkLblNombre.Location = new System.Drawing.Point(17, 163);
            this.LkLblNombre.Name = "LkLblNombre";
            this.LkLblNombre.Size = new System.Drawing.Size(63, 16);
            this.LkLblNombre.TabIndex = 11;
            this.LkLblNombre.TabStop = true;
            this.LkLblNombre.Text = "Nombre";
            this.LkLblNombre.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LkLblNombre_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // ucTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LkLblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMarcaModelo);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNoExistencias);
            this.Controls.Add(this.PBImage);
            this.Name = "ucTelefono";
            this.Size = new System.Drawing.Size(408, 376);
            this.Load += new System.EventHandler(this.ucTelefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBImage;
        private System.Windows.Forms.Label LblNoExistencias;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblMarcaModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LkLblNombre;
        private System.Windows.Forms.Label label2;
    }
}