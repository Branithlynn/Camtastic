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
    public class CameraRepo
    {
        private readonly DBContext db;
        public CameraRepo()
        {
            db = new DBContext();
        }

        public void Add(Camera camera)
        {
            db.Cameras.Add(camera);
            db.SaveChanges();
        }
        public List<Camera> ShowAll()
        {
            return db.Cameras.ToList();
        }
        public Camera FindCamera(string brand, string model)
        {

            foreach (Camera item in db.Cameras)
            {
                if (item.Model.Equals(model) && item.BrandName.Equals(brand))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
