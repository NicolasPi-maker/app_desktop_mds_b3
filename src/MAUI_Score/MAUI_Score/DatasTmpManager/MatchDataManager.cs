using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class MatchDataManager : Interfaces.DataManagerInterface<Models.Match>
    {
        private List<Models.Match> matches { get; set; }

        public MatchDataManager() 
        {}

        public List<Models.Match> GetAll()
        {
            return matches;
        }

        public Models.Match GetById(int id)
        {
            return matches.Find(x => x.id == id);
        }

        public void Add(Models.Match match)
        {
            matches.Add(match);
        }

        public bool Update(Models.Match match)
        {
            Models.Match matchToUpdate = matches.Find(x => x.id == match.id);
            matchToUpdate = match;
            return true;
        }

        public bool Delete(int id)
        {
            matches.Remove(matches.Find(x => x.id == id));
            return true;
        }
    }
}
