namespace SEOWhiteKing.Infrastructure
{
    public class AppSettings
    {
        public Company? Company { get; set; } = new Company();
    }

    public class Company
    {
        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyShortPhone { get; set; }
        public string? CompanyEmail { get; set; }
    }
}
