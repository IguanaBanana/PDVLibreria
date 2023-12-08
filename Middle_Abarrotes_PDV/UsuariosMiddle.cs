using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Middle_Abarrotes_PDV
{
    public class UsuariosMiddle
    {
        //propiedades de la clase
        public string password;
        public string correo;
        public string nombre;
        public string direccion;
        public string telefono;
        public int id;
        CRUDs_BD bd;
        public static string msgError;

        public UsuariosMiddle()
        {
            //crear una instancia de MYSQL a mi bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "pdv-luis", "3306");
        }
        public List<UsuariosMiddle> consultarUsuarios(string where)
        {
            List<UsuariosMiddle> listaDeProds = new List<UsuariosMiddle>();
           UsuariosMiddle Usu = new UsuariosMiddle();

            List<object[]> res = this.bd.consulta("customers", where);
            //validamos que traig un elemento la lista
            if (res.Count >= 1)
            {


                for (int i = 0; i < res.Count; i++)
                {
                    Usu = new UsuariosMiddle();
                    object[] tempo = res[0];
                    Usu.id = int.Parse(tempo[0].ToString());
                    Usu.nombre = tempo[1].ToString();
                    Usu.correo = tempo[2].ToString();
                    Usu.telefono = tempo[3].ToString();
                    Usu.direccion = tempo[4].ToString();
                    Usu.password = tempo[5].ToString();

                    
                }

                listaDeProds.Add(Usu);

            }
            else
            {
                Producto.msgError = "Datos inexistentes." + this.bd.msgError;
                Usu = null;
            }

            return listaDeProds;

        }
        public bool crearUsuarios( string nombre, string email, string telefono, string direcion, string password)
        {
            List<string> nombresCampos = new List<string>()
            {
                

                    "Name", "Email", "Phone", "Adress","password"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            //vals.Add(new ValoresAInsertar(userId));
            vals.Add(new ValoresAInsertar(nombre));
            vals.Add(new ValoresAInsertar(email));
            vals.Add(new ValoresAInsertar(telefono));
            vals.Add(new ValoresAInsertar(direcion));
            vals.Add(new ValoresAInsertar(password));

            bool resultado = this.bd.insertar("customers", nombresCampos, vals);
            //valir el res
            if (resultado == false)
                Producto.msgError = this.bd.msgError;

            return resultado;
        }//crear
        public bool modificarUsuarios(string userId, string nombre, string email, string telefono, string direcion, string password)
            {
                List<string> nombresCampos = new List<string>()
            {


                    "CustomerID","Name", "Email", "Phone", "Adress","password"
            };

                List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
                vals.Add(new ValoresAInsertar(userId));
                vals.Add(new ValoresAInsertar(nombre));
                vals.Add(new ValoresAInsertar(email));
                vals.Add(new ValoresAInsertar(telefono));
                vals.Add(new ValoresAInsertar(direcion));
                vals.Add(new ValoresAInsertar(password));

                bool resultado = this.bd.modificar("customers", nombresCampos, vals, id);
            //valir el res
            if (resultado == false)
                Producto.msgError = this.bd.msgError;

            return resultado;
        }//crear

        public bool borrarUsuario(int id)
        {
            bool res = this.bd.borrar("customers", id);
            if (res = false)
                Producto.msgError = this.bd.msgError;
            return res;
        }
    }
}
