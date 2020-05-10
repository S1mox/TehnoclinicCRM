﻿using System;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class SpecialistsForm : Form
    {
        SpecialistsController controller = new SpecialistsController();     // Контроллер для работы с таблице специалистов

        public SpecialistsForm()
        {
            InitializeComponent();

            UpdateGrid();   // Обновление таблицы на форме
        }

        private void Add_Click(object sender, EventArgs e)
        {
            controller.Add(new Specialist() { FIO = FIO.Text, PhoneNumber = PhoneNumber.Text, Position = Position.Text });       // Добавление записи через контроллер

            UpdateGrid();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            if (SpecialistGrid.CurrentRow != null)
            {
                Specialist currentSpecialist = controller.Get(int.Parse(SpecialistGrid.CurrentRow.Cells["Id"].Value.ToString()));      // Берем экземпляр специалиста из базы по его Id

                SpecialistEdit.Text = currentSpecialist.FIO;
                PositionEdit.Text = currentSpecialist.Position;
                PhoneNumberEdit.Text = currentSpecialist.PhoneNumber;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();                                   // Выход из приложения
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                controller.Delete(int.Parse(SpecialistGrid.CurrentRow.Cells["Id"].Value.ToString()));               // Удаление из таблицы БД по его идентификатору
            }

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            SpecialistGrid.DataSource = null;
            SpecialistGrid.DataSource = controller.UpdateTable();
            SpecialistGrid.Columns["Id"].Visible = false;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Specialist specialist = new Specialist()                                        // Создаем экземпляр специалиста из выбранной ячейки
            {
                Id = int.Parse(SpecialistGrid.CurrentRow.Cells["Id"].Value.ToString()),
                FIO = SpecialistEdit.Text,
                Position = PositionEdit.Text,
                PhoneNumber = PhoneNumberEdit.Text
            };

            MessageBox.Show(specialist.ToString());

            controller.Update(specialist);

            UpdateGrid();
        }

        private void MenuForm_Click(object sender, EventArgs e)
        {            

        }

        private void Reset_Click(object sender, EventArgs e)        // Сброс поиска
        {
            CriteriesBox.SelectedIndex = 0;
            SearchText.Text = "";           
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (SearchText != null && SearchText.Text.Length > 0 && CriteriesBox.SelectedItem != null)
            {
                try
                {
                    SpecialistGrid.DataSource = null;
                    SpecialistGrid.DataSource = controller.Select(CriteriesBox.SelectedItem.ToString(), SearchText.Text);       // создаем новую таблицу из найденных записей

                    SpecialistGrid.Columns["Id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                UpdateGrid();
            }
        }

        public void Dictionary_Click(object senderm, EventArgs e)
        {
            new DirectoryForm().Show();
        }
    }
}