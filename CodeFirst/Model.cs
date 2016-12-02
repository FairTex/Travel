using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Device.Location;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Base
    {
        [Key]
        public int UserId { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class Point
    {
        [Key]
        public int PointId { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GeoCoordinate Coordinate { get; set; }

        [Range(0, 5)]
        public int Raiting { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }

    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        public string Text { get; set; }
        public virtual User User { get; set; }
    }
}
