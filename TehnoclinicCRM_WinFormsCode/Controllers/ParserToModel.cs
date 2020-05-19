using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class ParserToModel
    {
        public Client GetClient(DataRow row)
        {
            return new Client()
            {
                Id = int.Parse(row["Id"].ToString()),
                FIO = row["ФИО"].ToString(),
                Passport = row["Паспортные_данные"].ToString(),
                PhoneNumber = row["Номер_телефона"].ToString(),
            };
        }

        public Specialist GetSpecialist(DataRow row)
        {
            return new Specialist()
            {
                Id = int.Parse(row["Id"].ToString()),
                FIO = row["ФИО"].ToString(),
                Position = row["Должность"].ToString(),
                PhoneNumber = row["Телефон"].ToString(),
            };
        }

        public Service GetService(DataRow row)
        {
            return new Service()
            {
                Id = int.Parse(row["Id"].ToString()),
                Name = row["Услуга"].ToString(),
                Subdivision = int.Parse(row["Код_подразделения"].ToString()),
                Price = double.Parse(row["Цена"].ToString())
            };
        }

        public Subdivision GetSubdivision(DataRow row)
        {
            return new Subdivision()
            {
                Id = int.Parse(row["Код"].ToString()),
                Type = row["Тип"].ToString(),
            };
        }
    }
}
