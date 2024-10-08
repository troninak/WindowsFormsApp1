using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();

        public Form1()
        {
            InitializeComponent();
            LoadPartnerData();
        }

        public void LoadPartnerData()
        {
            try
            {
                // Очищаем предыдущие данные в контейнере (если данные загружаются повторно)
                flowLayoutPanelPartners.Controls.Clear();

                // Получаем данные о партнёрах
                DataTable partnerData = db.GetPartnerData();

                if (partnerData.Rows.Count > 0)
                {
                    foreach (DataRow row in partnerData.Rows)
                    {
                        // Создаем новый Panel для каждого партнёра (если нужно групировать элементы)
                        Panel partnerPanel = new Panel();
                        partnerPanel.Width = flowLayoutPanelPartners.Width - 20;  // Делаем ширину панели чуть меньше, чем у FlowLayoutPanel
                        partnerPanel.Height = 100;  // Задаём высоту
                        partnerPanel.Margin = new Padding(5);  // Устанавливаем отступы

                        // Создаём метку для типа и компании
                        Label labelTypeCompany = new Label();
                        labelTypeCompany.Text = row["type_partner"] + " | " + row["company_name"].ToString();
                        labelTypeCompany.Width = partnerPanel.Width;
                        labelTypeCompany.Font = new Font("Arial", 12, FontStyle.Bold);

                        // Создаём метку для имени директора
                        Label labelName = new Label();
                        labelName.Text = "Директор: " + row["director_name"].ToString();
                        labelName.Width = partnerPanel.Width;

                        // Создаём метку для телефона
                        Label labelPhone = new Label();
                        labelPhone.Text = "Телефон: " + row["phone"].ToString();
                        labelPhone.Width = partnerPanel.Width;

                        // Создаём метку для рейтинга
                        Label labelRating = new Label();
                        labelRating.Text = "Рейтинг: " + row["rating"].ToString();
                        labelRating.Width = partnerPanel.Width;

                        // Добавляем метки в панель партнера
                        partnerPanel.Controls.Add(labelTypeCompany);
                        partnerPanel.Controls.Add(labelName);
                        partnerPanel.Controls.Add(labelPhone);
                        partnerPanel.Controls.Add(labelRating);

                        // Добавляем панель партнёра в FlowLayoutPanel
                        flowLayoutPanelPartners.Controls.Add(partnerPanel);
                    }
                }
                else
                {
                    MessageBox.Show("Нет данных о партнёрах");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

    }
}
