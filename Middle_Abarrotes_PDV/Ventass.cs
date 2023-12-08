using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Abarrotes_PDV
{
    public  class Ventass
    {
        //campos 
        DateTime fechaHora;
        public int cajeroId = 0;
        public double monto = 0;
        public static string msgError = "";
        //vars para reutilizar el CRUD
        CRUDs_BD bd;
        public Ventass()
        {
            //crear una instancia de MYSQL a mi bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "pdv-luis", "3306");
        }

        public double registrarVenta(int cajeroId, double monto, double pago,List<ProductoAVender> prodsAVender) {
            double res = 0;
            this.fechaHora = new DateTime();
            //registramos la venta de la tabla 'ventas'
            try
            {
                List<string> campos = new List<string>() { "customerID", "Date", "TotalAmount"  };

                List<ValoresAInsertar> valores = new List<ValoresAInsertar>() 
                {
                    new ValoresAInsertar(cajeroId.ToString(), false ),
                    new ValoresAInsertar(DateTime.Today.ToString(), true ),
                    new ValoresAInsertar(monto.ToString(), false ),
                };

                //INSERT INTO `ventas`( `fecha_hora`, `cajero_id`, `monto`) VALUES ('"+fechaHora.Now+"]','"+this.cajeroId+"','"this.monto"')
                bool registroVenta = bd.insertar("Sales", campos, valores);
                if (registroVenta)
                {
                    //cuando se registra la venta, tomamos su ID (Last_insert_id o el SELECT )
                    int ultimoIDVenta = int.Parse(bd.consulta1SoloValor("saleid", "sales", " 1 ORDER BY saleid DESC LIMIT 1").ToString());// consulta1SoloValor(string campo, string tabla, string criterioBusqueda)
                    //hacemos un barrido de todos los productos a Vender, en la lista prodsAVender
                    //lista de campos detalles

                    List<string> listaCamposDetalles = new List<string>() { "Quantity", "SaleID", "Price" };
                  
                    for (int i = 0; i < prodsAVender.Count; i++)
                    {
                        // por cada prod en la lista, hacemos un registro en Ventas_Detalles
                       // $"INSERT INTO `ventas_detalles`(`venta_id`, `producto_id`, `cantidad`) VALUES ({ultimoIDVenta},{prodsAVender[i].productoId},{prodsAVender[i].cantidad})"
                        List<ValoresAInsertar> listaValoresDetalles = new List<ValoresAInsertar>() {
                        new ValoresAInsertar(prodsAVender[i].cantidad.ToString(), false),
                        new ValoresAInsertar(prodsAVender[i].productoId.ToString(), false),
                        new ValoresAInsertar(ultimoIDVenta.ToString(), false),
                        };
                        bool resDetalles = bd.insertar("salesdetails", listaCamposDetalles, listaValoresDetalles);
                        if (resDetalles) {
                            // double precio = double.Parse(bd.consulta1SoloValor("precio", "productos", "id =" + prodsAVender[i].productoId).ToString());
                            // monto += precio * prodsAVender[i].cantidad;
                            res = pago-monto;
                        }
                        else {
                            Ventass.msgError = bd.msgError;
                            return -1;
                        }
                    }

                    // si no hay error en tiempo de ejecución... devolvemos MsgBox Todo bien... y el cambio de pago - monto
                    // si hay error , devolvemos -1 y capturamos el msgError
                }
                else {
                    Ventass.msgError = bd.msgError;
                    return -1;
                }
               
               
            }
            catch (Exception)
            {
                res = -1;
                Ventass.msgError = bd.msgError;
            }
           


            return res;
        }
    }
}
