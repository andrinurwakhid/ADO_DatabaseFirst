using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int menudefault;
            mdefault :
            Console.WriteLine("==================[ CRUD ]===================");
            Console.WriteLine("||    1. CREATE      ||    3. UPDATE       ||");
            Console.WriteLine("||    2. READ        ||    4. DELETE       ||");
            Console.WriteLine("||                5. EXIT                  ||");
            Console.WriteLine("=============================================");
            Console.Write("Tentukan Pilihanmu : "); menudefault = Convert.ToInt32(Console.ReadLine());
            switch (menudefault)
            {
                case 1:
                    Program mc1 = new Program();
                    mc1.m1();
                    break;
                case 2:
                    Program mc2 = new Program();
                    mc2.m2();
                    break;
                case 3:
                    Program mc3 = new Program();
                    mc3.m3();
                    break;
                case 4:
                    Program mc4 = new Program();
                    mc4.m4();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto mdefault;
            }
        }
        public void isimenu ()
        {
            Console.WriteLine("||    1. MAHASISWA   ||    3. MATAKULIAH   ||");
            Console.WriteLine("||    2. DOSEN       ||    4. JADWAL       ||");
            Console.WriteLine("||                5. EXIT                  ||");
            Console.WriteLine("=============================================");
        }
        public void m1()
        {
            int menu1;
        m1:
            Console.Clear();
            Console.WriteLine("================== CREATE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu1 = Convert.ToInt32(Console.ReadLine());
            switch (menu1)
            {
                case 1:
                    MahasiswaController panggilmhs = new MahasiswaController();
                    panggilmhs.InsertMHS();
                    Console.WriteLine("Sukses");
                    break;
                case 2:
                    DosenController panggildosen = new DosenController();
                    panggildosen.InsertDOSEN();
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    MakulController panggilmakul = new MakulController();
                    panggilmakul.InsertMK();
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    JadwalController panggiljadwal = new JadwalController();
                    panggiljadwal.InsertJADWAL();
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m1;
            }
        }
        public void m2()
        {
            int menu2;
        m2:
            Console.Clear();
            Console.WriteLine("=================== READ ====================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu2 = Convert.ToInt32(Console.ReadLine());
            switch (menu2)
            {
                case 1:
                    MahasiswaController panggilmhs = new MahasiswaController();
                    panggilmhs.GetAllMahasiswa();
                    Console.WriteLine("Sukses");
                    break;
                case 2:
                    DosenController panggildosen = new DosenController();
                    panggildosen.GetAllDosen();
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    MakulController panggilmakul = new MakulController();
                    panggilmakul.GetAllMakul();
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    JadwalController panggiljadwal = new JadwalController();
                    panggiljadwal.GetAllJadwal();
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m2;
            }
        }
        public void m3()
        {
            int menu3, input1, input2, input3, input4;
        m3:
            Console.Clear();
            Console.WriteLine("================== UPDATE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu3 = Convert.ToInt32(Console.ReadLine());
            switch (menu3)
            {
                case 1:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input1 = Convert.ToInt32(System.Console.ReadLine());
                    MahasiswaController panggilmhs = new MahasiswaController();
                    panggilmhs.UpdateMHS(input1);
                    Console.WriteLine("Sukses");
                    break;
                case 2:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input2 = Convert.ToInt32(System.Console.ReadLine());
                    DosenController panggildosen = new DosenController();
                    panggildosen.UpdateDosen(input2);
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input3 = Convert.ToInt32(System.Console.ReadLine());
                    MakulController panggilmakul = new MakulController();
                    panggilmakul.UpdateMakul(input3);
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input4 = Convert.ToInt32(System.Console.ReadLine());
                    JadwalController panggiljadwal = new JadwalController();
                    panggiljadwal.UpdateJadwal(input4);
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m3;
            }

        }
        public void m4()
        {
            int menu4, input1, input2, input3, input4;
        m4:
            Console.Clear();
            Console.WriteLine("================== DELETE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu4 = Convert.ToInt32(Console.ReadLine());
            switch (menu4)
            {
                case 1:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input1 = Convert.ToInt32(System.Console.ReadLine());
                    MahasiswaController panggilmhs = new MahasiswaController();
                    panggilmhs.DeleteMahasiswa(input1);
                    Console.WriteLine("Sukses");
                    break;
                case 2:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input2 = Convert.ToInt32(System.Console.ReadLine());
                    DosenController panggildosen = new DosenController();
                    panggildosen.DeleteDosen(input2);
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input3 = Convert.ToInt32(System.Console.ReadLine());
                    MakulController panggilmakul = new MakulController();
                    panggilmakul.DeleteMakul(input3);
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input4 = Convert.ToInt32(System.Console.ReadLine());
                    JadwalController panggiljadwal = new JadwalController();
                    panggiljadwal.DeleteJadwal(input4);
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m4;
            }
        }
    }
}
