using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WMPLib;

namespace Grafos1
{
    public partial class Form1 : Form
    {
        Grafos refer = new Grafos();

        public Form1()
        {
            InitializeComponent();
        }

        void SonidoError()
        {
            //WindowsMediaPlayer player = new WindowsMediaPlayer();
            //player.URL = @"Properties\Resources\XPError.mp3";
            //player.controls.play();
        }

        private void insertarVertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevoNombre = textBoxVerNom.Text;
                    if (nuevoNombre == "")
                        throw new FormatException();

                textBoxVerNom.Text = "";

                refer.InsertarNodo(nuevoNombre);

                ActualizarCombos();

                ImprimirTodo();
            }

            catch (ArgumentException)
            {
                SonidoError();
                MessageBox.Show("Ya existe un nodo con el nombre a insertar.");                
            }

            catch (FormatException)
            {
                SonidoError();
                MessageBox.Show("Error: el nodo a insertar debe poseer al menos un caracter para el nombre.");
            }
        }

        private void insertarArcButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comborigen.SelectedIndex >= 0 && combostino.SelectedIndex >= 0)
                {
                    string _origen = comborigen.Text;
                    string _destino = combostino.Text;

                    if (_origen != _destino)
                        refer.InsertarArco(_origen, _destino);

                    else throw new FormatException();

                    ImprimirTodo();
                }

                else throw new InvalidOperationException();
            }

            catch (FormatException)
            {
                SonidoError();
                MessageBox.Show("El nodo del destino debe ser distinto al del origen.");
            }

            catch (ArgumentException)
            {
                SonidoError();
                MessageBox.Show("El arco que intenta realizar ya se encuentra registrado.");
            }

            catch (InvalidOperationException)
            {
                SonidoError();
                MessageBox.Show("Error: seleccion de nodo de origen y/o destino invalido(s).");
            }
        }

        private void borrarArcButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comborigen.SelectedIndex >= 0 && combostino.SelectedIndex >= 0)
                {
                    string _origen = comborigen.Text;
                    string _destino = combostino.Text;

                    BorrarEnlace(_origen, _destino);
                    ImprimirTodo();
                }

                else throw new FormatException();
            }

            catch (NotSupportedException)
            {
                MessageBox.Show("Error: no existe un enlace entre los nodos indicados.");
            }

            catch (FormatException)
            {
                MessageBox.Show("Error: no hay un nodo seleccionado en uno o ambos espacios. ");
            }
        
        }        

        void ImprimirTodo()
        {
            Vertice aux = refer.retornarRaiz();
            string arcos = RegresarArcos(aux);

            dataGridView1.Rows.Clear();

            if (aux != null)
                dataGridView1.Rows.Add(aux._nombre, arcos);

            if (aux.sig != null)
            {
                while (aux.sig != null)
                {
                    aux = aux.sig;
                    arcos = RegresarArcos(aux);
                    dataGridView1.Rows.Add(aux._nombre, arcos);
                }
            }
        }

        string RegresarArcos(Vertice vertice)
        {
            string arcos = null;

            Arco aux = vertice.arco;

            if (aux != null)
            {
                arcos = aux._nombre;

                if (aux.sig != null)
                {
                    while (aux.sig != null)
                    {
                        aux = aux.sig;
                        arcos += ", " + aux._nombre;                        
                    }
                }
            }

            return arcos;
        }

        void ActualizarCombos()
        {
            Vertice aux = refer.retornarRaiz();

            comborigen.Items.Clear();
            combostino.Items.Clear();

            if(aux!=null)
            {
                comborigen.Items.Add(aux._nombre);
                combostino.Items.Add(aux._nombre);

                comborigen.SelectedIndex = 0;
                combostino.SelectedIndex = 0;

                if (aux.sig != null)
                {
                    while (aux.sig != null)
                    {
                        aux = aux.sig;

                        comborigen.Items.Add(aux._nombre);
                        combostino.Items.Add(aux._nombre);
                    }
                }
            }
        }

        void BorrarEnlace(string _origen, string _destino, bool repetir = true)
        { 
                Vertice nodoDelOrigen = refer.BuscarNodo(_origen);

                Arco arcoAux = nodoDelOrigen.arco;

                if (arcoAux == null)
                {
                    throw new NotSupportedException();
                }

                if (arcoAux._nombre == _destino)
                {
                    nodoDelOrigen.arco = nodoDelOrigen.arco.sig;
                    arcoAux = null;

                    if (repetir)
                    {
                        BorrarEnlace(_destino, _origen, false);
                    }
                }

                else
                {
                    #region busqueda y borrado

                    Arco anterior = arcoAux;
                    arcoAux = arcoAux.sig;

                    while (arcoAux != null)
                    {       
                        if (arcoAux._nombre == _destino)
                        {
                            anterior.sig = arcoAux.sig;
                            arcoAux = null;

                            if (repetir)
                            {
                                BorrarEnlace(_destino, _origen, false);
                                //borrado = true;
                            }

                            break;
                        }

                        else
                        {
                            anterior = arcoAux;
                            arcoAux = arcoAux.sig;
                        }
                    }

                    #endregion

                }
            }

        private void recorridosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = recorridosCombo.SelectedIndex;

            switch (index)
            {
                case 0:
                    Vertice raiz = refer.retornarRaiz();
                    refer.DFS(raiz);
                    #region imprimir
                    List<string> resultado = refer.RetornarResultado();

                    foreach (string c in resultado)
                        if (c == resultado[0])
                            resultadolabel.Text = c;
                        else resultadolabel.Text += ", " + c;
                    #endregion
                    break;

                case 1:
                    Vertice raizBF = refer.retornarRaiz();
                    refer.BFS(raizBF);
                    #region imprimir
                    List<string> resultadoBF = refer.RetornarResultado(1);

                    foreach (string c in resultadoBF)
                        if (c == resultadoBF[0])
                            resultadolabel.Text = c;
                        else resultadolabel.Text += ", " + c;
                    #endregion
                    break;
            }
            
        }        


    }
}
