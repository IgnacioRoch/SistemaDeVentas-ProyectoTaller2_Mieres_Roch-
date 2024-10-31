namespace CapaPresentacion.Gerente_Comercial
{
    partial class FormEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtTPVentaFin = new System.Windows.Forms.DateTimePicker();
            this.BGenerarGraficaVenta = new System.Windows.Forms.Button();
            this.LVentas = new System.Windows.Forms.Label();
            this.TxtTPVentaInicio = new System.Windows.Forms.DateTimePicker();
            this.ChartTopVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LFechaHastaVenta = new System.Windows.Forms.Label();
            this.LFechaInicioVenta = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BGenerarGraficaProdPreferidos = new System.Windows.Forms.Button();
            this.TxtProdPrefFin = new System.Windows.Forms.DateTimePicker();
            this.LProductosPreferidos = new System.Windows.Forms.Label();
            this.ChartTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LFechaInicioProdFav = new System.Windows.Forms.Label();
            this.TxtProdPrefInicio = new System.Windows.Forms.DateTimePicker();
            this.LFechaFinProdFav = new System.Windows.Forms.Label();
            this.ChartCantProductosCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BGenerarGraficaProductoCategoria = new System.Windows.Forms.Button();
            this.LCantidadProdPorCategoria = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopVentas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCantProductosCategoria)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtTPVentaFin);
            this.panel2.Controls.Add(this.BGenerarGraficaVenta);
            this.panel2.Controls.Add(this.LVentas);
            this.panel2.Controls.Add(this.TxtTPVentaInicio);
            this.panel2.Controls.Add(this.ChartTopVentas);
            this.panel2.Controls.Add(this.LFechaHastaVenta);
            this.panel2.Controls.Add(this.LFechaInicioVenta);
            this.panel2.Location = new System.Drawing.Point(33, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 315);
            this.panel2.TabIndex = 1;
            // 
            // TxtTPVentaFin
            // 
            this.TxtTPVentaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtTPVentaFin.Location = new System.Drawing.Point(279, 25);
            this.TxtTPVentaFin.Name = "TxtTPVentaFin";
            this.TxtTPVentaFin.Size = new System.Drawing.Size(102, 20);
            this.TxtTPVentaFin.TabIndex = 5;
            // 
            // BGenerarGraficaVenta
            // 
            this.BGenerarGraficaVenta.BackColor = System.Drawing.Color.White;
            this.BGenerarGraficaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarGraficaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarGraficaVenta.Location = new System.Drawing.Point(404, 22);
            this.BGenerarGraficaVenta.Name = "BGenerarGraficaVenta";
            this.BGenerarGraficaVenta.Size = new System.Drawing.Size(108, 22);
            this.BGenerarGraficaVenta.TabIndex = 7;
            this.BGenerarGraficaVenta.Text = "Generar gráfica";
            this.BGenerarGraficaVenta.UseVisualStyleBackColor = false;
            this.BGenerarGraficaVenta.Click += new System.EventHandler(this.BGenerarGraficaVenta_Click);
            // 
            // LVentas
            // 
            this.LVentas.AutoSize = true;
            this.LVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentas.ForeColor = System.Drawing.Color.DimGray;
            this.LVentas.Location = new System.Drawing.Point(14, 0);
            this.LVentas.Name = "LVentas";
            this.LVentas.Size = new System.Drawing.Size(250, 16);
            this.LVentas.TabIndex = 0;
            this.LVentas.Text = "Ventas en relación a las ganancias";
            // 
            // TxtTPVentaInicio
            // 
            this.TxtTPVentaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtTPVentaInicio.Location = new System.Drawing.Point(87, 25);
            this.TxtTPVentaInicio.Name = "TxtTPVentaInicio";
            this.TxtTPVentaInicio.Size = new System.Drawing.Size(102, 20);
            this.TxtTPVentaInicio.TabIndex = 6;
            // 
            // ChartTopVentas
            // 
            this.ChartTopVentas.BackColor = System.Drawing.Color.SlateGray;
            this.ChartTopVentas.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.ChartTopVentas.BorderSkin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChartTopVentas.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea1.Name = "ChartArea1";
            this.ChartTopVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartTopVentas.Legends.Add(legend1);
            this.ChartTopVentas.Location = new System.Drawing.Point(17, 55);
            this.ChartTopVentas.Name = "ChartTopVentas";
            this.ChartTopVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            this.ChartTopVentas.Series.Add(series1);
            this.ChartTopVentas.Size = new System.Drawing.Size(565, 242);
            this.ChartTopVentas.TabIndex = 1;
            this.ChartTopVentas.Text = "chart2";
            // 
            // LFechaHastaVenta
            // 
            this.LFechaHastaVenta.AutoSize = true;
            this.LFechaHastaVenta.Location = new System.Drawing.Point(204, 27);
            this.LFechaHastaVenta.Name = "LFechaHastaVenta";
            this.LFechaHastaVenta.Size = new System.Drawing.Size(69, 13);
            this.LFechaHastaVenta.TabIndex = 3;
            this.LFechaHastaVenta.Text = "Fecha hasta:";
            // 
            // LFechaInicioVenta
            // 
            this.LFechaInicioVenta.AutoSize = true;
            this.LFechaInicioVenta.Location = new System.Drawing.Point(14, 27);
            this.LFechaInicioVenta.Name = "LFechaInicioVenta";
            this.LFechaInicioVenta.Size = new System.Drawing.Size(67, 13);
            this.LFechaInicioVenta.TabIndex = 4;
            this.LFechaInicioVenta.Text = "Fecha inicio:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BGenerarGraficaProdPreferidos);
            this.panel3.Controls.Add(this.TxtProdPrefFin);
            this.panel3.Controls.Add(this.LProductosPreferidos);
            this.panel3.Controls.Add(this.ChartTopProductos);
            this.panel3.Controls.Add(this.LFechaInicioProdFav);
            this.panel3.Controls.Add(this.TxtProdPrefInicio);
            this.panel3.Controls.Add(this.LFechaFinProdFav);
            this.panel3.Location = new System.Drawing.Point(33, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 301);
            this.panel3.TabIndex = 1;
            // 
            // BGenerarGraficaProdPreferidos
            // 
            this.BGenerarGraficaProdPreferidos.BackColor = System.Drawing.Color.White;
            this.BGenerarGraficaProdPreferidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarGraficaProdPreferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarGraficaProdPreferidos.Location = new System.Drawing.Point(404, 21);
            this.BGenerarGraficaProdPreferidos.Name = "BGenerarGraficaProdPreferidos";
            this.BGenerarGraficaProdPreferidos.Size = new System.Drawing.Size(108, 22);
            this.BGenerarGraficaProdPreferidos.TabIndex = 7;
            this.BGenerarGraficaProdPreferidos.Text = "Generar gráfica";
            this.BGenerarGraficaProdPreferidos.UseVisualStyleBackColor = false;
            this.BGenerarGraficaProdPreferidos.Click += new System.EventHandler(this.BGenerarGraficaProdPreferidos_Click);
            // 
            // TxtProdPrefFin
            // 
            this.TxtProdPrefFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtProdPrefFin.Location = new System.Drawing.Point(288, 21);
            this.TxtProdPrefFin.Name = "TxtProdPrefFin";
            this.TxtProdPrefFin.Size = new System.Drawing.Size(102, 20);
            this.TxtProdPrefFin.TabIndex = 5;
            // 
            // LProductosPreferidos
            // 
            this.LProductosPreferidos.AutoSize = true;
            this.LProductosPreferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductosPreferidos.ForeColor = System.Drawing.Color.DimGray;
            this.LProductosPreferidos.Location = new System.Drawing.Point(3, 0);
            this.LProductosPreferidos.Name = "LProductosPreferidos";
            this.LProductosPreferidos.Size = new System.Drawing.Size(152, 16);
            this.LProductosPreferidos.TabIndex = 0;
            this.LProductosPreferidos.Text = "Productos preferidos";
            // 
            // ChartTopProductos
            // 
            this.ChartTopProductos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChartTopProductos.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.ChartTopProductos.BorderSkin.BackColor = System.Drawing.Color.White;
            this.ChartTopProductos.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea2.Name = "ChartArea1";
            this.ChartTopProductos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartTopProductos.Legends.Add(legend2);
            this.ChartTopProductos.Location = new System.Drawing.Point(17, 49);
            this.ChartTopProductos.Name = "ChartTopProductos";
            this.ChartTopProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "ProductosPreferidos";
            this.ChartTopProductos.Series.Add(series2);
            this.ChartTopProductos.Size = new System.Drawing.Size(565, 245);
            this.ChartTopProductos.TabIndex = 1;
            this.ChartTopProductos.Text = "chart2";
            // 
            // LFechaInicioProdFav
            // 
            this.LFechaInicioProdFav.AutoSize = true;
            this.LFechaInicioProdFav.Location = new System.Drawing.Point(14, 27);
            this.LFechaInicioProdFav.Name = "LFechaInicioProdFav";
            this.LFechaInicioProdFav.Size = new System.Drawing.Size(67, 13);
            this.LFechaInicioProdFav.TabIndex = 4;
            this.LFechaInicioProdFav.Text = "Fecha inicio:";
            // 
            // TxtProdPrefInicio
            // 
            this.TxtProdPrefInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtProdPrefInicio.Location = new System.Drawing.Point(87, 21);
            this.TxtProdPrefInicio.Name = "TxtProdPrefInicio";
            this.TxtProdPrefInicio.Size = new System.Drawing.Size(102, 20);
            this.TxtProdPrefInicio.TabIndex = 6;
            // 
            // LFechaFinProdFav
            // 
            this.LFechaFinProdFav.AutoSize = true;
            this.LFechaFinProdFav.Location = new System.Drawing.Point(213, 27);
            this.LFechaFinProdFav.Name = "LFechaFinProdFav";
            this.LFechaFinProdFav.Size = new System.Drawing.Size(69, 13);
            this.LFechaFinProdFav.TabIndex = 3;
            this.LFechaFinProdFav.Text = "Fecha hasta:";
            // 
            // ChartCantProductosCategoria
            // 
            this.ChartCantProductosCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChartCantProductosCategoria.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.ChartCantProductosCategoria.BorderSkin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChartCantProductosCategoria.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea3.Name = "ChartArea1";
            this.ChartCantProductosCategoria.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartCantProductosCategoria.Legends.Add(legend3);
            this.ChartCantProductosCategoria.Location = new System.Drawing.Point(16, 34);
            this.ChartCantProductosCategoria.Name = "ChartCantProductosCategoria";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.Name = "Productos por Categoria";
            this.ChartCantProductosCategoria.Series.Add(series3);
            this.ChartCantProductosCategoria.Size = new System.Drawing.Size(509, 558);
            this.ChartCantProductosCategoria.TabIndex = 0;
            this.ChartCantProductosCategoria.Text = "Ventas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.BGenerarGraficaProductoCategoria);
            this.panel4.Controls.Add(this.LCantidadProdPorCategoria);
            this.panel4.Controls.Add(this.ChartCantProductosCategoria);
            this.panel4.Location = new System.Drawing.Point(681, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 622);
            this.panel4.TabIndex = 0;
            // 
            // BGenerarGraficaProductoCategoria
            // 
            this.BGenerarGraficaProductoCategoria.BackColor = System.Drawing.Color.White;
            this.BGenerarGraficaProductoCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarGraficaProductoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarGraficaProductoCategoria.Location = new System.Drawing.Point(304, 6);
            this.BGenerarGraficaProductoCategoria.Name = "BGenerarGraficaProductoCategoria";
            this.BGenerarGraficaProductoCategoria.Size = new System.Drawing.Size(108, 22);
            this.BGenerarGraficaProductoCategoria.TabIndex = 7;
            this.BGenerarGraficaProductoCategoria.Text = "Generar gráfica";
            this.BGenerarGraficaProductoCategoria.UseVisualStyleBackColor = false;
            this.BGenerarGraficaProductoCategoria.Click += new System.EventHandler(this.BGenerarGraficaProductoCategoria_Click);
            // 
            // LCantidadProdPorCategoria
            // 
            this.LCantidadProdPorCategoria.AutoSize = true;
            this.LCantidadProdPorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadProdPorCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.LCantidadProdPorCategoria.Location = new System.Drawing.Point(13, 9);
            this.LCantidadProdPorCategoria.Name = "LCantidadProdPorCategoria";
            this.LCantidadProdPorCategoria.Size = new System.Drawing.Size(261, 16);
            this.LCantidadProdPorCategoria.TabIndex = 0;
            this.LCantidadProdPorCategoria.Text = "Productos registrados  por categoría";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 641);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopVentas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCantProductosCategoria)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCantProductosCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTopVentas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LVentas;
        private System.Windows.Forms.Label LProductosPreferidos;
        private System.Windows.Forms.Label LCantidadProdPorCategoria;
        private System.Windows.Forms.DateTimePicker TxtTPVentaFin;
        private System.Windows.Forms.DateTimePicker TxtTPVentaInicio;
        private System.Windows.Forms.Label LFechaHastaVenta;
        private System.Windows.Forms.Label LFechaInicioVenta;
        private System.Windows.Forms.DateTimePicker TxtProdPrefFin;
        private System.Windows.Forms.Label LFechaInicioProdFav;
        private System.Windows.Forms.DateTimePicker TxtProdPrefInicio;
        private System.Windows.Forms.Label LFechaFinProdFav;
        private System.Windows.Forms.Button BGenerarGraficaProdPreferidos;
        private System.Windows.Forms.Button BGenerarGraficaVenta;
        private System.Windows.Forms.Button BGenerarGraficaProductoCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTopProductos;
    }
}