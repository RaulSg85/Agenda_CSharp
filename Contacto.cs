using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Consola 
{
    class Contacto : IComparable<Contacto>
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Contacto(string nombre)
        {
            Nombre = nombre;
        }

        public Contacto()
        {

        }
        public Contacto(string nombre, string telefono) : this(nombre)
        {
            Telefono = telefono;
        }
        public Contacto(string nombre, string telefono, string email) : this(nombre, telefono)
        {            
            Email = email;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null) return false;

            Contacto c = obj as Contacto;
            if (c == null) return false;

            return string.Equals(Nombre, c.Nombre) && string.Equals(Telefono, c.Telefono);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashNombre = (Nombre != null ? Nombre.GetHashCode() : 0);
                int hashTelefono = (Telefono != null ? Telefono.GetHashCode() : 0);

                return (hashNombre * 13) ^ hashTelefono;
            }
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}\nTelefono: {1}\nEmail: {2}\n", Nombre, Telefono, Email);
        }

        public int CompareTo(Contacto other)
        {
            return Nombre.CompareTo(other.Nombre);
        }
    }
}
