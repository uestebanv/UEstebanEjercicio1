using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Opcion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Valor1 { get; set; }
        public Decimal Valor2 { get; set; }
        public Decimal resultado { get; set; }
        public string Cadena { get; set; }
        public List<object> CadenaResultado { get; set; }
        public List<object> Opciones { get; set; }
        public bool Correct { get; set; }


        public static BL.Opcion GetAll()
        {
            BL.Opcion opcion = new BL.Opcion();
            try
            {
                using (SqlConnection connection = new SqlConnection(BL.Conexion.Cadena()))
                {
                    var query = "Select IdOpcion, Nombre From Opcion";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            opcion.Opciones = new List<object>();
                            foreach (DataRow Item in dt.Rows)
                            {
                                BL.Opcion opcion1 = new BL.Opcion();
                                opcion1.Id = (int)Item[0];
                                opcion1.Name = (string)Item[1];

                                opcion.Opciones.Add(opcion1);
                            }
                            opcion.Correct = true;
                        }
                        else
                        {
                            opcion.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                opcion.Correct = false;
            }
            return opcion;
        }
    }
}
