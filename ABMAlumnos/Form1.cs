using System.Data;

namespace ABMAlumnos
{
    public partial class FormAlumnos : Form
    {
        List<Alumno> listaAlumnos = new List<Alumno>();
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            listaAlumnos.Clear();

            if (!File.Exists("alumnos.txt"))
            {
                using (File.Create("alumnos.txt"))
                {

                }
            }
            ListarAlumnos();
            labelCountAlumnos.Text = listaAlumnos.Count.ToString();
        }

        private void ClearForm()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxCarrera.Text = "";
            numericUpDownLegajo.Value = 0;
            numericUpDownPromedio.Value = 0;
            dateTimePickerFechaNacimiento.Value = DateTime.Now;

        }

        private void RefreshDataGridView()
        {
            dataGridViewAlumnos.DataSource = null;
            dataGridViewAlumnos.DataSource = listaAlumnos;
            labelCountAlumnos.Text = listaAlumnos.Count.ToString();
            ClearForm();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var AlumnoNuevo = new Alumno()
            {
                nombre = textBoxNombre.Text,
                apellido = textBoxApellido.Text,
                fechaNacimiento = dateTimePickerFechaNacimiento.Value,
                legajo = (int)numericUpDownLegajo.Value,
                carrera = textBoxCarrera.Text,
                promedio = numericUpDownPromedio.Value
            };

            listaAlumnos.Add(AlumnoNuevo);
            RefreshDataGridView();
            GuardarAlumnosEnArchivo();

        }

        private void GuardarAlumnosEnArchivo()
        {
            using (var writer = new StreamWriter("alumnos.txt"))
            {
                foreach (var alumno in listaAlumnos)
                {
                    writer.WriteLine(alumno.ToString());
                }
            }
        }

        private void ListarAlumnos()
        {
            using (var reader = new StreamReader("alumnos.txt"))
            {
                var linea = reader.ReadLine();
                while (linea != null)
                {
                    var alumno = Alumno.getAlumnosFromTxt(linea);
                    listaAlumnos.Add(alumno);
                    linea = reader.ReadLine();
                }
                RefreshDataGridView();

            }
        }

        

        private void SelectAlumno(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                var alumno = dataGridViewAlumnos.SelectedRows[0].DataBoundItem as Alumno;
                textBoxNombre.Text = alumno.nombre;
                textBoxApellido.Text = alumno.apellido;
                dateTimePickerFechaNacimiento.Value = alumno.fechaNacimiento;
                numericUpDownLegajo.Value = alumno.legajo;
                textBoxCarrera.Text = alumno.carrera;
                numericUpDownPromedio.Value = alumno.promedio;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                var alumno = dataGridViewAlumnos.SelectedRows[0].DataBoundItem as Alumno;
                var legajo = alumno.legajo;

                var alumnoToModificar = listaAlumnos.Find(alumno => alumno.legajo == legajo);

                alumnoToModificar.nombre = textBoxNombre.Text;
                alumnoToModificar.apellido = textBoxApellido.Text;
                alumnoToModificar.fechaNacimiento = dateTimePickerFechaNacimiento.Value;
                alumnoToModificar.legajo = (int)numericUpDownLegajo.Value;
                alumnoToModificar.carrera = textBoxCarrera.Text;
                alumnoToModificar.promedio = numericUpDownPromedio.Value;

                RefreshDataGridView();
                GuardarAlumnosEnArchivo();

            }
            else
            {
                MessageBox.Show("Seleccione un alumno para modificar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            var personaSeleccionada = dataGridViewAlumnos.SelectedRows[0].DataBoundItem as Alumno;
            listaAlumnos.Remove(personaSeleccionada);
            RefreshDataGridView();
        }
    }
}
