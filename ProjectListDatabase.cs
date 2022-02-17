using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Seceta_Raisa_ONGs.Models;

namespace Seceta_Raisa_ONGs.Data

public class ProjectListDatabase
{
	readonly SQLiteAsyncConnection_database;

		public ProjectListDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<ProjectListDatabase>().Wait();
        _database.CreateTableAsync<Proiect>().Wait();
        _database.CreateTableAsync<ListProiect>().Wait();
    }
    public Task<int> SaveProiectAsync (Proiect proiect)
    {
        if( proiect.ID != 0)
        {
            return _database.UpdateAsync(proiect);
        }
        else
        {
            return _database.InsertAsync(proiect);
        }
    }

    public Task<int> DeleteProductAsync (Proiect proiect)
    {
        return _database.DeleteAsync(proiect);
    }
    public Task<List<Proiect>> GetProiectsAsync()
    {
        return _database.Table<GetProiectsAsync>().ToListAsync();
    }

    public Task<List<ProjectListDatabase>> GetProjectListsAsync()
    {
        return _database.Table<ProjectListDatabase>().ToListAsync();
    }
    public Task<ProjectListDatabase> GetProjectListAsync(int id)
    {
        return _database.Table<ProjectListDatabase>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
    }
    public Task<int> SaveProjectListAsync (ProjectListDatabase slist)
    {
        if (slist.ID != 0)
        {
            return _database.UpdateAsync(slist);
        }
        else
        {
            return _database.InsertAsync(slist);
        }
    }
    public Task<int> DeleteProjectListAsync (ProjectListDatabase slist)
    {
        return _database.DeleteAsync(slist);
    }
}
