using ExcelDataReader;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Z.Dapper.Plus;

namespace ExcelMicrosoftSqlServerXml
{
    public partial class Start : Form
    {

        string connetionString;
        string sqlQuery;
        SqlConnection cnn;
        SqlCommand sc;
        string nazwaBazyDanych = "CN_Test";
        string nazwaTabeli = "CN_pracownicy";
        bool czyPolaczono = false;

        DataSet ds;
        DataTableCollection tables;
        DataTable dt;
        BindingSource bs = new BindingSource();
        public Start()
        {
            InitializeComponent();
        }




        private void Polacz_Click(object sender, EventArgs e)
        {


            if (czyPolaczono == false)
            {

                connetionString = @"Data Source=" + SerwerTextBox.Text + ";Initial Catalog=master;Integrated Security=True;Encrypt=False;User ID=" + LoginTextBox.Text + "; Password=" + HasloTextBox.Text;
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Nawi¹zano po³¹czenie");
                    StatusPolaczenia.Text = "Po³¹czony";
                    czyPolaczono = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("B³¹d przy po³¹czeniu");
                }
            }
            else
            {
                MessageBox.Show("Po³¹czenie jest ca³y czas aktywne");
            }
        }

        private void Rozlacz_Click(object sender, EventArgs e)
        {
            if (czyPolaczono == true)
            {


                try
                {
                    cnn.Close();
                    MessageBox.Show("Roz³¹czono po³¹czenie");
                    StatusPolaczenia.Text = "Roz³¹czony";
                    czyPolaczono = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("B³¹d przy roz³¹czeniu");
                }
            }
            else
            {
                MessageBox.Show("Brak nawi¹zanego po³¹czenia");
            }
        }

        private void TworzenieBazyDanych_Click(object sender, EventArgs e)
        {
            sqlQuery = @"CREATE DATABASE " + nazwaBazyDanych + ";";

            try
            {
                sc = new SqlCommand(sqlQuery, cnn);
                sc.ExecuteNonQuery();
                MessageBox.Show("Utworzenie bazy danych " + nazwaBazyDanych);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Baza danych " + nazwaBazyDanych + " ju¿ istnieje, lub jest roz³¹czone po³¹czenie");
            }
        }

        private void TworzenieTabeli_Click(object sender, EventArgs e)
        {

            sqlQuery = @"CREATE TABLE [" + nazwaBazyDanych + "].dbo." + nazwaTabeli
                + "( Prac_ID int NOT NULL IDENTITY (1,1), Prac_Dzial varchar(50) NOT NULL, Prac_Kod varchar(50) NOT NULL, "
                + "Prac_Nazwisko varchar(50) NOT NULL, Prac_Imie varchar(50) NOT NULL, Prac_Stanowisko varchar(50) NOT NULL )"
                + ";";

            try
            {
                sc = new SqlCommand(sqlQuery, cnn);
                sc.ExecuteNonQuery();
                MessageBox.Show("Utworzono tabelê " + nazwaTabeli);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Tabela " + nazwaTabeli + " ju¿ istnieje, lub b³¹d");
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PobierzDane_Click(object sender, EventArgs e)
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook_XLSX|*xlsx", ValidateNames = true })
            {


                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    textSciezka.Text = openFileDialog.FileName;
                    using (var fileStream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {


                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileStream))
                        {
                            ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });


                            tables = ds.Tables;
                            cbo.Items.Clear();

                            foreach (DataTable table in tables)
                            {
                                cbo.Items.Add(table.TableName);
                            }


                        }
                    }


                }
            }
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = tables[cbo.SelectedItem.ToString()];
            ResoultGrid.DataSource = dt;


            foreach (var i in dt.Columns)
            {
                Imie.Items.Add(i.ToString());
                Nazwisko.Items.Add(i.ToString());
                KodPracownika.Items.Add(i.ToString());
                Dzial.Items.Add(i.ToString());
                Stanowisko.Items.Add(i.ToString());

            }


        }

        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt != null)
                {
                    List<Pracownik> pracownicy = new List<Pracownik>();


                    // foreach (int i in dt.Rows)
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Pracownik p = new Pracownik();
                        p.Prac_Imie = dt.Rows[i][Imie.GetItemText(Imie.SelectedItem)].ToString();
                        p.Prac_Nazwisko = dt.Rows[i][Nazwisko.GetItemText(Nazwisko.SelectedItem)].ToString();
                        p.Prac_Kod = dt.Rows[i][KodPracownika.GetItemText(KodPracownika.SelectedItem)].ToString();
                        p.Prac_Dzial = dt.Rows[i][Dzial.GetItemText(Dzial.SelectedItem)].ToString();
                        p.Prac_Stanowisko = dt.Rows[i][Stanowisko.GetItemText(Stanowisko.SelectedItem)].ToString();

                        pracownicy.Add(p);
                    }

                    bs.DataSource = pracownicy;
                }



                DapperPlusManager.Entity<Pracownik>().Table("[" + nazwaBazyDanych + "].dbo." + nazwaTabeli);

                List<Pracownik> pracowniks = bs.DataSource as List<Pracownik>;

                if (pracowniks != null)
                {
                    cnn.BulkInsert(pracowniks);
                    MessageBox.Show("Baza zaimportowana");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            List<Pracownik> listaPracownikowPobierz = new List<Pracownik>();
            SqlDataReader reader;

            sqlQuery = @"SELECT * FROM [" + nazwaBazyDanych + "].dbo." + nazwaTabeli;

            try
            {
                sc = new SqlCommand(sqlQuery, cnn);

                reader = sc.ExecuteReader();

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        Pracownik pracownik = new Pracownik();


                        pracownik.Prac_ID = Convert.ToInt32(reader["Prac_ID"]);
                        pracownik.Prac_Imie = reader["Prac_Imie"].ToString();
                        pracownik.Prac_Nazwisko = reader["Prac_Nazwisko"].ToString();
                        pracownik.Prac_Kod = reader["Prac_Kod"].ToString();
                        pracownik.Prac_Dzial = reader["Prac_Dzial"].ToString();
                        pracownik.Prac_Stanowisko = reader["Prac_Stanowisko"].ToString();



                        listaPracownikowPobierz.Add(pracownik);
                    }

                }

                using (StringWriter stringWriter = new StringWriter(new StringBuilder()))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pracownik>));


                    StreamWriter filestream = new StreamWriter(@"C:\TestExcel\test2.xml");
                    xmlSerializer.Serialize(filestream, listaPracownikowPobierz);
                    filestream.Close();
                }




                MessageBox.Show("Pobrano dane z bazy danych" + nazwaBazyDanych + "z tabeli" + nazwaTabeli);


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("B³¹d przy pobieraniu danych");
            }
        }
    }
}