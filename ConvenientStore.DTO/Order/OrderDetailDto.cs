namespace ConvenientStore.DTO.Order
{
    public class OrderDetailDto
    {
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}