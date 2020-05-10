using System.Configuration;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class ConstStrings
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["TehnoclinicCRM_WinFormsCode.Properties.Settings.ConnectionString"].ConnectionString;
        // возвращает строку подключения
    }
}
