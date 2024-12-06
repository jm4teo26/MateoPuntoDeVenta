namespace Pantallas
{
    partial class frmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
            lblReporteVentas = new Label();
            label2 = new Label();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            lblFechaFin = new Label();
            btnBuscar = new Button();
            btnExportarPDF = new Button();
            listReporteVentas = new ListBox();
            SuspendLayout();
            // 
            // lblReporteVentas
            // 
            lblReporteVentas.AutoSize = true;
            lblReporteVentas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReporteVentas.Location = new Point(12, 9);
            lblReporteVentas.Name = "lblReporteVentas";
            lblReporteVentas.Size = new Size(168, 31);
            lblReporteVentas.TabIndex = 0;
            lblReporteVentas.Text = "Reporte Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Inicio:";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(137, 72);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(147, 27);
            txtFechaInicio.TabIndex = 2;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(385, 72);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(147, 27);
            txtFechaFin.TabIndex = 4;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(306, 75);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(73, 20);
            lblFechaFin.TabIndex = 3;
            lblFechaFin.Text = "Fecha Fin:";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(569, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 48);
            btnBuscar.TabIndex = 78;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Image = (Image)resources.GetObject("btnExportarPDF.Image");
            btnExportarPDF.ImageAlign = ContentAlignment.MiddleRight;
            btnExportarPDF.Location = new Point(12, 115);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.RightToLeft = RightToLeft.No;
            btnExportarPDF.Size = new Size(168, 38);
            btnExportarPDF.TabIndex = 79;
            btnExportarPDF.Text = "Exportar en PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            // 
            // listReporteVentas
            // 
            listReporteVentas.FormattingEnabled = true;
            listReporteVentas.Location = new Point(24, 167);
            listReporteVentas.Name = "listReporteVentas";
            listReporteVentas.Size = new Size(563, 224);
            listReporteVentas.TabIndex = 80;
            // 
            // frmReporteVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(636, 450);
            Controls.Add(listReporteVentas);
            Controls.Add(btnExportarPDF);
            Controls.Add(btnBuscar);
            Controls.Add(txtFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(label2);
            Controls.Add(lblReporteVentas);
            Name = "frmReporteVentas";
            Text = "Reporte Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReporteVentas;
        private Label label2;
        private TextBox txtFechaInicio;
        private TextBox txtFechaFin;
        private Label lblFechaFin;
        private Button btnBuscar;
        private Button btnExportarPDF;
        private ListBox listReporteVentas;
    }
}