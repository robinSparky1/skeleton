namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder() {
        }

        public object Active { get; set; }
        public int OrderNumber { get; set; }
        public string Address { get; set; }
        public int ItemCount { get; set; }
        public double OrderPrice { get; set; }
    }
}