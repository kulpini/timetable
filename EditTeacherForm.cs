using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetable
{
    public partial class EditTeacherForm : Form
    {
        public int teacherId;
        public string connectionString;
        public EditTeacherForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void ShowDays()
        {
            string commandText = "SELECT * FROM days WHERE ID NOT IN (SELECT dayID FROM workingdays WHERE teacherID=" + Convert.ToString(teacherId) + ")";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "days");
            DaysDataGrid.DataSource = dataset.Tables["days"].DefaultView;
            DaysDataGrid.Columns["ID"].Visible = false;
            DaysDataGrid.Columns["dayname"].Width=120;
        }

        private void ShowWorkingDays()
        {
            string commandText = "SELECT w.ID,d.dayname FROM workingdays w,days d WHERE w.dayID=d.ID AND w.teacherID=" + Convert.ToString(teacherId);
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "days");
            WorkingDaysDataGrid.DataSource = dataset.Tables["days"].DefaultView;
            WorkingDaysDataGrid.Columns["ID"].Visible = false;
            WorkingDaysDataGrid.Columns["dayname"].Width = 120;
        }

        private void ShowLessons()
        {
            string commandText = "SELECT * FROM lessons WHERE ID NOT IN (SELECT lessonID FROM studying WHERE teacherID=" + Convert.ToString(teacherId) + ")";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "lessons");
            LessonsDataGrid.DataSource = dataset.Tables["lessons"].DefaultView;
            LessonsDataGrid.Columns["ID"].Visible = false;
            LessonsDataGrid.Columns["lessonname"].Width = 120;
        }

        private void ShowTeacherLessons()
        {
            string commandText = "SELECT s.ID,l.lessonname FROM studying s,lessons l WHERE s.lessonID=l.ID AND s.teacherID=" + Convert.ToString(teacherId);
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "lessons");
            TeacherLessonsDataGrid.DataSource = dataset.Tables["lessons"].DefaultView;
            TeacherLessonsDataGrid.Columns["ID"].Visible = false;
            TeacherLessonsDataGrid.Columns["lessonname"].Width = 120;
        }

        private void EditTeacherForm_Load(object sender, EventArgs e)
        {
            ShowDays();
            ShowWorkingDays();
            ShowLessons();
            ShowTeacherLessons();
        }

        private void CheckDayButton_Click(object sender, EventArgs e)
        {
            if (DaysDataGrid.CurrentCell != null)
            {
                int index = DaysDataGrid.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(DaysDataGrid[0, index].Value);
                CheckDay(ID);
            }
            else
                MessageBox.Show("Не выбран день!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void CheckDay(int dayID)
        {
            string commandText = "INSERT INTO workingdays (teacherID,dayID) VALUES (" +Convert.ToString(teacherId)+","+ Convert.ToString(dayID) + ")";
            ExecuteQuery(commandText);
            ShowDays();
            ShowWorkingDays();
        }

        private void UnCheckDay(int ID)
        {
            string commandText = "DELETE FROM workingdays WHERE ID =" + Convert.ToString(ID);
            ExecuteQuery(commandText);
            ShowDays();
            ShowWorkingDays();
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

        private void CheckLesson(int lessonID)
        {
            string commandText = "INSERT INTO studying (teacherID,lessonID) VALUES ("+Convert.ToString(teacherId)+"," + Convert.ToString(lessonID) + ")";
            ExecuteQuery(commandText);
            ShowLessons();
            ShowTeacherLessons();
        }

        private void UnCheckLesson(int ID)
        {
            string commandText = "DELETE FROM studying WHERE ID =" + Convert.ToString(ID);
            ExecuteQuery(commandText);
            ShowLessons();
            ShowTeacherLessons();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TeacherNameTextBox.Text == "")
                MessageBox.Show("Не задано ФИО преподавателя", "Ошибка!", MessageBoxButtons.OK);
            else
                if (WorkingDaysDataGrid.RowCount == 0)
                    MessageBox.Show("Не заданы рабочие дни", "Ошибка!", MessageBoxButtons.OK);
                else
                    if (TeacherLessonsDataGrid.RowCount == 0)
                        MessageBox.Show("Не заданы рабочие дисциплины", "Ошибка!", MessageBoxButtons.OK);
            else
            {
                EditTeacher();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void EditTeacher()
        {
            string commandText = "UPDATE teachers SET teachername='" + TeacherNameTextBox.Text + "' WHERE ID=" + Convert.ToString(teacherId);
            ExecuteQuery(commandText);
        }
    }
}
