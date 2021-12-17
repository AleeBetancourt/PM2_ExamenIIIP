using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PM2_Examen.Models
{
    public class Pagos
{
       
            [PrimaryKey, AutoIncrement]
            public int Id_pago { get; set; }
            [MaxLength(255)]
            public string Descripcion { get; set; }
            [MaxLength(255)]
            public double Monto { get; set; }
            [MaxLength(255)]
            public DateTime Fecha { get; set; }

            ////public byte[] Photo_recibo { get; set; }


    }
}
