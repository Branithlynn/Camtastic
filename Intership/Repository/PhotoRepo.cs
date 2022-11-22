using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intership.Entity;
using System.Data.Entity;
using Intership.Context;

namespace Intership.Repository
{
    internal class PhotoRepo
    {
        private readonly DBContext db;

        public PhotoRepo()
        {
            db = new DBContext();
        }
        public void Add(Photo photo)
        {
            db.Photos.Add(photo);
            db.SaveChanges();
        }
        public List<Photo> ShowAll()
        {
            return db.Photos.ToList();
        }
    }
}
