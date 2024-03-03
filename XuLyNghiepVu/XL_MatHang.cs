using QLCH_KTLT.Entities;
using QLCH_KTLT.XuLyLuuTru;

namespace QLCH_KTLT.XuLyNghiepVu
{
    public class XL_MatHang
    {
        public static MatHang[] DocDanhSach(string tukhoa = "")
        {
            MatHang[] danhsach;
            danhsach = LT_MatHang.DocDanhSach();
            int n = 0;
            for (int i = 0; i < danhsach.Length; i++)
            {
                if (danhsach[i].MaMH.Contains(tukhoa) || danhsach[i].Ten.Contains(tukhoa))
                {
                    n++;
                }
            }

            MatHang[] ketqua;
            ketqua = new MatHang[n];
            int j = 0;
            for (int i = 0; i < danhsach.Length; i++)
            {
                if (danhsach[i].MaMH.Contains(tukhoa) || danhsach[i].Ten.Contains(tukhoa))
                {
                    ketqua[j] = danhsach[i];
                    j++;
                }
            }

            return ketqua;
        }

        public static string ThemMatHang(MatHang p)
        {
            string kq = string.Empty;
            bool isValid = true;
            if (p.Gia < 0)
            {
                kq = "Gia san pham khong hop le";
            }
            if (isValid)
            {
                LT_MatHang.ThemMatHang(p);
                kq = "Them Thanh Cong";
            }
            return kq;
        }

        public static string SuaMatHang(MatHang p)
        {
            string kq = string.Empty;
            bool isValid = true;
            if (p.Gia < 0)
            {
                kq = "Gia san pham khong hop le";
            }
            if (isValid)
            {
                LT_MatHang.SuaMatHang(p);
                kq = "Sua Thanh Cong";
            }
            return kq;
        }

        public static string XoaMatHang(string mamh)
        {
            string kq = string.Empty;
            bool isValid = true;
            if (mamh == null)
            {
                kq = "San pham khong hop le";
            }
            if (isValid)
            {
                LT_MatHang.XoaMatHang(mamh);
                kq = "Xoa Thanh Cong";
            }
            return kq;
        }

        public static MatHang? DocThongTinChiTietSanPham(string masp)
        {
            MatHang? kq;
            kq = LT_MatHang.DocThongTinChiTietSanPham(masp);
            return kq;
        }
    }
}
