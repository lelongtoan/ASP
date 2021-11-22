﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace doanasp.Models
{
    public class GioHang
    {

        //mã  sản phẩm
        [Key]
        [DisplayName("MÃ SẢN PHẨM")]
        public SanPham masanpham { get; set; }
        //mã khách hàng 
        [Key]
        [DisplayName("MÃ KHÁCH HÀNG")]
        public account makhachhang { get; set; }
        //số lượng
        [DisplayName("SỐ LƯỢNG")]
        public String soluong { get; set; }
        //trạng thái  1 là còn sản phẩm . -1 là hết sản phẩm 
        [DisplayName("TRẠNG THÁI")]
        public int trangthai { get; set; }
    }
}