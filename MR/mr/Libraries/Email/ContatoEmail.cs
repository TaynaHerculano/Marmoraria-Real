using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            //servidor que vai enviar a mensagem

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("ttataaa@gmail.com", "85041129");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - Loja Virtual</h2>" +
                "<b>Nome: </b> {0} <br/>" +
                "<b>E-mail: </b> {1} <br/>" +
                "<b>Texto</b> {2} <br/>" +
                "<br/> E-mail enviado automaticamente do site LojaVirtual.", 
                contato.Nome,
                contato.Email, 
                contato.Texto
                );

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("ttataaa@gmail.com");
            mensagem.To.Add(new MailAddress("ttataaa@gmail.com"));
            mensagem.Subject = "Contato - Loja Virtual - E-mail:" + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            smtp.Send(mensagem);

        }

    }
}
