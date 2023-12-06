using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            addRows(addClass.publishDate());
            Filling();
            groupBoxSetting.Visible = false;
        }
        AddtoDB addClass = new AddtoDB();
        //SelectDB addClass = new SelectDB();


        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOpenSetting.FlatAppearance.BorderSize = 0;
            buttonOpenSetting.FlatStyle = FlatStyle.Flat;
            buttonShowAll.FlatAppearance.BorderSize = 0;
            buttonShowAll.FlatStyle = FlatStyle.Flat;
            buttonSortCategory.FlatAppearance.BorderSize = 0;
            buttonSortCategory.FlatStyle = FlatStyle.Flat;
            buttonSendOperation.FlatStyle = FlatStyle.Flat;
            buttonSendOperation.FlatAppearance.BorderSize = 0;
            buttonSortName.FlatStyle = FlatStyle.Flat;
            buttonSortName.FlatAppearance.BorderSize = 0;
            btnConclusionDate.FlatStyle = FlatStyle.Flat;
            btnConclusionDate.FlatAppearance.BorderSize = 0;
        }
        private void Filling()
        {
            DataTable datatableCategory = addClass.fillCategory();
            if (datatableCategory != null)
            {
                comboBoxCategory.DataSource = datatableCategory;
                comboBoxCategory.DisplayMember = "Категория";
                comboBoxCategory.ValueMember = "Категория";
                comboBoxCategory1.DataSource = datatableCategory;
                comboBoxCategory1.DisplayMember = "Категория";
                comboBoxCategory1.ValueMember = "Категория";
            }
            else { MessageBox.Show("В базе нет категорий. Добавьте её!"); }

            DataTable datatableName = addClass.fillName();
            if (datatableName != null)
            {
                comboBoxName.DataSource = datatableName;
                comboBoxName.DisplayMember = "Имя";
                comboBoxName.ValueMember = "Имя";
                comboBoxName1.DataSource = datatableName;
                comboBoxName1.DisplayMember = "Имя";
                comboBoxName1.ValueMember = "Имя";

            }
            else { MessageBox.Show("В базе нет пользователей. Добавьте их!"); }

            groupBoxSetting.Visible = false;
        }

        private void addRows(DataTable table)
        {
            if (table != null)
            {
                dataGridView.DataSource = table;
            }
            else { MessageBox.Show("Записей нет! самое время добавить!", "Внимание!"); }
        }

        private void Summation(string categoryName)
        {
            double sum = 0;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                sum += Convert.ToDouble(dataGridView[3, i].Value);
            }
            labelK.Text = "Сумма расходов " + categoryName + " : " + sum.ToString() + " рублей";
        }

        private void buttonSortCategory_Click(object sender, EventArgs e)
        {
            string categorySort = comboBoxCategory1.Text;
            addRows(addClass.sortCategory(categorySort));
            string categoryName = "по категории " + categorySort;
            Summation(categoryName);
        }

        private void buttonSortName_Click(object sender, EventArgs e)
        {
            string nameSort = comboBoxName1.Text;
            addRows(addClass.sortName(nameSort));
            string cat = "по имени " + nameSort;
            Summation(cat);
        }

        private void btnConclusionDate_Click(object sender, EventArgs e)
        {
            string dateStartStr = dateTimeStart.Value.ToShortDateString();
            dateStartStr = string.Join("/", dateStartStr.Split('.'));

            string dateStopStr = dateTimeStop.Value.ToShortDateString();
            dateStopStr = string.Join("/", dateStopStr.Split('.'));

            addRows(addClass.sortDate(dateStartStr, dateStopStr));
            string cat = "с " + dateStartStr + " по " + dateStopStr;
            Summation(cat);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            buttonShowAll.Text = "Показать все траты";
            addRows(addClass.publishDate());
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            string name = textBoxAddName.Text;
            string category = textBoxAddCategory.Text;
            addClass.addNameCategory(name, category);
            Filling();
            textBoxAddName.Clear();
            textBoxAddCategory.Clear();
        }

        private void buttonOpenSetting_Click(object sender, EventArgs e)
        {
            if (groupBoxSetting.Visible == true)
            {
                groupBoxSetting.Visible = false;
                buttonOpenSetting.Text = "Открыть натройки";
                return;
            }
            if (groupBoxSetting.Visible == false)
            {
                groupBoxSetting.Visible = true;
                buttonOpenSetting.Text = "Закрыть натройки";
            }
        }

        private void buttonSendOperation_Click(object sender, EventArgs e)
        {
            if (comboBoxName.Text == null || textBoxSum.Text == null
                || textBoxComment.Text == null || comboBoxCategory.Text == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }
            try
            {
                double s = Convert.ToDouble(textBoxSum.Text);
                string userName = comboBoxName.Text;
                string date = dateTime.Value.ToShortDateString();
                date = string.Join("/", date.Split('.'));
                string amountMoney = textBoxSum.Text;
                string category = comboBoxCategory.Text;
                string comment = textBoxComment.Text;

                addClass.addRecord(userName, date, amountMoney, category, comment);
                buttonShowAll.Text = "Обновить данные";
                textBoxSum.Clear();
                textBoxComment.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); return; }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.Remove(row);
                }
                addClass.saveDelete("DELETE  FROM [Журнал_расходов] WHERE Id = @rowId ");
            }
            catch (InvalidCastException ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
            catch (OleDbException ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

       
    }
}
