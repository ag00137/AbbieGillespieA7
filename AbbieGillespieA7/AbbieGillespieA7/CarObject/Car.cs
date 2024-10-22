using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbbieGillespieA7.CarObject
{
    /// <summary>
    /// Represents a single object from the provided JSON data.
    /// </summary>
    public class Car : IComparable<Car>
    {
        /// <summary>
        /// Gets or sets the make of the car.
        /// </summary>
        [JsonPropertyName("make")]
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model of the car.
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Gets or sets the year the car was made.
        /// </summary>
        [JsonPropertyName("year")]
        public int Year {  get; set; }

        /// <summary>
        /// Gets or sets the price of the car.
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the color of the car.
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Gets or sets the number of cylinders.
        /// </summary>
        [JsonPropertyName("cylinders")]
        public int Cylinders { get; set; }

        /// <summary>
        /// Gets or sets the mileage of the car.
        /// </summary>
        [JsonPropertyName("mileage")]
        public int Mileage { get; set; }

        public int CompareTo(Car other)
        {
            if (other == null) return 1;
            return this.Make.CompareTo(other.Make);
        }
    }
}
