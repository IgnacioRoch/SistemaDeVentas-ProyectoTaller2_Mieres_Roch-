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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LVentas = new System.Windows.Forms.Label();
            this.ChartTopVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LProductosPreferidos = new System.Windows.Forms.Label();
            this.ChartTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartCantProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LCantidadProductos = new System.Windows.Forms.Label();
            this.LNroClientes = new System.Windows.Forms.Label();
            this.LNroProveedores = new System.Windows.Forms.Label();
            this.LNroUsuarios = new System.Windows.Forms.Label();
            this.LNroMarcas = new System.Windows.Forms.Label();
            this.LCategorias = new System.Windows.Forms.Label();
            this.LNroProductos = new System.Windows.Forms.Label();
            this.LStockbajo = new System.Windows.Forms.Label();
            this.LCantVentas = new System.Windows.Forms.Label();
            this.NroValor1 = new System.Windows.Forms.Label();
            this.NroValor2 = new System.Windows.Forms.Label();
            this.NroValor3 = new System.Windows.Forms.Label();
            this.NroValor4 = new System.Windows.Forms.Label();
            this.NroValor5 = new System.Windows.Forms.Label();
            this.NroValor6 = new System.Windows.Forms.Label();
            this.NroValor7 = new System.Windows.Forms.Label();
            this.NroValor8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopVentas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCantProductos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LNroClientes);
            this.panel1.Controls.Add(this.LNroProveedores);
            this.panel1.Controls.Add(this.LNroUsuarios);
            this.panel1.Controls.Add(this.LNroMarcas);
            this.panel1.Controls.Add(this.LCategorias);
            this.panel1.Controls.Add(this.LNroProductos);
            this.panel1.Controls.Add(this.LStockbajo);
            this.panel1.Controls.Add(this.NroValor8);
            this.panel1.Controls.Add(this.NroValor7);
            this.panel1.Controls.Add(this.NroValor6);
            this.panel1.Controls.Add(this.NroValor5);
            this.panel1.Controls.Add(this.NroValor4);
            this.panel1.Controls.Add(this.NroValor3);
            this.panel1.Controls.Add(this.NroValor2);
            this.panel1.Controls.Add(this.NroValor1);
            this.panel1.Controls.Add(this.LCantVentas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 594);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LVentas);
            this.panel2.Controls.Add(this.ChartTopVentas);
            this.panel2.Location = new System.Drawing.Point(308, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 310);
            this.panel2.TabIndex = 1;
            // 
            // LVentas
            // 
            this.LVentas.AutoSize = true;
            this.LVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentas.ForeColor = System.Drawing.Color.DimGray;
            this.LVentas.Location = new System.Drawing.Point(14, 0);
            this.LVentas.Name = "LVentas";
            this.LVentas.Size = new System.Drawing.Size(55, 16);
            this.LVentas.TabIndex = 0;
            this.LVentas.Text = "Ventas";
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
            this.ChartTopVentas.Location = new System.Drawing.Point(17, 26);
            this.ChartTopVentas.Name = "ChartTopVentas";
            this.ChartTopVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ChartTopVentas.Series.Add(series4);
            this.ChartTopVentas.Size = new System.Drawing.Size(485, 271);
            this.ChartTopVentas.TabIndex = 1;
            this.ChartTopVentas.Text = "chart2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.LProductosPreferidos);
            this.panel3.Controls.Add(this.ChartTopProductos);
            this.panel3.Location = new System.Drawing.Point(308, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 278);
            this.panel3.TabIndex = 1;
            // 
            // LProductosPreferidos
            // 
            this.LProductosPreferidos.AutoSize = true;
            this.LProductosPreferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductosPreferidos.ForeColor = System.Drawing.Color.DimGray;
            this.LProductosPreferidos.Location = new System.Drawing.Point(14, 0);
            this.LProductosPreferidos.Name = "LProductosPreferidos";
            this.LProductosPreferidos.Size = new System.Drawing.Size(192, 16);
            this.LProductosPreferidos.TabIndex = 0;
            this.LProductosPreferidos.Text = "Los 6 productos preferidos";
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
            this.ChartTopProductos.Location = new System.Drawing.Point(14, 24);
            this.ChartTopProductos.Name = "ChartTopProductos";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.ChartTopProductos.Series.Add(series5);
            this.ChartTopProductos.Size = new System.Drawing.Size(485, 251);
            this.ChartTopProductos.TabIndex = 1;
            this.ChartTopProductos.Text = "chart2";
            // 
            // ChartCantProductos
            // 
            this.ChartCantProductos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChartCantProductos.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.ChartCantProductos.BorderSkin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChartCantProductos.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea6.Name = "ChartArea1";
            this.ChartCantProductos.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ChartCantProductos.Legends.Add(legend6);
            this.ChartCantProductos.Location = new System.Drawing.Point(16, 26);
            this.ChartCantProductos.Name = "ChartCantProductos";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.ChartCantProductos.Series.Add(series6);
            this.ChartCantProductos.Size = new System.Drawing.Size(345, 531);
            this.ChartCantProductos.TabIndex = 0;
            this.ChartCantProductos.Text = "Ventas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.LCantidadProductos);
            this.panel4.Controls.Add(this.ChartCantProductos);
            this.panel4.Location = new System.Drawing.Point(848, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(382, 594);
            this.panel4.TabIndex = 0;
            // 
            // LCantidadProductos
            // 
            this.LCantidadProductos.AutoSize = true;
            this.LCantidadProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadProductos.ForeColor = System.Drawing.Color.DimGray;
            this.LCantidadProductos.Location = new System.Drawing.Point(13, 0);
            this.LCantidadProductos.Name = "LCantidadProductos";
            this.LCantidadProductos.Size = new System.Drawing.Size(261, 16);
            this.LCantidadProductos.TabIndex = 0;
            this.LCantidadProductos.Text = "Cantidad de productos por categoría";
            // 
            // LNroClientes
            // 
            this.LNroClientes.BackColor = System.Drawing.Color.Transparent;
            this.LNroClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LNroClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroClientes.ForeColor = System.Drawing.Color.DimGray;
            this.LNroClientes.Image = global::CapaPresentacion.Properties.Resources.iconsClientes;
            this.LNroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LNroClientes.Location = new System.Drawing.Point(3, 428);
            this.LNroClientes.Name = "LNroClientes";
            this.LNroClientes.Size = new System.Drawing.Size(201, 57);
            this.LNroClientes.TabIndex = 0;
            this.LNroClientes.Text = "N° Clientes";
            this.LNroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LNroClientes.UseCompatibleTextRendering = true;
            // 
            // LNroProveedores
            // 
            this.LNroProveedores.BackColor = System.Drawing.Color.Transparent;
            this.LNroProveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LNroProveedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroProveedores.ForeColor = System.Drawing.Color.DimGray;
            this.LNroProveedores.Image = global::CapaPresentacion.Properties.Resources.iconsProveedores;
            this.LNroProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LNroProveedores.Location = new System.Drawing.Point(3, 356);
            this.LNroProveedores.Name = "LNroProveedores";
            this.LNroProveedores.Size = new System.Drawing.Size(201, 57);
            this.LNroProveedores.TabIndex = 0;
            this.LNroProveedores.Text = "N° Proveedores";
            this.LNroProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LNroProveedores.UseCompatibleTextRendering = true;
            // 
            // LNroUsuarios
            // 
            this.LNroUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.LNroUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LNroUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroUsuarios.ForeColor = System.Drawing.Color.DimGray;
            this.LNroUsuarios.Image = global::CapaPresentacion.Properties.Resources.iconsUsuarios;
            this.LNroUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LNroUsuarios.Location = new System.Drawing.Point(3, 500);
            this.LNroUsuarios.Name = "LNroUsuarios";
            this.LNroUsuarios.Size = new System.Drawing.Size(201, 57);
            this.LNroUsuarios.TabIndex = 0;
            this.LNroUsuarios.Text = "N° Usuarios";
            this.LNroUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LNroUsuarios.UseCompatibleTextRendering = true;
            // 
            // LNroMarcas
            // 
            this.LNroMarcas.BackColor = System.Drawing.Color.Transparent;
            this.LNroMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LNroMarcas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroMarcas.ForeColor = System.Drawing.Color.DimGray;
            this.LNroMarcas.Image = global::CapaPresentacion.Properties.Resources.iconsMarcas;
            this.LNroMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LNroMarcas.Location = new System.Drawing.Point(3, 285);
            this.LNroMarcas.Name = "LNroMarcas";
            this.LNroMarcas.Size = new System.Drawing.Size(201, 57);
            this.LNroMarcas.TabIndex = 0;
            this.LNroMarcas.Text = "N° Marcas";
            this.LNroMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LNroMarcas.UseCompatibleTextRendering = true;
            // 
            // LCategorias
            // 
            this.LCategorias.BackColor = System.Drawing.Color.Transparent;
            this.LCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LCategorias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategorias.ForeColor = System.Drawing.Color.DimGray;
            this.LCategorias.Image = global::CapaPresentacion.Properties.Resources.iconsCategorias;
            this.LCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LCategorias.Location = new System.Drawing.Point(3, 215);
            this.LCategorias.Name = "LCategorias";
            this.LCategorias.Size = new System.Drawing.Size(201, 57);
            this.LCategorias.TabIndex = 0;
            this.LCategorias.Text = "N° Categorias";
            this.LCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LCategorias.UseCompatibleTextRendering = true;
            // 
            // LNroProductos
            // 
            this.LNroProductos.BackColor = System.Drawing.Color.Transparent;
            this.LNroProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LNroProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroProductos.ForeColor = System.Drawing.Color.DimGray;
            this.LNroProductos.Image = global::CapaPresentacion.Properties.Resources.iconsProductos;
            this.LNroProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LNroProductos.Location = new System.Drawing.Point(3, 146);
            this.LNroProductos.Name = "LNroProductos";
            this.LNroProductos.Size = new System.Drawing.Size(201, 57);
            this.LNroProductos.TabIndex = 0;
            this.LNroProductos.Text = "N° Productos";
            this.LNroProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LNroProductos.UseCompatibleTextRendering = true;
            // 
            // LStockbajo
            // 
            this.LStockbajo.BackColor = System.Drawing.Color.Transparent;
            this.LStockbajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LStockbajo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStockbajo.ForeColor = System.Drawing.Color.DimGray;
            this.LStockbajo.Image = global::CapaPresentacion.Properties.Resources.iconsCepo;
            this.LStockbajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LStockbajo.Location = new System.Drawing.Point(3, 78);
            this.LStockbajo.Name = "LStockbajo";
            this.LStockbajo.Size = new System.Drawing.Size(201, 57);
            this.LStockbajo.TabIndex = 0;
            this.LStockbajo.Text = "Stock bajo";
            this.LStockbajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LStockbajo.UseCompatibleTextRendering = true;
            // 
            // LCantVentas
            // 
            this.LCantVentas.BackColor = System.Drawing.Color.Transparent;
            this.LCantVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LCantVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantVentas.ForeColor = System.Drawing.Color.DimGray;
            this.LCantVentas.Image = global::CapaPresentacion.Properties.Resources.iconsBolsaDinero;
            this.LCantVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LCantVentas.Location = new System.Drawing.Point(3, 9);
            this.LCantVentas.Name = "LCantVentas";
            this.LCantVentas.Size = new System.Drawing.Size(201, 57);
            this.LCantVentas.TabIndex = 0;
            this.LCantVentas.Text = "Total de ventas";
            this.LCantVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LCantVentas.UseCompatibleTextRendering = true;
            // 
            // NroValor1
            // 
            this.NroValor1.BackColor = System.Drawing.Color.Transparent;
            this.NroValor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NroValor1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroValor1.ForeColor = System.Drawing.Color.DimGray;
            this.NroValor1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NroValor1.Location = new System.Drawing.Point(210, 9);
            this.NroValor1.Name = "NroValor1";
            this.NroValor1.Size = new System.Drawing.Size(73, 57);
            this.NroValor1.TabIndex = 0;
            this.NroValor1.Text = "valor";
            this.NroValor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NroValor1.UseCompatibleTextRendering = true;
            // 
            // NroValor2
            // 
            this.NroValor2.BackColor = System.Drawing.Color.Transparent;
            this.NroValor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NroValor2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroValor2.ForeColor = System.Drawing.Color.DimGray;
            this.NroValor2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NroValor2.Location = new System.Drawing.Point(210, 78);
            this.NroValor2.Name = "NroValor2";
            this.NroValor2.Size = new System.Drawing.Size(73, 57);
            this.NroValor2.TabIndex = 0;
            this.NroValor2.Text = "valor";
            this.NroValor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NroValor2.UseCompatibleTextRendering = true;
            // 
            // NroValor3
            // 
            this.NroValor3.BackColor = System.Drawing.Color.Transparent;
            this.NroValor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NroValor3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroValor3.ForeColor = System.Drawing.Color.DimGray;
            this.NroValor3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NroValor3.Location = new System.Drawing.Point(210, 147);
            this.NroValor3.Name = "NroValor3";
            this.NroValor3.Size = new System.Drawing.Size(73, 57);
            this.NroValor3.TabIndex = 0;
            this.NroValor3.Text = "valor";
            this.NroValor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NroValor3.UseCompatibleTextRendering = true;
            // 
            // NroValor4
            // 
            this.NroValor4.BackColor = System.Drawing.Color.Transparent;
            this.NroValor4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NroValor4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroValor4.ForeColor = System.Drawing.Color.DimGray;
            this.NroValor4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NroValor4.Location = new System.Drawing.Point(210, 216);
            this.NroValor4.Name = "NroValor4";
            this.NroValor4.Size = new System.Drawing.Size(73, 57);
            this.NroValor4.TabIndex = 0;
            this.NroValor4.Text = "valor";
            this.NroValor4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NroValor4.UseCompatibleTextRendering = true;
            // 
            // NroValor5
            // 
            this.NroValor5.BackColor = System.Drawing.Color.Transparent;
            this.NroValor5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NroValor5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroValor5.ForeColor = System.Drawing.Color.DimGray;
            this.NroValor5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NroValor5.Location = new System.Drawing.Point(210, 286);
            this.NroValor5.Name = "NroValor5";
            this.NroValor5.Size = new System.Drawing.Size(73, 57);
            this.NroValor5.TabIndex = 0;
            this.NroValor5.Text = "valor";
            this.NroValor5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NroValor5.UseCompatibleTextRendering = true;
            // 
            // NroValor6
            // 
            this.NroValor6.BackColor = System.Drawing.Color.Transparent;
            this.NroValor6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NroValor6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroValor6.ForeColor = System.Drawing.Color.DimGray;
            this.NroValor6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NroValor6.Location = new System.Drawing.Point(210, 357);
            this.NroValor6.Name = "NroValor6";
            this.NroValor6.Size = new System.Drawing.Size(73, 57);
            this.NroValor6.TabIndex = 0;
            this.NroValor6.Text = "valor";
            this.NroValor6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NroValor6.UseCompatibleTextRendering = true;
            // 
            // NroValor7
            // 
            this.NroValor7.BackColor = System.Drawing.Color.Transparent;
            this.NroValor7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NroValor7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroValor7.ForeColor = System.Drawing.Color.DimGray;
            this.NroValor7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NroValor7.Location = new System.Drawing.Point(210, 428);
            this.NroValor7.Name = "NroValor7";
            this.NroValor7.Size = new System.Drawing.Size(73, 57);
            this.NroValor7.TabIndex = 0;
            this.NroValor7.Text = "valor";
            this.NroValor7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NroValor7.UseCompatibleTextRendering = true;
            // 
            // NroValor8
            // 
            this.NroValor8.BackColor = System.Drawing.Color.Transparent;
            this.NroValor8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NroValor8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroValor8.ForeColor = System.Drawing.Color.DimGray;
            this.NroValor8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NroValor8.Location = new System.Drawing.Point(210, 500);
            this.NroValor8.Name = "NroValor8";
            this.NroValor8.Size = new System.Drawing.Size(73, 57);
            this.NroValor8.TabIndex = 0;
            this.NroValor8.Text = "valor";
            this.NroValor8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NroValor8.UseCompatibleTextRendering = true;
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 618);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopVentas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCantProductos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCantProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTopProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTopVentas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LVentas;
        private System.Windows.Forms.Label LProductosPreferidos;
        private System.Windows.Forms.Label LCantidadProductos;
        private System.Windows.Forms.Label LCantVentas;
        private System.Windows.Forms.Label LNroProveedores;
        private System.Windows.Forms.Label LNroUsuarios;
        private System.Windows.Forms.Label LNroMarcas;
        private System.Windows.Forms.Label LCategorias;
        private System.Windows.Forms.Label LNroProductos;
        private System.Windows.Forms.Label LStockbajo;
        private System.Windows.Forms.Label LNroClientes;
        private System.Windows.Forms.Label NroValor8;
        private System.Windows.Forms.Label NroValor7;
        private System.Windows.Forms.Label NroValor6;
        private System.Windows.Forms.Label NroValor5;
        private System.Windows.Forms.Label NroValor4;
        private System.Windows.Forms.Label NroValor3;
        private System.Windows.Forms.Label NroValor2;
        private System.Windows.Forms.Label NroValor1;
    }
}