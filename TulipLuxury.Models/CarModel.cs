using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TulipLuxury.Models
{
	public class CarModel
	{
        [Required]
        public string Id { get; set; }

        public string Model { get; set; }

        public string YearOfMan { get; set; }

        public string PlateNumber { get; set; }

        public string ChasisNumber { get; set; }

        public string Caption { get; set; }

        public string Highs { get; set; }

        public string Verdicts { get; set; }

        public string Exploits { get; set; }

        public string Exploit1 { get; set; }

        public string Exploit2 { get; set; }

        public string Exploit3 { get; set; }

        public string Review { get; set; }

        public string Image { get; set; }

        public string Color { get; set; }

        public string Color1 { get; set; }

        public string Color2 { get; set; }

        public string Color3 { get; set; }

        public string Color4 { get; set; }

        public string TypeOfCar { get; set; }

        public decimal Price { get; set; }

        public string UnitOfPrice { get; set; }

        public string Mileage { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Image> Images { get; set; }

    }
}

