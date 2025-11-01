
namespace ABMAlumnos
{
    partial class FormAlumnos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAlumnos = new DataGridView();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            numericUpDownLegajo = new NumericUpDown();
            textBoxCarrera = new TextBox();
            numericUpDownPromedio = new NumericUpDown();
            labelNombre = new Label();
            labelApellido = new Label();
            labelLegajo = new Label();
            labelCarrera = new Label();
            labelPromedio = new Label();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            labelFechaNacimiento = new Label();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            labelBusquedaLegajo = new Label();
            numericUpDownBusquedaLegajo = new NumericUpDown();
            buttonBuscar = new Button();
            button1 = new Button();
            label1 = new Label();
            labelCountAlumnos = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLegajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPromedio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBusquedaLegajo).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlumnos.Location = new Point(419, 65);
            dataGridViewAlumnos.MultiSelect = false;
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.ReadOnly = true;
            dataGridViewAlumnos.RowHeadersWidth = 62;
            dataGridViewAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlumnos.Size = new Size(762, 391);
            dataGridViewAlumnos.TabIndex = 0;
            dataGridViewAlumnos.SelectionChanged += SelectAlumno;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(197, 12);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(182, 31);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(197, 65);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(182, 31);
            textBoxApellido.TabIndex = 2;
            // 
            // numericUpDownLegajo
            // 
            numericUpDownLegajo.Location = new Point(197, 167);
            numericUpDownLegajo.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownLegajo.Name = "numericUpDownLegajo";
            numericUpDownLegajo.Size = new Size(182, 31);
            numericUpDownLegajo.TabIndex = 3;
            // 
            // textBoxCarrera
            // 
            textBoxCarrera.Location = new Point(197, 221);
            textBoxCarrera.Name = "textBoxCarrera";
            textBoxCarrera.Size = new Size(182, 31);
            textBoxCarrera.TabIndex = 4;
            // 
            // numericUpDownPromedio
            // 
            numericUpDownPromedio.DecimalPlaces = 2;
            numericUpDownPromedio.Location = new Point(197, 272);
            numericUpDownPromedio.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownPromedio.Name = "numericUpDownPromedio";
            numericUpDownPromedio.Size = new Size(182, 31);
            numericUpDownPromedio.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(109, 15);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(82, 25);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(109, 68);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(82, 25);
            labelApellido.TabIndex = 7;
            labelApellido.Text = "Apellido:";
            // 
            // labelLegajo
            // 
            labelLegajo.AutoSize = true;
            labelLegajo.Location = new Point(123, 169);
            labelLegajo.Name = "labelLegajo";
            labelLegajo.Size = new Size(68, 25);
            labelLegajo.TabIndex = 8;
            labelLegajo.Text = "Legajo:";
            // 
            // labelCarrera
            // 
            labelCarrera.AutoSize = true;
            labelCarrera.Location = new Point(119, 224);
            labelCarrera.Name = "labelCarrera";
            labelCarrera.Size = new Size(72, 25);
            labelCarrera.TabIndex = 9;
            labelCarrera.Text = "Carrera:";
            // 
            // labelPromedio
            // 
            labelPromedio.AutoSize = true;
            labelPromedio.Location = new Point(33, 274);
            labelPromedio.Name = "labelPromedio";
            labelPromedio.Size = new Size(158, 25);
            labelPromedio.TabIndex = 10;
            labelPromedio.Text = "Promedio General:";
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Location = new Point(197, 115);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(182, 31);
            dateTimePickerFechaNacimiento.TabIndex = 11;
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(10, 120);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(181, 25);
            labelFechaNacimiento.TabIndex = 12;
            labelFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(28, 323);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(141, 62);
            buttonAgregar.TabIndex = 13;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(28, 391);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(141, 60);
            buttonModificar.TabIndex = 14;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(28, 457);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(141, 60);
            buttonEliminar.TabIndex = 15;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelBusquedaLegajo
            // 
            labelBusquedaLegajo.AutoSize = true;
            labelBusquedaLegajo.Location = new Point(604, 18);
            labelBusquedaLegajo.Name = "labelBusquedaLegajo";
            labelBusquedaLegajo.Size = new Size(153, 25);
            labelBusquedaLegajo.TabIndex = 17;
            labelBusquedaLegajo.Text = "Buscar por legajo:";
            // 
            // numericUpDownBusquedaLegajo
            // 
            numericUpDownBusquedaLegajo.Location = new Point(763, 16);
            numericUpDownBusquedaLegajo.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownBusquedaLegajo.Name = "numericUpDownBusquedaLegajo";
            numericUpDownBusquedaLegajo.Size = new Size(220, 31);
            numericUpDownBusquedaLegajo.TabIndex = 18;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(1040, 9);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(141, 42);
            buttonBuscar.TabIndex = 19;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(213, 323);
            button1.Name = "button1";
            button1.Size = new Size(141, 31);
            button1.TabIndex = 20;
            button1.Text = "Clear Form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 360);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 21;
            label1.Text = "Alumnos Registrados:";
            // 
            // labelCountAlumnos
            // 
            labelCountAlumnos.AutoSize = true;
            labelCountAlumnos.Location = new Point(391, 360);
            labelCountAlumnos.Name = "labelCountAlumnos";
            labelCountAlumnos.Size = new Size(22, 25);
            labelCountAlumnos.TabIndex = 22;
            labelCountAlumnos.Text = "0";
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 522);
            Controls.Add(labelCountAlumnos);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonBuscar);
            Controls.Add(numericUpDownBusquedaLegajo);
            Controls.Add(labelBusquedaLegajo);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(labelFechaNacimiento);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(labelPromedio);
            Controls.Add(labelCarrera);
            Controls.Add(labelLegajo);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(numericUpDownPromedio);
            Controls.Add(textBoxCarrera);
            Controls.Add(numericUpDownLegajo);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(dataGridViewAlumnos);
            Name = "FormAlumnos";
            Text = "Alumnos";
            Load += LoadForm;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLegajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPromedio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBusquedaLegajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAlumnos;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private NumericUpDown numericUpDownLegajo;
        private TextBox textBoxCarrera;
        private NumericUpDown numericUpDownPromedio;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelLegajo;
        private Label labelCarrera;
        private Label labelPromedio;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private Label labelFechaNacimiento;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Label labelBusquedaLegajo;
        private NumericUpDown numericUpDownBusquedaLegajo;
        private Button buttonBuscar;
        private Button button1;
        private Label label1;
        private Label labelCountAlumnos;
    }
}
