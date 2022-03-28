using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MilkBrasil.Models;
using SQLite;



namespace MilkBrasil.LocalDataBase
{
  public class DataBase
    {
        readonly SQLiteAsyncConnection _database;

        public DataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<CadastroCooperados>().Wait();
        }

        //Método para registrar todos os campos do cadastro de cooperados
        public Task<List<CadastroCooperados>> GetCooperadosAsync()
        {
            return _database.Table<CadastroCooperados>().ToListAsync();
        }

        //Método para inserir (salvar) o registro no banco de dados
        public Task<int> SaveCooperadosAsync(CadastroCooperados cadastroCooperados)
        {
            return _database.InsertAsync(cadastroCooperados);
        }

   
    }
}
