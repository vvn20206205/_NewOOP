using CCustomerSpace;
using System;
using System.Text;

namespace COrderSpace
{
    // các mặt hàng tạp hóa 
    public class GroceryOrder
    {      // Thuộc tính GroceryOrder

        private Customer objCust;
        // Properties GroceryOrder 
        public Customer ObjCust { get => objCust; set => objCust = value; }

        public GroceryOrder(Customer objCust)
        { ObjCust = objCust; }
        public string Choose()
        {
            return $"Hello {objCust.ToString()}. You have ordered grocery items";
        }
    }
    // các sản phẩm bánh mì
    public class BreadOrder
    {
        // Thuộc tính BreadOrder

        private Customer objCust;
        // Properties BreadOrder 
        public Customer ObjCust { get => objCust; set => objCust = value; }
        public BreadOrder(Customer objCust)
        { ObjCust = objCust; }
        public string Choose()
        {
            return $"Hello {objCust.ToString()}. You have ordered bakery items";
        }
    }
}