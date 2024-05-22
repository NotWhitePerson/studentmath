using Microsoft.IdentityModel.Abstractions;
using VizsgaCommon;

namespace VizsgaForm
{
    public partial class Form1 : Form
    {
        List<VizsgaCommon.LogEntry> _logs;
        List<VizsgaCommon.LogEntry> _logsBackup;
        public Form1()
        {
            InitializeComponent();
            _LoadData();
            _LoadSearchFields();
        }

        private void _LoadData()
        {
            using (SQL sql = new SQL())
            {
                _logs = sql.Logs.ToList();
            }
            this.dataGridView1.DataSource = _logs;
            _logsBackup = _logs;
        }

        private void _LoadSearchFields()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                this.comboBox1.Items.Add(col.HeaderText);
            }
            this.comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.debugok.Text = this._logs.Where(a => a.Level == "DEBUG").Count().ToString();
            this.errorok.Text = this._logs.Where(a => a.Level == "ERROR").Count().ToString();
            this.osszes.Text = this._logs.Count().ToString();
        }
        private void _Search()
        {
            _logs = _logsBackup;
            switch (this.comboBox1.SelectedItem)
            {
                case "Id":
                    {
                        _logs = _logs.Where(a => a.Id.ToString() == this.textBox3.Text).ToList();
                        break;
                    }
                case "CorrelationId":
                    {
                        _logs = _logs.Where(a => a.CorrelationId.ToString() == this.textBox3.Text).ToList();
                        break;
                    }
                case "DateUtc":
                    {
                        _logs = _logs.Where(a => a.DateUtc.ToString() == this.textBox3.Text).ToList();
                        break;
                    }
                case "Thread":
                    {
                        _logs = _logs.Where(a => a.Thread.ToString() == this.textBox3.Text).ToList();
                        break;
                    }
                case "Level":
                    {
                        _logs = _logs.Where(a => a.Level.Contains(this.textBox3.Text)).ToList();
                        break;
                    }
                case "Logger":
                    {
                        _logs = _logs.Where(a => a.Logger.Contains(this.textBox3.Text)).ToList();
                        break;
                    }
                case "Message":
                    {
                        _logs = _logs.Where(a => a.Message.Contains(this.textBox3.Text)).ToList();
                        break;
                    }
                case "Exception":
                    {
                        _logs = _logs.Where(a => a.Exception.Contains(this.textBox3.Text)).ToList();
                        break;
                    }
            }
            dataGridView1.DataSource = _logs;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Keresési szöveg nincs megadva!");
                this.textBox3.Focus();
                return;
            }
            _Search();
            this.mentesm.Enabled = true;
        }

        private void vissza_Click(object sender, EventArgs e)
        {
            _logs = _logsBackup;
            dataGridView1.DataSource = _logs;
            this.mentesm.Enabled = false;
        }

        private void mentesm_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            if (!string.IsNullOrEmpty(dlg.FileName))
            {
                string[] lines = _logs.Select(d => $"{d.Id};{d.CorrelationId};{d.DateUtc};{d.Thread};{d.Level};{d.Logger};{d.Message};{d.Exception}").ToArray();
                File.AppendAllLines(dlg.FileName, lines);
            }
        }
    }
}