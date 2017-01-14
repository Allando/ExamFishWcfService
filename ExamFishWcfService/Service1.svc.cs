using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExamFishWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static List<Catch> fishList = new List<Catch>()
        {
            new Catch(1, "EbbeVand", "Gedde", 3.75, 2),
            new Catch(2, "PeterStor", "Ørred", 1.75, 7),
            new Catch(3, "AndyBor", "Skalle", 0.35, 25),
            new Catch(4, "JamShen", "Bras", 1.30, 25),
            new Catch(5, "ZuSheik", "Snapper", 0.75, 30),
            new Catch(6, "Micha", "Helt", 0.95, 2)//Bekræft id!!
        };

        public List<Catch> GetCatches()
        {
            return fishList;
        }

        public Catch GetOneCatch(string id)
        {
            return fishList.FirstOrDefault(f => f.Id == int.Parse(id));
        }

        public bool AddCatch(Catch newCatch)
        {
            var result = fishList.Where(f => f.Id != newCatch.Id);
            if (result != null)
            {
                fishList.Add(new Catch(newCatch.Id, newCatch.Name, newCatch.Species,
                    newCatch.Weight, newCatch.Week));
                return true;
            }
            return false;
        }

        public bool DeleteCatch(string id)
        {
            var result = fishList.FirstOrDefault(f => f.Id == int.Parse(id));
            if (result != null)
            {
                //fishList.RemoveAt(result.Id);
                fishList.Remove(result);
                return true;
            }
            return false;

            //foreach (var c in fishList)
            //{
            //    if (c.Id == int.Parse(id))
            //    {
            //        fishList.RemoveAt(c.Id);
            //        return true;
            //    }
            //}
            //return true;
        }

        public bool UpdateCatch(string id, Catch myCatch)
        {
            var result = fishList.FirstOrDefault(f => f.Id == int.Parse(id));
            if (result != null)
            {
                new Catch(result.Id, result.Name, result.Species, result.Weight, result.Week);
                return true;
        
            }
            return false;
        }
    }
}
