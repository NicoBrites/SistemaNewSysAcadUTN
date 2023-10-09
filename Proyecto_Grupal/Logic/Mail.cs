using MimeKit;

namespace Logic
{
    public static class Email
    {
        /// <summary>
        /// Envia un email de confirmacion al usuario registrado
        /// </summary>
        /// <param name="email"></param>
        public static bool SendMessageSmtp(string email, string contraseña, string nombre, string apellido)
        {
            MimeMessage mail = new MimeMessage();
            mail.From.Add(new MailboxAddress("Sistema Sysacad", "foo@sandbox54c0a3c56b0042a2801b8f6c5cebe46a.mailgun.org"));
            mail.To.Add(new MailboxAddress($"{apellido},{nombre}", email));
            mail.Subject = "Registro de alumno";
            mail.Body = new TextPart("plain")
            {
                Text = @$"Registro exitoso, bienvenido al nuevo SistemaSysacad. Tu contraseña es: {contraseña} y tu usario es tu Correo",
            };
            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    client.Connect("smtp.mailgun.org", 587, false);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate("postmaster@sandbox54c0a3c56b0042a2801b8f6c5cebe46a.mailgun.org", "6fe8556259578bfe346b768e1f8ff099-77316142-466e2907");

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
