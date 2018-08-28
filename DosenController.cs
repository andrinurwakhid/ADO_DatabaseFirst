using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DatabaseFirst
{
    class DosenController
    {
        MAHASISWAEntities mhs_context = new MAHASISWAEntities();

        // =========================================== INSERT =============================================

        public void InsertDOSEN()
        {
            Console.Clear();
            System.Console.Write("NAMA DOSEN : ");
            string Nama_DOSEN = System.Console.ReadLine();
            System.Console.Write("ID MAKUL   : ");
            string ID_MAKUL = System.Console.ReadLine();

            PENGAJAR call = new PENGAJAR();
            {
                call.NAME = Nama_DOSEN;
                call.ID_MAKUL = Convert.ToUInt16(ID_MAKUL);

            };
            try
            {
                mhs_context.PENGAJARs.Add(call);
                var result = mhs_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }




        // =========================================== READ =============================================

        public List<PENGAJAR> GetAllDosen()
        {
            var getalls = mhs_context.PENGAJARs.ToList();
            foreach (PENGAJAR dosen in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("NAMA              : " + dosen.NAME);
                System.Console.WriteLine("ID_MAKUL          : " + dosen.ID_MAKUL);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================


        public PENGAJAR GetById2(int input2)
        {
            var dosen = mhs_context.PENGAJARs.Find(input2);
            if (dosen == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return dosen;
        }
        public int UpdateDosen(int input2)
        {
            System.Console.Write("MASUKKAN NAMA BARU     : ");
            string Nama = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ID_MAKUL BARU : ");
            string id_makul = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ULANG ID      : ");
            string id_dsn = System.Console.ReadLine();

            var getdsn = mhs_context.PENGAJARs.Find(Convert.ToInt16(id_dsn));
            if (getdsn == null)
            {
                System.Console.Write("TIDAK ADA ID DOSEN : " + id_dsn);
            }
            else
            {
                PENGAJAR dosen = GetById2(input2);
                dosen.NAME = Nama;
                dosen.ID_MAKUL = Convert.ToInt16(id_makul);

                mhs_context.Entry(dosen).State = System.Data.Entity.EntityState.Modified;
                mhs_context.SaveChanges();
            }
            return input2;
        }

        // =========================================== DELETE =============================================
        public void DeleteDosen(int input)
        {
            var x = (from y in mhs_context.PENGAJARs where y.ID == input select y).FirstOrDefault();
            mhs_context.PENGAJARs.Remove(x);
            mhs_context.SaveChanges();
        }
    }
}
