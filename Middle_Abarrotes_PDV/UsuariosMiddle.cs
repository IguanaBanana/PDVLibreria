using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Abarrotes_PDV
{
    public class UsuariosMiddle
    {
        //propiedades de la clase
        public string password;
        public string correo;
        public string nombre;
        public string imagen;
        public int id;
        CRUDs_BD bd;
        public static string msgError;

        public UsuariosMiddle()
        {
            //crear una instancia de MYSQL a mi bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "La_Libreria", "3306");
        }
        public List<UsuariosMiddle> consultarUsuarios(string where)
        {
            List<UsuariosMiddle> listaDeProds = new List<UsuariosMiddle>();
           UsuariosMiddle Usu = new UsuariosMiddle();

            List<object[]> res = this.bd.consulta("usuarios", where);
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
                    Usu.password = tempo[3].ToString();
                    Usu.imagen = tempo[4].ToString();
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
        public bool crearUsuarios(string nom, string correo, string password)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "correo", "password"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(correo));
            vals.Add(new ValoresAInsertar(password));

            bool resultado = this.bd.insertar("usuarios", nombresCampos, vals);
            //valir el res
            if (resultado == false)
                Producto.msgError = this.bd.msgError;

            return resultado;
        }//crear
        public bool modificarUsuarios(int id, string nom, string correo, string password)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "correo", "password"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(correo));
            vals.Add(new ValoresAInsertar(password));

            bool resultado = this.bd.modificar("usuarios", nombresCampos, vals, id);
            //valir el res
            if (resultado == false)
                Producto.msgError = this.bd.msgError;

            return resultado;
        }//crear

        public bool borrarUsuario(int id)
        {
            bool res = this.bd.borrar("usuarios", id);
            if (res = false)
                Producto.msgError = this.bd.msgError;
            return res;
        }
    }
}
