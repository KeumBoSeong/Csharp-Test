namespace TagHelper_MyForm.Models
{
    public class TripReservation
    {
        public Depart Depart { get; set; }
        public Destination Destination { get; set; }
        public int Personnel { get; set; }
        public string Name { get; set;}
        public string HP { get; set; }
        public Covid Covid { get; set; }
        public string Request { get; set; }

    }
    public enum Covid
    {
        네,
        아니요   
    }
    public enum Depart
    {
        인천국제공항,
        김포국제공항,
        제주국제공항,
        김해국제공항,
        대구국제공항
    }
    public enum Destination
    {
        인천국제공항,
        김포국제공항,
        제주국제공항,
        김해국제공항,
        대구국제공항,
        오사카국제공항,
        도쿄국제공항,
        베이징국제공항,
        다낭국제공항,
        세부국제공항,
    }
    
}
