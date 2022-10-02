using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos1
{
    public class Grafos
    {
        public Grafos() { }

        static Vertice raiz;

        static List<string> stack = new List<string>();
        static List<string> queue = new List<string>();
        static List<string> dFResult = new List<string>();
        static List<string> bFResult = new List<string>();

        public void InsertarNodo(string nombre)
        {
            if (raiz == null)
                raiz = new Vertice(nombre.ToUpper());

            else
            {
                Vertice aux = raiz;

                if (aux.sig != null)
                {
                    while (aux.sig != null)
                    {
                        if (aux._nombre.ToLower() == nombre.ToLower())
                        {
                            throw new ArgumentException();
                        }

                        else
                            aux = aux.sig;
                    }

                    if (aux._nombre.ToLower() != nombre.ToLower())
                        aux.sig = new Vertice(nombre.ToUpper());
                    else throw new ArgumentException();
                }

                else
                {
                    if (aux._nombre.ToLower() != nombre.ToLower())
                        aux.sig = new Vertice(nombre.ToUpper());
                    else throw new ArgumentException();
                }
            }
        }

        public void InsertarArco(string origen, string destino, bool repita = true)
        {
            var aux = raiz;

            if (aux._nombre == origen)
                AgregarArco(ref aux, destino);

            else if (aux.sig != null)
            {
                while (aux.sig != null)
                {
                    aux = aux.sig;

                    if (aux._nombre == origen)
                    {
                        AgregarArco(ref aux, destino);
                        break;
                    }
                }
            }

            if(repita)
                InsertarArco(destino, origen, false);
        }   

        private void AgregarArco(ref Vertice _nodo, string _destino)
        {
            Arco arcoAux = _nodo.arco;

            if (arcoAux == null)
                _nodo.arco = new Arco(_destino);

            else
            {
                if (arcoAux._nombre == _destino)
                    throw new ArgumentException();

                while (arcoAux.sig != null)
                {
                    arcoAux = arcoAux.sig;

                    if (arcoAux._nombre == _destino)
                        throw new ArgumentException();
                }                

                arcoAux.sig = new Arco(_destino);
            }
        }

        public Vertice BuscarNodo(string id)
        {
            var aux = raiz;

            if (aux._nombre == id)
                return aux;

            else
            {
                while (aux.sig != null)
                {
                    aux = aux.sig;

                    if (aux._nombre == id)
                        return aux;
                }

                if (aux._nombre == id)
                    return aux;
            }

            throw new EntryPointNotFoundException();
        }
        
        public Vertice retornarRaiz()
        {
            return raiz;
        }

        public void DFS(Vertice T, bool firstTime = true)
        {
            if (firstTime)
            {
                stack.Clear();
                dFResult.Clear();
                ReiniciarNodos();
            }

            if (!T.visitado)
            {
                stack.Add(T._nombre);
                dFResult.Add(T._nombre);
                T.visitado = true;
            }

            Vertice next = BuscarNodo(T.arco._nombre);

            if (!next.visitado)
                DFS(next, false);

            else
            {
                Arco aux = T.arco;

                while (next.visitado)
                {
                    if (aux.sig != null)
                    {
                        aux = aux.sig;
                        next = BuscarNodo(aux._nombre);

                        if (!next.visitado)
                        {
                            DFS(next, false);
                            break;
                        }
                    }

                    else
                    {
                        if (stack.Count > 0)
                        {
                            stack.RemoveAt(stack.Count-1);

                            if (stack.Count > 0)
                            {
                                next = BuscarNodo(stack[stack.Count - 1]);
                                DFS(next, false);
                            }
                        }
                        break;
                    }
                }
            }
        }

        public void BFS(Vertice T, bool firstTime = true)
        {
            if (firstTime)
            {
                queue.Clear();
                bFResult.Clear();
                ReiniciarNodos();
            }
            if (!T.visitado)
            {
                T.visitado = true;
                if (firstTime)
                    bFResult.Add(T._nombre);
            }

            if (queue.Count > 0 && queue[0] == T._nombre)
                queue.RemoveAt(0);

            Arco aux = T.arco;
            Vertice next = BuscarNodo(aux._nombre);

            #region revisar los arcos para agregarlos a la cola
            if (!next.visitado)
            {
                queue.Add(next._nombre);
                bFResult.Add(next._nombre);
                next.visitado = true;
            }
            #endregion

            while (aux.sig != null)
            {
                aux = aux.sig;
                next = BuscarNodo(aux._nombre);

                #region revisar los arcos para agregarlos a la cola
                if (!next.visitado)
                {
                    queue.Add(next._nombre);
                    bFResult.Add(next._nombre);
                    next.visitado = true;
                }
                #endregion
            }

            if (queue.Count > 0)
                BFS(BuscarNodo(queue[0]), false);
            
        }

        void ReiniciarNodos()
        {
            var aux = raiz;

            aux.visitado = false;

            while (aux.sig != null)
            {
                aux = aux.sig;
                aux.visitado = false;
            }
        }

        public List<string> RetornarResultado(int a = 0)
        {
            if (a == 0)
                return dFResult;

            else
                return bFResult;
        }
    }
}
