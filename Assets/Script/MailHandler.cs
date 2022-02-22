using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

public class MailHandler : MonoBehaviour
{
    private string name;
    private string to;
    public void CreateMessage()
    {
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("mat.planchot@gmail.com", "ytazfgouqxfcvnmi"),
            EnableSsl = true
        };
        string body = "De la part de : " + name;
        client.Send("mat.planchot@gmail.com", to, "cerealis", body);
    }

    public void SetName(string name) {
        this.name = name;
    }
    public void SetTo(string to){
        this.to = to;
    }
}
