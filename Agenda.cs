using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Consola
{
    class Agenda
    {
        //propiedades
        private const int TAMAÑO = 5;
        private Contacto[] _contactos;
        private int _indice;

        public int NumContactos
        {
            get { return _indice; }
        }
        //constructores
        
        public Agenda ()
        {
            _indice = 0;
            _contactos = new Contacto[TAMAÑO];
        }

        //métodos
        public void AgregarContacto(Contacto contacto)
        {
            if(_indice < TAMAÑO)
            {
                _contactos[_indice] = contacto;
                _indice++;
            }
            else
            {
                Console.WriteLine("Agenda Llena");
            }
        }

        public void BorrarUltimoContacto()
        {
            if (_indice > 0)
            {
                _contactos[_indice] = null;
                _indice--;
            }
            else
            {
                Console.WriteLine("La agenda está vacía");
            }
        }

        public bool AgendaVacia()
        {
            if(_indice == 0)
            {
                Console.WriteLine("Agenda Vacía");
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void MostrarOrdenados()
        {
            if (AgendaVacia())
            {
                return;
            }

            Contacto[] contactos_ordenados = new Contacto[_indice];
            Array.Copy(_contactos, contactos_ordenados, _indice);
            Array.Sort(contactos_ordenados);

            Console.WriteLine(CadenaContactos(contactos_ordenados));
        }

        public void MostrarOrdenadosDesc()
        {
            if (AgendaVacia())
            {
                return;
            }

            Contacto[] contactos_ordenados = new Contacto[_indice];
            Array.Copy(_contactos, contactos_ordenados, _indice);
            Array.Sort(contactos_ordenados);
            Array.Reverse(contactos_ordenados);

            Console.WriteLine(CadenaContactos(contactos_ordenados));
        }

        public Contacto BuscarPorNombre(string nombre)
        {
            foreach (Contacto contacto in _contactos)
            {
                if(contacto != null && contacto.Nombre == nombre)
                {
                    return contacto;
                }
            }

            return null;
        }

        public void MostrarContactos()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return CadenaContactos(_contactos);
        }
        private string CadenaContactos(Contacto[] contactos)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _indice; i++)
            {
                if (contactos[i] == null) { continue; }
                string dato = string.Format("{0}. {1}", i + 1, contactos[i]);
                sb.AppendLine(dato);
            }

            return sb.ToString();
        }
    }
}
