namespace CityWeather.Core.Models
{
    public class Weather
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        public Weather()
        {
            Title = " ";
            Temperature = " ";
            Wind = " ";
            Humidity = " ";
            Visibility = " ";
            Sunrise = " ";
            Sunset = " ";
        }

        protected bool Equals(Weather other)
        {
            return string.Equals(Title, other.Title) 
                && string.Equals(Temperature, other.Temperature) 
                && string.Equals(Wind, other.Wind) 
                && string.Equals(Humidity, other.Humidity) 
                && string.Equals(Visibility, other.Visibility) 
                && string.Equals(Sunrise, other.Sunrise) 
                && string.Equals(Sunset, other.Sunset);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Weather) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Temperature != null ? Temperature.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Wind != null ? Wind.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Humidity != null ? Humidity.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Visibility != null ? Visibility.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Sunrise != null ? Sunrise.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Sunset != null ? Sunset.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
