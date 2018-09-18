using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace alterarEmail
{
    class Dados
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();


        public Dados()
        {
            if (getDictionary().Count == 0)
            {
                adicionarErro();
            }
        }


        public Dictionary<string, string> getDictionary()
        {
            return dictionary;
        }


        public void adicionarErro()
        {
            dictionary.Add(".con", ".com");
            dictionary.Add(".comn", ".com");
            dictionary.Add(".comp", ".com");
            dictionary.Add(".combr", ".com.br");
            dictionary.Add(".cim", ".com");
            dictionary.Add(".bd", ".br");
            dictionary.Add(".bt", ".br");
            //dictionary.Add(".b", ".br");
            dictionary.Add(".be", ".br");
            dictionary.Add(".vom", ".com");
            dictionary.Add(".clm", ".com");
            dictionary.Add(".com.com", ".com");
            dictionary.Add(".comcom", ".com");
            dictionary.Add(".comi", ".com");
            dictionary.Add(".comh", ".com");
            dictionary.Add(".cpm", ".com");
            dictionary.Add(".comthe", ".com");
            dictionary.Add(".xom", ".com");
            dictionary.Add(".com.com.br", ".com.br");
            dictionary.Add("umail.com", "gmail.com");
            dictionary.Add("gmail.d", "gmail.com");
            dictionary.Add("gmal.com", "gmail.com");
            dictionary.Add("gmaim.com", "gmail.com");
            dictionary.Add("g.mail.com", "gmail.com");
            dictionary.Add("g.mail", "gmail.com");
            dictionary.Add("g.com", "gmail.com");
            dictionary.Add("gmaik.com", "gmail.com");
            dictionary.Add("gmail.com.br", "gmail.com");
            dictionary.Add("gmail.com.r", "gmail.com");
            dictionary.Add("gmai.com", "gmail.com");
            dictionary.Add("gail.com", "gmail.com");
            dictionary.Add("guimail.com", "gmail.com");
            dictionary.Add("gmsil.com", "gmail.com");
            dictionary.Add("gmaol.com", "gmail.com");
            dictionary.Add("gmil.com", "gmail.com");
            dictionary.Add("fmail.com", "gmail.com");
            dictionary.Add("gmeil.com", "gmail.com");
            dictionary.Add("gmaul.com", "gmail.com");
            dictionary.Add("gemeil.com", "gmail.com");
            dictionary.Add("gemai.com", "gmail.com");
            dictionary.Add("gemail.com", "gmail.com");
            dictionary.Add("gamil.com", "gmail.com");
            dictionary.Add("gnail.com", "gmail.com");
            dictionary.Add("gmailq.com", "gmail.com");
            dictionary.Add("hot.com", "hotmail.com");
            dictionary.Add("hotmaio.com", "hotmail.com");
            dictionary.Add("hottmail.com", "hotmail.com");
            dictionary.Add("hot.ail.com", "hotmail.com");
            dictionary.Add("rotmail.com", "hotmail.com");
            dictionary.Add("htmail.com", "hotmail.com");
            dictionary.Add("hotmsil.com", "hotmail.com");
            dictionary.Add("hotmal.com", "hotmail.com");
            dictionary.Add("hormail.com", "hotmail.com");
            dictionary.Add("hotnail.com", "hotmail.com");
            dictionary.Add("hotamail.com", "hotmail.com");
            dictionary.Add("hotmeil.com", "hotmail.com");
            dictionary.Add("hotmai.com", "hotmail.com");
            dictionary.Add("hitmail.com", "hotmail.com");
            dictionary.Add("hotmil.com", "hotmail.com");
            dictionary.Add("homail.com", "hotmail.com");
            dictionary.Add("hotmailml.com", "hotmail.com");
            dictionary.Add("hotmmail.com", "hotmail.com");
            dictionary.Add("hoqtmail.com", "hotmail.com");
            dictionary.Add("hotmai.mail.com", "hotmail.com");
            dictionary.Add("jotmail.com", "hotmail.com");
            dictionary.Add("hoymail.com", "hotmail.com");
            dictionary.Add("hotimail.com", "hotmail.com");
            dictionary.Add("iutlook", "outlook");
            dictionary.Add("outook.com", "outlook.com");
            dictionary.Add("outloo.com", "outlook.com");
            dictionary.Add("ig.com.br", "ig.com");
            dictionary.Add("yhaoo.com", "yahoo.com");
            dictionary.Add("yahvoo.com", "yahoo.com");
            dictionary.Add("yhoo.com.br", "yahoo.com.br");
            //dictionary.Add("gmail", "gmail.com");
            //dictionary.Add("mail.com", "gmail.com");
        }
    }
}
