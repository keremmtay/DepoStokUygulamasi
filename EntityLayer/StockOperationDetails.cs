using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class StockOperationDetails
    {
        [Key]
        public int Id { get; set; }
        public int StockOperationId { get; set; }   
        public int ProductId { get; set; }
        public int Adet { get; set; }
        public double Fiyat { get; set; }

        // İlişkiler

        public Product Product { get; set; }
        public StockOperation StockOperation { get; set; }


    }
}
