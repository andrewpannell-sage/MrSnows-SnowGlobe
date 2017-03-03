using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /* -------------------------------------------------------------------
    Variables
    ---------------------------------------------------------------------- */
    string stor = "";
    string output = "";
    string tilfeldigbokstavtrukket = "";
    string tilfeldigsubjecttrukket = "";
    string tilfeldigverbtrukket = "";
    string tilfeldigarticletrukket = "";
    string tilfeldigadverbtrukket = "";
    string tilfeldigplacetrukket = "";
    string tilfeldigprepositiontrukket = "";
    string tilfeldigadjectivetrukket = "";
    string tilfeldiginterjectiontrukket = "";
    string tilfeldignounobjecttrukket = "";
    int tilfeldigbokstavtall = 0;
    int tilfeldigarticletall = 0;
    int tilfeldigsubjecttall = 0;
    int tilfeldigverbtall = 0;
    int tilfeldigadverbtall = 0;
    int tilfeldigplacetall = 0;
    int tilfeldigprepositiontall = 0;
    int tilfeldigadjectivetall = 0;
    int tilfeldiginterjectiontall = 0;
    int tilfeldignounobjecttall = 0;
    int antallsetninger = 0;
    int minstbokstaver = 0;
    int maksbokstaver = 0;
    int minstord = 0;
    int maksord = 0;

    /* -------------------------------------------------------------------
     Arrays
    ---------------------------------------------------------------------- */
    string[] bokstav = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] article = { "the", "a", "one", "some", "any", };
    string[] subject = { "boy", "girl", "dog", "car", "cat", "fish", "woman", "man", "book", "bird", };
    string[] verb = { "drove", "jumped", "ran", "walked", "skipped", "climbed", "balanced", "argued", "applauded", "shouted", "talked" };
    string[] adverb = {  "so", "absentmindedly", "adoringly", "awkwardly", "beautifully", "briskly", "brutally", "carefully", "cheerfully", "competitively", "wishfully", "worriedly", "really", "recklessly", "remorsefully", "ruthlessly" };
    string[] place = { "home", "away", "outside", "upstairs", "out", };
    string[] preposition = { "to", "from", "over", "under", "on", "in", "inside", "into", "past", "with", "within", };
    string[] adjective = { "clear", "clean", "bad", "big", "young", "tall", "abandoned", "absolute", "adorable", "adventurous", "academic", "acceptable", "acclaimed", "accomplished",  };
    string[] interjection = { "aha", "ahem", "ahh", "ahoy", "alas", "arg", "aw", "bam", "bingo", "blah", "boo", "bravo", "brrr", "oh", "dear", "ohoh", "oops", "ouch", "ow", "wahoo", "whoa", "whoops", "wow", "yeah", "yes", "yikes", "yippee", "yo", "yuck", };
    string[] nounobject = { "man", "mountain", "state", "ocean", "country", "building", "cat", "airline" };


    protected void Page_Load(object sender, EventArgs e)
    {

    }


    private string tilfeldigbokstav()
    {
        Random minRandomGenerator = new Random();
        tilfeldigbokstavtall = minRandomGenerator.Next(0, 26);
        tilfeldigbokstavtrukket = bokstav[tilfeldigbokstavtall];
        return tilfeldigbokstavtrukket;
    }

    private int tilfeldigsetningtrukket()
    {
        System.Threading.Thread.Sleep(100);
        Random minRandomGenerator11 = new Random();
        int randomsetning = minRandomGenerator11.Next(minstord, maksord+1);
        return randomsetning;
    }


    private string endeligoutput()
    {
        
        if (tilfeldigsetningtrukket() == 1)
        {
            stor = tilfeldigsubject();
            
            output = StorForbokstav(stor) + ".";
        }

        else if (tilfeldigsetningtrukket() == 2)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigsubject() + ".";
        }

        else if (tilfeldigsetningtrukket() == 3)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigsubject() + " " + tilfeldigverb() +".";
        }
        else if (tilfeldigsetningtrukket() == 4)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigsubject() + " " + tilfeldigverb() + " " + tilfeldigplace() + ".";
        }

        else if (tilfeldigsetningtrukket() == 5)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigadjective() + " " + tilfeldigsubject() + " " + tilfeldigverb() + " " + tilfeldigplace() + ".";
        }

        else if (tilfeldigsetningtrukket() == 6)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigadjective() + " " + tilfeldigsubject() + " " + tilfeldigverb() + " " + tilfeldigadverb() + " " + tilfeldigplace() + ".";
        }

        else if (tilfeldigsetningtrukket() == 7)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigadjective() + " " + tilfeldigsubject() + " " + tilfeldigverb() + " " + tilfeldigpreposition() + " " + tilfeldigarticle() + " " + tilfeldignounobject()  + ".";
        }

        else if (tilfeldigsetningtrukket() == 8)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigadjective() + " " + tilfeldigsubject() + " " + tilfeldigverb() + " " + tilfeldigpreposition() + " " + tilfeldigarticle() + " " + tilfeldigadjective() + " " + tilfeldignounobject() + ".";
        }

        else if (tilfeldigsetningtrukket() == 9)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigadjective() + " " + tilfeldigsubject() + " "  + tilfeldigverb()  + " " + tilfeldigadverb() + " " +  tilfeldigpreposition() + " " + tilfeldigarticle() + " " + tilfeldigadjective() + " " + tilfeldignounobject() + ".";

        }

        else if (tilfeldigsetningtrukket() == 10)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigadjective() + " " + tilfeldigsubject() + " " + tilfeldigverb() + " " + tilfeldigadverb() + " " + tilfeldigpreposition() + " " + tilfeldigarticle() + " " + tilfeldigadjective() +  " " + tilfeldignounobject() + ", " + " '" + tilfeldiginterjection() + "!'";
        }

        else if (tilfeldigsetningtrukket() >= 11)
        {
            stor = tilfeldigarticle();
            output = StorForbokstav(stor) + " " + tilfeldigadjective() + " " + tilfeldigsubject() + " " + tilfeldigverb() + " " + tilfeldigadverb() + " " + tilfeldigpreposition() + " " + tilfeldigarticle() + " " + tilfeldigadjective() + " and " + tilfeldigadjective() + " " + tilfeldignounobject() + ".";
        }


        return output;
    }



    private string tilfeldigarticle()
    {
        
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator2 = new Random();
        tilfeldigarticletall = minRandomGenerator2.Next(article.Length);
        tilfeldigarticletrukket = article[tilfeldigarticletall];


        return tilfeldigarticletrukket;
    }

    private string tilfeldigsubject()
    {
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator3 = new Random();
        tilfeldigsubjecttall = minRandomGenerator3.Next(subject.Length);
        tilfeldigsubjecttrukket = subject[tilfeldigsubjecttall];


        return tilfeldigsubjecttrukket;
    }


    private string tilfeldigverb()
    {
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator4 = new Random();
        tilfeldigverbtall = minRandomGenerator4.Next(verb.Length);
        tilfeldigverbtrukket = verb[tilfeldigverbtall];


        return tilfeldigverbtrukket;
    }

    private string tilfeldigadverb()
    {
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator5 = new Random();
        tilfeldigadverbtall = minRandomGenerator5.Next(adverb.Length);
        tilfeldigadverbtrukket = adverb[tilfeldigadverbtall];


        return tilfeldigadverbtrukket;
    }

    private string tilfeldigplace()
    {
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator6 = new Random();
        tilfeldigplacetall = minRandomGenerator6.Next(place.Length);
        tilfeldigplacetrukket = place[tilfeldigplacetall];


        return tilfeldigplacetrukket;
    }

    private string tilfeldigpreposition()
    {
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator7 = new Random();
        tilfeldigprepositiontall = minRandomGenerator7.Next(preposition.Length);
        tilfeldigprepositiontrukket = preposition[tilfeldigprepositiontall];


        return tilfeldigprepositiontrukket;
    }

    private string tilfeldigadjective()
    {                                     
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator8 = new Random();
        tilfeldigadjectivetall = minRandomGenerator8.Next(adjective.Length);
        tilfeldigadjectivetrukket = adjective[tilfeldigadjectivetall];


        return tilfeldigadjectivetrukket;
    }

    private string tilfeldiginterjection()
    {
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator9 = new Random();
        tilfeldiginterjectiontall = minRandomGenerator9.Next(interjection.Length);
        tilfeldiginterjectiontrukket = interjection[tilfeldiginterjectiontall];


        return tilfeldiginterjectiontrukket;
    }

    private string tilfeldignounobject()
    {
        System.Threading.Thread.Sleep(75);
        Random minRandomGenerator10 = new Random();
        tilfeldignounobjecttall = minRandomGenerator10.Next(nounobject.Length);
        tilfeldignounobjecttrukket = nounobject[tilfeldignounobjecttall];


        return tilfeldignounobjecttrukket;
    }


    private string StorForbokstav(string stor)
    {
        System.Text.StringBuilder tekst = new System.Text.StringBuilder(stor);
        tekst[0] = Char.ToUpper(tekst[0]);
        return tekst.ToString();
    }

    /* -------------------------------------------------------------------
    Run code when button is pushed
    ---------------------------------------------------------------------- */
    protected void Button1_Click(object sender, EventArgs e)
    {
        /* -------------------------------------------------------------------
        Get user input
        ---------------------------------------------------------------------- */
        try
        {
            antallsetninger = Convert.ToInt32(TextBox1.Text);
            minstord = Convert.ToInt32(TextBox2.Text);
            maksord = Convert.ToInt32(TextBox3.Text);
        }
        catch
        {
            this.Title = "ERROR";
        }

        /* -------------------------------------------------------------------
        Get functions
        ---------------------------------------------------------------------- */


        /* -------------------------------------------------------------------
        Text shown when button is pushed
        ---------------------------------------------------------------------- */

        if ((minstord <= maksord) && (minstord > 0))
        {
            Label1.Text ="";
            if (antallsetninger > 0)
            {
                for (int antall = 0; antall < antallsetninger; antall++)
                {
                    System.Threading.Thread.Sleep(100);
                    Label1.Text += endeligoutput();
                    Label1.Text += "</br>";



                }

            }
            else
            {
                Label1.Text = "You need at least one sentence.";
            }
        }

        else
        {
            Label1.Text = "You have put in something invalid. Check what you have done and try again.";
        }
       
        
    }
}