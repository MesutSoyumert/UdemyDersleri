﻿using System;
using System.Collections.Generic;

namespace EgitimSatis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEgitimService egitimService = new EgitimManager(new EfEgitimDal(), new YuzdelikIndirimKampanyaManager());
            //IEgitimService egitimService = new EgitimManager(new EfEgitimDal(), new StandartFiyatKampanyaManager());


            foreach (var egitim in egitimService.ListeleEgitimler())
            {
                Console.WriteLine(egitim.Ad + "=" + egitim.Fiyat);
            }

            Console.ReadLine();
        }
    }

    class Egitim : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
    }

    internal interface IEntity
    {
    }

    class EgitimManager : IEgitimService
    {
        IEgitimDal _egitimDal;
        IKampanyaService _kampanyaService;

        public EgitimManager(IEgitimDal egitimDal, IKampanyaService kampanyaService)
        {
            _egitimDal = egitimDal;
            _kampanyaService = kampanyaService;
        }

        public List<Egitim> ListeleEgitimler()
        {
            List<Egitim> egitimler = _egitimDal.ListeleEgitimler();
            _kampanyaService.FiyatGuncelle(egitimler);
            return egitimler;
        }
    }

    interface IEgitimDal
    {
        List<Egitim> ListeleEgitimler();
    }

    class EfEgitimDal : IEgitimDal
    {
        public List<Egitim> ListeleEgitimler()
        {
            return new List<Egitim>
            {
                new Egitim() {Id = 1, Ad = "C# Kursu", Fiyat = 400},
                new Egitim() { Id = 2, Ad = "Java Kursu", Fiyat = 300},
                new Egitim(){Id = 3, Ad = "Python Kursu", Fiyat= 200}
            };
        }
    }

    internal interface IEgitimService
    {
        List<Egitim> ListeleEgitimler();
    }

    interface IKampanyaService
    {
        void FiyatGuncelle(List<Egitim> egitimler);
    }

    class StandartFiyatKampanyaManager : IKampanyaService
    {
        public void FiyatGuncelle(List<Egitim> egitimler)
        {
            foreach (var egitim in egitimler)
            {
                egitim.Fiyat = GuncelStandartFiyatiGetir();
            }
        }

        private decimal GuncelStandartFiyatiGetir()
        {
            //veri tabanına bağlan kampanya detaylarını al
            return 25;
        }
    }

    class YuzdelikIndirimKampanyaManager : IKampanyaService
    {
        public void FiyatGuncelle(List<Egitim> egitimler)
        {
            foreach (var egitim in egitimler)
            {
                egitim.Fiyat = egitim.Fiyat - (egitim.Fiyat * YuzdelikIndirimiGetir());
            }
        }

        private decimal YuzdelikIndirimiGetir()
        {
            //veri tabanına bağlan kampanya detaylarını al
            return Convert.ToDecimal(0.90);
        }
    }
}
