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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel2.Location = new System.Drawing.Point(44, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 387);
            this.panel2.TabIndex = 1;
            // 
            // TxtTPVentaFin
            // 
            this.TxtTPVentaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtTPVentaFin.Location = new System.Drawing.Point(372, 31);
            this.TxtTPVentaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTPVentaFin.Name = "TxtTPVentaFin";
            this.TxtTPVentaFin.Size = new System.Drawing.Size(135, 22);
            this.TxtTPVentaFin.TabIndex = 5;
            // 
            // BGenerarGraficaVenta
            // 
            this.BGenerarGraficaVenta.BackColor = System.Drawing.Color.White;
            this.BGenerarGraficaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarGraficaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarGraficaVenta.Location = new System.Drawing.Point(539, 27);
            this.BGenerarGraficaVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BGenerarGraficaVenta.Name = "BGenerarGraficaVenta";
            this.BGenerarGraficaVenta.Size = new System.Drawing.Size(144, 27);
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
            this.LVentas.Location = new System.Drawing.Point(19, 0);
            this.LVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVentas.Name = "LVentas";
            this.LVentas.Size = new System.Drawing.Size(359, 25);
            this.LVentas.TabIndex = 0;
            this.LVentas.Text = "Cantidad de ventas por categoría";
            // 
            // TxtTPVentaInicio
            // 
            this.TxtTPVentaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtTPVentaInicio.Location = new System.Drawing.Point(116, 31);
            this.TxtTPVentaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTPVentaInicio.Name = "TxtTPVentaInicio";
            this.TxtTPVentaInicio.Size = new System.Drawing.Size(135, 22);
            this.TxtTPVentaInicio.TabIndex = 6;
            // 
            // ChartTopVentas
            // 
            this.ChartTopVentas.BackColor = System.Drawing.Color.SlateGray;
            this.ChartTopVentas.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.ChartTopVentas.BorderSkin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChartTopVentas.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea4.Name = "ChartArea1";
            this.ChartTopVentas.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartTopVentas.Legends.Add(legend4);
            this.ChartTopVentas.Location = new System.Drawing.Point(23, 68);
            this.ChartTopVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChartTopVentas.Name = "ChartTopVentas";
            this.ChartTopVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "Ventas";
            this.ChartTopVentas.Series.Add(series4);
            this.ChartTopVentas.Size = new System.Drawing.Size(753, 298);
            this.ChartTopVentas.TabIndex = 1;
            this.ChartTopVentas.Text = "chart2";
            // 
            // LFechaHastaVenta
            // 
            this.LFechaHastaVenta.AutoSize = true;
            this.LFechaHastaVenta.Location = new System.Drawing.Point(272, 33);
            this.LFechaHastaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaHastaVenta.Name = "LFechaHastaVenta";
            this.LFechaHastaVenta.Size = new System.Drawing.Size(84, 16);
            this.LFechaHastaVenta.TabIndex = 3;
            this.LFechaHastaVenta.Text = "Fecha hasta:";
            // 
            // LFechaInicioVenta
            // 
            this.LFechaInicioVenta.AutoSize = true;
            this.LFechaInicioVenta.Location = new System.Drawing.Point(19, 33);
            this.LFechaInicioVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaInicioVenta.Name = "LFechaInicioVenta";
            this.LFechaInicioVenta.Size = new System.Drawing.Size(82, 16);
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
            this.panel3.Location = new System.Drawing.Point(44, 409);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 370);
            this.panel3.TabIndex = 1;
            // 
            // BGenerarGraficaProdPreferidos
            // 
            this.BGenerarGraficaProdPreferidos.BackColor = System.Drawing.Color.White;
            this.BGenerarGraficaProdPreferidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarGraficaProdPreferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarGraficaProdPreferidos.Location = new System.Drawing.Point(539, 26);
            this.BGenerarGraficaProdPreferidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BGenerarGraficaProdPreferidos.Name = "BGenerarGraficaProdPreferidos";
            this.BGenerarGraficaProdPreferidos.Size = new System.Drawing.Size(144, 27);
            this.BGenerarGraficaProdPreferidos.TabIndex = 7;
            this.BGenerarGraficaProdPreferidos.Text = "Generar gráfica";
            this.BGenerarGraficaProdPreferidos.UseVisualStyleBackColor = false;
            this.BGenerarGraficaProdPreferidos.Click += new System.EventHandler(this.BGenerarGraficaProdPreferidos_Click);
            // 
            // TxtProdPrefFin
            // 
            this.TxtProdPrefFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtProdPrefFin.Location = new System.Drawing.Point(384, 26);
            this.TxtProdPrefFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProdPrefFin.Name = "TxtProdPrefFin";
            this.TxtProdPrefFin.Size = new System.Drawing.Size(135, 22);
            this.TxtProdPrefFin.TabIndex = 5;
            // 
            // LProductosPreferidos
            // 
            this.LProductosPreferidos.AutoSize = true;
            this.LProductosPreferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductosPreferidos.ForeColor = System.Drawing.Color.DimGray;
            this.LProductosPreferidos.Location = new System.Drawing.Point(4, 0);
            this.LProductosPreferidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LProductosPreferidos.Name = "LProductosPreferidos";
            this.LProductosPreferidos.Size = new System.Drawing.Size(269, 25);
            this.LProductosPreferidos.TabIndex = 0;
            this.LProductosPreferidos.Text = "Productos más vendidos";
            // 
            // ChartTopProductos
            // 
            this.ChartTopProductos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChartTopProductos.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.ChartTopProductos.BorderSkin.BackColor = System.Drawing.Color.White;
            this.ChartTopProductos.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea5.Name = "ChartArea1";
            this.ChartTopProductos.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ChartTopProductos.Legends.Add(legend5);
            this.ChartTopProductos.Location = new System.Drawing.Point(23, 60);
            this.ChartTopProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChartTopProductos.Name = "ChartTopProductos";
            this.ChartTopProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "ProductosPreferidos";
            this.ChartTopProductos.Series.Add(series5);
            this.ChartTopProductos.Size = new System.Drawing.Size(753, 302);
            this.ChartTopProductos.TabIndex = 1;
            this.ChartTopProductos.Text = "chart2";
            // 
            // LFechaInicioProdFav
            // 
            this.LFechaInicioProdFav.AutoSize = true;
            this.LFechaInicioProdFav.Location = new System.Drawing.Point(19, 33);
            this.LFechaInicioProdFav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaInicioProdFav.Name = "LFechaInicioProdFav";
            this.LFechaInicioProdFav.Size = new System.Drawing.Size(82, 16);
            this.LFechaInicioProdFav.TabIndex = 4;
            this.LFechaInicioProdFav.Text = "Fecha inicio:";
            // 
            // TxtProdPrefInicio
            // 
            this.TxtProdPrefInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtProdPrefInicio.Location = new System.Drawing.Point(116, 26);
            this.TxtProdPrefInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProdPrefInicio.Name = "TxtProdPrefInicio";
            this.TxtProdPrefInicio.Size = new System.Drawing.Size(135, 22);
            this.TxtProdPrefInicio.TabIndex = 6;
            // 
            // LFechaFinProdFav
            // 
            this.LFechaFinProdFav.AutoSize = true;
            this.LFechaFinProdFav.Location = new System.Drawing.Point(284, 33);
            this.LFechaFinProdFav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaFinProdFav.Name = "LFechaFinProdFav";
            this.LFechaFinProdFav.Size = new System.Drawing.Size(84, 16);
            this.LFechaFinProdFav.TabIndex = 3;
            this.LFechaFinProdFav.Text = "Fecha hasta:";
            // 
            // ChartCantProductosCategoria
            // 
            this.ChartCantProductosCategoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChartCantProductosCategoria.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.ChartCantProductosCategoria.BorderSkin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChartCantProductosCategoria.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea6.Name = "ChartArea1";
            this.ChartCantProductosCategoria.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ChartCantProductosCategoria.Legends.Add(legend6);
            this.ChartCantProductosCategoria.Location = new System.Drawing.Point(21, 42);
            this.ChartCantProductosCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChartCantProductosCategoria.Name = "ChartCantProductosCategoria";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Legend = "Legend1";
            series6.Name = "Productos por Categoria";
            this.ChartCantProductosCategoria.Series.Add(series6);
            this.ChartCantProductosCategoria.Size = new System.Drawing.Size(679, 687);
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
            this.panel4.Location = new System.Drawing.Point(908, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(731, 765);
            this.panel4.TabIndex = 0;
            // 
            // BGenerarGraficaProductoCategoria
            // 
            this.BGenerarGraficaProductoCategoria.BackColor = System.Drawing.Color.White;
            this.BGenerarGraficaProductoCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarGraficaProductoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarGraficaProductoCategoria.Location = new System.Drawing.Point(405, 7);
            this.BGenerarGraficaProductoCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BGenerarGraficaProductoCategoria.Name = "BGenerarGraficaProductoCategoria";
            this.BGenerarGraficaProductoCategoria.Size = new System.Drawing.Size(144, 27);
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
            this.LCantidadProdPorCategoria.Location = new System.Drawing.Point(17, 11);
            this.LCantidadProdPorCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCantidadProdPorCategoria.Name = "LCantidadProdPorCategoria";
            this.LCantidadProdPorCategoria.Size = new System.Drawing.Size(318, 20);
            this.LCantidadProdPorCategoria.TabIndex = 0;
            this.LCantidadProdPorCategoria.Text = "Productos registrados  por categoría";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1829, 789);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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