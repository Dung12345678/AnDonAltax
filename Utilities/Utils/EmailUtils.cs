using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mail;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.CSharp;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Web;

namespace BMS.Utils
{
    public class EmailUtils
    {
        public static bool SendEmailWithConfirm(string recipientEmail, string subject, string body, ref string errorText)
        {
            bool result = false;
            MessageBoxManager.Yes = "Xem trước";
            MessageBoxManager.No = "Gửi luôn";
            MessageBoxManager.Cancel = "Không gửi";
            MessageBoxManager.Register();

            DialogResult dlg = MessageBox.Show("Bạn có muốn gửi mail cho người nhận không?", TextUtils.Caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                result = SendEmailThroughDefaultClient(recipientEmail, subject, body, ref errorText);
                //result = sendHtmlEMailThroughOUTLOOK(recipientEmail, subject, body);
            }
            else if (dlg == DialogResult.No)
            {
                result = SendEmail(recipientEmail, subject, body, ref errorText);
            }

            MessageBoxManager.Unregister();

            return result;
        }

        public static bool SendEmailThroughDefaultClient(string recipientEmail, string subject, string body, ref string errorText)
        {
            try
            {
                string link = String.Format(@"mailto:{0}?subject={1}&body={2}", recipientEmail, System.Web.HttpUtility.UrlEncode(subject), System.Web.HttpUtility.UrlEncode(body));
                link = link.Replace("+", "%20");
                System.Diagnostics.Process.Start(link);
                return true;
            }
            catch (Exception ex)
            {
                errorText = ex.Message;
                return false;
            }
        }

        public static bool sendEMailThroughOUTLOOK(string _RecipientEmail, string _EmailSubject, string _EmailBody)
        {
            bool check = false;
            try
            {
                // Create the Outlook application by using inline initialization.
                Outlook.Application oApp = new Outlook.Application();

                //Create the new message by using the simplest approach.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

                //Add a recipient.
                // TODO: Change the following recipient where appropriate.
                Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add(_RecipientEmail);
                oRecip.Resolve();

                //Set the basic properties.
                oMsg.Subject = _EmailSubject;
                oMsg.Body = _EmailBody;

                //Add an attachment.
                // TODO: change file path where appropriate

                //String sSource = "C:\\setupxlg.txt";
                //String sDisplayName = "MyFirstAttachment";
                //int iPosition = (int)oMsg.Body.Length + 1;
                //int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //Outlook.Attachment oAttach = oMsg.Attachments.Add(sSource, iAttachType, iPosition, sDisplayName);

                // If you want to, display the message.
                oMsg.Display(true);  //modal

                //Send the message.
                //oMsg.Save();
                //oMsg.Send();

                //Explicitly release objects.
                oRecip = null;
                //oAttach = null;
                oMsg = null;
                oApp = null;
                check = true;
            }//end of try block
            catch (Exception ex)
            {
                check = false;
            }//end of catch

            return check;
        }//end of Email Method

        public static bool sendHtmlEMailThroughOUTLOOK(string _RecipientEmail, string _EmailSubject, string _EmailBody)
        {
            bool check = false;
            try
            {
                // Create the Outlook application by using inline initialization.
                Outlook.Application oApp = new Outlook.Application();

                //Create the new message by using the simplest approach.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
                //Outlook.MailItem oMsg = (Outlook.MailItem)Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);

                //Add a recipient.
                // TODO: Change the following recipient where appropriate.
                Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add(_RecipientEmail);
                oRecip.Resolve();

                //Set the basic properties.
                oMsg.Subject = _EmailSubject;
                oMsg.HTMLBody = _EmailBody;

                //Add an attachment.
                // TODO: change file path where appropriate

                //String sSource = "C:\\setupxlg.txt";
                //String sDisplayName = "MyFirstAttachment";
                //int iPosition = (int)oMsg.Body.Length + 1;
                //int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //Outlook.Attachment oAttach = oMsg.Attachments.Add(sSource, iAttachType, iPosition, sDisplayName);

                // If you want to, display the message.
                oMsg.Display(true);  //modal

                //Send the message.
                //oMsg.Save();
                //oMsg.Send();

                //Explicitly release objects.
                oRecip = null;
                //oAttach = null;
                oMsg = null;
                oApp = null;
                check = true;
            }//end of try block
            catch (Exception ex)
            {
                check = false;
            }//end of catch

            return check;
        }//end of Email Method

        public static bool SendEmail(string recipientEmail, string subject, string body, ref string errorText)
        {
            bool checkMail = false;
            try
            {
                body += @"

--------
Email này được gửi tự động từ hệ thống Quản lý tòa nhà.
Xin vui lòng không gửi email trả lời tới địa chỉ này.";
                DataTable dtEmail = TextUtils.Select("select * from ConfigSystem Where Keyname = 'EMAIL_HOTLINE'");
                if (dtEmail.Rows.Count > 0)
                {

                    string smtp = dtEmail.Rows[0]["KeyValue2"].ToString();
                    if (String.IsNullOrEmpty(smtp))
                        throw new Exception("SMTP server address is empty (ConfigSystem EMAIL_HOTLINE KeyValue2)");

                    int portMail = TextUtils.ToInt(dtEmail.Rows[0]["KeyValue3"].ToString());
                    if (portMail == 0)
                        throw new Exception("SMTP server port is empty (ConfigSystem EMAIL_HOTLINE KeyValue3)");

                    string emailFrom = dtEmail.Rows[0]["KeyValue"].ToString();
                    if (String.IsNullOrEmpty(emailFrom))
                        throw new Exception("Sender email is empty (ConfigSystem EMAIL_HOTLINE KeyValue)");

                    string emailPass = dtEmail.Rows[0]["KeyValue1"].ToString();
                    if (String.IsNullOrEmpty(emailPass))
                        throw new Exception("Sender password is empty (ConfigSystem EMAIL_HOTLINE KeyValue1)");

                    using (MailMessage mail = new MailMessage())
                    {
                        using (SmtpClient smtpServer = new SmtpClient(smtp))
                        {
                            mail.From = new System.Net.Mail.MailAddress(emailFrom);
                            mail.To.Add(recipientEmail);
                            mail.Subject = subject;
                            mail.Body = body;
                            smtpServer.Port = portMail;
                            smtpServer.Credentials = new System.Net.NetworkCredential(emailFrom, emailPass);
                            smtpServer.EnableSsl = true;
                            smtpServer.Timeout = 10000;
                            smtpServer.Send(mail);
                        }
                    }
                    checkMail = true;
                }
                else
                    throw new Exception("KeyName [EMAIL_HOTLINE] doesn't exist in ConfigSystem");
            }
            catch (Exception ex)
            {
                errorText = ex.Message;
                checkMail = false;
            }
            return checkMail;
        }
    }
}
