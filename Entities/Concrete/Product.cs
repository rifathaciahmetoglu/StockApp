using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string? ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductBarcode { get; set; }
        public string? ProductDescription { get; set;}

    }
}
