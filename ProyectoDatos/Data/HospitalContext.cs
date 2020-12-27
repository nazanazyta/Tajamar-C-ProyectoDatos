using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyectoDatos.Models;

namespace ProyectoDatos.Data
{
    public class HospitalContext
    {
        //Net Core trae todas las librerías limpias, no trae nada.
        //Existen los NuGet: necesito añadir las librerías que necesito
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public HospitalContext()
        {
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Hospital> GetHospitales()
        {
            List<Hospital> hospitales = new List<Hospital>();
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "select * from hospital";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                Hospital hosp = new Hospital();
                hosp.IdHospital = Convert.ToInt32(this.reader["hospital_cod"]);
                hosp.Nombre = this.reader["nombre"].ToString();
                hosp.Direccion = this.reader["direccion"].ToString();
                hosp.Telefono = this.reader["telefono"].ToString();
                hosp.Camas = Convert.ToInt32(this.reader["num_cama"]);
                hospitales.Add(hosp);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public Hospital BuscarHospital(int idhospital)
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "select * from hospital where hospital_cod=@idhosp";
            this.com.Parameters.AddWithValue("@idhosp", idhospital);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            Hospital h = new Hospital();
            h.IdHospital = Convert.ToInt32(this.reader["hospital_cod"]);
            h.Nombre = this.reader["nombre"].ToString();
            h.Direccion = this.reader["direccion"].ToString();
            h.Telefono = this.reader["telefono"].ToString();
            h.Camas = Convert.ToInt32(this.reader["num_cama"]);
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return h;
        }

        public int EliminarHospital(int idhospi)
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "delete from hospital where hospital_cod=@id";
            this.com.Parameters.AddWithValue("@id", idhospi);
            this.cn.Open();
            int eli = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return eli;
        }

        public int InsertarHospital(int idhospital, String nombre, String direccion
            , String tlf, int numcamas)
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "insert into hospital values (@idhospital, @nombre, " +
                "@direccion, @telefono, @numcamas)";
            this.com.Parameters.AddWithValue("@idhospital", idhospital);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", tlf);
            this.com.Parameters.AddWithValue("@numcamas", numcamas);
            this.cn.Open();
            int insertados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return insertados;
        }

        public int UpdateHospital(int idhospital, String nombre, String direccion
            , String tlf, int numcamas)
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "update hospital set nombre=@nombre, direccion=@direccion," +
                " telefono=@telefono, num_cama=@numcamas where hospital_cod=@hospitalcod";
            this.com.Parameters.AddWithValue("@hospitalcod", idhospital);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", tlf);
            this.com.Parameters.AddWithValue("@numcamas", numcamas);
            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return modificados;
        }
    }
}
