using CoursAdoNet;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CoursAdoNetDeconnecte
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM personne", Connection.Instance);
            //Création de commande d'insertion
            SqlCommand commandInsert = new SqlCommand("INSERT INTO personne ( Nom, Prenom) Values (@nom,@prenom)", Connection.Instance);
            //commandInsert.Parameters.Add("@id", SqlDbType.Int, 11, "Id");
            commandInsert.Parameters.Add("@nom", SqlDbType.VarChar, 50, "Nom");
            commandInsert.Parameters.Add("@prenom", SqlDbType.VarChar, 50, "Prenom");
            SqlCommand commandUpdate = new SqlCommand("UPDATE personne set nom = @nom, prenom = @prenom WHERE id=@id",Connection.Instance);
            commandUpdate.Parameters.Add("@id", SqlDbType.Int, 11, "Id");
            commandUpdate.Parameters.Add("@nom", SqlDbType.VarChar, 50, "Nom");
            commandUpdate.Parameters.Add("@prenom", SqlDbType.VarChar, 50, "Prenom");
            SqlCommand commandDelete = new SqlCommand("DELETE FROM personne where id = @id", Connection.Instance);
            commandDelete.Parameters.Add("@id", SqlDbType.Int, 11, "Id");
            //Attacher la commande a l'adapter
            adapter.InsertCommand = commandInsert;
            adapter.UpdateCommand = commandUpdate;
            adapter.DeleteCommand = commandDelete;
            DataSet data = new DataSet();
            Connection.Instance.Open();
            adapter.Fill(data, "Personnes");
            Connection.Instance.Close();
            //Stocker la table Personnes du DataSet dans une variable
            DataTable tablePersonne = data.Tables["Personnes"];
            //indiquer que la column ID est autoIncrementer
            tablePersonne.Columns["Id"].AutoIncrement = true;
            //indiquer le pas
            tablePersonne.Columns["Id"].AutoIncrementStep = 1;
            //indiquer le début 
            tablePersonne.Columns["Id"].AutoIncrementSeed = (int)tablePersonne.Rows[tablePersonne.Rows.Count - 1]["Id"] + 1;
            Console.WriteLine("----Avant-----");
            foreach(DataRow r in data.Tables["Personnes"].Rows)
            {
                Console.WriteLine("Nom : " + r["Nom"] + " id : " + r["Id"]);
            }
            //Creer une nouvelle ligne
            DataRow ro = data.Tables["Personnes"].NewRow();
            ro["Nom"] = "Coucou1";
            ro["Prenom"] = "CoucouPrénom";
            data.Tables["Personnes"].Rows.Add(ro);
            ro = data.Tables["Personnes"].NewRow();
            ro["Nom"] = "Coucou2";
            ro["Prenom"] = "CoucouPrénom";
            //ro["Id"] = (int)tablePersonne.Rows[tablePersonne.Rows.Count - 1]["Id"] + 1;
            data.Tables["Personnes"].Rows.Add(ro);
            Console.WriteLine("----Après-----");
            foreach (DataRow r in data.Tables["Personnes"].Rows)
            {
                Console.WriteLine("Nom : " + r["Nom"] + " id : "+r["Id"]);
            }
            //modification d'une ligne
            tablePersonne.Rows[3]["Nom"] = "New Value of name at index number 3";
            Connection.Instance.Open();
            //suppression d'une ligne à l'interieur d'une table du DataSet
            tablePersonne.Rows[5].Delete();
            //Mettre à jour la base de donnée à partir de la table du DataSet en utilisant les commandes du adapter
            adapter.Update(tablePersonne);
            Connection.Instance.Close();
            Console.ReadLine();
        }
    }
}
