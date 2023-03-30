using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace parcial12023
{
    public partial class Form1 : Form
    {
        List<personas> personass = new List<personas>();
        List<partido> partidos= new List<partido>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Jhony\source\repos\parcial12023\bin\Debug\datospersonas.txt"))
            {
                FileStream stream = new FileStream("datospersonas.txt", FileMode.Open, FileAccess.Read); 
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek()>-1)
                {
                    personas personas = new personas(); 
                    personas.Nombre= reader.ReadLine();
                    personas.Dpi= reader.ReadLine();
                    personas.Direeccion= reader.ReadLine();
                    
                    personass.Add(personas);

                }
                reader.Close();
            }

        }
    }
}
