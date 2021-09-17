using Core;
using Core.Entities;

namespace Entities.DTOs
{
    //İki entity tablosunu birbirine joinleyerek buraya yazarız
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
        
    }
}