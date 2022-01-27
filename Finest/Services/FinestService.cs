using Finest.Models;
using System.Collections.Generic;
using System.Linq;

namespace Finest.Services
{
    public class FinestService
    {
        private static IList<FinestModel> finests = new List<FinestModel>();

        public IList<FinestModel> GetAll()
        {
            return finests;
        }

        public IList<FinestModel> GetAllCompleted()
        {
            return finests.Where(e => e.Completed == true).ToList();
        }

        public FinestModel Details(int id)
        {
            return finests.FirstOrDefault(x => x.Id == id);
        }

        public void Create(FinestModel finestModel)
        {
            finestModel.Id = finests.Count + 1;
            finests.Add(finestModel);
        }

        public void Edit(int id, FinestModel finestModel)
        {
            FinestModel finest = finests.FirstOrDefault(x => x.Id == id);
            finest.Name = finestModel.Name;
            finest.Description = finestModel.Description;
            finest.Date = finestModel.Date;
            finest.Completed = finestModel.Completed;
        }

        public void Delete(int id)
        {
            FinestModel finest = finests.FirstOrDefault(x => x.Id == id);
            finests.Remove(finest);
        }
    }
}
