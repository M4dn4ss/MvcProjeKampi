﻿using DataAccessLayer.Abstract;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr.Abstract
{
    public interface IAdminDal : IRepository<Admin>
    {
    }
}
