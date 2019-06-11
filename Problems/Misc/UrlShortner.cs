using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Misc
{
    public class UrlShortner
    {
        public string IdToShortUrl(int n)
        {
            string allowchars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            char[] map =
                allowchars.ToCharArray();

            StringBuilder shortUrl = new StringBuilder();

            while (n > 0)
            {
                shortUrl.Append(map[n % 62]);
                n /= 62;
            }

            return Reverse(shortUrl.ToString());
        }

        private string Reverse(string value)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = value.Length - 1; i >= 0; i--)
            {
                sb.Append(value[i]);
            }

            return sb.ToString();
        }
    }
}
