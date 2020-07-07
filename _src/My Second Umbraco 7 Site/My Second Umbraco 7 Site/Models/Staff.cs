namespace My_Second_Umbraco_7_Site.Models
{
    public class Staff
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }
        public string Informaiton { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string DribbbleLink { get; set; }
        public string GithubLink { get; set; }

        public Staff(string name, string imageUrl, string role, string informaiton, string facebookLink, string twitterLink, string dribbbleLink, string githubLink)
        {
            Name = name;
            ImageUrl = imageUrl;
            Role = role;
            Informaiton = informaiton;
            FacebookLink = facebookLink;
            TwitterLink = twitterLink;
            DribbbleLink = dribbbleLink;
            GithubLink = githubLink;
        }
    }
}
