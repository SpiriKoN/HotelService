﻿using Hotel.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repository
{
    public interface IRepository
    {
        List<TypeRoom> GetAllType();
        void ReserverRoom(string[] valueFields);
    }
}
