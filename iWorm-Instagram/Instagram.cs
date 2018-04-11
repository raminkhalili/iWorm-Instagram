using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iWorm_Instagram
{
    class Instagram
    {
        public static void Unfollow(string id, string token)
        {

            WebClient client = new WebClient();
            client.QueryString.Add("action", "unfollow");
            var res = client.UploadValues("https://api.instagram.com/v1/users/" + id + "/relationship?access_token=" + token, "POST", client.QueryString);
        }
        public static void Follow(string id, string token)
        {

            WebClient client = new WebClient();
            client.QueryString.Add("action", "follow");
            var res = client.UploadValues("https://api.instagram.com/v1/users/" + id + "/relationship?access_token=" + token, "POST", client.QueryString);
        }

        public static void Like(string id, string token)
        {

            WebClient client = new WebClient();
            client.QueryString.Add("access_token", token);
            var res = client.UploadValues("https://api.instagram.com/v1/media/"+id+"/likes", "POST", client.QueryString);
        }

        public static void RemoveLike(string id, string token)
        {

            WebClient client = new WebClient();


            var res = client.UploadValues ("https://api.instagram.com/v1/media/" + id + "/likes?access_token=" + token,"DELETE",client.QueryString);
        }


        public static void Comment(string id,string token,string Comment)
        {
            WebClient client = new WebClient();
            client.QueryString.Add("access_token", token);
            client.QueryString.Add("text", Comment);
            var res = client.UploadValues("https://api.instagram.com/v1/media/" + id + "/comments","POST",client.QueryString);
        }
    }
    class InstagramInformation
    {
        public Data data { get; set; }
        public Meta meta { get; set; }
    }
    class InstagramFollows
    {
        public DataFollows[] data{get;set;}
    }
    class Post
    {
        public DataPost[] data { get; set; }
    }
    class DataPost
    {
        public string id { get; set; }
        public Images images { get; set; }
        public bool user_has_liked { get; set; }
    }
    class Images
    {
       public ImageInfo thumbnail { get; set; }
    }
    class ImageInfo
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }
    class RelationshipData
    {
        public DataRel data { get; set; }
        public Meta meta { get; set; }
    }
    class DataRel
    {
        public string outgoing_status { get; set; }
        public string incoming_status { get; set; }
        public bool target_user_is_private { get; set; }
    }
    class Data
    {
        public string id { set; get; }
        public string username { get; set; }

        public string profile_picture { get; set; }
        public string full_name { get; set; }
        public string bio { get; set; }
        public string website { get; set; }
        public bool is_business { get; set; }
        public Counts counts { get; set; }


    }
    class Counts
    {
        public int media { set; get; }
        public int follows { set; get; }
        public int followed_by { set; get; }
    }
    class Meta
    {
        public int code { set; get; }
    }

    class DataFollows
    {
        public string username { get; set; }
        public string profile_picture { get; set; }
        public string full_name { get; set; }
        public string id { get; set; }
    }
}
