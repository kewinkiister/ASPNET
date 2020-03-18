using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using LojaVirtual.Models;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            /*
             * SMTP -> Servidor que vai enviar a menssagem 
             */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("kevinkiister0@gmail.com", ""),
                EnableSsl = true
            };

            string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>"+
                "<b>Nome: {0}</b> <br />" +
                "<b>Email: {1}</b> <br />" +
                "<b>Texto: {2}</b> <br />" +
                "<br /> Email enviado automaticamento do site LojaVirtual.", contato.Nome, contato.Email, contato.Texto);

            /*
             * MailMenssage -> Contrutor da menssagem
             */

            MailMessage menssage = new MailMessage
            {
                From = new MailAddress("kevinkiister0@gmail.com")
            };
            menssage.To.Add("kevinkiister0@gmail.com");
            menssage.Subject = "Contato - LojaVirtual - Email: " + contato.Email;
            menssage.Body = corpoMsg;
            menssage.IsBodyHtml = true;

            smtp.Send(menssage);
        }

    }
}
