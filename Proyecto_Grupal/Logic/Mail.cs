using MimeKit;
using System.Configuration;


namespace Logic
{
    public static class Email
    {
        /// <summary>
        /// Envia un email de confirmacion al usuario registrado
        /// </summary>
        /// <param name="email"></param>
        public static bool SendMessageSmtp(string email, string contraseña, string nombre, string apellido, string tipoEvento, string msj = "")
        {
            
            MimeMessage mail = new MimeMessage();
            string host = ConfigurationManager.AppSettings["mailgunHost"]!;
            string password = ConfigurationManager.AppSettings["mailgunPassword"]!;
            mail.From.Add(new MailboxAddress("Sistema Sysacad", $"foo@{host}"));
            mail.To.Add(new MailboxAddress($"{apellido},{nombre}", email));
            if (tipoEvento == "Registro estudiante")
            {
                mail.Subject = "Registro de alumno";
                mail.Body = new TextPart("plain")
                {
                    Text = @$"Registro exitoso, bienvenido al nuevo SistemaSysacad. Tu contraseña es: {contraseña} y tu usario es tu Correo",
                };
            }
            else if (tipoEvento == "Cambio curso")
            {
                mail.Subject = "Modificacion en el curso";
                mail.Body = new TextPart("plain")
                {
                    Text = @$"{msj}",
                };
            }
            else if (tipoEvento == "Creo estudiante")
            {
                mail.Subject = "Informacion para el estudiante";
                mail.Body = new TextPart("plain")
                {
                    Text = @$"{msj}",
                };
            }
            else if (tipoEvento == "Notificacion vencimiento")
            {
                mail.Subject = "Notificacion vencimiento de Cuota";
                mail.Body = new TextPart("plain")
                {
                    Text = @$"{msj}",
                };
            }

            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    client.Connect("smtp.mailgun.org", 587, false);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate($"postmaster@{host}", $"{password}");

                    client.Send(mail);
                    client.Disconnect(true);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}
