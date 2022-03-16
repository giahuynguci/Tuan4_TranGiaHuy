using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuan4_TranGiaHuy.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masach { get; set; }

        public string tensach { get; set; }

        public string hinh { get; set; }
        public double giaban { get; set; }
        public int iSoluong { get; set; }
        public double dThanhtien
        {
            get { return iSoluong * giaban; }
        }
        public GioHang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            iSoluong = 1;
        }
    }
}