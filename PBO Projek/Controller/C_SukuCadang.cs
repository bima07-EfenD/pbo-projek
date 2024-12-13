using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Model;
using PBO_Projek.Views.Homepage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_SukuCadang : Connector
    {
        C_Homepage Controller;
        V_SukuCadang viewsuca;

        public C_SukuCadang(C_Homepage controller, V_SukuCadang view)
        {
            Controller = controller;
            viewsuca = view;
        }

        public void Execute_No_Return(NpgsqlCommand cmd)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<M_SukuCadang> GetAllSukuCadang()
        {
            List<M_SukuCadang> sukuCadangList = new List<M_SukuCadang>();
            DataTable query = Execute_With_Return("SELECT Id_Suku_Cadang, Nama_Suku_Cadang,Kategori, Stok, Harga FROM Data_Suku_Cadang");

            foreach (DataRow row in query.Rows)
            {
                M_SukuCadang m_SukuCadang = new M_SukuCadang()
                {
                    Id_Suku_Cadang = Convert.ToInt32(row["Id_Suku_Cadang"]),
                    Nama_Suku_Cadang = row["Nama_Suku_Cadang"].ToString(),
                    Kategori = row["Kategori"].ToString(),
                    Stok = Convert.ToInt32(row["Stok"]),
                    Harga = Convert.ToDecimal(row["Harga"]),

                };
                sukuCadangList.Add(m_SukuCadang);
            }
            return sukuCadangList;
        }


    }
}
