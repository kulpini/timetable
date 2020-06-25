using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetable
{
    public partial class MainForm : Form
    {
        static string dbPath = AppDomain.CurrentDomain.BaseDirectory+"\\timetable.mdb";
        public string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + dbPath;
        private string activeTable;
        private readonly string[] activeTableName = new string []{ "days", "classes", "lessons" };
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowTableButton_Click(object sender, EventArgs e)
        {
            if (TableNameComboBox.SelectedIndex != -1)
            {
                activeTable = activeTableName[TableNameComboBox.SelectedIndex];
                ShowData();
                switch (activeTable)
                {
                    case "days":
                        GridTitleLabel.Text = "Список дней недели";
                        break;
                    case "lessons":
                        GridTitleLabel.Text = "Список учебных предметов";
                        break;
                    case "classes":
                        GridTitleLabel.Text = "Список классов";
                        break;
                }
            }
        }

        private string GetFieldName()
        {
            string fieldName = "";
            switch (activeTable)
            {
                case "days":
                    fieldName = "dayname";
                    break;
                case "lessons":
                    fieldName = "lessonname";
                    break;
                case "classes":
                    fieldName = "classname";
                    break;
            }
            return fieldName;
        }

        private void EditValue(int ID, string value)
        {
            string commandText = "UPDATE "+activeTable+" SET "+GetFieldName()+"='"+value+"' WHERE ID="+Convert.ToString(ID);
            ExecuteQuery(commandText);
            ShowData();
        }

        private void ShowAllTeachers()
        {
            string commandText = "SELECT * FROM teachers ORDER BY teachername";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "teachers");
            TeachersDataGrid.DataSource = dataset.Tables["teachers"].DefaultView;
            TeachersDataGrid.Columns["ID"].Visible = false;
            TeachersDataGrid.Columns["teachername"].Width = 300;
        }

        private void DeleteValue(int ID)
        {
            string commandText = "DELETE FROM " + activeTable + " WHERE ID="+Convert.ToString(ID);
            ExecuteQuery(commandText);
            ShowData();
        }

        private void AddNewValue(string newValue)
        {
            string commandText = "INSERT INTO "+activeTable+"("+GetFieldName()+") VALUES ('"+newValue+"')";
            ExecuteQuery(commandText);
            ShowData();
        }

        private void ExecuteQuery(string queryText)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = queryText;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ShowTeachers(string commandText)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "teachers");
            TeachersDataGrid.DataSource = dataset.Tables["teachers"].DefaultView;
            TeachersDataGrid.Columns["ID"].Visible = false;
            TeachersDataGrid.Columns["teachername"].Width = 300;
        }

        private void ShowData()
        {
            string commandText = "SELECT * FROM " + activeTable;
            if (activeTable == "lessons")
                commandText += " ORDER BY lessonname";
            if (activeTable == "classes")
                commandText += " ORDER BY classname";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "table");
            DataGrid.DataSource = dataset.Tables["table"].DefaultView;
            DataGrid.Columns["ID"].Visible = false;
            DataGrid.Columns[1].Width = 250;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (activeTable != null)
            {
                string title="";
                switch (activeTable)
                {
                    case "classes":
                        title = "Добавление нового класса в рабочую базу";
                        break;
                    case "lessons":
                        title = "Добавление нового предмета в рабочую базу";
                        break;
                    case "days":
                        title = "Добавление нового дня в рабочую базу";
                        break;
                }
                AddDataForm addForm = new AddDataForm();
                addForm.TitleLabel.Text = title;
                addForm.ShowDialog();
                if (addForm.DialogResult == DialogResult.OK)
                {
                    string newValue = addForm.NewValueTextBox.Text;
                    AddNewValue(newValue);
                }
            }
            else
                MessageBox.Show("Не выбрана ни одна таблица!","Ошибка!",MessageBoxButtons.OK);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = DataGrid.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(DataGrid[0,index].Value);
                    DeleteValue(ID);
                }
            }
            else
                MessageBox.Show("Не выбраны данные для удаления!","Ошибка!",MessageBoxButtons.OK);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.CurrentCell != null)
            {
                int index = DataGrid.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(DataGrid[0, index].Value);
                string value = Convert.ToString(DataGrid[1, index].Value);
                EditDataForm editForm = new EditDataForm();
                editForm.NewValueTextBox.Text = value;
                editForm.ShowDialog();
                if (editForm.DialogResult==DialogResult.OK)
                {
                    value = editForm.NewValueTextBox.Text;
                    EditValue(ID, value);
                }
            }
            else
                MessageBox.Show("Не выбраны данные для редактирования!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string commandText = "SELECT * FROM teachers";
            if (FindTextBox.Text != "")
                commandText += " WHERE teachername LIKE '%"+FindTextBox.Text+"%'";
            commandText += " ORDER BY teachername";
            ShowTeachers(commandText);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowAllTeachers();
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            AddTeacherForm addForm = new AddTeacherForm { connectionString = this.connectionString };
            addForm.ShowDialog();
            string commandText = "SELECT * FROM teachers ORDER BY teachername";
            ShowTeachers(commandText);
        }

        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            if (TeachersDataGrid.CurrentCell != null)
            {
                int index = TeachersDataGrid.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(TeachersDataGrid[0, index].Value);
                DialogResult result = MessageBox.Show("Удалить запись о преподавателе?","",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteTeacher(ID);
                    string commandText = "SELECT * FROM teachers ORDER BY teachername";
                    ShowTeachers(commandText);
                }
            }
            else
                MessageBox.Show("Не выбрана запись для удаления!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void DeleteTeacher(int Id)
        {
            string commandText = "DELETE FROM teachers WHERE ID=" + Convert.ToString(Id);
            ExecuteQuery(commandText);
            commandText = "DELETE FROM workingdays WHERE teacherID=" + Convert.ToString(Id);
            ExecuteQuery(commandText);
            commandText = "DELETE FROM studying WHERE teacherID=" + Convert.ToString(Id);
            ExecuteQuery(commandText);
            MessageBox.Show("Преподаватель удалён из рабочей базы", "", MessageBoxButtons.OK);
        }

        private void TeachersDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = TeachersDataGrid.CurrentCell.RowIndex;
            int ID = Convert.ToInt32(TeachersDataGrid[0,index].Value);
            ShowDays(ID);
            ShowLessons(ID);
        }

        private void ShowDays(int teacherId)
        {
            string commandText = "SELECT l.lessonname FROM lessons l,studying s WHERE l.ID=s.lessonID AND s.teacherID="+Convert.ToString(teacherId);
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "lessons");
            LessonsDataGrid.DataSource = dataset.Tables["lessons"].DefaultView;
            LessonsDataGrid.Columns["lessonname"].Width = 250;
        }

        private void ShowLessons(int teacherId)
        {
            string commandText = "SELECT d.dayname FROM days d,workingdays w WHERE d.ID=w.dayID AND w.teacherID=" + Convert.ToString(teacherId);
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "days");
            WorkingDaysDataGrid.DataSource = dataset.Tables["days"].DefaultView;
            WorkingDaysDataGrid.Columns["dayname"].Width = 250;
        }

        private void EditTeacherButton_Click(object sender, EventArgs e)
        {
            if (TeachersDataGrid.CurrentCell != null)
            {
                int index = TeachersDataGrid.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(TeachersDataGrid[0,index].Value);
                string name = Convert.ToString(TeachersDataGrid[1,index].Value);
                EditTeacherForm editForm = new EditTeacherForm { teacherId = ID,connectionString = this.connectionString};
                editForm.TeacherNameTextBox.Text = name;
                editForm.ShowDialog();
                ShowAllTeachers();
            }
            else
                MessageBox.Show("Не выбран преподаватель из списка!", "Ошибка!", MessageBoxButtons.OK);
        }
    }
}
