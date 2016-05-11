﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using teknolojiMarket.Models;
namespace teknolojiMarket.Models
{
    public class Musteri
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sifre { get; set; }
        public string nik { get; set; }
        public string eposta { get; set; }
        public double bakiye { get; set; }

        public List<Urun> sepet = new List<Urun>();


        public Musteri(DataTable dt) {
            ad = dt.Rows[0]["adi"].ToString();
            soyad = dt.Rows[0]["soyadi"].ToString();
            nik = dt.Rows[0]["nik"].ToString();
            sifre = dt.Rows[0]["sifre"].ToString();
            eposta = dt.Rows[0]["eposta"].ToString();
            bakiye = Convert.ToDouble(dt.Rows[0]["bakiye"].ToString());
        }
        public void sepetDoldur(DataTable dt)
        {
            Urun u;
            for (int i=0;i<dt.Rows.Count;i++) {
                u = new Urun(dt.Rows[i]);
                sepet.Add(u);
            }
        }
    }
   
}