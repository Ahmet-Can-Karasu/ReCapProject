﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        

       
        void Add(Car car);
        void Delete(Car car);
        void Updete(Car car);
    }
}
