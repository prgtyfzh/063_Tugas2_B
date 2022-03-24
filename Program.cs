using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EXEPABD
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-NH7J05B;database=Exercise;Integrated Security=TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Pegawai (ID_Pegawai char(5) not null primary key, Nama_Pegawai varchar(30), Alamat varchar(50), Jabatan varchar(20))" +
                    ("create table Pelanggan (ID_Pelanggan char(5) not null primary key, Nama_Pelanggan varchar(30), Alamat varchar(50))" +
                    ("create table Obat (ID_Obat char(5) not null primary key, Nama_Obat varchar(30), Jenis varchar(20), Harga decimal(15,0), Stok varchar(20))"), con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah." + e);
                Console.ReadKey();
            }

            finally
            {
                con.Close();
            }
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-NH7J05B;database=Exercise;Integrated Security=TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Pegawai (ID_Pegawai, Nama_Pegawai, Alamat, Jabatan) values ('KP001', 'Asri', 'Bandung', 'Apoteker')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Data berhasil ditambahkan");
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("Data gagal ditambahkan." + e);
                Console.ReadKey();
            }

            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
    }
}
