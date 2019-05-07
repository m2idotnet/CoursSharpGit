using System;
using System.Data.SqlClient;

namespace CoursAdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Merci de saisir votre Nom : ");
            //string n = Console.ReadLine();
            //Console.Write("Merci de saisir votre Prénom : ");
            //string p = Console.ReadLine();

            //insertion Sans resultat requete
            //SqlConnection connection = new SqlConnection(@"Data Source=(localDb)\CoursAdoNet;Integrated Security=True");
            //SqlCommand command = new SqlCommand("INSERT INTO personne (nom,prenom) values(@nom,@prenom)", connection);
            //command.Parameters.Add(new SqlParameter("@nom", n));
            //command.Parameters.Add(new SqlParameter("@prenom", p));
            //connection.Open();
            //if(command.ExecuteNonQuery() > 0)
            //{
            //    Console.WriteLine("Insertion effecuté");
            //}

            //Insertion avec resultat de la requete
            //SqlCommand command = new SqlCommand("INSERT INTO personne (nom,prenom) OUTPUT INSERTED.ID values(@nom,@prenom)", connection);
            //command.Parameters.Add(new SqlParameter("@nom", n));
            //command.Parameters.Add(new SqlParameter("@prenom", p));
            //connection.Open();
            //int id = (int)command.ExecuteScalar();
            //Console.WriteLine("Insertion effectué avec id = " + id);
            //Lecture d'une requete
            Console.Write("Votre recherche  : ");
            string search = Console.ReadLine();
            SqlCommand command = new SqlCommand("SELECT * FROM personne where nom like @search OR prenom like @search", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@search", "%"+search+"%"));
            Connection.Instance.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("Nom : " + reader.GetString(1) + " Prénom :  " + reader.GetString(2) + " Id : " + reader.GetInt32(0));
            }
            reader.Close();
            command.Dispose();
            Connection.Instance.Close();
            Console.ReadLine();
        }
    }
}
