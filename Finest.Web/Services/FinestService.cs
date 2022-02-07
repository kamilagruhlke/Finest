using Finest.Models;
using System.Collections.Generic;
using System.Linq;

namespace Finest.Services
{
    public class FinestService
    {
        private readonly FinestContext context;

        public FinestService(FinestContext context)
        {
            this.context = context;
        }

        public IList<FinestModel> GetAll()
        {
            return this.context.Finest.Where(e => e.Completed == false).ToList();
        }

        public IList<FinestModel> GetAllCompleted()
        {
            return this.context.Finest.Where(e => e.Completed).ToList();
        }

        public FinestModel Details(int id)
        {
            return this.context.Finest.FirstOrDefault(x => x.Id == id);
        }

        public void Create(FinestModel finestModel)
        {
            this.context.Finest.Add(finestModel);

            this.context.SaveChanges();

        }

        public void Edit(int id, FinestModel finestModel)
        {
            FinestModel finest = this.context.Finest.FirstOrDefault(x => x.Id == id);
            finest.Name = finestModel.Name;
            finest.Description = finestModel.Description;
            finest.Date = finestModel.Date;
            finest.Completed = finestModel.Completed;

            this.context.SaveChanges();

        }

        public void Delete(int id)
        {
            FinestModel finest = this.context.Finest.FirstOrDefault(x => x.Id == id);
            this.context.Finest.Remove(finest);

            this.context.SaveChanges();
        }
    }
}
