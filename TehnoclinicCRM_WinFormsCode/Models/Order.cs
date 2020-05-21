namespace TehnoclinicCRM_WinFormsCode.Models
{
    class Order
    {
        public int Id { get; set; }
        public int? NumberOfOrder { get; set; }
        public string DateOfReceiving { get; set; }
        public Client Client { get; set; }
        public Service Service { get; set; }
        public Specialist Specialist { get; set; }
        public string DateOfBegin { get; set; }
        public string DateOfEnd { get; set; }
        public double? Sum { get; set; }
        public int? Status { get; set; }

        public override string ToString()
        {
            return $"{Id}; {NumberOfOrder}; {DateOfReceiving}; {Client}; {Service}; {Specialist}; {DateOfBegin}; {DateOfEnd}; {Sum}; {Status}";
        }
    }
}
