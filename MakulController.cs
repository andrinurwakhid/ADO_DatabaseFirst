using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DatabaseFirst
{
    class MakulController
    {
        MAHASISWAEntities mhs_context = new MAHASISWAEntities();

        // =========================================== INSERT =============================================
        public void InsertMK()
        {
            Console.Clear();
            System.Console.Write("Nama MK : ");
            string Nama_MK = System.Console.ReadLine();
            System.Console.Write("SKS : ");
            string SKS = System.Console.ReadLine();

            MAKUL call = new MAKUL();
            {
                call.NAME = Nama_MK;
                call.SKS = SKS;

            };
            try
            {
                mhs_context.MAKULs.Add(call);
                var result = mhs_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }





        // =========================================== READ =============================================

        public List<MAKUL> GetAllMakul()
        {
            var getalls = mhs_context.MAKULs.ToList();
            foreach (MAKUL makul in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("NAMA              : " + makul.NAME);
                System.Console.WriteLine("SKS               : " + makul.SKS);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }

        // =========================================== UPDATE =============================================


        public MAKUL GetById3(int input3)
        {
            var makul = mhs_context.MAKULs.Find(input3);
            if (makul == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return makul;
        }
        public int UpdateMakul(int input3)
        {
            System.Console.Write("MASUKKAN NAMA BARU : ");
            string Nama = System.Console.ReadLine();
            System.Console.Write("MASUKKAN SKS BARU  : ");
            string sks = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ULANG ID      : ");
            string id_makul = System.Console.ReadLine();

            var getmakul = mhs_context.PENGAJARs.Find(Convert.ToInt16(id_makul));
            if (getmakul == null)
            {
                System.Console.Write("TIDAK ADA ID DOSEN : " + id_makul);
            }
            else
            {
                MAKUL makul = GetById3(input3);
                makul.NAME = Nama;
                makul.SKS = sks;

                mhs_context.Entry(makul).State = System.Data.Entity.EntityState.Modified;
                mhs_context.SaveChanges();
            }
            return input3;
        }
        // =========================================== DELETE =============================================
        public void DeleteMakul(int input)
        {
            var x = (from y in mhs_context.MAKULs where y.ID == input select y).FirstOrDefault();
            mhs_context.MAKULs.Remove(x);
            mhs_context.SaveChanges();
        }
    }
}
