using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DatabaseFirst
{
    class MahasiswaController
    {
        MAHASISWAEntities mhs_context = new MAHASISWAEntities();
        
        // =========================================== INSERT =============================================
        public void InsertMHS()
        {
            Console.Clear();
            System.Console.Write("Nama Mahasiswa : ");
            string Nama_Mahasiswa = System.Console.ReadLine();
            System.Console.Write("Alamat Mahasiswa : ");
            string Alamat_Mahasiswa = System.Console.ReadLine();
            System.Console.Write("Email : ");
            string email = System.Console.ReadLine();

            MAHASISWA call = new MAHASISWA();
            {
                call.NAME = Nama_Mahasiswa;
                call.ADDRESS = Alamat_Mahasiswa;
                call.EMAIL = email;

            };
            try
            {
                mhs_context.MAHASISWAs.Add(call);
                var result = mhs_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        // =========================================== READ =============================================
        public List<MAHASISWA> GetAllMahasiswa()
        {
            var getalls = mhs_context.MAHASISWAs.ToList();
            foreach (MAHASISWA mahasiswa in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("NAMA              : " + mahasiswa.NAME);
                System.Console.WriteLine("ALAMAT            : " + mahasiswa.ADDRESS);
                System.Console.WriteLine("EMAIL             : " + mahasiswa.EMAIL);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public MAHASISWA GetById(int input)
        {
            var mahasiswa = mhs_context.MAHASISWAs.Find(input);
            if (mahasiswa == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return mahasiswa;
        }
        public int UpdateMHS(int input)
        {
            System.Console.Write("MASUKKAN NAMA BARU   : ");
            string Nama = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ALAMAT BARU : ");
            string Alamat = System.Console.ReadLine();
            System.Console.Write("MASUKKAN EMAIL BARU  : ");
            string Email = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ULANG ID    : ");
            string id_mhs = System.Console.ReadLine();

            var getmhs = mhs_context.MAHASISWAs.Find(Convert.ToInt16(id_mhs));
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID MAHASISWA : " + id_mhs);
            }
            else
            {
                MAHASISWA mahasiswa = GetById(input);
                mahasiswa.NAME = Nama;
                mahasiswa.ADDRESS = Alamat;
                mahasiswa.EMAIL = Email;

                mhs_context.Entry(mahasiswa).State = System.Data.Entity.EntityState.Modified;
                mhs_context.SaveChanges();
            }
            return input;
        }

        // =========================================== DELETE =============================================
        public void DeleteMahasiswa(int input)
        {
            var x = (from y in mhs_context.MAHASISWAs where y.ID == input select y).FirstOrDefault();
            mhs_context.MAHASISWAs.Remove(x);
            mhs_context.SaveChanges();
        }
        
    }
}
