class ExStructEnum
{
        struct SinhVien
        {
            public string HoTen_133;
            public int MaSinhVien_133;
            public string Lop_133;
            public int CMND_133;
            public string DiaChi_133;
            public int DiemTB_133;
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write("Ho ten: ");
            SV.HoTen_133 = Console.ReadLine();
            Console.Write("Ma sinh vien: ");
            SV.MaSinhVien_133 = int.Parse(Console.ReadLine());
            Console.Write("Lop: ");
            SV.Lop_133 = Console.ReadLine();
            Console.Write("So CMND/CCCD: ");
            SV.CMND_133 = int.Parse(Console.ReadLine());
            Console.Write("Dia chi thuong tru: ");
            SV.DiaChi_133 = Console.ReadLine();
             Console.Write("Diem trung binh: ");
            SV.DiemTB_133 = int.Parse(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine("Ho ten: " + SV.HoTen_133);
            Console.WriteLine("Ma sinh vien: " + SV.MaSinhVien_133);
            Console.WriteLine("Lop: " + SV.Lop_133);
            Console.WriteLine("So CMND/CCCD: " + SV.CMND_133);
            Console.WriteLine("Dia chi thuong tru: " + SV.DiaChi_133);
            Console.WriteLine("Diem trung binh: " + SV.DiemTB_133);
        }
        enum HocLuc {Kem, TrungBinh = 5, Kha, Gioi};

        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();

            Console.WriteLine("Nhap thong tin sinh vien:");
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine();
            Console.WriteLine("Thong tin sinh vien vua nhap la: ");
            XuatThongTinSinhVien(SV1);
            int a = (int)HocLuc.Kha;
            Console.WriteLine(a);
            Console.ReadLine();
        }
}