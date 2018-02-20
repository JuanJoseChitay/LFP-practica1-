using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace practica1_lfp_alex
{
    public partial class Form1 : Form
    {
        String Texto;
        int contador = 1;
        String archivoActual;
        OpenFileDialog file;
        SaveFileDialog saveFile1;
        int indice = 0;
        string[] a = new string[7];
        string[] line2 = new string[7];


        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juan José chitay lux." + "\n" + "201314609" + "\n" + "Lenguajes Formales y de Programación \"B-\" ", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);

         
            //TextBox mytextbox = new TextBox();
           // tabControl1.TabPages.Add(mytextbox);

        }





        private void cargarPestañanToolStripMenuItem_Click(object sender, EventArgs e)
        {


            abrir();
            

        }

        // metodo para abrir los archivos 

        public void abrir()
        {
            indice = tabControl1.SelectedIndex;


            //busqueda de archivo
            line2[indice] = "";

            string carga;
            OpenFileDialog busqueda = new OpenFileDialog();
            busqueda.Filter = "Text Files (.lfp)|*.lfp|All Files (*.*)|*.*";
            if (busqueda.ShowDialog() == DialogResult.OK)
            {
                carga = busqueda.FileName;
                a[indice] = carga;
            }


            string line;


            // carga de archivo
            System.IO.StreamReader archivo = new System.IO.StreamReader(a[indice]);
            while ((line = archivo.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                line2[indice] = line2[indice] + line + "\r\n";
                //line3 = line3 + line;

            }

            archivo.Close();
            System.Console.ReadLine();
            if (indice == 0) { textBox1.Text = line2[indice]; }
            if (indice == 1) { textBox2.Text = line2[indice]; }
            if (indice == 2) { textBox3.Text = line2[indice]; }
            if (indice == 3) { textBox4.Text = line2[indice]; }
            if (indice == 4) { textBox5.Text = line2[indice]; }
            if (indice == 5) { textBox6.Text = line2[indice]; }
          


        }



        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indice = tabControl1.SelectedIndex;

            if (a[indice].Equals("0"))
            {
                string carga;
                SaveFileDialog busqueda = new SaveFileDialog();
                busqueda.Filter = "Text Files (.lfp)|*.lfp|All Files (*.*)|*.*";
                if (busqueda.ShowDialog() == DialogResult.OK)
                {
                    carga = busqueda.FileName;
                    a[indice] = carga;
                    Console.WriteLine(a[indice]);
                }
            }

            System.IO.StreamWriter archivo = new System.IO.StreamWriter(a[indice]);

            if (indice == 0) { archivo.WriteLine(textBox1.Text); }
            if (indice == 1) { archivo.WriteLine(textBox2.Text); }
            if (indice == 2) { archivo.WriteLine(textBox3.Text); }
            if (indice == 3) { archivo.WriteLine(textBox4.Text); }
            if (indice == 4) { archivo.WriteLine(textBox5.Text); }
            if (indice == 5) { archivo.WriteLine(textBox6.Text); }
            

            archivo.Close();
            MessageBox.Show("Su archivo se ha guardado correctamente");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
