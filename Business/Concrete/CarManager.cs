﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Descriptions.Length>2)
            {
                _carDal.Add(car);

            }
            else
            {
                Console.WriteLine("Günlük fiyatı 0'dan büyük İsmi 2 karakterden uzun olmalı");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId==id);
        }
    }
}
