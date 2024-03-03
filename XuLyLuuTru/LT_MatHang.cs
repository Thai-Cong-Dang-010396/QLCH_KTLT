using QLCH_KTLT.Entities;

namespace QLCH_KTLT.XuLyLuuTru
{
    public class LT_MatHang
    {
        public static void LuaDanhSach(MatHang[] danhsach)
        {
            StreamWriter writer = new StreamWriter("f:\\dsmh.txt");
            writer.WriteLine(danhsach.Length);
            for (int i = 0; i < danhsach.Length; i++)
            {
                writer.WriteLine($"{danhsach[i].MaMH},{danhsach[i].Ten},{danhsach[i].HanDung},{danhsach[i].CongTySx},{danhsach[i].NgaySx},{danhsach[i].LoaiHang},{danhsach[i].Gia}");
            }
            writer.Close();
        }

        public static MatHang[] DocDanhSach()
        {
            MatHang[] danhsach;
            StreamReader reader = new StreamReader("f:\\dsmh.txt");
            string s = reader.ReadLine();
            int n = int.Parse(s);
            danhsach = new MatHang[n];

            for (int i = 0; i < danhsach.Length; i++)
            {
                s = reader.ReadLine();
                string[] m = s.Split(",");
                danhsach[i].MaMH = m[0];
                danhsach[i].Ten = m[1];
                danhsach[i].HanDung = m[2];
                danhsach[i].CongTySx = m[3];
                danhsach[i].NgaySx = m[4];
                danhsach[i].LoaiHang = m[5];
                danhsach[i].Gia = int.Parse(m[6]);
            }

            reader.Close();
            return danhsach;
        }

        public static void ThemMatHang(MatHang p)
        {
            MatHang[] danhsach = DocDanhSach();
            MatHang[] danhsachmoi = new MatHang[danhsach.Length + 1];
            for (int i = 0; i < danhsach.Length; i++)
            {
                danhsachmoi[i] = danhsach[i];
            }
            danhsachmoi[danhsachmoi.Length - 1] = p;
            LuaDanhSach(danhsachmoi);
        }

        public static void SuaMatHang(MatHang p)
        {
            MatHang[] danhsach = DocDanhSach();

            for (int i = 0; i < danhsach.Length; i++)
            {
                if (danhsach[i].MaMH == p.MaMH)
                {
                    danhsach[i] = p;
                }
            }
            LuaDanhSach(danhsach);
        }

        public static void XoaMatHang(string mamh)
        {
            MatHang[] danhsach = DocDanhSach();
            MatHang[] danhsachmoi = new MatHang[danhsach.Length - 1];
            int j = 0;
            for (int i = 0; i < danhsach.Length; i++)
            {
                if (danhsach[i].MaMH != mamh)
                {
                    danhsachmoi[j++] = danhsach[i];
                }
            }
            LuaDanhSach(danhsachmoi);
        }

        public static MatHang? DocThongTinChiTietSanPham(string masp)
        {
            MatHang[] ds = DocDanhSach();
            foreach (MatHang s in ds)
            {
                if (s.MaMH == masp)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
