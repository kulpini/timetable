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

namespace timetable
{
    public partial class AddTeacherForm : Form
    {
        public string connectionString;
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ShowDays()
        {
            string commandText = "SELECT * FROM days WHERE ID NOT IN (SELECT dayID FROM tempdays)";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "days");
            DaysDataGrid.DataSource = dataset.Tables["days"].DefaultView;
            DaysDataGrid.Columns["ID"].Visible = false;
            DaysDataGrid.Columns["dayname"].Width = 120;
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

        private int ExecuteAdding(string queryText)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = queryText;
            command.ExecuteNonQuery();
            command = new OleDbCommand("SELECT @@IDENTITY", connection);
            return (int)command.ExecuteScalar();
        }

        private void ShowWorkingDays()
        {
            string commandText = "SELECT t.ID,d.dayname FROM tempdays t,days d WHERE t.dayID=d.ID";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "days");
            WorkingDaysDataGrid.DataSource = dataset.Tables["days"].DefaultView;
            WorkingDaysDataGrid.Columns["ID"].Visible = false;
            WorkingDaysDataGrid.Columns["dayname"].Width = 120;
        }

        private void ShowLessons()
        {
            string commandText = "SELECT * FROM lessons l WHERE ID NOT IN (SELECT lessonID FROM templessons)";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "lessons");
            LessonsDataGrid.DataSource = dataset.Tables["lessons"].DefaultView;
            LessonsDataGrid.Columns["ID"].Visible = false;
            LessonsDataGrid.Columns["lessonname"].Width = 120;
        }

        private void ShowTeacherLessons()
        {
            string commandText = "SELECT t.ID,l.lessonname FROM templessons t,lessons l WHERE t.lessonID=l.ID";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "lessons");
            TeacherLessonsDataGrid.DataSource = dataset.Tables["lessons"].DefaultView;
            TeacherLessonsDataGrid.Columns["ID"].Visible = false;
            TeacherLessonsDataGrid.Columns["lessonname"].Width = 120;
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            ShowDays();
            ShowWorkingDays();
            ShowLessons();
            ShowTeacherLessons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TeacherNameTextBox.Text == "")
                MessageBox.Show("Не задано ФИО преподавателя","Ошибка!",MessageBoxButtons.OK);
            else 
                if (WorkingDaysDataGrid.RowCount==0)
                    MessageBox.Show("Не заданы рабочие дни", "Ошибка!", MessageBoxButtons.OK);
                else
                    if (TeacherLessonsDataGrid.RowCount == 0)
                        MessageBox.Show("Не заданы рабочие дисциплины", "Ошибка!", MessageBoxButtons.OK);
            else
            {
                AddNewTeacher();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CheckDay(int dayID)
        {
            string commandText = "INSERT INTO tempdays (dayID) VALUES ("+Convert.ToString(dayID)+")";
            ExecuteQuery(commandText);
            ShowDays();
            ShowWorkingDays();
        }

        private void UnCheckDay(int ID)
        {
            string commandText = "DELETE FROM tempdays WHERE ID =" + Convert.ToString(ID);
            ExecuteQuery(commandText);
            ShowDays();
            ShowWorkingDays();
        }

        private void CheckLesson(int lessonID)
        {
            string commandText = "INSERT INTO templessons (lessonID) VALUES (" + Convert.ToString(lessonID) + ")";
            ExecuteQuery(commandText);
            ShowLessons();
            ShowTeacherLessons();
        }

        private void UnCheckLesson(int ID)
        {
            string commandText = "DELETE FROM templessons WHERE ID =" + Convert.ToString(ID);
            ExecuteQuery(commandText);
            ShowLessons();
            ShowTeacherLessons();
        }

        private void AddNewTeacher()
        {
            string commandText = "INSERT INTO teachers (teachername) VALUES ('"+TeacherNameTextBox.Text+"')";
            int id = ExecuteAdding(commandText);
            commandText = "INSERT INTO studying(teacherID,lessonID) SELECT " + Convert.ToString(id) + ",lessonID FROM templessons";
            ExecuteQuery(commandText);
            commandText = "INSERT INTO workingdays(teacherID,dayID) SELECT "+Convert.ToString(id)+",dayID FROM tempdays";
            ExecuteQuery(commandText);
        }

        private void CheckDayButton_Click(object sender, EventArgs e)
        {
            if (DaysDataGrid.CurrentCell != null)
            {
                int index = DaysDataGrid.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(DaysDataGrid[0,index].Value);
                CheckDay(ID);
            }
            else
                MessageBox.Show("Не выбран день!","Ошибка!",MessageBoxButtons.OK);
        }

        private void AddTeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string commandText = "DELETE FROM tempdays";
            ExecuteQuery(commandText);
            commandText = "DELETE FROM templessons";
            ExecuteQuery(commandText);
        }

        private void UnCheckDayButton_Click(object sender, EventArgs e)
        {
            if (WorkingDaysDataGrid.CurrentCell != null)
            {
                int index = WorkingDaysDataGrid.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(WorkingDaysDataGrid[0, index].Value);
                UnCheckDay(ID);
            }
            else
                MessageBox.Show("Не выбран день!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void CheckLessonButton_Click(object sender, EventArgs e)
        {
            if (LessonsDataGrid.CurrentCell != null)
            {
                int index = LessonsDataGrid.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(LessonsDataGrid[0, index].Value);
                CheckLesson(ID);
            }
            else
                MessageBox.Show("Не выбрана дисциплина!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void UnCheckLessonButton_Click(object sender, EventArgs e)
        {
            if (TeacherLessonsDataGrid.CurrentCell != null)
            {
                int index = TeacherLessonsDataGrid.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(TeacherLessonsDataGrid[0, index].Value);
                UnCheckLesson(ID);
            }
            else
                MessageBox.Show("Не выбрана дисциплина!", "Ошибка!", MessageBoxButtons.OK);
        }
    }
}
