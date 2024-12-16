public class DataService
{
    protected readonly ApplicationContext db;
    public DataService(ApplicationContext db)
    {
        this.db = db;
    }
    public Worker Create(Worker worker)
    {
        db.Workers.Add(worker);
        db.SaveChanges();
        return worker;
    }
    public List<Worker> GetData()
    {
        return db.Workers.ToList();
    }
    public bool Update(WorkerDto workerDto, Guid id)
    {
        var worker = db.Workers.Find(id);
        if (worker == null)
        {
            return false;
        }
        worker.Name = workerDto.Name;
        worker.Grade = workerDto.Grade;
        db.SaveChanges();
        return true;
    }

    public bool Delete(Guid id)
    {
        var worker = db.Workers.Find(id);
        if (worker == null)
        {
            return false;
        }
        db.Workers.Remove(worker);
        db.SaveChanges();
        return true;
    }

}