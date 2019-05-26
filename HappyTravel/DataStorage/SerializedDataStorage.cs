using HappyTravel.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace HappyTravel.DataStorage
{
    internal class SerializedDataStorage : IDataStorage
    {
        private readonly List<User> _users;
        private ObservableCollection<Client> _clients;
        private ObservableCollection<Contract> _contracts;
        private ObservableCollection<Pass> _pass;

        internal SerializedDataStorage()
        {
            _clients = new ObservableCollection<Client>();
            _contracts = new ObservableCollection<Contract>();
            _pass = new ObservableCollection<Pass>();
            try
            {
                SerializeClients();
                SerializeContract();
                SerializePass();
            }
            catch (Exception e)
            {
                MessageBox.Show("blyt");
            }
        }

        public ObservableCollection<Client> GetClients()
        {
            return _clients;
        }

        private void SerializeClients()
        {
            string connStr = "server=us-cdbr-gcp-east-01.cleardb.net;user=b08c8f9d8c7549;database=gcp_b59f698ea7b4607d7c34;password=1ab93de2;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM client";
                MySqlCommand comand = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var client_code = reader.GetInt32(0);
                        var passport_number = reader.GetString(1);
                        var surname = reader.GetString(2);
                        var name = reader.GetString(3);
                        var fathers_name = reader.GetString(4);
                        var birth_date = reader.GetDateTime(5);
                        var age = reader.GetInt32(6);
                        var email = reader.GetString(7);
                        _clients.Add(new Client(client_code, passport_number, surname, name, fathers_name, birth_date, age, email));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public ObservableCollection<Contract> GetContract()
        {
            return _contracts;
        }

        private void SerializeContract()
        {
            string connStr = "server=us-cdbr-gcp-east-01.cleardb.net;user=b08c8f9d8c7549;database=gcp_b59f698ea7b4607d7c34;password=1ab93de2;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM contract";
                MySqlCommand comand = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var contract_number = reader.GetString(0);
                        var date_of_making = reader.GetDateTime(1);
                        var client_code = reader.GetString(2);
                        _contracts.Add(new Contract(contract_number,date_of_making, client_code));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public ObservableCollection<Pass> GetPass()
        {
            return _pass;
        }

        private void SerializePass()
        {
            string connStr = "server=us-cdbr-gcp-east-01.cleardb.net;user=b08c8f9d8c7549;database=gcp_b59f698ea7b4607d7c34;password=1ab93de2;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM pass";
                MySqlCommand comand = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pass_number = reader.GetInt32(0);
                        var status = reader.GetString(1);
                        var number_of_people = reader.GetInt32(2);
                        var price = reader.GetDecimal(3);
                        var start_date = reader.GetDateTime(4);
                        var end_date = reader.GetDateTime(5);
                        var duration = reader.GetInt32(6);
                        var contract_number = reader.GetInt32(7);
                        _pass.Add(new Pass(pass_number, status, number_of_people, price, start_date, end_date, duration, contract_number));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }
        //private void SaveChanges()
        //{
        //    SerializationManager.Serialize(_users, FileFolderHelper.StorageFilePath);
        //}

    }
}
