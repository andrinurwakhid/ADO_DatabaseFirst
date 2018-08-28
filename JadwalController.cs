using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DatabaseFirst
{
    class JadwalController
    {
        MAHASISWAEntities mhs_context = new MAHASISWAEntities();

        // =========================================== INSERT =============================================

        public void InsertJADWAL()
        {
            Console.Clear();
            System.Console.Write("ID MAHASISWA : ");
            string ID_MHS = System.Console.ReadLine();
            System.Console.Write("ID DOSEN     : ");
            string ID_DOSEN = System.Console.ReadLine();

            JADWAL call = new JADWAL();
            {
                call.ID_MAHASISWA = Convert.ToUInt16(ID_MHS);
                call.ID_PENGAJAR = Convert.ToUInt16(ID_DOSEN);

            };
            try
            {
                mhs_context.JADWALs.Add(call);
                var result = mhs_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }


        // =========================================== READ =============================================

        public List<JADWAL> GetAllJadwal()
        {
            var getalls = mhs_context.JADWALs.ToList();
            foreach (JADWAL jadwal in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID MAHASISWA      : " + jadwal.ID_MAHASISWA);
                System.Console.WriteLine("ID DOSEN          : " + jadwal.ID_PENGAJAR);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }

        // =========================================== UPDATE =============================================
        
        public JADWAL GetById4(int input4)
        {
            var jadwal = mhs_context.JADWALs.Find(input4);
            if (jadwal == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return jadwal;
        }
        public int UpdateJadwal(int input4)
        {
            System.Console.Write("MASUKKAN ID MAHASISWA BARU : ");
            string id_mahasiswa = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ID PENGAJAR  BARU : ");
            string id_pengajar = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ULANG ID          : ");
            string id_jadwal = System.Console.ReadLine();

            var getjadwal = mhs_context.PENGAJARs.Find(Convert.ToInt16(id_jadwal));
            if (getjadwal == null)
            {
                System.Console.Write("TIDAK ADA ID DOSEN : " + id_jadwal);
            }
            else
            {
                JADWAL jadwal = GetById4(input4);
                jadwal.ID_MAHASISWA = Convert.ToInt16(id_mahasiswa);
                jadwal.ID_PENGAJAR = Convert.ToInt16(id_pengajar);

                mhs_context.Entry(jadwal).State = System.Data.Entity.EntityState.Modified;
                mhs_context.SaveChanges();
            }
            return input4;
        }
        
        // =========================================== DELETE =============================================
        public void DeleteJadwal(int input)
        {
            var x = (from y in mhs_context.JADWALs where y.ID == input select y).FirstOrDefault();
            mhs_context.JADWALs.Remove(x);
            mhs_context.SaveChanges();
        }
    }
}
