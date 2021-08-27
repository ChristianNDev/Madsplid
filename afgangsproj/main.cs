using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using afgangsprojekt.pattens;

namespace Madspild
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

        }


        SqlConnection con = new SqlConnection(@"You're database connection");
        string cs = @"You're database connection";
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        produkt pro = new produkt();


        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'afgangsprojektDataSet2.produkt' table. You can move, or remove it, as needed.
           // this.produktTableAdapter2.Fill(this.afgangsprojektDataSet2.produkt);
            // TODO: This line of code loads data into the 'afgangsprojektDataSet1.produkt' table. You can move, or remove it, as needed.
           // this.produktTableAdapter1.Fill(this.afgangsprojektDataSet1.produkt);
            // TODO: This line of code loads data into the 'afgangsprojektDataSet.produkt' table. You can move, or remove it, as needed.
            this.produktTableAdapter.Fill(this.afgangsprojektDataSet.produkt);


            int sum = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.IsNewRow) break;
                int product = (int)row.Cells[6].Value + (int)row.Cells[6].Value;
                sum += product;
                row.Cells[6].Value = product;
            }

            antalkg_label.Text = sum.ToString() + " kg";

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM produkt ORDER BY id DESC ", con);


            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                offerstat_t.Text = dr["id"].ToString();

            }
            con.Close();




        }

      
        private void tabPage3_Click(object sender, EventArgs e)
        {
            tabPage3.Height = 400;
        }


        private void Home_btn_Click(object sender, EventArgs e)
        {
           

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM produkt ORDER BY id DESC ", con);

          
            //SqlCommand cmd1 = new SqlCommand("SELECT kg + kg as sum from produkt", con);



            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                offerstat_t.Text = dr["id"].ToString();
                

            }
            con.Close();
            tabControl1.SelectedTab = tabPage1;
            Sp1.Visible = true;
            Sp2.Visible = false;
            Sp4.Visible = false;
           

        }

        private void offer_btn_Click(object sender, EventArgs e)
        {
      

            tabControl1.SelectedTab = tabPage2;
            Sp1.Visible = false;
            Sp2.Visible = true;
            Sp4.Visible = false;
           

        }
            private void delivery_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            Sp1.Visible = false;
            Sp2.Visible = false;
            Sp4.Visible = true;

            SqlConnection con1 = new SqlConnection(cs);
            DataTable dt = new DataTable();
            con1.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select LoginName,FirstName,LastName,adresse,afhenting,Mail from [User] where UserID = 1 ", con1);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                letxt_brugernavn.Text = (myReader["LoginName"].ToString());
                letxt_navn.Text = (myReader["FirstName"].ToString());
                leEfternavn_txt.Text = (myReader["LastName"].ToString());
                letxt_mail.Text = (myReader["adresse"].ToString());
                letxt_adresse.Text = (myReader["Mail"].ToString());
                //and whatever you have to retrieve
                bool checkvalue = Convert.ToBoolean(myReader["afhenting"]);
                if(checkvalue == true)
                {
                    letxt_ja.Checked = true;
                }
                else if(checkvalue == false)
                {
                    letxt_nej.Checked = false;
                }
            }
            con1.Close();

        }

     

        private void Opret_tilbud_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=tcp:afgangsserver.database.windows.net,1433;Initial Catalog=afgangsprojekt;Persist Security Info=False;User ID=Chris;Password=Kaffe123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


            SqlCommand cmd = new SqlCommand("INSERT INTO produkt (product,produktbeskrivelse,quantity, price,stars,kg,fra_dato,til_dato) VALUES (@title,@Beskrivelse,@Antal,@Pris,@stars, @kg, @datofra,@datotil)", con);

            //Tilføjer data til tabellen
            //string tilbud_titel = Convert.ToString(tilbud_titel.TrimEnd);


            // #region Validering af textbokse til databasen

            //#region Validerer tilbud
            //Validere om slutbrugeren skriver noget eller e
            if (string.IsNullOrEmpty(tilbud_titel.Text))
            {
                Error_titel.Visible = true;
                Error_titel.Text = "Skriv venligt en titel";
                 pro.tilbud_titel = "";

            }
            else
            {
                Error_titel.Visible = false;
                cmd.Parameters.AddWithValue("@title", tilbud_titel.Text);

            }
            if (string.IsNullOrEmpty(tilbud_beskrivelse.Text))
            {

                error_beskrivelse.Visible = true;
                error_beskrivelse.Text = "Skriv venligt en beskrivelse";
                tilbud_beskrivelse.Text = "";


            }
            else
            {

                error_beskrivelse.Visible = false;

                cmd.Parameters.AddWithValue("@Beskrivelse", tilbud_beskrivelse.Text);

            }
            //#endregion slut tilbud
            #region Validerer Antal

            int i;
            //Validere om antal er 0 eller om antal er over 0
            if (int.TryParse(tilbud_antal.Text, out i))
            {

                pro.tilbud_antalD = Convert.ToInt32(tilbud_antal.Text);

                cmd.Parameters.AddWithValue("@Antal", (pro.tilbud_antalD));
                error_Antal.Visible = false;

            }
            else
            {
                error_Antal.Visible = true;
                error_Antal.Text = "Skriv venligt et tal antalet af måltider";
            }
            #endregion slut antal
            #region Validerer Pris
            //Validere om Pris er 0 eller om pris er over 0
            if (int.TryParse(tilbud_pris.Text, out i))
            {
                pro.tilbud_pris = Convert.ToInt32(tilbud_pris.Text);
                cmd.Parameters.AddWithValue("@Pris", (pro.tilbud_pris));
                error_pris.Visible = false;
            }
            else
            {


                error_pris.Visible = true;
                error_pris.Text = "Skriv venligt et tal antalet af måltider";
            }
            //Validere om Pris er 0 eller om pris er over 0
            if (int.TryParse(tilbud_kg.Text, out i))
            {
                pro.tilbud_kg = Convert.ToInt32(tilbud_kg.Text);

                cmd.Parameters.AddWithValue("@kg", (pro.tilbud_kg));
                error_pris.Visible = false;
            }
            else
            {


                error_pris.Visible = true;
                error_pris.Text = "Skriv venligt et tal antalet af måltider";
            }
            #endregion slut Pris
            #region Validerer Dato fra
            if (DateTime.Parse(tilbud_fradato.Text) == null)
            {
                error_fradato.Visible = true;
                error_fradato.Text = "Skriv venligt et tal antalet af måltider";
            }
            else
            {
                pro.tilbud_fradato = Convert.ToDateTime(tilbud_fradato.Text);
                cmd.Parameters.AddWithValue("@datotil", (pro.tilbud_fradato));
                error_fradato.Visible = false;

            }
            #endregion slut dato fra
            #region Validerer Dato til
            if (DateTime.Parse(tilbud_tildato.Text) == null)
            {
                error_tildato.Visible = true;
                error_tildato.Text = "Skriv venligt et tal antalet af måltider";
            }
            else
            {
                pro.tilbud_datetil = Convert.ToDateTime(tilbud_tildato.Text);
                cmd.Parameters.AddWithValue("@datofra", (pro.tilbud_datetil));
                error_tildato.Visible = false;

            }
            #endregion slut til
            #region Validerer Stjerner

            if (int.TryParse(tilbud_stjerner.Text, out i))
            {
                pro.tilbud_stjerner = Convert.ToInt32(tilbud_stjerner.Text);
                cmd.Parameters.AddWithValue("@stars", (pro.tilbud_stjerner));

                //Inkrementer med et for hver tilbud slutkunden laver
              Offerstat offer = new Offerstat();
              cmd.Parameters.AddWithValue("@offerS", (offer.MyId));
              error_stjerner.Visible = false;
            }


            else
            {
                error_stjerner.Text = "Skriv venligst et tal fra 1-6";
            }
            #endregion slut Stjerner
            // #endregion slut Validering
            con.Open();
            int y = cmd.ExecuteNonQuery();

            con.Close();

            if (y != 0)
            {
              

                MessageBox.Show(i + "Dit tilbud blev oprettet");
                tabControl1.SelectedTab = tabPage1;
            }


          

        }

       

        private void tilbud_opretbud_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void App_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void tilbudob_redigere_btn_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentRow.Index;
            if (dataGridView2.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                tabControl1.SelectedTab = tabPage7;




                /* tilbud_fradato.Value = tilbud_tildato.Value;
                 tilbud_tildato.Value = tilbud_fradato.Value;



                 tilbud_fradato.Value = tilbud_fradato.Value;
                 tilbud_tildato.Value = tilbud_tildato.Value;
                  */


            }


        }

        private void redigere_gem_Click(object sender, EventArgs e)
        {
         if (redigere_titel.Text != "" && redigere_beskriv.Text != "")
             {
                 cmd = new SqlCommand("UPDATE produkt set product = @title, produktbeskrivelse = @Beskrivelse, quantity = @Antal, price = @Pris, stars = @stars, kg = @kg where ID=@id", con);
                 con.Open();
                 cmd.Parameters.AddWithValue("@id", ID);
                 cmd.Parameters.AddWithValue("@title", redigere_titel.Text);
                 cmd.Parameters.AddWithValue("@Beskrivelse", redigere_beskriv.Text);
                 cmd.Parameters.AddWithValue("@Antal", redigere_antal.Text);
                 cmd.Parameters.AddWithValue("@Pris", redigere_pris.Text);
                 cmd.Parameters.AddWithValue("@stars", redigere_stjerner.Text);
                 cmd.Parameters.AddWithValue("@kg", redigere_kg.Text);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Record Updated Successfully");
                 con.Close();
                 DisplayData();
                 tabControl1.SelectedTab = tabPage1;
                 ClearData();
             }
             else
             {
                 MessageBox.Show("Please Select Record to Update");
             }
            


        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lebtn_opret_Click(object sender, EventArgs e)
        {

            if (letxt_brugernavn.Text != "" && letxt_navn.Text != "")
            {
                cmd = new SqlCommand("UPDATE [User] set FirstName = @Name, LastName = @lastname, adresse = @Adresse,afhenting = @afhent, Mail = @Mail WHERE UserID = 1", con);
                con.Open();
                
              
                cmd.Parameters.AddWithValue("@Name", letxt_navn.Text);
                cmd.Parameters.AddWithValue("@lastname", leEfternavn_txt.Text);
                cmd.Parameters.AddWithValue("@Adresse", letxt_adresse.Text);
                cmd.Parameters.AddWithValue("@Mail", letxt_mail.Text);
                if (letxt_ja.Checked)
                {
                    cmd.Parameters.AddWithValue("@afhent", 1);
                }
               else if (letxt_nej.Checked)
                {
                    cmd.Parameters.AddWithValue("@afhent", 0);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                tabControl1.SelectedTab = tabPage1;
               
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void ClearData()
        {
            redigere_titel.Text = "";
            redigere_beskriv.Text = "";
            redigere_antal.Text = "";
            redigere_pris.Text = "";
            redigere_stjerner.Text = "";
            redigere_kg.Text = "";

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from produkt", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }


        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            redigere_titel.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            redigere_beskriv.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            redigere_antal.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            redigere_pris.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            redigere_stjerner.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            redigere_kg.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        }


        private void slet_overblik_btn_Click(object sender, EventArgs e)
        {



            if (ID != 0)
            {
                cmd = new SqlCommand("delete produkt where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }

      

        private void logout_main_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du er nu logget ud ");
            //Skjuler formen
            Form1 frm1 = new Form1();
            main me = new main();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
           
        }

        private void redigere_titel_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

