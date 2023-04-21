using System;
using Back_CRUDs_BD;
using Middle_Abarrotes_PDV;
using static Mysqlx.Datatypes.Scalar.Types;

namespace Middle_Abarrotes_PDV
{
	public class Producto
	{
		//propiedades de la clase
		public int id;
		public string titulo;
		public string issn;
		public string autor;
		public presentacion presentacion;
		public double precio;
		//vars para reutilizar el CRUD
		CRUDs_BD bd;
		//var statis de  msg de error
		public static string msgError;

		public Producto()
		{
			//crear una instancia de MYSQL a mi bd
			bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "La_Libreria", "3306");
		}

		//métodos de la clase CRUD
		public bool crear(string titulo, string issn, string autor, double precio, presentacion presentacion)
		{
			List<string> nombresCampos = new List<string>()
			{
					"titulo", "issn", "autor", "precio", "presentacion"
			};

			List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
			vals.Add(new ValoresAInsertar(titulo));
			vals.Add(new ValoresAInsertar(issn));
			vals.Add(new ValoresAInsertar(autor));
			vals.Add(new ValoresAInsertar(precio.ToString(), false));
			vals.Add(new ValoresAInsertar(presentacion.ToString()));

			bool resultado = this.bd.insertar("productos", nombresCampos, vals);
			//valir el res
			if (resultado == false)
				Producto.msgError = this.bd.msgError;

			return resultado;
		}//crear


		public bool modificar(int id, string titulo, string issn, string autor, presentacion presentacion, double precio)
		{
			List<string> nombresCampos = new List<string>()
			{
					"titulo", "issn", "autor", "presentacion", "precio"
			};

			List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
			vals.Add(new ValoresAInsertar(titulo));
			vals.Add(new ValoresAInsertar(issn));
			vals.Add(new ValoresAInsertar(autor));
			vals.Add(new ValoresAInsertar(presentacion.ToString()));
			vals.Add(new ValoresAInsertar(precio.ToString(), false));

			bool resultado = this.bd.modificar("productos", nombresCampos, vals, id);
			//valir el res
			if (resultado == false)
				Producto.msgError = this.bd.msgError;

			return resultado;
		}//crear

		//borrar
		public bool borrar(int id)
		{
			bool res = this.bd.borrar("productos", id);
			if (res = false)
				Producto.msgError = this.bd.msgError;
			return res;
		}

		public List<Producto> consultageneral(string tabla)
		{
            List<Producto> listadePro = new List<Producto>();
            Producto prodResultado = new Producto();
            List<object[]> res = this.bd.consulta("productos");
            //validamos que traig un elemento la lista
            if (res.Count >= 1)
            {
                for (int i = 0; i < res.Count; i++)
                {
                    prodResultado = new Producto();
                    presentacion presentacionTexto;
                    object[] tempo = res[i];
					prodResultado.id = int.Parse(tempo[0].ToString());
                    prodResultado.titulo = tempo[1].ToString();
                    prodResultado.issn = tempo[2].ToString();
                    prodResultado.autor = tempo[3].ToString();
                    prodResultado.precio = double.Parse(tempo[5].ToString());
                    switch (tempo[4].ToString())
                    {
                        case "Terror":
                            presentacionTexto = presentacion.Terror;
                            break;
                        case "Romance":
                            presentacionTexto = presentacion.Romance;
                            break;
                        case "Fantasia":
                            presentacionTexto = presentacion.Fantasia;
                            break;
                        default:
                            presentacionTexto = presentacion.Terror;
                            break;
                    }
                    prodResultado.presentacion = presentacionTexto;
					listadePro.Add(prodResultado);
                }

            }
            else
            {
                Producto.msgError = "Titulo no existente en La Libreria :( " + this.bd.msgError;
                prodResultado = null;
            }

            return listadePro;
        }
        public List<Producto> consultarPorTitulo( string where)
		{
			List<Producto> listadePro = new List<Producto>();
			Producto prodResultado = new Producto();
			List<object[]> res = this.bd.consulta("productos", where);
			//validamos que traig un elemento la lista
			if (res.Count >= 1)
			{
				for (int i = 0; i < res.Count; i++)
				{
					prodResultado = new Producto();
					presentacion presentacionTexto;
					object[] tempo = res[0];
					prodResultado.id = int.Parse(tempo[0].ToString());
					prodResultado.titulo = tempo[1].ToString();
					prodResultado.issn = tempo[2].ToString();
					prodResultado.autor = tempo[3].ToString();
					prodResultado.precio = double.Parse(tempo[5].ToString());
					switch (tempo[4].ToString())
					{
						case "Terror":
							presentacionTexto = presentacion.Terror;
							break;
						case "Romance":
							presentacionTexto = presentacion.Romance;
							break;
						case "Fantasia":
							presentacionTexto = presentacion.Fantasia;
							break;
						default:
							presentacionTexto = presentacion.Terror;
							break;
					}
                    prodResultado.presentacion = presentacionTexto;
                }
                listadePro.Add(prodResultado);

            }
			else
			{
				Producto.msgError = "Titulo no existente en La Libreria :( " + this.bd.msgError;
				prodResultado = null;
			}

			return listadePro;
		}
        public List<Producto> consultarPorAutor(string where)
        {
            List<Producto> listadePro = new List<Producto>();
            Producto prodResultado = new Producto();
            List<object[]> res = this.bd.consulta("productos", where);
            //validamos que traig un elemento la lista
            if (res.Count >= 1)
            {
                for (int i = 0; i < res.Count; i++)
                {
                    prodResultado = new Producto();
                    presentacion presentacionTexto;
                    object[] tempo = res[0];
                    prodResultado.id = int.Parse(tempo[0].ToString());
                    prodResultado.titulo = tempo[1].ToString();
                    prodResultado.issn = tempo[2].ToString();
                    prodResultado.autor = tempo[3].ToString();
                    prodResultado.precio = double.Parse(tempo[5].ToString());
                    switch (tempo[4].ToString())
                    {
                        case "Terror":
                            presentacionTexto = presentacion.Terror;
                            break;
                        case "Romance":
                            presentacionTexto = presentacion.Romance;
                            break;
                        case "Fantasia":
                            presentacionTexto = presentacion.Fantasia;
                            break;
                        default:
                            presentacionTexto = presentacion.Terror;
                            break;
                    }
                    prodResultado.presentacion = presentacionTexto;
                }
                listadePro.Add(prodResultado);

            }
            else
            {
                Producto.msgError = "Autor no existente en La Libreria :( " + this.bd.msgError;
                prodResultado = null;
            }

            return listadePro;
        }
    }
}

