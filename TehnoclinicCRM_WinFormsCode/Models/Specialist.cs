namespace TehnoclinicCRM_WinFormsCode.Models
{
    class Specialist
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Id}; {FIO}; {Position}; {PhoneNumber};";
        }
    }
}
