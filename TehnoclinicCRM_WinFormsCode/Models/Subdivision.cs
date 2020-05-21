namespace TehnoclinicCRM_WinFormsCode.Models
{
    class Subdivision
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
