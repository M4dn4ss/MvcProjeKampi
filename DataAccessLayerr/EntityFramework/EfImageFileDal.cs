using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayerr.Abstract;
using EntityLayer.Concrete;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr.EntityFramework
{
    public class EfImageFileDal : GenericRepository<ImageFile>, IImageFileDal
    {
    }
}
