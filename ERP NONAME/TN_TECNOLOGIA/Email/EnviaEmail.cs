using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ALTO_VALE.TN_TECNOLOGIA.Email
{
    public class EnviaEmail
    {
       public void enviaEmail(String destinatario,String mensagem)
        {
            TN_TECNOLOGIA.Email.TEmail email = new TN_TECNOLOGIA.Email.TEmail();

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("vaquinhadagalera@gmail.com", "zxdsl8431");
            MailMessage mail = new MailMessage
            {
                Sender = new System.Net.Mail.MailAddress("vaquinhadagalera@gmail.com", "ENVIADOR"),
                From = new MailAddress("vaquinhadagalera@gmail.com", "ENVIADOR")
            };
            mail.To.Add(new MailAddress("hermanyjohann@gmail.com", "RECEBEDOR"));
            mail.Subject = "teste de envio";
            mail.Body = " teste de envio abc";
            mail.IsBodyHtml = false;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
            }
            catch (System.Exception erro)
            {
                //trata erro
            }
            finally
            {
                mail = null;
            }

        }
    }
}
