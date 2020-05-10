namespace TehnoclinicCRM_WinFormsCode.Models
{
    class Client
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Passport { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Id}; {FIO}; {Passport}; {PhoneNumber};";
        }
    }
}
