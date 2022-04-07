using BusinessLayerr.Abstract;
using DataAccessLayerr.Abstract;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imagefileDal;

        public ImageFileManager(IImageFileDal imagefileDal)
        {
            _imagefileDal = imagefileDal;
        }

        public List<ImageFile> GetList()
        {
            return _imagefileDal.List();
        }
    }
}
