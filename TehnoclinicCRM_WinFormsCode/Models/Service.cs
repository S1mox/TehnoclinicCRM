namespace TehnoclinicCRM_WinFormsCode.Models
{
    class Service
    {
        public int Id { get; set; }
        public int Subdivision { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
